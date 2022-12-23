using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace EHR_Admin
{
    public partial class Report : Form
    {
        Controller ctrl;
        public Report()
        {
            InitializeComponent();
            ctrl = new Controller();

        }

        private void Report_Load(object sender, EventArgs e)
        {
            DataTable dt = ctrl.GetDiagnosisCount();

            if (dt != null)
            {
                foreach(DataRow i in dt.Rows)
                {
                    chart.Series["Count"].Points.AddXY(i[0], i[1]);
                }
            }
            

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }
    }
}
