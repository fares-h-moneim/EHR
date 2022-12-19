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
            string query = "SELECT * " +
                "From Pharmacy " +
                "Where Username = '" + username + "' and Password = '" + password + "';";
            return dbMan.ExecuteReader(query);
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

        public DataTable GetMedications(string PatientID)
        {
            string query = "Select Medications.Prescription_ID, Medication, Quantity FROM Medications, Prescription, Diagnosis WHERE Patient_ID = '"+PatientID+ "' AND Diagnosis.Prescription_ID = Prescription.Prescription_ID AND Prescription.Prescription_ID = Medications.Prescription_ID AND Prescription.Given_or_not IS NULL";
            return dbMan.ExecuteReader(query);
        }

        public int MedicationsGiven(int PID, int Pharm)
        {
            string query = "UPDATE Prescription SET Given_or_not = "+Pharm+" WHERE Prescription_ID = " + PID + ";";
            return dbMan.ExecuteNonQuery(query);
        }


        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}

