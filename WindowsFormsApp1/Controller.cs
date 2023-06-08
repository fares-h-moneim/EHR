using System.Collections.Generic;
using System.Data;

namespace WindowsFormsApp1
{
    public class Controller
    {
        DBManager DbMan;

        public Controller()
        {
            DbMan = new DBManager();
        }

        public int DeleteChronic(string NationalID)
        {
            string Query = "DELETE FROM ChronicDiseases Where PatientID = '" + NationalID + "';";
            return DbMan.ExecuteNonQuery(Query);
        }

        public DataTable GetRelativeRequests(string NationalID)
        {
            string Query = "SELECT FirstName, LastName, PhoneNumber, Relative_ID, Patient_ID from Patient, Relatives Where Relatives.Relative_ID = '" + NationalID + "' and Relatives.Patient_ID = Patient.NationalID and Accepted = 0";
            return DbMan.ExecuteReader(Query);
        }

        public int AcceptRelative(string NationalID, string RelativeID)
        {
            string Query = "UPDATE Relatives SET Accepted = 1 Where Relative_ID = '" + NationalID + "' and Patient_ID = '" + RelativeID + "';";
            
            int x = DbMan.ExecuteNonQuery(Query);

            Query = "UPDATE Relatives SET Accepted = 1 Where Relative_ID = '" + RelativeID + "' and Patient_ID = '" + NationalID + "';";

            int y = DbMan.ExecuteNonQuery(Query);

            return x+y;
        }

        public int RejectRelative(string NationalID, string RelativeID)
        {
            string Query = "Delete from Relatives Where Patient_ID = '" + NationalID + "' and Relative_ID = '" + RelativeID + "';";
            int x = DbMan.ExecuteNonQuery(Query);
            Query = "Delete from Relatives Where Patient_ID = '" + RelativeID + "' and Relative_ID = '" + NationalID + "';";
            int y = DbMan.ExecuteNonQuery(Query);
            return x + y;
        }

        public DataTable CheckforReletiveRequest(string NationalID, string RelativeID)
        {
            string Query = "Select * from Relatives where Patient_ID = '"+NationalID+ "' and Relative_ID = '" + RelativeID + "';";

            return DbMan.ExecuteReader(Query);
        }

        public DataTable GetChronic(string NationalID)
        {
            string Query = "SELECT * from ChronicDiseases WHERE PatientID = '" + NationalID + "';";
            return DbMan.ExecuteReader(Query);
        }
        public int InsertPatient(string NationalID, string FirstName, string LastName, string Username, string Password, string Gender, string Age, string Blood, string Phone, string Emergency)
        {

            string StoredProcedureName = StoredProcedures.InsertPatient;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@NationalID", NationalID);
            Parameters.Add("@FirstName", FirstName);
            Parameters.Add("@LastName", LastName);
            Parameters.Add("@Username", Username);
            Parameters.Add("@Password", Password);
            Parameters.Add("@Phone", Phone);
            Parameters.Add("@Gender", Gender);
            Parameters.Add("@Blood", Blood);
            Parameters.Add("@Emergency", Emergency);
            Parameters.Add("@Age", Age);
            return DbMan.ExecuteNonQuery(StoredProcedureName, Parameters);

        }

        public int UpdatePatient(string PreviousNationalID, string NationalID, string FirstName, string LastName, string Username, string Password, string Gender, string Blood, string Phone, string Emergency)
        {
            string StoredProcedureName = StoredProcedures.UpdatePatient;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@NationalID", NationalID);
            Parameters.Add("@FirstName", FirstName);
            Parameters.Add("@LastName", LastName);
            Parameters.Add("@Username", Username);
            Parameters.Add("@Password", Password);
            Parameters.Add("@Phone", Phone);
            Parameters.Add("@Gender", Gender);
            Parameters.Add("@Blood", Blood);
            Parameters.Add("@Emergency", Emergency);
            Parameters.Add("@NationalIDPREV", PreviousNationalID);
            return DbMan.ExecuteNonQuery(StoredProcedureName, Parameters);

        }

        public DataTable GetRelatives(string ID)
        {
            string Query = "SELECT FirstName, LastName, PhoneNumber from Patient, Relatives Where Relatives.Patient_ID = '" + ID + "' and Relatives.Relative_ID = Patient.NationalID and Accepted = 1";
            return DbMan.ExecuteReader(Query);
        }

        public DataTable SelectDescriptions(string ID)
        {
            string Query = "SELECT Distinct Description From Lab_Results where Patient_ID = '"+ID+"' and Test_Result IS NOT NULL;";
            return DbMan.ExecuteReader(Query);
        }
        public DataTable getpatientstatusupondeath(string ID)
        {
            string Query = "SELECT Organ_Donor_Upon_Death FROM Patient WHERE NationalID='" + ID + "';";
            return DbMan.ExecuteReader(Query);

        }
        public DataTable SelectLabDates(string ID, string Description)
        {
            string Query = "SELECT * From Lab_Results where Patient_ID = '" + ID + "' and Description = '"+Description+"' and Test_Result IS NOT NULL;";
            return DbMan.ExecuteReader(Query);
        }

        public DataTable GetResult(string ID, string Description, string TestID)
        {
            string Query = "SELECT * From Lab_Results where Patient_ID = '" + ID + "' and Description = '" + Description + "' and ID = '"+ TestID + "';";
            return DbMan.ExecuteReader(Query);
        }

        public int InsertChronicDisease(string Disease, string NationalID)
        {
        
            string Query = "INSERT INTO ChronicDiseases Values ('" + Disease + "','" + NationalID + "');";
            return DbMan.ExecuteNonQuery(Query);
        }

        public DataTable GetPatient(string Email, string Password)
        {
            string Query = "SELECT * " +
                "From Patient " +
                "Where Email = '" + Email + "' AND Password = '" + Password + "';";
            return DbMan.ExecuteReader(Query);
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
        public int InsertHospital(string Name, string HospitalID, string Username, string Password)
        {
            string Query = "INSERT INTO Hospital (Name, Hospital_ID, Username, Password, Address " +
                            "Values ('" + Name + "','" + HospitalID + "','" + Username + "','" + Password + ");";
            return DbMan.ExecuteNonQuery(Query);
        }
        public int InsertPharmacy(string Name, string PharmacyID, string PhoneNumber)
        {
            string Query = "INSERT INTO Pharmacy (Name, Pharmacy_ID, PhoneNUmber " +
                            "Values ('" + Name + "','" + PharmacyID + "','" + PhoneNumber + "');";
            return DbMan.ExecuteNonQuery(Query);
        }
        public DataTable viewmedicalhistory(string DateTime1, string DateTime2, string PatientID) //complex Query
        {
            string Query = "SELECT Hospital.Name, Diagnosis.Date_Time, Diagnosis.Symptoms, Diagnosis.Diagnosis FROM Hospital, Diagnosis, Patient WHERE Date_Time BETWEEN '" + DateTime1 + "' AND '" + DateTime2 + "' AND Diagnosis.Hospital_ID=Hospital.Hospital_ID AND Diagnosis.Patient_ID = '" + PatientID + "' AND Diagnosis.Patient_ID=Patient.NationalID;"; 
            return DbMan.ExecuteReader(Query);
        }
        public int InsertOrganDonor(string Organ, string PatientID, int Status)
        {
            string Query = "INSERT INTO Organ_Donor VALUES ('" + Organ + "','" + PatientID + "'," + Status + ");";
            return DbMan.ExecuteNonQuery(Query);
        }
        public DataTable GetOrgan_Donor(string Organ, string ID)
        {
            string Query = "SELECT * FROM Organ_Donor WHERE Organ_Type='" + Organ + "' AND Donor_ID='" + ID + "';";
            return DbMan.ExecuteReader(Query);
        }
        public DataTable GetOrgan_Donor_1(string ID)
        {
            string Query = "SELECT * FROM Organ_Donor WHERE Donor_ID='" + ID + "';";
            return DbMan.ExecuteReader(Query);
        }

        public DataTable GetPrescriptions(string DateTime1, string DateTime2, string ID)
        {
            string Query = "SELECT Hospital.Name, Prescription.Date_Time, Prescription.Given_or_not, Medications.Medication FROM Hospital, Diagnosis, Patient, Medications, Prescription WHERE Prescription.Date_Time BETWEEN '" + DateTime1 + "' AND '" + DateTime2 + "' AND Diagnosis.Hospital_ID=Hospital.Hospital_ID AND Diagnosis.Patient_ID = '" + ID + "' AND Diagnosis.Patient_ID=Patient.NationalID AND Medications.Prescription_ID=Prescription.Prescription_ID AND Diagnosis.Prescription_ID=Prescription.Prescription_ID;";
            return DbMan.ExecuteReader(Query);
        }

        public DataTable GetSurgeries(string DateTime1, string DateTime2, string ID) //complex Query
        {
            string Query = "SELECT Hospital.Name, Date_Time, Surgery_Report, Type_of_Surgery FROM Hospital, Surgery, Patient WHERE Surgery.Date_Time Between '" + DateTime1 + "' AND '" + DateTime2 + "' and Surgery.Hospital_ID=Hospital.Hospital_ID and Surgery.Patient_ID=Patient.NationalID and Surgery.Patient_ID='" + ID + "';";
            return DbMan.ExecuteReader(Query);
        }

        public int InsertRelative(string ID, string RelativeID)
        {
            string Query = "INSERT INTO Relatives VALUES ('" + ID + "','" + RelativeID + "', 0);";
            int x = DbMan.ExecuteNonQuery(Query);
            Query = "INSERT INTO Relatives VALUES ('" + RelativeID + "','" + ID + "', 0);";
            int y = DbMan.ExecuteNonQuery(Query);
            return x + y;
        }

        public int OrganDonorUponDeath(string patientID)
        {
            string Query = "UPDATE Patient SET Organ_Donor_Upon_Death = 1 WHERE NationalID = '"+patientID+"';";
            return DbMan.ExecuteNonQuery(Query);
        }
        public DataTable GetWaiting()
        {
            string Query = "SELECT * FROM Organ_Waiting_List WHERE Status = 0 ORDER BY Priority Description"; //assuming 0 means Status
            return DbMan.ExecuteReader(Query);
        }

        public int UpdateStatus(string PatientID, string Organ)
        {
            string Query = "UPDATE Organ_Waiting_List SET Status = 1 WHERE Organ_Required = '" + Organ + "' AND Patient_ID = '" + PatientID + "';";
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

