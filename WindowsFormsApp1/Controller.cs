using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using System.Xml.Linq;

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
            string query = "INSERT INTO Patient (NationalID, Fname, Lname, Email, Password, PhoneNumber, Gender, BloodType, EmergencyContact, Age) " +
                            "Values ('" + nationalid + "','" + fname + "','" + lname + "','" + username + "','" + password + "','" + gender + "'," + Int32.Parse(age) + ",'" + blood + "','" + phone + "','" + emerg + "');";
           return dbMan.ExecuteNonQuery(query);
        }
        public DataTable GetPatient(string email, string password)
        {
            string query = "SELECT * " +
                "From Patient " +
                "Where Email = '" + email + "' AND Password = '" + password + "';";
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

