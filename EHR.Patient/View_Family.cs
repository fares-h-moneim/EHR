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
    public partial class View_Family : Form
    {
        string ID;
        Controller ctrl;
        public View_Family(string idt)
        {
            InitializeComponent();
            ID = idt;
            ctrl = new Controller();
            DataTable dt = ctrl.GetRelatives(idt);
            none.Visible = false;
            kryptonDataGridView1.Visible = false;

            if (dt == null)
            {
                none.Visible = true;
                kryptonDataGridView1.Visible = false;
            }
            else
            {
                kryptonDataGridView1.DataSource = dt;
                kryptonDataGridView1.Refresh();
                none.Visible = false;
                kryptonDataGridView1.Visible = true;
            }
        }

        private void View_Family_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
