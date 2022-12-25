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
        int Hospital_id;
        public View_Pending_Requests(int x)
        {
            ctrl = new Controller();
            InitializeComponent();
            Hospital_id = x;
            DataTable dt = new DataTable();
            dt = ctrl.GetWaitingforhospital(Hospital_id);
            kryptonDataGridView1.DataSource = dt;
        }

        private void kryptonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void View_Pending_Requests_Load(object sender, EventArgs e)
        {

        }
    }
}
