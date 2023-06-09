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
            if(PatientID.Text=="" || kryptonTextBox1.Text=="" || kryptonTextBox2.Text == "")
            {
                MessageBox.Show("Please enter in all fields");
                return;
            }
            int wx = ctrl.Updatetodead(PatientID.Text);
            DataTable dt = null;
            dt = ctrl.GetIfDonor(PatientID.Text);
            if (dt != null)
            {
                int x = Convert.ToInt32(dt.Rows[0][0]);
                if (x == 1)
                {
                    MessageBox.Show("Report made successfully");
                    ctrl.DeleteFromOrganDonor(PatientID.Text);
                    ctrl.InsertOrganDonor("Kidney", PatientID.Text, 0);
                    DataTable dt1 = ctrl.GetWaiting();
                    string PatientID = "";
                    for (int i = 0; i < dt1.Rows.Count; i++)
                    {
                        if (Convert.ToString(dt1.Rows[i][0]) == "Kidney")
                        {
                            PatientID = dt1.Rows[i][1].ToString();
                            ctrl.UpdateStatus(PatientID, "Kidney");
                            ctrl.DeleteDonor(PatientID.Text, "Kidney");
                            break;
                        }
                    }
                    ctrl.InsertOrganDonor("Part of Liver", PatientID.Text, 0);

                    for (int i = 0; i < dt1.Rows.Count; i++)
                    {
                        if (Convert.ToString(dt1.Rows[i][0]) == "Part of Liver")
                        {
                            PatientID = dt1.Rows[i][1].ToString();
                            ctrl.UpdateStatus(PatientID, "Part of Liver");
                            ctrl.DeleteDonor(PatientID.Text, "Part of Liver");
                            break;
                        }
                    }
                    ctrl.InsertOrganDonor("Part of Intestine", PatientID.Text, 0);
                    for (int i = 0; i < dt1.Rows.Count; i++)
                    {
                        if (Convert.ToString(dt1.Rows[i][0]) == "Part of Intestine")
                        {
                            PatientID = dt1.Rows[i][1].ToString();
                            ctrl.UpdateStatus(PatientID, "Part of Intestine");
                            ctrl.DeleteDonor(PatientID.Text, "Part of Intestine");
                            break;
                        }
                    }
                    ctrl.InsertOrganDonor("Lungs", PatientID.Text, 0);
                    for (int i = 0; i < dt1.Rows.Count; i++)
                    {
                        if (Convert.ToString(dt1.Rows[i][0]) == "Lungs")
                        {
                            PatientID = dt1.Rows[i][1].ToString();
                            ctrl.UpdateStatus(PatientID, "Lungs");
                            ctrl.DeleteDonor(PatientID.Text, "Lungs");
                            break;
                        }
                    }
                    ctrl.InsertOrganDonor("Part of Pancreas", PatientID.Text, 0);
                    for (int i = 0; i < dt1.Rows.Count; i++)
                    {
                        if (Convert.ToString(dt1.Rows[i][0]) == "Part of Pancreas")
                        {
                            PatientID = dt1.Rows[i][1].ToString();
                            ctrl.UpdateStatus(PatientID, "Part of Pancreas");
                            ctrl.DeleteDonor(PatientID.Text, "Part of Pancreas");
                            break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Patient not found Enter correct ID");
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
