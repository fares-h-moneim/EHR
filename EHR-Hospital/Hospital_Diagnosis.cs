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
    public partial class Hospital_Diagnosis : Form
    {
        int HospitalID;
        int PrescriptionID;
        Controller ctrl = new Controller();
        public Hospital_Diagnosis(int x)
        {
            InitializeComponent();
            HospitalID = x;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

            if (Prescription.Text == "")
            {
                PrescriptionID = -1;
            }
            else
            {
                string format = "yyyy-MM-dd HH:mm:ss";
                int x = ctrl.InsertPrescription(DateTime.Now.ToString(format));
                if (x != 0)
                {
                    DataTable dt = ctrl.GetPrescriptionID(DateTime.Now.ToString(format));
                    PrescriptionID = Convert.ToInt32(dt.Rows[0][0]);
                }


                int res = ctrl.InsertDiagnosis(HospitalID, PatientID.Text, DateTime.Now.ToString(format), Diagnosis.Text, Symptoms.Text, PrescriptionID);

                if (res == 0)
                {
                    MessageBox.Show("Error!");
                }
                else
                {
                    if (PrescriptionID != -1)
                    {
                        string[] ch = Prescription.Text.Split(',');
                        for (int i = 0; i < ch.Length; i++)
                        {
                            int y = ctrl.InsertMedications(PrescriptionID, ch[i]);
                        }
                    }
                }
            }
        }

        private void PatientID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Diagnosis_TextChanged(object sender, EventArgs e)
        {

        }

        private void Prescription_TextChanged(object sender, EventArgs e)
        {
   
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PatientID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (PatientID.Text.ToString().Length >= 16)
            {
                e.Handled = true;
            }
        }
    }
}
