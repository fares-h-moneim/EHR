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
        DBManager DbMan;

        public Controller()
        {
            DbMan = new DBManager();
        }
        public DataTable GetRelativesChronic(string ID)
        {
            string Query = "SELECT Patient.FirstName, Patient.LastName, ChronicDiseases.Disease FROM Patient, ChronicDiseases WHERE Patient.NationalID IN (SELECT Relatives.Relative_ID From Relatives WHERE Relatives.Patient_ID = '" + ID + "' AND Accepted = 1) AND ChronicDiseases.PatientID = Patient.NationalID";
            return DbMan.ExecuteReader(Query);
        }

        public DataTable GetHospital(string Username, string Password)
        {
            string Query = "SELECT * " +
                "From Hospital " +
                "Where Username = '" + Username + "' and Password = '" + Password + "';";
            return DbMan.ExecuteReader(Query);
        }

        public int InsertLabTest(string PatientID, string Date, string Description)
        {
            string Query = "Insert into Lab_Results(Patient_ID, Date_Time, Description) values ('" + PatientID + "', '" +Date+ "', '"+Description+"')";
            return DbMan.ExecuteNonQuery(Query);
        }

        public int IDExist(string ID)
        {
            string Query = "SELECT COUNT(NationalID) FROM Patient WHERE NationalID = '" + ID + "';";
            return (int)DbMan.ExecuteScalar(Query);
        }

        public int EmailExist(string Email)
        {
            string Query = "SELECT COUNT(Email) FROM Patient WHERE Email = '" + Email + "';";
            return (int)DbMan.ExecuteScalar(Query);
        }

        public int InsertDiagnosis(int HospitalID, string PatientID, string Date, string Diagnosis, string Symptoms, int Prescription_ID) //complex Query
        {
            string storedprocedurenames = StoredProcedures.InsertDiag;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@HosID", HospitalID);
            Parameters.Add("@patID", PatientID);
            Parameters.Add("@Date", Date);
            Parameters.Add("@Diag", Diagnosis);
            Parameters.Add("@symp", Symptoms);
            Parameters.Add("@presID", Prescription_ID);
            return DbMan.ExecuteNonQuery(storedprocedurenames, Parameters);

        }
        public DataTable GetLabTests()
        {
            string Query = "SELECT * FROM Lab_Tests";
            return DbMan.ExecuteReader(Query);
        }
        public DataTable GetSurgeriesTypes()
        {
            string Query = "SELECT * FROM Surguries";
            return DbMan.ExecuteReader(Query);
        }

        public DataTable InsertPrescription(string Date)
        {
            string Query = "INSERT INTO Prescription(Date_Time) VALUES ('" + Date + "')" +
                " Select @@IDENTITY AS [@@IDENTITY];";
            return DbMan.ExecuteReader(Query);
        }
        public int Updatetodead(string ID)
        {
            string Query = "UPDATE Patient Set DeadOrAlive=1 Where NationalID='" + ID + "';";
            return DbMan.ExecuteNonQuery(Query);
        }
        public DataTable GetWaiting()
        {
            string Query = "SELECT * FROM Organ_Waiting_List WHERE Status = 0 ORDER BY Priority Description"; //assuming 0 means Status
            return DbMan.ExecuteReader(Query);
        }
        public DataTable GetWaitingforhospital(int ID)
        {
            string Query = "SELECT * FROM Organ_Waiting_List WHERE Status = 0 and Hospital_ID=" + ID + " ORDER BY Priority Description"; //assuming 0 means Status
            return DbMan.ExecuteReader(Query);
        }

        public DataTable GetDonate()
        {
            string Query = "SELECT * FROM Organ_Donor"; //assuming 0 means Status
            return DbMan.ExecuteReader(Query);
        }

        public DataTable GetPatient(string ID)
        {
            string Query = "SELECT * FROM Patient WHERE NationalID='" + ID + "';";
            return DbMan.ExecuteReader(Query);
        }
        public DataTable GetPrescriptionID(string Date)
        {
            string Query = "Select Prescription_ID FROM Prescription WHERE Date_Time = '" + Date + "';";
            return DbMan.ExecuteReader(Query);
        }

        public int InsertMedications(int PresID, string Medication, int Quantity)
        {
            string Query = "Insert INTO Medications Values ("+PresID+",'"+Medication+"',"+Quantity+");";
            return DbMan.ExecuteNonQuery(Query);
        }

        public DataTable GetHospital(string Username)
        {
            string Query = "SELECT Hospital_ID " +
                "From Hospital " +
                "Where Username = '" + Username + "';";
            return DbMan.ExecuteReader(Query);
        }

        public int InsertOrganWaiting(string Organ, string PatientID, int Priority, int HospitalID, int Status, string Date)
        {
            string Query = "INSERT INTO Organ_Waiting_List VALUES ('" + Organ + "','" + PatientID + "'," + Priority + ", "+HospitalID+","+Status+",'"+Date+"');";
            return DbMan.ExecuteNonQuery(Query);
        }

        public DataTable GetChronic(string PatientID)
        {
            string Query = "Select Disease FROM ChronicDiseases WHERE PatientID = '"+PatientID+"';";
            return DbMan.ExecuteReader(Query);
        }

        public DataTable GetDiagnosis(string PatientID)
        {
            string Query = "Select Date_Time, Diagnosis, Symptoms FROM Diagnosis WHERE Patient_ID = '" + PatientID + "';";
            return DbMan.ExecuteReader(Query);
        }

        public DataTable GetPrescriptions(string PatientID) //complex Query
        {
            string Query = "Select Prescription.Date_Time, Medications.Medication, Prescription.Given_or_not FROM Prescription, Diagnosis, Medications WHERE Patient_ID = '" + PatientID + "' AND Diagnosis.Prescription_ID = Prescription.Prescription_ID AND Prescription.Prescription_ID = Medications.Prescription_ID;";
            return DbMan.ExecuteReader(Query);
        }

        public DataTable GetSurgeries(string PatientID)
        {
            string Query = "Select Date_Time, Type_of_Surgery, Surgery_Report FROM Surgery WHERE Patient_ID = '" + PatientID + "';";
            return DbMan.ExecuteReader(Query);
        }

        public DataTable GetLabs(string PatientID)
        {
            string Query = "Select Date_Time, Test_Result FROM Lab_Results WHERE Patient_ID = '" + PatientID + "';";
            return DbMan.ExecuteReader(Query);
        }

        public DataTable GetLabsNotNull(string PatientID)
        {
            string Query = "Select Date_Time, Test_Result FROM Lab_Results WHERE Patient_ID = '" + PatientID + "' and Lab_ID IS NOT NULL;";
            return DbMan.ExecuteReader(Query);
        }

        public DataTable GetIfDonor(string patientID)
        {
            string Query = "SELECT Organ_Donor_Upon_Death FROM Patient WHERE NationalID = '" + patientID + "'";
            return DbMan.ExecuteReader(Query);
        }

        public int InsertOrganDonor(string Organ, string PatientID, int Status)
        {
            string Query = "INSERT INTO Organ_Donor VALUES ('" + Organ + "','" + PatientID + "'," + Status + ");";
            return DbMan.ExecuteNonQuery(Query); 
        }

        public int DeleteFromOrganDonor(string patientID)
        {
            string storedprocedurenames = StoredProcedures.DELETEORGAN;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@patID", patientID);
            return DbMan.ExecuteNonQuery(storedprocedurenames, Parameters);
        }

        public int InsertIntoSurgery(string PatientID, int HospitalID, string Report, string Date, string Type)
        {
            string Query = "INSERT INTO Surgery(Patient_ID, Hospital_ID, Surgery_Report, Date_Time, Type_of_Surgery) VALUES ('"+PatientID+"',"+HospitalID+",'"+Report+"','" + Date + "','" + Type + "');";
            return DbMan.ExecuteNonQuery(Query);
        }

        public DataTable GetMedicationList()
        {
            string Query = "SELECT * FROM Drugs ORDER BY Trade_Name ASC";
            return DbMan.ExecuteReader(Query);
        }

        public int ChangePass(string ID, string Password)
        {
            string Query = "UPDATE Hospital SET Password = '" + Password + "' WHERE Username = '" + ID + "' ;";
            return DbMan.ExecuteNonQuery(Query);
        }

        public DataTable GetDiseases()
        {
            string Query = "SELECT * FROM Diseases";
            return DbMan.ExecuteReader(Query);
        }

        public int UpdateStatus(string PatientID, string Organ)
        {
            string Query = "UPDATE Organ_Waiting_List SET Status = 1 WHERE Organ_Required = '" + Organ + "' AND Patient_ID = '" + PatientID + "' AND Status = 0;";
            return DbMan.ExecuteNonQuery(Query);
        }

        public int DeleteDonor(string PatientID, string Organ)
        {
            string Query = "DELETE FROM Organ_Donor WHERE Donor_ID = '" + PatientID + "' AND Organ_Type = '" + Organ+"';";
            return DbMan.ExecuteNonQuery(Query);
        }
        public void TerminateConnection()
        {
            DbMan.CloseConnection();
        }
    }
}

