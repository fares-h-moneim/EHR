using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using System.Xml.Linq;
using System.Reflection;

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


        public int InsertLabResult(int Lab_ResultID, byte[] Image, int labid)
        {
            string query = "Update Lab_Results Set Lab_ID = '"+labid+"', Test_Result = '" + Image + "' where ID = '" + Lab_ResultID + "';";

            return dbMan.ExecuteNonQuery(query);
        }
        
        public DataTable GetLab(string user, string pass)
        {
            string query = "SELECT * FROM Laboratory WHERE Username='" + user + "' and Password='" + pass + "';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetLaboratory(string email, string password)
        {
            string query = "SELECT * " +
                "From Laboratory " +
                "Where Username = '" + email + "' AND Password = '" + password + "';";
            return dbMan.ExecuteReader(query);
        }

        public int IDExist(string id)
        {
            string query = "SELECT COUNT(NationalID) FROM Patient WHERE NationalID = '" + id + "';";
            return (int)dbMan.ExecuteScalar(query);
        }
        public DataTable getResults(/*int idl,*/ string id)
        {
            string query = "SELECT * FROM Lab_Results WHERE Patient_ID='" + id + "';" /*"and Lab_ID='" + idl + "';"*/;
            return dbMan.ExecuteReader(query);
        }
        
        public int EmailExist(string email)
        {
            string query = "SELECT COUNT(Email) FROM Patient WHERE Email = '" + email + "';";
            return (int)dbMan.ExecuteScalar(query);
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

