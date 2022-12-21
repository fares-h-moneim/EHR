using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EHR_Hospital
{
    public partial class Patient_History_Bg : Form
    {
        Controller ctrl = new Controller();
        public Patient_History_Bg()
        {
            InitializeComponent();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            DataTable dt = null;
            if (Request.Text == "Chronic Disease")
            {
                dt = ctrl.GetChronic(PatientID.Text);
            }
            else if (Request.Text == "Diagnosis")
            {
                dt = ctrl.GetDiagnosis(PatientID.Text);
            }
            else if (Request.Text == "Prescriptions")
            {
                dt = ctrl.GetPrescriptions(PatientID.Text);
            }
            else if (Request.Text == "Surgeries")
            {
                dt = ctrl.GetSurgeries(PatientID.Text);
            }
            else
            {
                dt = ctrl.GetLabs(PatientID.Text);
            }

            kryptonDataGridView1.DataSource = dt;
            kryptonDataGridView1.Refresh();

        }

        private void Patient_History_Bg_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Request_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kryptonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PatientID_TextChanged(object sender, EventArgs e)
        {

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
