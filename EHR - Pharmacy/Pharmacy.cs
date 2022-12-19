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
        int pharmaid;
        Controller ctrl = new Controller();
        public Pharmacy(int x)
        {
            pharmaid = x;   
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
            DataTable dt = null;
            dt = ctrl.RealPatient(PatientID.Text);
            if (dt != null)
            {
                View_Precriptions myForm = new View_Precriptions(PatientID.Text, pharmaid);
                this.Hide();
                myForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("PatientID is Incorrect");
            }    
        }

        private void PatientID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}