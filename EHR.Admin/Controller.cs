using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using System.Xml.Linq;
using System.Reflection;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Security.Cryptography;

namespace EHR_Admin
{
    public class Controller
    {
        DBManager DbMan;

        public Controller()
        {
            DbMan = new DBManager();
        }

        public DataTable GetDiagnosisCount()
        {
            string Query = "SELECT Diseases, count(*) FROM Diagnosis, Diseases WHERE Diagnosis.Diagnosis = Diseases GROUP BY Diseases ORDER BY 2 DESC";
            return DbMan.ExecuteReader(Query);
        }

        public DataTable GetDiagnosisCountMale()
        {
            string Query = "SELECT Diseases, count(*) FROM Diagnosis, Diseases, Patient WHERE Diagnosis.Diagnosis = Diseases AND Patient_ID = NationalID AND Gender = 0 GROUP BY Diseases ORDER BY 2 DESC";
            return DbMan.ExecuteReader(Query);
        }

        public DataTable GetDiagnosisCountFemale()
        {
            string Query = "SELECT Diseases, count(*) FROM Diagnosis, Diseases, Patient WHERE Diagnosis.Diagnosis = Diseases AND Patient_ID = NationalID AND Gender = 1 GROUP BY Diseases ORDER BY 2 DESC";
            return DbMan.ExecuteReader(Query);
        }

        public DataTable GetDiagnosisCountAll()
        {
            string Query = "SELECT Diseases, sum(CASE WHEN Gender = 1 THEN 1 ELSE 0 END) as males,sum(CASE WHEN Gender = 0 THEN 1 ELSE 0 END) as females\r\nFROM Diagnosis, Diseases, Patient \r\nWHERE Diagnosis.Diagnosis = Diseases AND Patient_ID = NationalID\r\nGROUP BY Diseases \r\nORDER BY count(*) DESC";
            return DbMan.ExecuteReader(Query);
        }

        public DataTable GetLabCountAll()
        {
            string Query = "SELECT Lab_Tests, sum(CASE WHEN Gender = 1 THEN 1 ELSE 0 END) as males,sum(CASE WHEN Gender = 0 THEN 1 ELSE 0 END) as females\r\nFROM Lab_Tests, Lab_Results, Patient\r\nWHERE Lab_Results.Description = Lab_Tests AND Patient_ID = NationalID\r\nGroup By Lab_Tests \r\nOrder by Count(*) Description";
            return DbMan.ExecuteReader(Query);
        }

        public DataTable GetSurgeriesCountAll()
        {
            string Query = "SELECT Surgeries, sum(CASE WHEN Gender = 1 THEN 1 ELSE 0 END) as males,sum(CASE WHEN Gender = 0 THEN 1 ELSE 0 END) as females\r\nFROM Surguries, Surgery, Patient \r\nWHERE Surgery.Type_of_Surgery = Surgeries AND Patient_ID = NationalID \r\nGROUP BY Surgeries \r\norder by 2 Description";
            return DbMan.ExecuteReader(Query);
        }

        public DataTable GetMedicationCountAll()
        {
            string Query = "SELECT Trade_Name, sum(CASE WHEN Gender = 1 THEN 1 ELSE 0 END) as males,sum(CASE WHEN Gender = 0 THEN 1 ELSE 0 END) as females\r\nFROM Drugs, Prescription, Medications, Patient, Diagnosis \r\nWHERE Prescription.Prescription_ID = Medications.Prescription_ID AND Medication = Trade_Name AND Patient_ID = NationalID AND Prescription.Prescription_ID = Diagnosis.Prescription_ID \r\nGroup By Trade_Name \r\nOrder by count(*) Description";
            return DbMan.ExecuteReader(Query);
        }

        public DataTable GetDiagnosisCountAllDate(string Start, string End)
        {
            string Query = "SELECT Diseases, sum(CASE WHEN Gender = 1 THEN 1 ELSE 0 END) as males,sum(CASE WHEN Gender = 0 THEN 1 ELSE 0 END) as females\r\nFROM Diagnosis, Diseases, Patient \r\nWHERE Diagnosis.Diagnosis = Diseases AND Patient_ID = NationalID AND Date_Time BETWEEN '" + Start + "' AND '" + End + "'\r\nGROUP BY Diseases \r\nORDER BY count(*) DESC";
            return DbMan.ExecuteReader(Query);
        }

        public DataTable GetLabCountAllDate(string Start, string End)
        {
            string Query = "SELECT Lab_Tests, sum(CASE WHEN Gender = 1 THEN 1 ELSE 0 END) as males,sum(CASE WHEN Gender = 0 THEN 1 ELSE 0 END) as females\r\nFROM Lab_Tests, Lab_Results, Patient\r\nWHERE Lab_Results.Description = Lab_Tests AND Patient_ID = NationalID AND Date_Time BETWEEN '" + Start + "' AND '" + End + "'\r\nGroup By Lab_Tests \r\nOrder by Count(*) Description";
            return DbMan.ExecuteReader(Query);
        }

        public DataTable GetSurgeriesCountAllDate(string Start, string End)
        {
            string Query = "SELECT Surgeries, sum(CASE WHEN Gender = 1 THEN 1 ELSE 0 END) as males,sum(CASE WHEN Gender = 0 THEN 1 ELSE 0 END) as females\r\nFROM Surguries, Surgery, Patient \r\nWHERE Surgery.Type_of_Surgery = Surgeries AND Patient_ID = NationalID AND Date_Time BETWEEN '" + Start + "' AND '" + End + "'\r\nGROUP BY Surgeries \r\norder by 2 Description";
            return DbMan.ExecuteReader(Query);
        }

        public DataTable GetSurgeriesMaleDate(string Start, string End)
        {
            string Query = "SELECT Surgeries, count(*) FROM Surguries, Surgery, Patient WHERE Surgery.Type_of_Surgery = Surgeries AND Patient_ID = NationalID AND GENDER = 0 AND Date_Time BETWEEN '" + Start + "' AND '" + End + "'  GROUP BY Surgeries order by 2 Description";
            return DbMan.ExecuteReader(Query);
        }
        public DataTable GetSurgeriesFemaleDate(string Start, string End)
        {
            string Query = "SELECT Surgeries, count(*) FROM Surguries, Surgery, Patient WHERE Surgery.Type_of_Surgery = Surgeries AND Patient_ID = NationalID AND GENDER = 1 AND Date_Time BETWEEN '" + Start + "' AND '" + End + "'  GROUP BY Surgeries order by 2 Description";
            return DbMan.ExecuteReader(Query);
        }

        public DataTable GetMedicationCountAllDate(string Start, string End)
        {
            string Query = "SELECT Trade_Name, sum(CASE WHEN Gender = 1 THEN 1 ELSE 0 END) as males,sum(CASE WHEN Gender = 0 THEN 1 ELSE 0 END) as females\r\nFROM Drugs, Prescription, Medications, Patient, Diagnosis \r\nWHERE Prescription.Prescription_ID = Medications.Prescription_ID AND Medication = Trade_Name AND Patient_ID = NationalID AND Prescription.Prescription_ID = Diagnosis.Prescription_ID AND Prescription.Date_Time BETWEEN '" + Start + "' AND '" + End + "'\r\nGroup By Trade_Name \r\nOrder by count(*) Description";
            return DbMan.ExecuteReader(Query);
        }

        public DataTable GetDiagnosisCountMaleDate(string Start, string End)
        {
            string Query = "SELECT Diseases, count(*) FROM Diagnosis, Diseases, Patient WHERE Diagnosis.Diagnosis = Diseases AND Patient_ID = NationalID AND Gender = 0 AND Date_Time BETWEEN '" + Start + "' AND '" + End + "' GROUP BY Diseases ORDER BY 2 DESC";
            return DbMan.ExecuteReader(Query);
        }

        public DataTable GetDiagnosisCountFemaleDate(string Start, string End)
        {
            string Query = "SELECT Diseases, count(*) FROM Diagnosis, Diseases, Patient WHERE Diagnosis.Diagnosis = Diseases AND Patient_ID = NationalID AND Gender = 1 AND Date_Time BETWEEN '" + Start + "' AND '" + End + "' GROUP BY Diseases ORDER BY 2 DESC";
            return DbMan.ExecuteReader(Query);
        }

        public DataTable GetDiagnosisCountBetween(string Start, string End)
        {
            string Query = "SELECT Diseases, count(*) FROM Diagnosis, Diseases WHERE Diagnosis.Diagnosis = Diseases AND Date_Time BETWEEN '" + Start + "' AND '" + End + "' GROUP BY Diseases ORDER BY 2 DESC";
            return DbMan.ExecuteReader(Query);
        }

        public DataTable GetMedicationCount()
        {
            string Query = "SELECT Trade_Name, Count(*) FROM Drugs, Prescription, Medications WHERE Prescription.Prescription_ID = Medications.Prescription_ID AND Medication = Trade_Name Group By Trade_Name Order by 2 Description";
            return DbMan.ExecuteReader(Query);
        }

        public DataTable GetMedicationCountMale()
        {
            string Query = "SELECT Trade_Name, Count(*) FROM Drugs, Prescription, Medications, Patient, Diagnosis WHERE Prescription.Prescription_ID = Medications.Prescription_ID AND Medication = Trade_Name AND Patient_ID = NationalID AND Prescription.Prescription_ID = Diagnosis.Prescription_ID AND Gender = 0 Group By Trade_Name Order by 2 Description";
            return DbMan.ExecuteReader(Query);
        }

        public DataTable GetMedicationCountFemale()
        {
            string Query = "SELECT Trade_Name, Count(*) FROM Drugs, Prescription, Medications, Patient, Diagnosis WHERE Prescription.Prescription_ID = Medications.Prescription_ID AND Medication = Trade_Name AND Patient_ID = NationalID AND Prescription.Prescription_ID = Diagnosis.Prescription_ID AND Gender = 1 Group By Trade_Name Order by 2 Description";
            return DbMan.ExecuteReader(Query);
        }

        public DataTable GetMedicationCountBetween(string Start, string End)
        {
            string Query = "SELECT Trade_Name, Count(*) FROM Drugs, Prescription, Medications WHERE Prescription.Prescription_ID = Medications.Prescription_ID AND Medication = Trade_Name AND Date_Time Between '"+Start+"' AND '"+End+"'Group By Trade_Name Order by 2 Description";
            return DbMan.ExecuteReader(Query);
        }
        public DataTable GetMedicationMaleDate(string Start, string End)
        {
            string Query = "SELECT Trade_Name, Count(*) FROM Drugs, Prescription, Medications, Patient, Diagnosis WHERE Prescription.Prescription_ID = Medications.Prescription_ID AND Medication = Trade_Name AND Patient_ID = NationalID AND Prescription.Prescription_ID = Diagnosis.Prescription_ID AND Gender = 0 AND Prescription.Date_Time BETWEEN '" + Start + "' AND '" + End + "' Group By Trade_Name Order by 2 Description";
            return DbMan.ExecuteReader(Query);
        }

        public DataTable GetMedicationFemaleDate(string Start, string End)
        {
            string Query = "SELECT Trade_Name, Count(*) FROM Drugs, Prescription, Medications, Patient, Diagnosis WHERE Prescription.Prescription_ID = Medications.Prescription_ID AND Medication = Trade_Name AND Patient_ID = NationalID AND Prescription.Prescription_ID = Diagnosis.Prescription_ID AND Gender = 1 AND Prescription.Date_Time BETWEEN '" + Start + "' AND '" + End + "' Group By Trade_Name Order by 2 Description";
            return DbMan.ExecuteReader(Query);
        }

        public DataTable GetLabsCount()
        {
            string Query = "SELECT Lab_Tests, Count(*) FROM Lab_Tests, Lab_Results WHERE Lab_Results.Description = Lab_Tests Group By Lab_Tests Order by 2 Description";
            return DbMan.ExecuteReader(Query);
        }

        public DataTable GetLabMale()
        {
            string Query = "SELECT Lab_Tests, Count(*) FROM Lab_Tests, Lab_Results, Patient WHERE Lab_Results.Description = Lab_Tests AND Patient_ID = NationalID AND Gender = 0 Group By Lab_Tests Order by 2 Description";
            return DbMan.ExecuteReader(Query);
        }

        public DataTable GetLabFemale()
        {
            string Query = "SELECT Lab_Tests, Count(*) FROM Lab_Tests, Lab_Results, Patient WHERE Lab_Results.Description = Lab_Tests AND Patient_ID = NationalID AND Gender = 1 Group By Lab_Tests Order by 2 Description";
            return DbMan.ExecuteReader(Query);
        }

        public DataTable GetLabsCountBetween(string Start, string End)
        {
            string Query = "SELECT Lab_Tests, Count(*) FROM Lab_Tests, Lab_Results WHERE Lab_Results.Description = Lab_Tests AND Date_Time BETWEEN '" + Start + "' AND '" + End + "' Group By Lab_Tests Order by 2 Description";
            return DbMan.ExecuteReader(Query);
        }

        public DataTable GetLabMaleDate(string Start, string End)
        {
            string Query = "SELECT Lab_Tests, Count(*) FROM Lab_Tests, Lab_Results, Patient WHERE Lab_Results.Description = Lab_Tests AND Patient_ID = NationalID AND Gender = 0  AND Date_Time BETWEEN '" + Start + "' AND '" + End + "' Group By Lab_Tests Order by 2 Description";
            return DbMan.ExecuteReader(Query);
        }

        public DataTable GetLabFemaleDate(string Start, string End)
        {
            string Query = "SELECT Lab_Tests, Count(*) FROM Lab_Tests, Lab_Results, Patient WHERE Lab_Results.Description = Lab_Tests AND Patient_ID = NationalID AND Gender = 1  AND Date_Time BETWEEN '" + Start + "' AND '" + End + "' Group By Lab_Tests Order by 2 Description";
            return DbMan.ExecuteReader(Query);
        }

        public DataTable GetSurgeriesCount()
        {
            string Query = "SELECT Surgeries, count(*) FROM Surguries, Surgery WHERE Surgery.Type_of_Surgery = Surgeries GROUP BY Surgeries order by 2 Description";
            return DbMan.ExecuteReader(Query);
        }

        public DataTable GetSurgeriesMale()
        {
            string Query = "SELECT Surgeries, count(*) FROM Surguries, Surgery, Patient WHERE Surgery.Type_of_Surgery = Surgeries AND Patient_ID = NationalID AND GENDER = 0 GROUP BY Surgeries order by 2 Description";
            return DbMan.ExecuteReader(Query);
        }

        public DataTable GetSurgeriesFemale()
        {
            string Query = "SELECT Surgeries, count(*) FROM Surguries, Surgery, Patient WHERE Surgery.Type_of_Surgery = Surgeries AND Patient_ID = NationalID AND GENDER = 1 GROUP BY Surgeries order by 2 Description";
            return DbMan.ExecuteReader(Query);
        }

        public DataTable GetSurgeriesCountBetween(string Start, string End)
        {
            string Query = "SELECT Surgeries, count(*) FROM Surguries, Surgery WHERE Surgery.Type_of_Surgery = Surgeries AND Date_Time BETWEEN '" + Start + "' AND '" + End + "'GROUP BY Surgeries order by 2 Description";
            return DbMan.ExecuteReader(Query);
        }



        public DataTable GetAdmin(string Username, string Password)
        {
            string Query = "SELECT * " +
                "From Admins " +
                "Where Username = '" + Username + "' AND Password = '" + Password + "';";
            return DbMan.ExecuteReader(Query);
        }

        public DataTable GetHospital(string Username)
        {
            string Query = "SELECT Hospital_ID " +
                "From Hospital " +
                "Where Username = '" + Username + "';";
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
        public int ChangePass(string ID, string Password)
        {
            string Query = "UPDATE Admins SET Password = '" + Password + "' WHERE Username = '" + ID + "' ;";
            return DbMan.ExecuteNonQuery(Query);
        }


        public int InsertHospital(string Name,  string Username, string Password, string Address)
        {
            string StoredProcedureNames = StoredProcedures.InsertHospital;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Name", Name);
            Parameters.Add("@Username", Username);
            Parameters.Add("@Password", Password);
            Parameters.Add("@Address", Address);
            return DbMan.ExecuteNonQuery(StoredProcedureNames, Parameters);
        }

        public int InsertPharmacy(string Name, string Username, string Password, string Address, string PhoneNumber)
        {
            string StoredProcedureNames = StoredProcedures.InsertPharmacy;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Name", Name);
            Parameters.Add("@Username", Username);
            Parameters.Add("@Address", Address);
            Parameters.Add("@Password", Password);
            Parameters.Add("@Phoneno", PhoneNumber);
            return DbMan.ExecuteNonQuery(StoredProcedureNames, Parameters);
        }
        public int InsertLaboratory(string Name, string Username, string Password, string Address, string PhoneNumber)
        {
            string Query = "INSERT INTO Laboratory VALUES ('" + Name + "','" + Username + "','" + Password + "','" + Address + "','" + PhoneNumber + "');";
            return DbMan.ExecuteNonQuery(Query);
        }
        public int InsertPhonenumbers(string no, int ID)
        {
            string Query = "INSERT INTO PhoneNumbers VALUES ('" + no + "'," + ID + ");";
            return DbMan.ExecuteNonQuery(Query);
        }
        public int InsertAdmin(string FirstName, string LastName, string Username, string Password)
        {
            string Query = "INSERT INTO Admins VALUES ('" + FirstName + "','" + LastName + "','" + Username + "','" + Password + "');";
            return DbMan.ExecuteNonQuery(Query);
        }
        public void TerminateConnection()
        {
            DbMan.CloseConnection();
        }
    }
}

