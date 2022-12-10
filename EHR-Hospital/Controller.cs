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

