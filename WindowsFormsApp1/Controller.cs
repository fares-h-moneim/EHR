using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using System.Xml.Linq;
using System.Reflection;
using System.Security.Permissions;
using System.Security.Cryptography;

namespace WindowsFormsApp1
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

        public int InsertPatient(string nationalid, string fname, string lname, string username, string password, string gender, string age, string blood, string phone, string emerg)
        {

            string query = "INSERT INTO Patient (NationalID, Fname, Lname, Email, Password, PhoneNumber, Gender, BloodType, EmergencyContact, Age) " +
                            "Values ('" + nationalid + "','" + fname + "','" + lname + "','" + username + "','" + password + "','" + phone + "','" + gender + "','" + blood + "','" + emerg + "', " + Int32.Parse(age) + ");";
           return dbMan.ExecuteNonQuery(query);
        }
        public int InsertChronicDisease(string Disease, string nationalid)
        {
        
            string query = "INSERT INTO ChronicDiseases Values ('" + Disease + "','" + nationalid + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdatePatient(string nationalid_prev, string nationalid, string fname, string lname, string username, string password, string gender, string age, string blood, string phone, string emerg) {
            

            string query = "UPDATE Patient " + 
                "SET NationalID = '" + nationalid + "', Fname = '" + fname + "', Lname = '" + lname +"', Email = '" + username +"', Password = '" + password +"', PhoneNumber = '" + phone +"', Gender = " + gender + ", BloodType = '" + blood + "', Age = " + Convert.ToInt32(age) +  
                " WHERE NationalID = '" + nationalid_prev +"'";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable GetPatient(string email, string password)
        {
            string query = "SELECT * " +
                "From Patient " +
                "Where Email = '" + email + "' AND Password = '" + password + "';";
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
        public int InsertHospital(string name, string hospital_id, string username, string password)
        {
            string query = "INSERT INTO Hospital (Name, Hospital_ID, Username, Password, Address " +
                            "Values ('" + name + "','" + hospital_id + "','" + username + "','" + password + ");";
            return dbMan.ExecuteNonQuery(query);
        }
        public int InsertPharmacy(string name, string pharmacy_id, string phonenumber)
        {
            string query = "INSERT INTO Pharmacy (Name, Pharmacy_ID, PhoneNUmber " +
                            "Values ('" + name + "','" + pharmacy_id + "','" + phonenumber + "');";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable viewmedicalhistory(string datetime1, string datetime2, string pid)
        {
            string query = "SELECT Hospital.Name, Diagnosis.Date_Time, Diagnosis.Symptoms, Diagnosis.Diagnosis FROM Hospital, Diagnosis, Patient WHERE Date_Time BETWEEN '" + datetime1 + "' AND '" + datetime2 + "' AND Diagnosis.Hospital_ID=Hospital.Hospital_ID AND Diagnosis.Patient_ID = '" + pid + "' AND Diagnosis.Patient_ID=Patient.NationalID;"; 
            return dbMan.ExecuteReader(query);
        }
        public int InsertOrganDonor(string organ, string pid, int status)
        {
            string query = "INSERT INTO Organ_Donor VALUES ('" + organ + "','" + pid + "'," + status + ");";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable GetOrgan_Donor(string organ, string id)
        {
            string query = "SELECT * FROM Organ_Donor WHERE Organ_Type='" + organ + "' AND Donor_ID='" + id + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetPrescriptions(string datetime1, string datetime2, string id)
        {
            string query = "SELECT Hospital.Name, Prescription.Date_Time, Prescription.Given_or_not, Medications.Medication FROM Hospital, Diagnosis, Patient, Medications, Prescription WHERE Prescription.Date_Time BETWEEN '" + datetime1 + "' AND '" + datetime2 + "' AND Diagnosis.Hospital_ID=Hospital.Hospital_ID AND Diagnosis.Patient_ID = '" + id + "' AND Diagnosis.Patient_ID=Patient.NationalID AND Medications.Prescription_ID=Prescription.Prescription_ID AND Diagnosis.Prescription_ID=Prescription.Prescription_ID;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetSurgeries(string datetime1, string datetime2, string id)
        {
            string query = "SELECT Hospital.Name, Date_Time, Surgery_Report, Type_of_Surgery FROM Hospital, Surgery WHERE Surgery.Date_Time Between '" + datetime1 + "' AND '" + datetime2 + "' and Surgery.Hospital_ID=Hospital.Hospital_ID;";
            return dbMan.ExecuteReader(query);
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

