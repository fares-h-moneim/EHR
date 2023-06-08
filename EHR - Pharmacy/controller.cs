using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using System.Xml.Linq;
using System.Reflection;

namespace EHR___Pharmacy
{
    public class Controller
    {
        DBManager DbMan;

        public Controller()
        {
            DbMan = new DBManager();
        }
        public DataTable GetPharmacy(string Username, string Password)
        {
            string StoredProcedureNames = StoredProcedures.GetPharmacy;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", Username);
            Parameters.Add("@Password", Password);
            return DbMan.ExecuteReader(StoredProcedureNames, Parameters);
        }

        public DataTable GetPharmacyID(string Username)
        {
            string Query = "SELECT Pharmacy_ID " +
                "From Pharmacy " +
                "Where Username = '" + Username + "';";
            return DbMan.ExecuteReader(Query);
        }

        public DataTable RealPatient(string ID)
        {
            string Query = "SELECT NationalID FROM Patient WHERE NationalID = '" + ID + "';";
            return DbMan.ExecuteReader(Query);
        }

        public DataTable GetMedications(string PatientID) //complex Query
        {
            string StoredProcureNames = StoredProcedures.GetMedications;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PatientID", PatientID);
            return DbMan.ExecuteReader(StoredProcureNames, Parameters);
        }

        public int MedicationsGiven(int PID, int Pharmacy)
        {
            string Query = "UPDATE Prescription SET Given_or_not = "+Pharmacy+" WHERE Prescription_ID = " + PID + ";";
            return DbMan.ExecuteNonQuery(Query);
        }

        public int ChangePass(string ID, string Password)
        {
            string Query = "UPDATE Pharmacy SET Password = '" + Password + "' WHERE Username = '" + ID + "' ;";
            return DbMan.ExecuteNonQuery(Query);
        }


        public void TerminateConnection()
        {
            DbMan.CloseConnection();
        }
    }
}