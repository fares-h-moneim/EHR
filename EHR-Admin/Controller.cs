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

