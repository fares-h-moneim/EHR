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
    public partial class Organs : Form
    {
        int HospitalID;
        public Organs(int x)
        {
            HospitalID = x;
            InitializeComponent();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            Organ_Request myForm = new Organ_Request(HospitalID);
            myForm.ShowDialog();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            View_Pending_Requests view_Pending_Requests = new View_Pending_Requests();
            view_Pending_Requests.ShowDialog();
        }
    }
}
