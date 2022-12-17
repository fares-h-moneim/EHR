using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EHR_Lab
{
    public partial class Lab : Form
    {
        public Lab()
        {
            InitializeComponent();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            Lab_Results myForm = new Lab_Results();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
