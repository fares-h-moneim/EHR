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
    public partial class View_Prescriptions : Form
    {
        Controller ctrl;
        string ID;
        public View_Prescriptions(string idt)
        {
            InitializeComponent();
            ctrl = new Controller();
            ID = idt;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            string format = "yyyy-MM-dd";
            DataTable dt = ctrl.GetPrescriptions(kryptonDateTimePicker1.Value.ToString(format), kryptonDateTimePicker2.Value.ToString(format), ID);
            kryptonDataGridView1.DataSource = dt;
        }
    }
}
