using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace EHR_Hospital
{
    public class DBManager
    {
        static string DB_Connection_String = @"Server=tcp:ehrcce25.database.windows.net,1433;Initial Catalog=EHR;Persist Security Info=False;User ID=EHR_Team6_Database;Password=3lo2Cce@da7i7a;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        SqlConnection MyConnection;

        public DBManager()
        {
            MyConnection = new SqlConnection(DB_Connection_String);
            try
            {
                MyConnection.Open();
                Console.WriteLine("The DB connection is opened successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("The DB connection is failed");
                Console.WriteLine(e.ToString());
            }
        }

        public int ExecuteNonQuery(string Query)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand(Query, MyConnection);
                return myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // this message should not appear to Username in the final application
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public DataTable ExecuteReader(string Query)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand(Query, MyConnection);
                SqlDataReader reader = myCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    return dt;
                }
                else
                {
                    reader.Close();
                    return null;
                }
            }
            catch (Exception ex)
            {
                // this message should not appear to Username in the final application
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public object ExecuteScalar(string Query)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand(Query, MyConnection);
                return myCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                // this message should not appear to Username in the final application
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public int ExecuteNonQuery(string storedProcedureName, Dictionary<string, object> Parameters)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand(storedProcedureName, MyConnection);

                myCommand.CommandType = CommandType.StoredProcedure;

                foreach (KeyValuePair<string, object> Param in Parameters)
                {
                    myCommand.Parameters.Add(new SqlParameter(Param.Key, Param.Value));
                }

                return myCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public DataTable ExecuteReader(string storedProcedureName, Dictionary<string, object> Parameters)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand(storedProcedureName, MyConnection);

                myCommand.CommandType = CommandType.StoredProcedure;

                if (Parameters != null)
                {
                    foreach (KeyValuePair<string, object> Param in Parameters)
                    {
                        myCommand.Parameters.Add(new SqlParameter(Param.Key, Param.Value));
                    }
                }

                SqlDataReader reader = myCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    return dt;
                }
                else
                {
                    reader.Close();
                    return null;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public object ExecuteScalar(string storedProcedureName, Dictionary<string, object> Parameters)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand(storedProcedureName, MyConnection);

                myCommand.CommandType = CommandType.StoredProcedure;

                if (Parameters != null)
                {
                    foreach (KeyValuePair<string, object> Param in Parameters)
                    {
                        myCommand.Parameters.Add(new SqlParameter(Param.Key, Param.Value));
                    }
                }

                return myCommand.ExecuteScalar();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public void CloseConnection()
        {
            try
            {
                MyConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

