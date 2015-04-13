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
    public partial class Form2 : Form
    {
        gagnagrunnur drasl = new gagnagrunnur();
        public Form2()
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

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btskrainn_Click(object sender, EventArgs e)
        {
            
            if (drasl.tiledaekki(btkennitala.Text))
            {
                videoleigan opnaa = new videoleigan(btkennitala.Text, false);
                opnaa.Show();
                this.Close(); 
            }
            else
            {
                MessageBox.Show("DAT´S DA WRONG NUMBA!!!");
            }
                       
        }
    }
}
