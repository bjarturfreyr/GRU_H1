using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Timaverkefni8
{
    class gagnagrunnur
    {
        private string server;
        private string database;
        private string uid;
        private string password;
        string tengistrengur = null;
        string fyrirspurn = null;
        MySqlConnection sqltenging;
        MySqlCommand nysqlskypun;
        MySqlDataReader sqllesari = null;
        public void tengingvidgagnagrunn()
        {
            server = "tsuts.tskoli.is";
            database = "0505972299_fortimaverk8";
            uid = "0505972299";
            password = "hara5ldur";
            tengistrengur = "server=" + server + ";userid=" + uid + ";password=" + password + ";database=" + database;
            sqltenging = new MySqlConnection(tengistrengur);
        }

        private bool Openconnection()
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
        public string fylla(string kt)
        {
            string lina = null;
            if (Openconnection() == true)
            {
                fyrirspurn = "SELECT name FROM Members where kennitala=" + kt + "";
                nysqlskypun = new MySqlCommand(fyrirspurn, sqltenging);
                sqllesari = nysqlskypun.ExecuteReader();
                while (sqllesari.Read())
                {
                    for (int i = 0; i < sqllesari.FieldCount; i++)
                    {
                        lina += (sqllesari.GetValue(i).ToString());
                    }
                }
                sqltenging.Close();
            }
            return lina;
        }
        public string fylla2(string kt)
        {
            string lina = null;
            if (Openconnection() == true)
            {
                fyrirspurn = "SELECT phonenum FROM Members where kennitala=" + kt + "";
                nysqlskypun = new MySqlCommand(fyrirspurn, sqltenging);
                sqllesari = nysqlskypun.ExecuteReader();
                while (sqllesari.Read())
                {
                    for (int i = 0; i < sqllesari.FieldCount; i++)
                    {
                        lina += (sqllesari.GetValue(i).ToString());
                    }
                }
                sqltenging.Close();
            }
            return lina;
        }
        public void setjaitoflu(string kt, string nafn, string numer)
        {
            if (Openconnection() == true)
            {
                fyrirspurn = "insert into Members (kennitala, name, phonenum) VALUES ('" + kt + "','" + nafn + "','" + numer + "')";
                nysqlskypun = new MySqlCommand(fyrirspurn, sqltenging);
                nysqlskypun.ExecuteNonQuery();
                CloseConnection();
            }
        }
        public bool tiledaekki(string kt)
        {
            string lina = null;
            if (Openconnection() == true)
            {
                fyrirspurn = "select kennitala from members where kennitala ='" + kt + "'";
                nysqlskypun = new MySqlCommand(fyrirspurn, sqltenging);
                sqllesari = nysqlskypun.ExecuteReader();
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
        public void uppfaera(string kt, string nafn, string numer)
        {
            if (Openconnection() == true)
            {
                fyrirspurn = "Update Members set name = '" + nafn + "', phonenum='" + numer + "'" + "WHERE kennitala ='" + kt + "'";
                nysqlskypun = new MySqlCommand(fyrirspurn, sqltenging);
                nysqlskypun.ExecuteNonQuery();
                CloseConnection();
            }
        }
        public void setjaimynd(string mynd, string kt)
        {
            if (Openconnection() == true)
            {
                fyrirspurn = "INSERT INTO members_has_rental (members_rental_id, members_kennitala, rental_rental_id)VALUES(DEFAULT, '"+ kt + "'," + mynd + ")";
                nysqlskypun = new MySqlCommand(fyrirspurn, sqltenging);
                nysqlskypun.ExecuteNonQuery();
                CloseConnection();
            }
        }
        public List<string> lesaurSQLtoflu(string kt)
        {
            List<string> faerslur = new List<string>();
            string lina = null;
            if (Openconnection() == true)
            {
                fyrirspurn = "SELECT Rental.rental_id, Rental.name FROM members_has_rental INNER JOIN Members ON members_has_rental.members_kennitala = Members.kennitala INNER JOIN Rental ON members_has_rental.rental_rental_id = Rental.rental_id WHERE Members.kennitala = '" + kt +"'";
                nysqlskypun = new MySqlCommand(fyrirspurn, sqltenging);
                sqllesari = nysqlskypun.ExecuteReader();
                while (sqllesari.Read())
                {
                    for (int i = 0; i < sqllesari.FieldCount; i++)
                    {
                        lina += (sqllesari.GetValue(i).ToString()) + ":";
                    }
                    faerslur.Add(lina);
                    lina = null;
                }
                CloseConnection();
                return faerslur;
            }
            return faerslur;
        }
        public bool buinnadleygja(string ktt, string dot)
        {
            string lina = null;
            if (Openconnection() == true)
            {
                fyrirspurn = "select rental_rental_id from members_has_rental where members_kennitala = '" + ktt + "' and rental_rental_id = " + dot + "";
                nysqlskypun = new MySqlCommand(fyrirspurn, sqltenging);
                sqllesari = nysqlskypun.ExecuteReader();
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
        public void eyda(string kt, string rental)
        {
            if (Openconnection() == true)
            {
                fyrirspurn = "Delete from members_has_rental where rental_rental_id=" + rental + " and members_kennitala ='" + kt + "'";
                nysqlskypun = new MySqlCommand(fyrirspurn, sqltenging);
                nysqlskypun.ExecuteNonQuery();
                CloseConnection();
            }
        }
    }
}
