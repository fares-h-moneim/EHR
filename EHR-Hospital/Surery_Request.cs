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
    public partial class Surery_Request : Form
    {
        Controller ctrl = new Controller();
        int HospitalID;
        public Surery_Request(int x)
        {
            HospitalID = x;
            InitializeComponent();
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
            ctrl.InsertIntoSurgery(PatientID.Text, HospitalID, kryptonTextBox1.Text, kryptonDateTimePicker1.Value.ToString(format), SurgeryType.Text);

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
                {
                    e.Handled = true;
                }
            }
        }
    }
}
