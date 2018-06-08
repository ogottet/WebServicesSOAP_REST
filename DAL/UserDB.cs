using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Configuration;
using System.Data.SqlClient;

namespace DAL
{
    public class UserDB
    {
        public static User GetUserById( int userId )
        {
            User u = null;

            string query = "SELECT * FROM tbl_SAP WHERE UserID = @uid";
            SqlCommand cmd = new SqlCommand( query );
            cmd.Parameters.AddWithValue( "uid", userId );
            u = GetSAPData( cmd );

            return u;
        }

        public static User GetUserByUsername( string username )
        {
            User u = null;

            string query = "SELECT * FROM tbl_SAP WHERE Username = @uname";
            SqlCommand cmd = new SqlCommand( query );
            cmd.Parameters.AddWithValue( "uname", username );
            u = GetSAPData( cmd );

            return u;
        }

        public static List<string> GetAllUsersData( string field )
        {
            List<string> UserData = null;
            string connectionString = ConfigurationManager.ConnectionStrings["StudentCardDB"].ConnectionString;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM tbl_SAP";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            if (UserData == null)
                                UserData = new List<string>();
                            if (field.Equals("all"))
                            {
                                string tmpVal;
                                tmpVal = "UserID: "  + (dr["UserID"].ToString()) + "\t\t";
                                tmpVal = tmpVal + (dr["Username"].ToString()) + "\t\t";
                                tmpVal = tmpVal + "CardID: " + (dr["CardID"].ToString());
                                UserData.Add(tmpVal);
                            } else
                            {
                                UserData.Add(dr[field].ToString());
                            }
                        }
                    }
                    cn.Close();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return UserData;
        }

        private static User GetSAPData( SqlCommand cmd )
        {
            User u = null;
            string cs = ConfigurationManager.ConnectionStrings["StudentCardDB"].ConnectionString;

            using (SqlConnection cn = new SqlConnection( cs ))
            {
                cmd.Connection = cn;
                cn.Open();

                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    if (sdr.Read())
                    {
                        u = new User()
                        {
                            Id = (int) sdr["UserID"],
                            Username = (string) sdr["Username"],
                            CardId = (int) sdr["CardID"]
                        };
                    }
                }

                cn.Close();
            }

            return u;
        }

        public static List<User> GetAllUsers()
        {
            List<User> userList = new List<User>();
            string connectionString = ConfigurationManager.ConnectionStrings["StudentCardDB"].ConnectionString;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM tbl_SAP";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            User u = new User()
                            {
                                Id = (int)dr["UserID"],
                                Username = (string)dr["Username"],
                                CardId = (int)dr["CardID"]
                            };

                            userList.Add(u);
                        }
                    }
                    cn.Close();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return userList;
        }

        public static List<Dictionary<string, object>> GetUsersTable()
        {
            List<Dictionary<string, object>> UserData = null;
            string connectionString = ConfigurationManager.ConnectionStrings["StudentCardDB"].ConnectionString;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM tbl_SAP";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            if (UserData == null)
                                UserData = new List<Dictionary<string, object>>();

                            Dictionary<string, object> row = new Dictionary<string, object>();


                            for (int i = 0; i < dr.FieldCount; i++)
                            {
                                row.Add(dr.GetName(i), dr.GetValue(i));
                            }

                            UserData.Add(row);
                        }
                    }
                    cn.Close();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return UserData;
        }
    }
}
