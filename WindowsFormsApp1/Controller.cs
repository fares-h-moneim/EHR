using System.Collections.Generic;
using System.Data;

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

            string StoredProcedureName = StoredProcedures.InsertPatient;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@NationalID", nationalid);
            Parameters.Add("@Fname", fname);
            Parameters.Add("@Lname", lname);
            Parameters.Add("@Username", username);
            Parameters.Add("@Password", password);
            Parameters.Add("@Phone", phone);
            Parameters.Add("@Gender", gender);
            Parameters.Add("@Blood", blood);
            Parameters.Add("@Emerg", emerg);
            Parameters.Add("@Age", age);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);

        }

        public int UpdatePatient(string nationalid_prev, string nationalid, string fname, string lname, string username, string password, string gender, string age, string blood, string phone, string emerg)
        {
            string StoredProcedureName = StoredProcedures.UpdatePatient;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@NationalID", nationalid);
            Parameters.Add("@Fname", fname);
            Parameters.Add("@Lname", lname);
            Parameters.Add("@Username", username);
            Parameters.Add("@Password", password);
            Parameters.Add("@Phone", phone);
            Parameters.Add("@Gender", gender);
            Parameters.Add("@Blood", blood);
            Parameters.Add("@Emerg", emerg);
            Parameters.Add("@Age", age);
            Parameters.Add("@NationalIDPREV", nationalid_prev);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);

        }


        public DataTable SelectDescriptions(string id)
        {
            string query = "SELECT Distinct Description From Lab_Results where Patient_ID = '"+id+"' and Test_Result IS NOT NULL;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable getpatientstatusupondeath(string id)
        {
            string query = "SELECT Organ_Donor_Upon_Death FROM Patient WHERE NationalID='" + id + "';";
            return dbMan.ExecuteReader(query);

        }
        public DataTable SelectLabDates(string id, string desc)
        {
            string query = "SELECT * From Lab_Results where Patient_ID = '" + id + "' and Description = '"+desc+"' and Test_Result IS NOT NULL;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetResult(string id, string desc, string test_id)
        {
            string query = "SELECT * From Lab_Results where Patient_ID = '" + id + "' and Description = '" + desc + "' and ID = '"+ test_id + "';";
            return dbMan.ExecuteReader(query);
        }

        public int InsertChronicDisease(string Disease, string nationalid)
        {
        
            string query = "INSERT INTO ChronicDiseases Values ('" + Disease + "','" + nationalid + "');";
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
        public DataTable viewmedicalhistory(string datetime1, string datetime2, string pid) //complex query
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
        public DataTable GetOrgan_Donor_1(string id)
        {
            string query = "SELECT * FROM Organ_Donor WHERE Donor_ID='" + id + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetPrescriptions(string datetime1, string datetime2, string id)
        {
            string query = "SELECT Hospital.Name, Prescription.Date_Time, Prescription.Given_or_not, Medications.Medication FROM Hospital, Diagnosis, Patient, Medications, Prescription WHERE Prescription.Date_Time BETWEEN '" + datetime1 + "' AND '" + datetime2 + "' AND Diagnosis.Hospital_ID=Hospital.Hospital_ID AND Diagnosis.Patient_ID = '" + id + "' AND Diagnosis.Patient_ID=Patient.NationalID AND Medications.Prescription_ID=Prescription.Prescription_ID AND Diagnosis.Prescription_ID=Prescription.Prescription_ID;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetSurgeries(string datetime1, string datetime2, string id) //complex query
        {
            string query = "SELECT Hospital.Name, Date_Time, Surgery_Report, Type_of_Surgery FROM Hospital, Surgery WHERE Surgery.Date_Time Between '" + datetime1 + "' AND '" + datetime2 + "' and Surgery.Hospital_ID=Hospital.Hospital_ID;";
            return dbMan.ExecuteReader(query);
        }

        public int InsertRelative(string id, string rid)
        {
            string query = "INSERT INTO Relatives VALUES ('" + id + "','" + rid + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int OrganDonorUponDeath(string patientID)
        {
            string query = "UPDATE Patient SET Organ_Donor_Upon_Death = 1 WHERE NationalID = '"+patientID+"';";
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

