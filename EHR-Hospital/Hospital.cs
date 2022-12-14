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
    public partial class Hospital : Form
    {
        int HospitalID;
        public Hospital(int x)
        {
            InitializeComponent();
            HospitalID = x;
        }

        private void img1_Click(object sender, EventArgs e)
        {
            Hospital_Diagnosis myForm = new Hospital_Diagnosis(HospitalID);
            myForm.ShowDialog();
        }

        private void Hospital_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            Patient_History_Bg MyForm = new Patient_History_Bg();
            MyForm.ShowDialog();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            Surery_Request MyForm = new Surery_Request();
            MyForm.ShowDialog();

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            Death_Report MyForm = new Death_Report();
            MyForm.ShowDialog();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            Organ_Request MyForm = new Organ_Request();
            MyForm.ShowDialog();
        }
    }
}
