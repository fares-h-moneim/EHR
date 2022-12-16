using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using System.Xml.Linq;
using System.Reflection;

namespace EHR_Hospital
{
    public class Controller
    {
        DBManager dbMan;

        public Controller()
        {
            dbMan = new DBManager();
        }

        //public int InsertSupplier(string snum, string sname, string city, int status)
        //{
        //    string query = "INSERT INTO S (S#, Name, City, Status) " +
        //                    "Values ('" + snum + "','" + sname + "','" + city + "'," + status + ");";
        //    return dbMan.ExecuteNonQuery(query);
        //}

        
        public DataTable GetHospital(string username, string password)
        {
            string query = "SELECT * " +
                "From Hospital " +
                "Where Username = '" + username + "' and Password = '" + password + "';";
            return dbMan.ExecuteReader(query);
        }

        public int IDExist(string id)
        {
            string query = "SELECT COUNT(NationalID) FROM Patient WHERE NationalID = '" + id + "';";
            return (int)dbMan.ExecuteScalar(query);
        }

        public int EmailExist(string email)
        {
            string query = "SELECT COUNT(Email) FROM Patient WHERE Email = '" + email + "';";
            return (int)dbMan.ExecuteScalar(query);
        }

        public int InsertDiagnosis(int HospitalID, string PatientID, string Date, string Diagnosis, string Symptoms, int Prescription_ID)
        {
            if (Prescription_ID == -1)
            {
                string query = "INSERT INTO Diagnosis Values (" + HospitalID + ",'" + PatientID + "','" + Date + "','" + Symptoms + "','" + Diagnosis + "', NULL);";
                return dbMan.ExecuteNonQuery(query);
            }
            else
            {
                string query = "INSERT INTO Diagnosis Values (" + HospitalID + ",'" + PatientID + "','" + Date + "','" + Symptoms + "','" + Diagnosis + "'," + Prescription_ID + ");";
                return dbMan.ExecuteNonQuery(query);
            }
        }

        public int InsertPrescription(string Date)
        {
            string query = "INSERT INTO Prescription(Date_Time) VALUES ('" + Date + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        

        public DataTable GetPrescriptionID(string Date)
        {
            string query = "Select Prescription_ID FROM Prescription WHERE Date_Time = '" + Date + "';";
            return dbMan.ExecuteReader(query);
        }

        public int InsertMedications(int PresID, string Medication)
        {
            string query = "Insert INTO Medications Values ("+PresID+",'"+Medication+"');";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable GetHospital(string username)
        {
            string query = "SELECT Hospital_ID " +
                "From Hospital " +
                "Where Username = '" + username + "';";
            return dbMan.ExecuteReader(query);
        }

        public int InsertOrganWaiting(string organ, string patientid, int priority)
        {
            string query = "INSERT INTO Organ_Waiting_List VALUES ('" + organ + "','" + patientid + "'," + priority + ");";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable GetChronic(string PatientID)
        {
            string query = "Select Disease FROM ChronicDiseases WHERE PatientID = '"+PatientID+"';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetDiagnosis(string PatientID)
        {
            string query = "Select Date_Time, Diagnosis, Symptoms FROM Diagnosis WHERE Patient_ID = '" + PatientID + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetPrescriptions(string PatientID)
        {
            string query = "Select Prescription.Date_Time, Medications.Medication, Prescription.Given_or_not FROM Prescription, Diagnosis, Medications WHERE Patient_ID = '" + PatientID + "' AND Diagnosis.Prescription_ID = Prescription.Prescription_ID AND Prescription.Prescription_ID = Medications.Prescription_ID;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetSurgeries(string PatientID)
        {
            string query = "Select Date_Time, Type_of_Surgery, Surgery_Report FROM Surgery WHERE Patient_ID = '" + PatientID + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetLabs(string PatientID)
        {
            string query = "Select Date_Time, Test_Result FROM Lab_Results WHERE Patient_ID = '" + PatientID + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable getifDonor(string patientID)
        {
            string query = "SELECT Organ_Donor_Upon_Death FROM Patient WHERE NationalID = '" + patientID + "'";
            return dbMan.ExecuteReader(query);
        }

        public int InsertOrganDonor(string organ, string pid, int status)
        {
            string query = "INSERT INTO Organ_Donor VALUES ('" + organ + "','" + pid + "'," + status + ");";
            return dbMan.ExecuteNonQuery(query);
        }

        public int DeleteFromOrganDonor(string patientID)
        {
            string query = "DELETE FROM Organ_Donor WHERE Donor_ID = '" + patientID + "'";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertIntoSurgery(string PatientID, int HospitalID, string Report, string Date, string Type)
        {
            string query = "INSERT INTO Surgery(Patient_ID, Hospital_ID, Surgery_Report, Date_Time, Type_of_Surgery) VALUES ('"+PatientID+"',"+HospitalID+",'"+Report+"'," + Date + ",'" + Type + "');";
            return dbMan.ExecuteNonQuery(query);
        }



        //public int DeleteSupplier(string snum)
        //{
        //    string query = "DELETE FROM S WHERE S#='" + snum + "';";
        //    return dbMan.ExecuteNonQuery(query);
        //}

        //public int UpdateSupplier(string snum, string city)
        //{
        //    string query = "UPDATE S SET City='" + city + "' WHERE S#='" + snum + "';";
        //    return dbMan.ExecuteNonQuery(query);
        //}

        //public DataTable SelectAllSuppliers()
        //{
        //    string query = "SELECT * FROM S;";
        //    return dbMan.ExecuteReader(query);
        //}

        //public int CountSuppliers()
        //{
        //    string query = "SELECT COUNT(S#) FROM S;";
        //    return (int)dbMan.ExecuteScalar(query);
        //}

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}

