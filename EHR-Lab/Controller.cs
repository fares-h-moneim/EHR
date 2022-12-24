using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using System.Xml.Linq;
using System.Reflection;
using System.Data.Common;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public class Controller
    {
        DBManager dbMan;
        static string DB_Connection_String = @"Server=tcp:ehrcce25.database.windows.net,1433;Initial Catalog=EHR;Persist Security Info=False;User ID=EHR_Team6_Database;Password=3lo2Cce@da7i7a;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        SqlConnection myConnection;
        public Controller()
        {
            dbMan = new DBManager();
            myConnection = new SqlConnection(DB_Connection_String);

            myConnection.Open();
        }

        //public int InsertSupplier(string snum, string sname, string city, int status)
        //{
        //    string query = "INSERT INTO S (S#, Name, City, Status) " +
        //                    "Values ('" + snum + "','" + sname + "','" + city + "'," + status + ");";
        //    return dbMan.ExecuteNonQuery(query);
        //}


        public int InsertLabResult(int Lab_ResultID, byte[] Image, int labid)
        {
            /*string query = "Update Lab_Results Set Lab_ID = '"+labid+"', Test_Result = '" + Image + "' where ID = '" + Lab_ResultID + "';";

            return dbMan.ExecuteNonQuery(query);*/
            using (SqlCommand cmd = new SqlCommand("Update Lab_Results Set Lab_ID = @labid, Test_Result = @image where ID = @Lab_ResultID;", myConnection))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@labid", labid.ToString());
                cmd.Parameters.AddWithValue("@image", Image);
                cmd.Parameters.AddWithValue("@Lab_ResultID", Lab_ResultID.ToString());
                return cmd.ExecuteNonQuery();
            }
        }

        public DataTable SelectDescriptions(string id)
        {
            string query = "SELECT Distinct Description From Lab_Results where Patient_ID = '" + id + "' and Test_Result IS NULL;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectLabDates(string id, string desc)
        {
            string storedprocedurenames = StoredProcedures.SelectLabDates;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@patID", id);
            Parameters.Add("@desc", desc);
            return dbMan.ExecuteReader(storedprocedurenames, Parameters);
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
            string storedprocedurenames = StoredProcedures.IDEXIST;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@patID", id);
            return (int)dbMan.ExecuteScalar(storedprocedurenames, Parameters);
        }
        public DataTable getResults(/*int idl,*/ string id)
        {
            string query = "SELECT * FROM Lab_Results WHERE Patient_ID='" + id + "' and Lab_ID IS NULL;";
            return dbMan.ExecuteReader(query);
        }
        
        public int EmailExist(string email)
        {
            string query = "SELECT COUNT(Email) FROM Patient WHERE Email = '" + email + "';";
            return (int)dbMan.ExecuteScalar(query);
        }

        public int ChangePass(string id, string pass)
        {
            string query = "UPDATE Laboratory SET Password = '" + pass + "' WHERE Name = '" + id + "' ;";
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

