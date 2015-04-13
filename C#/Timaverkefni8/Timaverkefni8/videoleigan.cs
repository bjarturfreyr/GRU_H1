using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timaverkefni8
{
    public partial class videoleigan : Form
    {
        List<string> listi = new List<string>();
        gagnagrunnur drasl = new gagnagrunnur();
        private string kt = null;
        bool tjekkk = false;
        public videoleigan(string kennitala, bool tjekk)
        {
            kt = kennitala;
            tjekkk = tjekk;
            InitializeComponent();
            try
            {
                drasl.tengingvidgagnagrunn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("villa: " + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string halli = null;
            switch(comboBox1.SelectedItem.ToString())
                    {
                        case "Toy Story 3":
                            halli = "13";
                            break;
                        case "Alice in Wonderland":
                            halli = "14";
                            break;
                        case "Harry Potter and the Deathly Hallows":
                            halli = "15";
                            break;
                        case "Inception":
                            halli = "16";
                            break;
                        case "Shrek Forever After":
                            halli = "17";
                            break;
                        case "The Twilight Saga: Eclipse":
                            halli = "18";
                            break;
                        case "Iron Man 2":
                            halli = "19";
                            break;
                        case "Tangled":
                            halli = "20";
                            break;
                        case "The Office":
                            halli = "21";
                            break;
                        case "Death Parade":
                            halli = "22";
                            break;
                        case "Modern Family":
                            halli = "23";
                            break;
                        case "Attack on Titan":
                            halli = "24";
                            break;
                    }
            if (drasl.buinnadleygja(tblokad.Text, halli) == false)            
            {
                listView1.Items.Clear();
                try
                {
                    switch (comboBox1.SelectedItem.ToString())
                    {
                        case "Toy Story 3":
                            drasl.setjaimynd("13", tblokad.Text);
                            break;
                        case "Alice in Wonderland":
                            drasl.setjaimynd("14", tblokad.Text);
                            break;
                        case "Harry Potter and the Deathly Hallows":
                            drasl.setjaimynd("15", tblokad.Text);
                            break;
                        case "Inception":
                            drasl.setjaimynd("16", tblokad.Text);
                            break;
                        case "Shrek Forever After":
                            drasl.setjaimynd("17", tblokad.Text);
                            break;
                        case "The Twilight Saga: Eclipse":
                            drasl.setjaimynd("18", tblokad.Text);
                            break;
                        case "Iron Man 2":
                            drasl.setjaimynd("19", tblokad.Text);
                            break;
                        case "Tangled":
                            drasl.setjaimynd("20", tblokad.Text);
                            break;
                        case "The Office":
                            drasl.setjaimynd("21", tblokad.Text);
                            break;
                        case "Death Parade":
                            drasl.setjaimynd("22", tblokad.Text);
                            break;
                        case "Modern Family":
                            drasl.setjaimynd("23", tblokad.Text);
                            break;
                        case "Attack on Titan":
                            drasl.setjaimynd("24", tblokad.Text);
                            break;
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                ListViewItem itm;
                try
                {

                    listi = drasl.lesaurSQLtoflu(tblokad.Text);
                    string[] konni;
                    foreach (var stuff in listi)
                    {
                        konni = stuff.Split(':');
                        itm = new ListViewItem(konni);
                        listView1.Items.Add(itm);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("villa: " + ex);
                }
            }
            else
            {
                MessageBox.Show("Þú ert nú þegar búinn að leygja myndina");
            }
            
        }

        private void videoleigan_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("ID", 40);
            listView1.Columns.Add("Mynd", 200);            
            tblokad.Enabled = false;
            tblokad.Text = kt;
            if (tjekkk)
            {                
            tbnafnbreyta.Text = drasl.fylla(kt);
            tbsimanumerbreyta.Text = drasl.fylla2(kt);
            }
            ListViewItem itm;
            try
            {

                listi = drasl.lesaurSQLtoflu(tblokad.Text);
                string[] konni;
                foreach (var stuff in listi)
                {
                    konni = stuff.Split(':');
                    itm = new ListViewItem(konni);
                    listView1.Items.Add(itm);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("villa: " + ex);
            }
        }

        private void btbreyta_Click(object sender, EventArgs e)
        {
            drasl.uppfaera(tblokad.Text, tbnafnbreyta.Text, tbsimanumerbreyta.Text);
            MessageBox.Show("Breyting tókst");
        }

        private void btafskramynd_Click(object sender, EventArgs e)
        {
            string halli = null;
            switch(comboBox1.SelectedItem.ToString())
                    {
                        case "Toy Story 3":
                            halli = "13";
                            break;
                        case "Alice in Wonderland":
                            halli = "14";
                            break;
                        case "Harry Potter and the Deathly Hallows":
                            halli = "15";
                            break;
                        case "Inception":
                            halli = "16";
                            break;
                        case "Shrek Forever After":
                            halli = "17";
                            break;
                        case "The Twilight Saga: Eclipse":
                            halli = "18";
                            break;
                        case "Iron Man 2":
                            halli = "19";
                            break;
                        case "Tangled":
                            halli = "20";
                            break;
                        case "The Office":
                            halli = "21";
                            break;
                        case "Death Parade":
                            halli = "22";
                            break;
                        case "Modern Family":
                            halli = "23";
                            break;
                        case "Attack on Titan":
                            halli = "24";
                            break;
                    }
            try
            {
                drasl.eyda(tblokad.Text, halli);
                listView1.Items.Clear();
                MessageBox.Show("Mynd hefur verið afskráð");
                ListViewItem itm;
                try
                {

                    listi = drasl.lesaurSQLtoflu(tblokad.Text);
                    string[] konni;
                    foreach (var stuff in listi)
                    {
                        konni = stuff.Split(':');
                        itm = new ListViewItem(konni);
                        listView1.Items.Add(itm);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("villa: " + ex);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("villa: " + ex);
            }
            
        }
    }
}
