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

        /* public int InsertPatient(string nationalid, string fname, string lname, string username, string password, string gender, string age, string blood, string phone, string emerg)
         {

             string query = "INSERT INTO Patient (NationalID, Fname, Lname, Email, Password, PhoneNumber, Gender, BloodType, EmergencyContact, Age) " +
                             "Values ('" + nationalid + "','" + fname + "','" + lname + "','" + username + "','" + password + "','" + phone + "','" + gender + "','" + blood + "','" + emerg + "', " + Int32.Parse(age) + ");";
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
        */

        public DataTable GetDiagnosisCount()
        {
            string query = "SELECT Diseases, count(*) FROM Diagnosis, Diseases WHERE Diagnosis.Diagnosis = Diseases GROUP BY Diseases ORDER BY 2 DESC";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetDiagnosisCountMale()
        {
            string query = "SELECT Diseases, count(*) FROM Diagnosis, Diseases, Patient WHERE Diagnosis.Diagnosis = Diseases AND Patient_ID = NationalID AND Gender = 0 GROUP BY Diseases ORDER BY 2 DESC";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetDiagnosisCountFemale()
        {
            string query = "SELECT Diseases, count(*) FROM Diagnosis, Diseases, Patient WHERE Diagnosis.Diagnosis = Diseases AND Patient_ID = NationalID AND Gender = 1 GROUP BY Diseases ORDER BY 2 DESC";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetDiagnosisCountAll()
        {
            string query = "SELECT Diseases, sum(CASE WHEN gender = 1 THEN 1 ELSE 0 END) as males,sum(CASE WHEN gender = 0 THEN 1 ELSE 0 END) as females\r\nFROM Diagnosis, Diseases, Patient \r\nWHERE Diagnosis.Diagnosis = Diseases AND Patient_ID = NationalID\r\nGROUP BY Diseases \r\nORDER BY count(*) DESC";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetLabCountAll()
        {
            string query = "SELECT Lab_Tests, sum(CASE WHEN gender = 1 THEN 1 ELSE 0 END) as males,sum(CASE WHEN gender = 0 THEN 1 ELSE 0 END) as females\r\nFROM Lab_Tests, Lab_Results, Patient\r\nWHERE Lab_Results.Description = Lab_Tests AND Patient_ID = NationalID\r\nGroup By Lab_Tests \r\nOrder by Count(*) desc";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetSurgeriesCountAll()
        {
            string query = "SELECT Surgeries, sum(CASE WHEN gender = 1 THEN 1 ELSE 0 END) as males,sum(CASE WHEN gender = 0 THEN 1 ELSE 0 END) as females\r\nFROM Surguries, Surgery, Patient \r\nWHERE Surgery.Type_of_Surgery = Surgeries AND Patient_ID = NationalID \r\nGROUP BY Surgeries \r\norder by 2 desc";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetMedicationCountAll()
        {
            string query = "SELECT Trade_Name, sum(CASE WHEN gender = 1 THEN 1 ELSE 0 END) as males,sum(CASE WHEN gender = 0 THEN 1 ELSE 0 END) as females\r\nFROM Drugs, Prescription, Medications, Patient, Diagnosis \r\nWHERE Prescription.Prescription_ID = Medications.Prescription_ID AND Medication = Trade_Name AND Patient_ID = NationalID AND Prescription.Prescription_ID = Diagnosis.Prescription_ID \r\nGroup By Trade_Name \r\nOrder by count(*) desc";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetDiagnosisCountAllDate(string start, string end)
        {
            string query = "SELECT Diseases, sum(CASE WHEN gender = 1 THEN 1 ELSE 0 END) as males,sum(CASE WHEN gender = 0 THEN 1 ELSE 0 END) as females\r\nFROM Diagnosis, Diseases, Patient \r\nWHERE Diagnosis.Diagnosis = Diseases AND Patient_ID = NationalID AND Date_Time BETWEEN '" + start + "' AND '" + end + "'\r\nGROUP BY Diseases \r\nORDER BY count(*) DESC";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetLabCountAllDate(string start, string end)
        {
            string query = "SELECT Lab_Tests, sum(CASE WHEN gender = 1 THEN 1 ELSE 0 END) as males,sum(CASE WHEN gender = 0 THEN 1 ELSE 0 END) as females\r\nFROM Lab_Tests, Lab_Results, Patient\r\nWHERE Lab_Results.Description = Lab_Tests AND Patient_ID = NationalID AND Date_Time BETWEEN '" + start + "' AND '" + end + "'\r\nGroup By Lab_Tests \r\nOrder by Count(*) desc";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetSurgeriesCountAllDate(string start, string end)
        {
            string query = "SELECT Surgeries, sum(CASE WHEN gender = 1 THEN 1 ELSE 0 END) as males,sum(CASE WHEN gender = 0 THEN 1 ELSE 0 END) as females\r\nFROM Surguries, Surgery, Patient \r\nWHERE Surgery.Type_of_Surgery = Surgeries AND Patient_ID = NationalID AND Date_Time BETWEEN '" + start + "' AND '" + end + "'\r\nGROUP BY Surgeries \r\norder by 2 desc";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetSurgeriesMaleDate(string start, string end)
        {
            string query = "SELECT Surgeries, count(*) FROM Surguries, Surgery, Patient WHERE Surgery.Type_of_Surgery = Surgeries AND Patient_ID = NationalID AND GENDER = 0 AND Date_Time BETWEEN '" + start + "' AND '" + end + "'  GROUP BY Surgeries order by 2 desc";
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetSurgeriesFemaleDate(string start, string end)
        {
            string query = "SELECT Surgeries, count(*) FROM Surguries, Surgery, Patient WHERE Surgery.Type_of_Surgery = Surgeries AND Patient_ID = NationalID AND GENDER = 1 AND Date_Time BETWEEN '" + start + "' AND '" + end + "'  GROUP BY Surgeries order by 2 desc";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetMedicationCountAllDate(string start, string end)
        {
            string query = "SELECT Trade_Name, sum(CASE WHEN gender = 1 THEN 1 ELSE 0 END) as males,sum(CASE WHEN gender = 0 THEN 1 ELSE 0 END) as females\r\nFROM Drugs, Prescription, Medications, Patient, Diagnosis \r\nWHERE Prescription.Prescription_ID = Medications.Prescription_ID AND Medication = Trade_Name AND Patient_ID = NationalID AND Prescription.Prescription_ID = Diagnosis.Prescription_ID AND Prescription.Date_Time BETWEEN '" + start + "' AND '" + end + "'\r\nGroup By Trade_Name \r\nOrder by count(*) desc";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetDiagnosisCountMaleDate(string start, string end)
        {
            string query = "SELECT Diseases, count(*) FROM Diagnosis, Diseases, Patient WHERE Diagnosis.Diagnosis = Diseases AND Patient_ID = NationalID AND Gender = 0 AND Date_Time BETWEEN '" + start + "' AND '" + end + "' GROUP BY Diseases ORDER BY 2 DESC";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetDiagnosisCountFemaleDate(string start, string end)
        {
            string query = "SELECT Diseases, count(*) FROM Diagnosis, Diseases, Patient WHERE Diagnosis.Diagnosis = Diseases AND Patient_ID = NationalID AND Gender = 1 AND Date_Time BETWEEN '" + start + "' AND '" + end + "' GROUP BY Diseases ORDER BY 2 DESC";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetDiagnosisCountBetween(string start, string end)
        {
            string query = "SELECT Diseases, count(*) FROM Diagnosis, Diseases WHERE Diagnosis.Diagnosis = Diseases AND Date_Time BETWEEN '" + start + "' AND '" + end + "' GROUP BY Diseases ORDER BY 2 DESC";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetMedicationCount()
        {
            string query = "SELECT Trade_Name, Count(*) FROM Drugs, Prescription, Medications WHERE Prescription.Prescription_ID = Medications.Prescription_ID AND Medication = Trade_Name Group By Trade_Name Order by 2 desc";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetMedicationCountMale()
        {
            string query = "SELECT Trade_Name, Count(*) FROM Drugs, Prescription, Medications, Patient, Diagnosis WHERE Prescription.Prescription_ID = Medications.Prescription_ID AND Medication = Trade_Name AND Patient_ID = NationalID AND Prescription.Prescription_ID = Diagnosis.Prescription_ID AND Gender = 0 Group By Trade_Name Order by 2 desc";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetMedicationCountFemale()
        {
            string query = "SELECT Trade_Name, Count(*) FROM Drugs, Prescription, Medications, Patient, Diagnosis WHERE Prescription.Prescription_ID = Medications.Prescription_ID AND Medication = Trade_Name AND Patient_ID = NationalID AND Prescription.Prescription_ID = Diagnosis.Prescription_ID AND Gender = 1 Group By Trade_Name Order by 2 desc";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetMedicationCountBetween(string start, string end)
        {
            string query = "SELECT Trade_Name, Count(*) FROM Drugs, Prescription, Medications WHERE Prescription.Prescription_ID = Medications.Prescription_ID AND Medication = Trade_Name AND Date_Time Between '"+start+"' AND '"+end+"'Group By Trade_Name Order by 2 desc";
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetMedicationMaleDate(string start, string end)
        {
            string query = "SELECT Trade_Name, Count(*) FROM Drugs, Prescription, Medications, Patient, Diagnosis WHERE Prescription.Prescription_ID = Medications.Prescription_ID AND Medication = Trade_Name AND Patient_ID = NationalID AND Prescription.Prescription_ID = Diagnosis.Prescription_ID AND Gender = 0 AND Prescription.Date_Time BETWEEN '" + start + "' AND '" + end + "' Group By Trade_Name Order by 2 desc";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetMedicationFemaleDate(string start, string end)
        {
            string query = "SELECT Trade_Name, Count(*) FROM Drugs, Prescription, Medications, Patient, Diagnosis WHERE Prescription.Prescription_ID = Medications.Prescription_ID AND Medication = Trade_Name AND Patient_ID = NationalID AND Prescription.Prescription_ID = Diagnosis.Prescription_ID AND Gender = 1 AND Prescription.Date_Time BETWEEN '" + start + "' AND '" + end + "' Group By Trade_Name Order by 2 desc";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetLabsCount()
        {
            string query = "SELECT Lab_Tests, Count(*) FROM Lab_Tests, Lab_Results WHERE Lab_Results.Description = Lab_Tests Group By Lab_Tests Order by 2 desc";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetLabMale()
        {
            string query = "SELECT Lab_Tests, Count(*) FROM Lab_Tests, Lab_Results, Patient WHERE Lab_Results.Description = Lab_Tests AND Patient_ID = NationalID AND Gender = 0 Group By Lab_Tests Order by 2 desc";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetLabFemale()
        {
            string query = "SELECT Lab_Tests, Count(*) FROM Lab_Tests, Lab_Results, Patient WHERE Lab_Results.Description = Lab_Tests AND Patient_ID = NationalID AND Gender = 1 Group By Lab_Tests Order by 2 desc";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetLabsCountBetween(string start, string end)
        {
            string query = "SELECT Lab_Tests, Count(*) FROM Lab_Tests, Lab_Results WHERE Lab_Results.Description = Lab_Tests AND Date_Time BETWEEN '" + start + "' AND '" + end + "' Group By Lab_Tests Order by 2 desc";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetLabMaleDate(string start, string end)
        {
            string query = "SELECT Lab_Tests, Count(*) FROM Lab_Tests, Lab_Results, Patient WHERE Lab_Results.Description = Lab_Tests AND Patient_ID = NationalID AND Gender = 0  AND Date_Time BETWEEN '" + start + "' AND '" + end + "' Group By Lab_Tests Order by 2 desc";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetLabFemaleDate(string start, string end)
        {
            string query = "SELECT Lab_Tests, Count(*) FROM Lab_Tests, Lab_Results, Patient WHERE Lab_Results.Description = Lab_Tests AND Patient_ID = NationalID AND Gender = 1  AND Date_Time BETWEEN '" + start + "' AND '" + end + "' Group By Lab_Tests Order by 2 desc";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetSurgeriesCount()
        {
            string query = "SELECT Surgeries, count(*) FROM Surguries, Surgery WHERE Surgery.Type_of_Surgery = Surgeries GROUP BY Surgeries order by 2 desc";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetSurgeriesMale()
        {
            string query = "SELECT Surgeries, count(*) FROM Surguries, Surgery, Patient WHERE Surgery.Type_of_Surgery = Surgeries AND Patient_ID = NationalID AND GENDER = 0 GROUP BY Surgeries order by 2 desc";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetSurgeriesFemale()
        {
            string query = "SELECT Surgeries, count(*) FROM Surguries, Surgery, Patient WHERE Surgery.Type_of_Surgery = Surgeries AND Patient_ID = NationalID AND GENDER = 1 GROUP BY Surgeries order by 2 desc";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetSurgeriesCountBetween(string start, string end)
        {
            string query = "SELECT Surgeries, count(*) FROM Surguries, Surgery WHERE Surgery.Type_of_Surgery = Surgeries AND Date_Time BETWEEN '" + start + "' AND '" + end + "'GROUP BY Surgeries order by 2 desc";
            return dbMan.ExecuteReader(query);
        }



        public DataTable GetAdmin(string user, string password)
        {
            string query = "SELECT * " +
                "From Admins " +
                "Where Username = '" + user + "' AND Password = '" + password + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetHospital(string username)
        {
            string query = "SELECT Hospital_ID " +
                "From Hospital " +
                "Where Username = '" + username + "';";
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
        public int ChangePass(string id, string pass)
        {
            string query = "UPDATE Admins SET Password = '" + pass + "' WHERE Username = '" + id + "' ;";
            return dbMan.ExecuteNonQuery(query);
        }


        public int InsertHospital(string name,  string username, string password, string address)
        {
            string StoredProcedureNames = StoredProcedures.InsertHospital;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Name", name);
            Parameters.Add("@Username", username);
            Parameters.Add("@Password", password);
            Parameters.Add("@Address", address);
            return dbMan.ExecuteNonQuery(StoredProcedureNames, Parameters);
        }

        public int InsertPharmacy(string name, string username, string password, string address, string phoneno)
        {
            string StoredProcedureNames = StoredProcedures.InsertPharmacy;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Name", name);
            Parameters.Add("@Username", username);
            Parameters.Add("@Address", address);
            Parameters.Add("@Password", password);
            Parameters.Add("@Phoneno", phoneno);
            return dbMan.ExecuteNonQuery(StoredProcedureNames, Parameters);
        }
        public int InsertLaboratory(string name, string username, string password, string address, string phoneno)
        {
            string query = "INSERT INTO Laboratory VALUES ('" + name + "','" + username + "','" + password + "','" + address + "','" + phoneno + "');";
            return dbMan.ExecuteNonQuery(query);
        }
        public int InsertPhonenumbers(string no, int id)
        {
            string query = "INSERT INTO PhoneNumbers VALUES ('" + no + "'," + id + ");";
            return dbMan.ExecuteNonQuery(query);
        }
        public int InsertAdmin(string fname, string lname, string user, string pass)
        {
            string query = "INSERT INTO Admins VALUES ('" + fname + "','" + lname + "','" + user + "','" + pass + "');";
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

