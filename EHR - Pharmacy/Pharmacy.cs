using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EHR___Pharmacy
{
    public partial class Pharmacy : Form
    {
        public Pharmacy()
        {
            InitializeComponent();
        }

        private void PatientID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (PatientID.Text.ToString().Length >= 16)
            {
                e.Handled = true;
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            View_Precriptions myForm = new View_Precriptions();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
