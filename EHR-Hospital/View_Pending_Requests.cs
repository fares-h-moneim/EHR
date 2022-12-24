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
    public partial class View_Pending_Requests : Form
    {
        Controller ctrl;
        public View_Pending_Requests()
        {
            ctrl = new Controller();
            InitializeComponent();
            DataTable dt = new DataTable();
            dt = ctrl.GetWaiting();
            kryptonDataGridView1.DataSource = dt;
        }

        private void kryptonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
