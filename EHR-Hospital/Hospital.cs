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
        public Hospital()
        {
            InitializeComponent();
        }

        private void img1_Click(object sender, EventArgs e)
        {
            Hospital_Diagnosis myForm = new Hospital_Diagnosis();
            myForm.ShowDialog();
        }

        private void Hospital_Load(object sender, EventArgs e)
        {

        }
    }
}
