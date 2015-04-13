using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GRU_H1_Backend
{
    class Gagnagrunnur
    {
        private string server;
        private string database;
        private string uid;
        private string password;
        string tengistrengur = null;
        string fyrirspurn = null;

        MySqlConnection sqltenging;
        MySqlCommand nySQLskipun;
        MySqlDataReader sqllesari = null;

        public void TengingVidGagnagrunn()
        {
            server = "10.200.10.24";
            database = "gru_h1_database";
            uid = "GRU_H1";
            password = "gaben";

            tengistrengur = "server= " + server + ";userid= " + uid + ";password= " + password + ";database= " + database;

            sqltenging = new MySqlConnection(tengistrengur);
        }

        private bool OpenConnection()
        {
            try
            {
                sqltenging.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                sqltenging.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }

        public bool Login(string username, string password)
        {
            string lina = null;
            if (OpenConnection() == true)
            {
                fyrirspurn = "SELECT username,password FROM users WHERE username='" + username + "' AND password='" + password + "'";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                sqllesari = nySQLskipun.ExecuteReader();
                while (sqllesari.Read())
                {
                    for (int i = 0; i < sqllesari.FieldCount; i += 1)
                    {
                        lina = (sqllesari.GetValue(i).ToString());
                    }
                }
                if (lina == null)
                {
                    CloseConnection();
                    return false;
                }
                else
                {
                    CloseConnection();
                    return true;
                }
            }
            else
            {
                CloseConnection();
                return false;
            }
        }

        public List<string> LesautSQLToflu()
        {
            List<string> Faerslur = new List<string>();
            string lina = null;
            if (OpenConnection() == true)
            {
                fyrirspurn = "SELECT userID, Username, Password, Email, Phone, isAdmin FROM Users";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                sqllesari = nySQLskipun.ExecuteReader();
                while (sqllesari.Read())
                {
                    for (int i = 0; i < sqllesari.FieldCount; i++)
                    {
                        if (i < 5)
                        {
                            lina += (sqllesari.GetValue(i).ToString()) + ":";
                        }
                        else
                        {
                            bool eradmin = sqllesari.GetBoolean(5);
                            if (eradmin == true)
                            {
                                lina += ("True" + ":");
                            }
                            else
                            {
                                lina += ("False" + ":");
                            }
                        }
                    }
                    Faerslur.Add(lina);
                    lina = null;
                }
                CloseConnection();
                return Faerslur;
            }
            return Faerslur;
        }

        public void SettInnUser(string username, string password, string email, string phone, string isadmin)
        {
            if (OpenConnection() == true)
            {
                fyrirspurn = "INSERT INTO users (UserID, username, password, email, phone, isadmin) VALUES (DEFAULT,'" + username + "','" + password + "','" + email + "','" + phone + "','" + isadmin + "')";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                nySQLskipun.ExecuteNonQuery();
                CloseConnection();
            }
        }

        public void BreyttUser(string id, string username, string password, string email, string phone, string isadmin)
        {
            if (OpenConnection() == true)
            {
                fyrirspurn = "UPDATE users SET username='" + username + "', password='" + password + "', email='" + email + "', phone='" + phone + "', isadmin=" + isadmin + " WHERE userid='" + id + "'";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                nySQLskipun.ExecuteNonQuery();
                CloseConnection();
            }
        }

        public void Eyda(string id)
        {
            if (OpenConnection() == true)
            {
                fyrirspurn = "DELETE FROM users WHERE userID='" + id + "'";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                nySQLskipun.ExecuteNonQuery();
                CloseConnection();
            }
        }

        public void Ban(string id)
        {
            if (OpenConnection() == true)
            {
                fyrirspurn = "UPDATE users SET isBanned='" + 1 + "')";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                nySQLskipun.ExecuteNonQuery();
            }
        }
    }
}
