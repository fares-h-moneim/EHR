﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EHR_Hospital
{
    public partial class Hospital_Diagnosis : Form
    {
        int HospitalID;
        int PrescriptionID;
        int[] Quantity = new int[20];
        string[] meds = new string[20];
        int x = 0;
        Controller ctrl = new Controller();
        public Hospital_Diagnosis(int x)
        {
            InitializeComponent();
            HospitalID = x;
            DataTable dt = null;
            dt = ctrl.GetMedicationList();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Trade_Name";
            comboBox1.ValueMember = "Trade_Name";
            DataTable dt2 = ctrl.GetDiseases();
            comboBox2.DataSource = dt2;
            comboBox2.DisplayMember = "Diseases";
            comboBox2.ValueMember = "Diseases";

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            string format = "yyyy-MM-dd HH:mm:ss";
            if(PatientID.Text=="" || Symptoms.Text=="" || Prescription.Text == "")
            {
                MessageBox.Show("Please insert in all fields");
                return;
            }
            DataTable dead = ctrl.GetPatient(PatientID.Text);
            if(dead != null)
            {
                if (Convert.ToBoolean(dead.Rows[0][11]) == true)
                {
                    MessageBox.Show("Patient is already dead");
                    return;
                }
            }
            if (Prescription.Text == "")
            {
                PrescriptionID = -1;
            }
            else
            {
                DataTable x = ctrl.InsertPrescription(DateTime.Now.ToString(format));
                    
                    PrescriptionID = Convert.ToInt32(x.Rows[0][0]);
                
                }
            int res = ctrl.InsertDiagnosis(HospitalID, PatientID.Text, DateTime.Now.ToString(format), comboBox2.Text, Symptoms.Text, PrescriptionID);
            if(res == 1)
            {
                MessageBox.Show("Diagnosis inserted successfully");
            }
            if (res == 0)
            {
                MessageBox.Show("Error!");
            }
            else
            {
                if (PrescriptionID != -1)
                {
                    for (int i = 0; i < x; i++)
                    {
                        ctrl.InsertMedications(PrescriptionID, meds[i], Quantity[i]);
                    }
                   
                }
            }
        }

        private void PatientID_TextChanged(object sender, EventArgs e)
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
                if (!char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void Hospital_Diagnosis_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            Prescription.Text = Prescription.Text + qty.Text + " " + comboBox1.Text + ", ";
            Quantity[x] = Convert.ToInt32(qty.Text);
            meds[x] = comboBox1.Text;
            x++;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled=true;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void qty_Enter(object sender, EventArgs e)
        {
            if (qty.Text == "Insert Quantity")
            {
                qty.Text = "";
                qty.StateActive.Content.Color1 = System.Drawing.Color.Black;
            }
        }

        private void qty_Leave(object sender, EventArgs e)
        {
            if (qty.Text == "")
            {
                qty.Text = "Insert Quantity";
                qty.StateActive.Content.Color1 = System.Drawing.Color.Silver;
            }
            else
            {
                qty.StateActive.Content.Color1 = System.Drawing.Color.Black;
            }
        }

        private void qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
