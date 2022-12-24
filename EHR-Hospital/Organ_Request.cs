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
    public partial class Organ_Request : Form
    {
        int HospitalID;
        Controller ctrl = new Controller();
        public Organ_Request(int x)
        {
            HospitalID = x;
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            int prio = 0;
            if(Priority.Text == "Extreme")
            {
                prio = 5;
            }    
            else if (Priority.Text == "High")
            {
                prio = 4;
            }
            else if (Priority.Text == "Medium")
            {
                prio = 3;
            }
            else if (Priority.Text == "Low")
            {
                prio = 2;
            }
            else { prio = 1; }

            if (Priority.SelectedIndex != -1 && Organs.SelectedIndex != -1 && PatientID.Text != "")
            {
                string format = "yyyy-MM-dd hh:mm:ss";
                int x = ctrl.InsertOrganWaiting(Organs.Text, PatientID.Text, prio, HospitalID, 0, DateTime.Now.ToString(format));
                if (x != 0)
                {
                    DataTable dt1 = ctrl.GetDonate();
                    string pid = "";
                    for (int i = 0; i < dt1.Rows.Count; i++)
                    {
                        if (Convert.ToString(dt1.Rows[i][0]) == Organs.Text)
                        {
                            pid = dt1.Rows[i][1].ToString();
                            ctrl.UpdateStatus(PatientID.Text, Organs.Text);
                            break;
                        }
                    }
                    MessageBox.Show("Success! Please Check Pending Requests to View Status");
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields");
            }
        }

        private void PatientID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Organs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Priority_SelectedIndexChanged(object sender, EventArgs e)
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

        private void Organs_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Priority_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
