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
    public partial class nyskra : Form
    {
        gagnagrunnur drasl = new gagnagrunnur();
        public nyskra()
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

        private void btskra_Click(object sender, EventArgs e)
        {
            try
            {
                drasl.setjaitoflu(tbktnyskra.Text, btnafnnyskra.Text, tbsimanumernyskra.Text);
                videoleigan opnaa = new videoleigan(tbktnyskra.Text, true);
                opnaa.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("villa: " + ex);
            }
            
           
            
        }
    }
}
