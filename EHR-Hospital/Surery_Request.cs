using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EHR_Hospital
{
    public partial class Surery_Request : Form
    {
        Controller ctrl;
        int HospitalID;
        public Surery_Request(int x)
        {
            HospitalID = x;
            InitializeComponent();
            ctrl = new Controller();
            DataTable dt = ctrl.getsurgeriestypes();
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "Surgeries";
            comboBox2.ValueMember = "Surgeries";
        }

        private void Surery_Request_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            string format = "yyyy-MM-dd HH:mm:ss";
            if (PatientID.Text.ToString() != "" && comboBox2.SelectedValue != null && kryptonTextBox1.Text.ToString() != "")
            {
                int x = ctrl.InsertIntoSurgery(PatientID.Text, HospitalID, kryptonTextBox1.Text, kryptonDateTimePicker1.Value.ToString(format), comboBox2.Text);

                if (x != 0)
                {
                    MessageBox.Show("Success!");
                }
                else
                {
                    MessageBox.Show("Patient Doesn't Exist");
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields");
            }
        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PatientID_TextChanged(object sender, EventArgs e)
        {

        }

        private void SurgeryType_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

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

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
