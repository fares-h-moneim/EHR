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
    public partial class Lab_Request : Form
    {
        Controller ctrl;
        public Lab_Request()
        {
            InitializeComponent();
            ctrl = new Controller();
            DataTable dt = ctrl.GetLabTests();
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "Lab_Tests";
            comboBox2.ValueMember = "Lab_Tests";
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            string format = "yyyy-MM-dd HH:mm:ss";
            if (PatientID.Text == "")
            {
                MessageBox.Show("Please fill all fields");
                return;
            }
            DataTable dead = ctrl.GetPatient(PatientID.Text);
            if (dead != null)
            {
                if (Convert.ToBoolean(dead.Rows[0][11]) == true)
                {
                    MessageBox.Show("Patient is already dead");
                    return;
                }
            }
            if (PatientID.Text != "" && comboBox2.Text != "")
            {
                int res = ctrl.InsertLabTest(PatientID.Text, DateTime.Now.ToString(format), comboBox2.Text);

                if(res == 0)
                {
                    MessageBox.Show("Patient ID does not exist");
                }
                else
                {
                    MessageBox.Show("Inserted Successfully");
                }
            }
            else
            {
                MessageBox.Show("Make sure to fill all the fields");
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
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

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
