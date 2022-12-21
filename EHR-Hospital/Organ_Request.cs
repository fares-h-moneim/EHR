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
        Controller ctrl = new Controller();
        public Organ_Request()
        {
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
            ctrl.InsertOrganWaiting(Organs.Text, PatientID.Text, prio);
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
                {
                    e.Handled = true;
                }
            }
        }
    }
}
