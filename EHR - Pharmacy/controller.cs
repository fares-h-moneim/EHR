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
        DBManager dbMan;

        public Controller()
        {
            dbMan = new DBManager();
        }
        public DataTable GetPharmacy(string username, string password)
        {
            string StoredProcedureNames = StoredProcedures.GetPharmacy;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", username);
            Parameters.Add("@Password", password);
            return dbMan.ExecuteReader(StoredProcedureNames, Parameters);
        }

        public DataTable GetPharmacyID(string username)
        {
            string query = "SELECT Pharmacy_ID " +
                "From Pharmacy " +
                "Where Username = '" + username + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable RealPatient(string id)
        {
            string query = "SELECT NationalID FROM Patient WHERE NationalID = '" + id + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetMedications(string PatientID) //complex query
        {
            string StoredProcureNames = StoredProcedures.GetMedications;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PatientID", PatientID);
            return dbMan.ExecuteReader(StoredProcureNames, Parameters);
        }

        public int MedicationsGiven(int PID, int Pharme)
        {
            string query = "UPDATE Prescription SET Given_or_not = "+Pharme+" WHERE Prescription_ID = " + PID + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int ChangePass(string id, string pass)
        {
            string query = "UPDATE Pharmacy SET Password = '" + pass + "' WHERE Username = '" + id + "' ;";
            return dbMan.ExecuteNonQuery(query);
        }


        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}