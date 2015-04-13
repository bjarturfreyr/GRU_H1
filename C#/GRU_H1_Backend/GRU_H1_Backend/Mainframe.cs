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
    public partial class Mainframe : Form
    {
        Gagnagrunnur gagnagrunnur = new Gagnagrunnur();
        public Mainframe()
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

        private void btusermynd_Click(object sender, EventArgs e)
        {
            var FD = new System.Windows.Forms.OpenFileDialog();
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileToOpen = FD.FileName;
                System.IO.FileInfo File = new System.IO.FileInfo(FD.FileName);
                System.IO.StreamReader reader = new System.IO.StreamReader(fileToOpen);
                userpicture.Image = Image.FromFile(FD.FileName);
            }
        }

        private void Mainframe_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("ID", 25);
            listView1.Columns.Add("Username", 70);
            listView1.Columns.Add("Password", 70);
            listView1.Columns.Add("Email", 100);
            listView1.Columns.Add("Phone", 60);
            listView1.Columns.Add("Admin", 50);
            listView1.Columns.Add("Banned", 50);
            List<string> linur = new List<string>();
            string[] arr = new string[7];
            ListViewItem itm;
            try
            {
                linur = gagnagrunnur.LesautSQLToflu();
                foreach (string lin in linur)
                {
                    string[] linaUrLista = lin.Split(':');
                    string id = linaUrLista[0];
                    string name = linaUrLista[1];
                    string password = linaUrLista[2];
                    string email = linaUrLista[3];
                    string phone = linaUrLista[4];
                    string admin = linaUrLista[5];
                    string banned = linaUrLista[6];
                    arr[0] = id;
                    arr[1] = name;
                    arr[2] = password;
                    arr[3] = email;
                    arr[4] = phone;
                    arr[5] = admin;
                    arr[6] = banned;
                    itm = new ListViewItem(arr);
                    listView1.Items.Add(itm);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btskranotanda_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtuserusername.Text;
                string password = txtuserpassword.Text;
                string email = txtuseremail.Text;
                string phone = txtuserphone.Text;
                string isadmin = "0";
                string banned = "0";
                if (userisadmin.Checked)
                {
                    isadmin = "1";
                }
                gagnagrunnur.SettInnUser(username, password, email, phone, isadmin);

                listView1.Clear();
                listView1.Columns.Add("ID", 25);
                listView1.Columns.Add("Username", 70);
                listView1.Columns.Add("Password", 70);
                listView1.Columns.Add("Email", 100);
                listView1.Columns.Add("Phone", 60);
                listView1.Columns.Add("Admin", 50);
                listView1.Columns.Add("Banned", 50);
                List<string> linur = new List<string>();
                string[] arr = new string[7];
                ListViewItem itm;
                try
                {
                    linur = gagnagrunnur.LesautSQLToflu();
                    foreach (string lin in linur)
                    {
                        string[] linaUrLista = lin.Split(':');
                        string id = linaUrLista[0];
                        username = linaUrLista[1];
                        password = linaUrLista[2];
                        email = linaUrLista[3];
                        phone = linaUrLista[4];
                        isadmin = linaUrLista[5];
                        banned = linaUrLista[6];
                        arr[0] = id;
                        arr[1] = username;
                        arr[2] = password;
                        arr[3] = email;
                        arr[4] = phone;
                        arr[5] = isadmin;
                        arr[6] = banned;
                        itm = new ListViewItem(arr);
                        listView1.Items.Add(itm);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btuserrefresh_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            listView1.Columns.Add("ID", 25);
            listView1.Columns.Add("Username", 70);
            listView1.Columns.Add("Password", 70);
            listView1.Columns.Add("Email", 100);
            listView1.Columns.Add("Phone", 60);
            listView1.Columns.Add("Admin", 50);
            listView1.Columns.Add("Banned", 50);
            List<string> linur = new List<string>();
            string[] arr = new string[7];
            ListViewItem itm;
            try
            {
                linur = gagnagrunnur.LesautSQLToflu();
                foreach (string lin in linur)
                {
                    string[] linaUrLista = lin.Split(':');
                    string id = linaUrLista[0];
                    string name = linaUrLista[1];
                    string password = linaUrLista[2];
                    string email = linaUrLista[3];
                    string phone = linaUrLista[4];
                    string admin = linaUrLista[5];
                    string banned = linaUrLista[6];
                    arr[0] = id;
                    arr[1] = name;
                    arr[2] = password;
                    arr[3] = email;
                    arr[4] = phone;
                    arr[5] = admin;
                    arr[6] = banned;
                    itm = new ListViewItem(arr);
                    listView1.Items.Add(itm);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btbreytanotanda_Click(object sender, EventArgs e)
        {
            string username = txtuserusername.Text;
            string password = txtuserpassword.Text;
            string email = txtuseremail.Text;
            string phone = txtuserphone.Text;
            string id = txtuserid.Text;
            string isadmin = "0";
            string isbanned = "0";
            if (userisadmin.Checked)
            {
                isadmin = "1";
            }

            try
            {
                gagnagrunnur.BreyttUser(id, username, password, email, phone, isadmin);

                listView1.Clear();
                listView1.Columns.Add("ID", 25);
                listView1.Columns.Add("Username", 70);
                listView1.Columns.Add("Password", 70);
                listView1.Columns.Add("Email", 100);
                listView1.Columns.Add("Phone", 60);
                listView1.Columns.Add("Admin", 50);
                listView1.Columns.Add("Banned", 50);
                List<string> linur = new List<string>();
                string[] arr = new string[7];
                ListViewItem itm;
                try
                {
                    linur = gagnagrunnur.LesautSQLToflu();
                    foreach (string lin in linur)
                    {
                        string[] linaUrLista = lin.Split(':');
                        id = linaUrLista[0];
                        string name = linaUrLista[1];
                        password = linaUrLista[2];
                        email = linaUrLista[3];
                        phone = linaUrLista[4];
                        isadmin = linaUrLista[5];
                        isbanned = linaUrLista[6];
                        arr[0] = id;
                        arr[1] = name;
                        arr[2] = password;
                        arr[3] = email;
                        arr[4] = phone;
                        arr[5] = isadmin;
                        arr[6] = isbanned;
                        itm = new ListViewItem(arr);
                        listView1.Items.Add(itm);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bteydanotanda_Click(object sender, EventArgs e)
        {
            try
            {
                string userid = txtuserid.Text;
                gagnagrunnur.Eyda(userid);

                listView1.Clear();
                listView1.Columns.Add("ID", 25);
                listView1.Columns.Add("Username", 70);
                listView1.Columns.Add("Password", 70);
                listView1.Columns.Add("Email", 100);
                listView1.Columns.Add("Phone", 60);
                listView1.Columns.Add("Admin", 50);
                listView1.Columns.Add("Banned", 50);
                List<string> linur = new List<string>();
                string[] arr = new string[7];
                ListViewItem itm;
                try
                {
                    linur = gagnagrunnur.LesautSQLToflu();
                    foreach (string lin in linur)
                    {
                        string[] linaUrLista = lin.Split(':');
                        string id = linaUrLista[0];
                        string name = linaUrLista[1];
                        string password = linaUrLista[2];
                        string email = linaUrLista[3];
                        string phone = linaUrLista[4];
                        string admin = linaUrLista[5];
                        string banned = linaUrLista[6];
                        arr[0] = id;
                        arr[1] = name;
                        arr[2] = password;
                        arr[3] = email;
                        arr[4] = phone;
                        arr[5] = admin;
                        arr[6] = banned;
                        itm = new ListViewItem(arr);
                        listView1.Items.Add(itm);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count <= 0)
            {
                return;
            }
            int intSelectIndex = listView1.SelectedIndices[0];
            if (intSelectIndex >= 0)
            {
                txtuserid.Text = listView1.SelectedItems[0].SubItems[0].Text;
                txtuserusername.Text = listView1.SelectedItems[0].SubItems[1].Text;
                txtuserpassword.Text = listView1.SelectedItems[0].SubItems[2].Text;
                txtuseremail.Text = listView1.SelectedItems[0].SubItems[3].Text;
                txtuserphone.Text = listView1.SelectedItems[0].SubItems[4].Text;
                if (listView1.SelectedItems[0].SubItems[5].Text == "True")
                {
                    userisadmin.Checked = true;
                }
                else
                {
                    userisadmin.Checked = false;
                }
            }
        }

        private void btbannotandi_Click(object sender, EventArgs e)
        {

        }
    }
}
