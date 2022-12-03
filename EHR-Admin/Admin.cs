using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EHR_Admin
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kryptonLabel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pharmacy_Click(object sender, EventArgs e)
        {
            Label_Name.Text = "Pharmacy Name";
            Phar.Text = "";
            Hos.Text = "Add Hospital";
            Lab.Text = "Add Laboratory";
            Sta.Text = "Show Statistics";
        }

        private void Hospital_Click(object sender, EventArgs e)
        {
            Label_Name.Text = "Hospital Name";
            Hos.Text = "";
            Phar.Text = "Add Pharmacy";
            Lab.Text = "Add Laboratory";
            Sta.Text = "Show Statistics";
        }

        private void Labs_Click(object sender, EventArgs e)
        {
            Label_Name.Text = "Lab Name";
            Lab.Text = "";
            Phar.Text = "Add Pharmacy";
            Hos.Text = "Add Hospital";
            Sta.Text = "Show Statistics";
        }

        private void Statistics_Click(object sender, EventArgs e)
        {
            Sta.Text = "";
            Phar.Text = "Add Pharmacy";
            Hos.Text = "Add Hospital";
            Lab.Text = "Add Laboratory";
        }
    }
}
