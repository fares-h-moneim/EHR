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
            ctrl.InsertOrganWaiting(Organs.Text, PatientID.Text, Convert.ToInt32(Priority.Text));
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
    }
}
