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
        int id;
        Controller ctrl;
        public Lab(int idt)
        {
            InitializeComponent();
            id = idt;
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
            Lab_Results myForm = new Lab_Results(id, PatientID.Text);
            this.Hide();
            myForm.ShowDialog();
            this.Close();
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
                {
                    e.Handled = true;
                }
            }
        }
    }
}
