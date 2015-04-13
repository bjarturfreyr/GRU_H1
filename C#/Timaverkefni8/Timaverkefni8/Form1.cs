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
    public partial class Form1 : Form
    {
        gagnagrunnur drasl = new gagnagrunnur();
        public Form1()
        {
            
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
            Form2 opna = new Form2();
            opna.Show();
            this.Hide();          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nyskra opna = new nyskra();
            opna.Show();
            this.Hide();
        }
    }
}
