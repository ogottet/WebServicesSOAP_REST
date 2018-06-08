using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class CardDB
    {
        public static Card GetCardById( int cardId )
        {
            Card c = null;

            string query = "SELECT * FROM tbl_PrintSystem WHERE CardID = @cid";
            SqlCommand cmd = new SqlCommand( query );
            cmd.Parameters.AddWithValue( "cid", cardId );
            c = GetCardData( cmd );

            return c;
        }

        public static List<string> GetAllCardIDs( string field )
        {
            List<string> CardIDs = null;
            string connectionString = ConfigurationManager.ConnectionStrings["StudentCardDB"].ConnectionString;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM tbl_PrintSystem";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            if (CardIDs == null)
                                CardIDs = new List<string>();
                            if (field.Equals("all"))
                            {
                                string tmpVal;
                                tmpVal = "CardID: " + (dr["CardID"].ToString()) + "\t\t";
                                tmpVal = tmpVal + (dr["Username"].ToString()) + "\t\t";
                                tmpVal = tmpVal + "Quota: " + (dr["Quota"].ToString());
                                CardIDs.Add(tmpVal);
                            }
                            else
                            {
                                CardIDs.Add(dr["CardID"].ToString());
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
            return CardIDs;
        }

        public static Card GetCardByUsername( string username )
        {
            Card c = null;

            string query = "SELECT * FROM tbl_PrintSystem WHERE Username = @uname";
            SqlCommand cmd = new SqlCommand( query );
            cmd.Parameters.AddWithValue( "uname", username );
            c = GetCardData( cmd );

            return c;
        }

        public static int UpdateCardData( Card c )
        {
            int affectedRows = -1;
            string cs = ConfigurationManager.ConnectionStrings["StudentCardDB"].ConnectionString;

            using (SqlConnection cn = new SqlConnection( cs ))
            {
                string query = "UPDATE tbl_PrintSystem SET Quota = @quota, Username = @uname WHERE CardID = @card";
                SqlCommand cmd = new SqlCommand( query, cn );
                cmd.Parameters.AddWithValue( "quota", c.Quota );
                cmd.Parameters.AddWithValue( "uname", c.Username );
                cmd.Parameters.AddWithValue( "card", c.CardId );

                cn.Open();
                affectedRows = cmd.ExecuteNonQuery();
                cn.Close();
            }

            
            return affectedRows;
        }

        private static Card GetCardData( SqlCommand cmd )
        {
            Card c = null;
            string cs = ConfigurationManager.ConnectionStrings["StudentCardDB"].ConnectionString;

            using (SqlConnection cn = new SqlConnection( cs ))
            {
                cmd.Connection = cn;
                cn.Open();

                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    if (sdr.Read())
                    {
                        c = new Card()
                        {
                            CardId = (int) sdr["CardID"],
                            Quota = (int) sdr["Quota"],
                            Username = (string) sdr["Username"]
                        };
                    }
                }

                cn.Close();
            }

            return c;
        }

        public static List<Card> GetAllCards()
        {
            List<Card> cards = new List<Card>();
            string connectionString = ConfigurationManager.ConnectionStrings["StudentCardDB"].ConnectionString;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM tbl_PrintSystem";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Card c = new Card()
                            {
                                CardId = (int)dr["CardID"],
                                Username = (string)dr["Username"],
                                Quota = (int)dr["Quota"]
                            };

                            cards.Add(c);
                        }
                    }
                    cn.Close();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return cards;
        }

        public static List<Dictionary<string, object>> GetCardsTable()
        {
            List<Dictionary<string, object>> UserData = null;
            string connectionString = ConfigurationManager.ConnectionStrings["StudentCardDB"].ConnectionString;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM tbl_PrintSystem";
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
