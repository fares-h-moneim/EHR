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
                int x = ctrl.InsertPrescription(DateTime.Now.ToString());
                if (x != 0)
                {
                    DataTable dt = ctrl.GetPrescriptionID(DateTime.Now.ToString());
                    PrescriptionID = Convert.ToInt32(dt.Rows[0][0]);
                }


                ctrl.InsertDiagnosis(HospitalID, PatientID.Text, DateTime.Now.ToString(), Diagnosis.Text, Symptoms.Text, PrescriptionID);

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

        private void PatientID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Diagnosis_TextChanged(object sender, EventArgs e)
        {

        }

        private void Prescription_TextChanged(object sender, EventArgs e)
        {
   
        }
    }
}
