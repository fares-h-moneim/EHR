using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace EHR_Lab
{
    public partial class Lab : Form
    {
        int ID;
        Controller ctrl;
        public Lab(int idt)
        {
            InitializeComponent();
            ID = idt;
            ctrl = new Controller();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            DataTable dt = ctrl.getResults(PatientID.Text);
            if (dt == null)
            {
                MessageBox.Show("Patient has no test results history pending");
                return;
            }
            Lab_Results myForm = new Lab_Results(ID, PatientID.Text);
            // this.Hide();
            myForm.ShowDialog();
        }

        private void Lab_Load(object sender, EventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Lab_Login myForm = new Lab_Login();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
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

        private void PatientID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
