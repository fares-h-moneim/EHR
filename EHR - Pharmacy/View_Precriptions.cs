using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EHR___Pharmacy
{
    public partial class View_Precriptions : Form
    {
        string pID;
        int pharmaid;
        Controller ctrl = new Controller();
        public View_Precriptions(string ID, int x)
        {
            pharmaid = x;
            pID = ID;
            InitializeComponent();
            DataTable dt = null;
            dt = ctrl.GetMedications(pID);
            dataGridView3.DataSource = dt;
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Prescription_ID";
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            ctrl.MedicationsGiven(Convert.ToInt32(comboBox1.Text), pharmaid);
            DataTable dt = ctrl.GetMedications(pID);
            dataGridView3.DataSource = dt;
            comboBox1.DataSource = dt;
            dataGridView3.Refresh();
            comboBox1.Refresh();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Form1 myForm = new Form1();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void View_Precriptions_Load(object sender, EventArgs e)
        {

        }
    }
}
