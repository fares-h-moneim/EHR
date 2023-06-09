using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
                if (!char.IsControl(e.KeyChar))
                    e.Handled = true;
            }
            else
            {
                if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                    e.Handled = true;
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            DataTable dt = null;
            dt = ctrl.RealPatient(PatientID.Text);
            if (dt != null)
            {
                DataTable dt2 = ctrl.GetMedications(PatientID.Text);
                if (dt2 != null)
                {
                    View_Precriptions myForm = new View_Precriptions(PatientID.Text, pharmaid);
                    this.Hide();
                    myForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Patient has no pending prescriptions");
                }
            }
            else
            {
                MessageBox.Show("PatientID is Incorrect");
            }    
        }

        private void PatientID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Form1 myForm = new Form1();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void Pharmacy_Load(object sender, EventArgs e)
        {

        }

        private void Logout_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(Logout, "Logout");
        }
    }
}