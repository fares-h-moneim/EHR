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
    public partial class Death_Report : Form
    {
        Controller ctrl = new Controller();
        public Death_Report()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            DataTable dt = null;
            dt = ctrl.getifDonor(PatientID.Text);
            int x = Convert.ToInt32(dt.Rows[0][0]);
            if (x == 1)
            {
                ctrl.DeleteFromOrganDonor(PatientID.Text);
                ctrl.InsertOrganDonor("Kidney", PatientID.Text, 0);
                ctrl.InsertOrganDonor("Liver", PatientID.Text, 0);
                ctrl.InsertOrganDonor("Intestine", PatientID.Text, 0);
                ctrl.InsertOrganDonor("Lungs", PatientID.Text, 0);
                ctrl.InsertOrganDonor("Pancrease", PatientID.Text, 0);
            }
        }

        private void PatientID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Death_Report_Load(object sender, EventArgs e)
        {

        }
    }
}
