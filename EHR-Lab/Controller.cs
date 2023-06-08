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
        DBManager DbMan;
        static string DB_Connection_String = @"Server=tcp:ehrcce25.database.windows.net,1433;Initial Catalog=EHR;Persist Security Info=False;User ID=EHR_Team6_Database;Password=3lo2Cce@da7i7a;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        SqlConnection MyConnection;
        public Controller()
        {
            DbMan = new DBManager();
            MyConnection = new SqlConnection(DB_Connection_String);

            MyConnection.Open();
        }
        public int InsertLabResult(int Lab_ResultID, byte[] Image, int labid)
        {
            /*string Query = "Update Lab_Results Set Lab_ID = '"+labid+"', Test_Result = '" + Image + "' where ID = '" + Lab_ResultID + "';";

            return DbMan.ExecuteNonQuery(Query);*/
            using (SqlCommand cmd = new SqlCommand("Update Lab_Results Set Lab_ID = @labid, Test_Result = @image where ID = @Lab_ResultID;", MyConnection))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@labid", labid.ToString());
                cmd.Parameters.AddWithValue("@image", Image);
                cmd.Parameters.AddWithValue("@Lab_ResultID", Lab_ResultID.ToString());
                return cmd.ExecuteNonQuery();
            }
        }

        public DataTable SelectDescriptions(string ID)
        {
            string Query = "SELECT Distinct Description From Lab_Results where Patient_ID = '" + ID + "' and Test_Result IS NULL;";
            return DbMan.ExecuteReader(Query);
        }

        public DataTable SelectLabDates(string ID, string Description)
        {
            string storedprocedurenames = StoredProcedures.SelectLabDates;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@patID", ID);
            Parameters.Add("@Description", Description);
            return DbMan.ExecuteReader(storedprocedurenames, Parameters);
        }


        public DataTable GetLab(string Username, string Password)
        {
            string Query = "SELECT * FROM Laboratory WHERE Username='" + Username + "' and Password='" + Password + "';";
            return DbMan.ExecuteReader(Query);
        }
        public DataTable GetLaboratory(string Email, string Password)
        {
            string Query = "SELECT * " +
                "From Laboratory " +
                "Where Username = '" + Email + "' AND Password = '" + Password + "';";
            return DbMan.ExecuteReader(Query);
        }

        public int IDExist(string ID)
        {
            string storedprocedurenames = StoredProcedures.IDEXIST;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@patID", ID);
            return (int)DbMan.ExecuteScalar(storedprocedurenames, Parameters);
        }
        public DataTable getResults(/*int idl,*/ string ID)
        {
            string Query = "SELECT * FROM Lab_Results WHERE Patient_ID='" + ID + "' and Lab_ID IS NULL;";
            return DbMan.ExecuteReader(Query);
        }
        
        public int EmailExist(string Email)
        {
            string Query = "SELECT COUNT(Email) FROM Patient WHERE Email = '" + Email + "';";
            return (int)DbMan.ExecuteScalar(Query);
        }

        public int ChangePass(string ID, string Password)
        {
            string Query = "UPDATE Laboratory SET Password = '" + Password + "' WHERE Name = '" + ID + "' ;";
            return DbMan.ExecuteNonQuery(Query);
        }
        public void TerminateConnection()
        {
            DbMan.CloseConnection();
        }
    }
}

