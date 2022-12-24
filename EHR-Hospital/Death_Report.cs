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
                DataTable dt1 = ctrl.GetWaiting();
                string pid = "";
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    if (Convert.ToString(dt1.Rows[i][0]) == "Kidney")
                    {
                        pid = dt1.Rows[i][1].ToString();
                        ctrl.UpdateStatus(pid, "Kidney");
                        break;
                    }
                }
                ctrl.InsertOrganDonor("Part of Liver", PatientID.Text, 0);

                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    if (Convert.ToString(dt1.Rows[i][0]) == "Part of Liver")
                    {
                        pid = dt1.Rows[i][1].ToString();
                        ctrl.UpdateStatus(pid, "Part of Liver");
                        break;
                    }
                }
                ctrl.InsertOrganDonor("Part of Intestine", PatientID.Text, 0);
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    if (Convert.ToString(dt1.Rows[i][0]) == "Part of Intestine")
                    {
                        pid = dt1.Rows[i][1].ToString();
                        ctrl.UpdateStatus(pid, "Part of Intestine");
                        break;
                    }
                }
                ctrl.InsertOrganDonor("Lungs", PatientID.Text, 0);
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    if (Convert.ToString(dt1.Rows[i][0]) == "Lungs")
                    {
                        pid = dt1.Rows[i][1].ToString();
                        ctrl.UpdateStatus(pid, "Lungs");
                        break;
                    }
                }
                ctrl.InsertOrganDonor("Part of Pancreas", PatientID.Text, 0);
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    if (Convert.ToString(dt1.Rows[i][0]) == "Part of Pancreas")
                    {
                        pid = dt1.Rows[i][1].ToString();
                        ctrl.UpdateStatus(pid, "Part of Pancreas");
                        break;
                    }
                }
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
