using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Apply_Organ : Form
    {
        Controller ctrl;
        string ID;
        
        public Apply_Organ(string idt)
        {
            InitializeComponent();
            ID = idt;
            ctrl = new Controller();
           DataTable dt = ctrl.GetOrgan_Donor_1(ID);
            if (dt == null)
            {
                return;
            }
            DataRowCollection dr1 = dt.Rows;
            foreach (DataRow i in dr1)
            {
                if (Convert.ToString(i[0]) == "Part of Intestine")
                {
                    Intestine.Checked = true;
                    Intestine.Enabled = false;
                }
                if (Convert.ToString(i[0]) == "Part of Liver")
                {
                    Liver.Checked = true;
                    Liver.Enabled = false;
                }
                if (Convert.ToString(i[0]) == "Part of Pancreas")
                {
                    Pancreas.Checked = true;
                    Pancreas.Enabled = false;
                }
                if (Convert.ToString(i[0]) == "Lung")
                {
                    Lung.Checked = true;
                    Lung.Enabled = false;
                }
                if (Convert.ToString(i[0]) == "Kidney")
                {
                    Kidney.Checked = true;
                    Kidney.Enabled = false;
                }
            }
            DataTable dt1 = ctrl.getpatientstatusupondeath(ID);
            DataRowCollection dr2 = dt1.Rows;
            if(Convert.ToBoolean(dr2[0][0]) == true)
            {
                kryptonCheckBox6.Checked = true;
                kryptonCheckBox6.Enabled = false;
            }
        }

        private void Oragn_Dono_Load(object sender, EventArgs e)
        {
          
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Submit_Click(object sender, EventArgs e)
        {

            if (kryptonCheckBox6.Checked == true && kryptonCheckBox6.Enabled == true)
            {
                ctrl.OrganDonorUponDeath(ID);
                
            }
            if (Kidney.Checked == true && Kidney.Enabled == true)
            {
                DataTable dt = ctrl.GetOrgan_Donor(Kidney.Text, ID);
                int x = ctrl.InsertOrganDonor(Kidney.Text.ToString(), ID, 1);
                if(x!=0)
                {
                    DataTable dt1 = ctrl.GetWaiting();
                    string PatientID = "";

                    for (int i = 0; i < dt1.Rows.Count; i++)
                    {
                        if (Convert.ToString(dt1.Rows[i][0]) == "Kidney")
                        {
                            PatientID = dt1.Rows[i][1].ToString();
                            ctrl.UpdateStatus(PatientID, "Kidney");
                            ctrl.DeleteDonor(ID, "Kidney");
                            break;
                        }
                    }
                }
                
            }
            
            if (Intestine.Checked == true && Intestine.Enabled == true)
            {
              int x =  ctrl.InsertOrganDonor(Intestine.Text.ToString(), ID, 1);
                if (x != 0)
                {
                    DataTable dt1 = ctrl.GetWaiting();
                    string PatientID = "";

                    for (int i = 0; i < dt1.Rows.Count; i++)
                    {
                        if (Convert.ToString(dt1.Rows[i][0]) == "Part of Intestine")
                        {
                            PatientID = dt1.Rows[i][1].ToString();
                            ctrl.UpdateStatus(PatientID, "Part of Intestine");
                            ctrl.DeleteDonor(ID, "Kidney");
                            break;
                        }
                    }
                }

            }
            if (Pancreas.Checked == true && Pancreas.Enabled == true)
            {
                int x = ctrl.InsertOrganDonor(Pancreas.Text.ToString(), ID, 1);
                if (x != 0)
                {
                    DataTable dt1 = ctrl.GetWaiting();
                    string PatientID = "";

                    for (int i = 0; i < dt1.Rows.Count; i++)
                    {
                        if (Convert.ToString(dt1.Rows[i][0]) == "Part of Pancreas")
                        {
                            PatientID = dt1.Rows[i][1].ToString();
                            ctrl.UpdateStatus(PatientID, "Part of Pancreas");
                            ctrl.DeleteDonor(ID, "Kidney");
                            break;
                        }
                    }
                }
            }
            if (Liver.Checked == true && Liver.Enabled == true)
            {
                int x = ctrl.InsertOrganDonor(Liver.Text.ToString(), ID, 1);
                if (x != 0)
                {
                    DataTable dt1 = ctrl.GetWaiting();
                    string PatientID = "";

                    for (int i = 0; i < dt1.Rows.Count; i++)
                    {
                        if (Convert.ToString(dt1.Rows[i][0]) == "Part of Liver")
                        {
                            PatientID = dt1.Rows[i][1].ToString();
                            ctrl.UpdateStatus(PatientID, "Part of Liver");
                            ctrl.DeleteDonor(ID, "Kidney");
                            break;
                        }
                    }
                }

            }
            if (Lung.Checked == true && Lung.Enabled == true)
            {
              int x =  ctrl.InsertOrganDonor(Lung.Text.ToString(), ID, 1);
                if (x != 0)
                {
                    DataTable dt1 = ctrl.GetWaiting();
                    string PatientID = "";

                    for (int i = 0; i < dt1.Rows.Count; i++)
                    {
                        if (Convert.ToString(dt1.Rows[i][0]) == "Lungs")
                        {
                            PatientID = dt1.Rows[i][1].ToString();
                            ctrl.UpdateStatus(PatientID, "Lungs");
                            ctrl.DeleteDonor(ID, "Kidney");
                            break;
                        }
                    }
                }

            }
            MessageBox.Show("Thank you for your contribution");
            this.Close();
        }

        private void kryptonCheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Kidney_CheckedChanged(object sender, EventArgs e)
        {
           

        }

        private void kryptonCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void kryptonCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Lung_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Liver_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Pancreas_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Intestine_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void kryptonCheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
