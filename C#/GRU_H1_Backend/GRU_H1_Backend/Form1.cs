using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GRU_H1_Backend
{
    public partial class Form1 : Form
    {
        Gagnagrunnur gagnagrunnur = new Gagnagrunnur();
        public Form1()
        {
            InitializeComponent();
            try
            {
                gagnagrunnur.TengingVidGagnagrunn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_1login_Click(object sender, EventArgs e)
        {
            string username = txt_1username.Text;
            string password = txt_1password.Text;
            if (username == string.Empty || password == string.Empty)
            {
                MessageBox.Show("Vantar að fylla út í öll textabox.");
            }
            else
	        {
                try
                {
                    if (gagnagrunnur.Login(username, password))
                    {
                        Mainframe mainframe = new Mainframe();
                        mainframe.Show();
                    }
                    else
                    {
                        MessageBox.Show("Rangt username eða password!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
	        }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Vinsamlegast hafðu samband við kerfisstjórnanda til að fá aðgang að notandanafni og lykilorði. Hægt er að búa til notanda á vefsíðunni okkar ef þú ert venjulegur notandi.");
        }
    }
}
