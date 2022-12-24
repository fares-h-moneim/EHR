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
            Start.Enabled = false;
            End.Enabled = false;
        }

        private void Report_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            chart.Titles.Add(selector.Text.ToString());
            foreach (var series in chart.Series)
            {
                series.Points.Clear();
            }
            if (selector.Text == "")
            {
                MessageBox.Show("Error Please Pick a Statistic to Show");
            }
            else
            {
                if(selector.Text == "Diagnosis")
                {
                    if (!kryptonCheckBox1.Checked)
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
                    else
                    {
                        string format = "yyyy-MM-dd HH:mm:ss";
                        DataTable dt = ctrl.GetDiagnosisCountBetween(Start.Value.ToString(format), End.Value.ToString(format));
                        if (dt != null)
                        {
                            foreach (DataRow i in dt.Rows)
                            {
                                chart.Series["Count"].Points.AddXY(i[0], i[1]);
                            }
                        }
                    }
                }
                else if(selector.Text == "Medications")
                {
                    if (!kryptonCheckBox1.Checked)
                    {
                        DataTable dt = ctrl.GetMedicationCount();

                        if (dt != null)
                        {
                            foreach (DataRow i in dt.Rows)
                            {
                                chart.Series["Count"].Points.AddXY(i[0], i[1]);
                            }
                        }
                    }
                    else
                    {
                        string format = "yyyy-MM-dd HH:mm:ss";
                        DataTable dt = ctrl.GetMedicationCountBetween(Start.Value.ToString(format), End.Value.ToString(format));
                        if (dt != null)
                        {
                            foreach (DataRow i in dt.Rows)
                            {
                                chart.Series["Count"].Points.AddXY(i[0], i[1]);
                            }
                        }
                    }
                }
                else if (selector.Text == "Lab Tests")
                {
                    if (!kryptonCheckBox1.Checked)
                    {
                        DataTable dt = ctrl.GetLabsCount();

                        if (dt != null)
                        {
                            foreach (DataRow i in dt.Rows)
                            {
                                chart.Series["Count"].Points.AddXY(i[0], i[1]);
                            }
                        }
                    }
                    else
                    {
                        string format = "yyyy-MM-dd HH:mm:ss";
                        DataTable dt = ctrl.GetLabsCountBetween(Start.Value.ToString(format), End.Value.ToString(format));
                        if (dt != null)
                        {
                            foreach (DataRow i in dt.Rows)
                            {
                                chart.Series["Count"].Points.AddXY(i[0], i[1]);
                            }
                        }
                    }

                }
                else
                {
                    if (!kryptonCheckBox1.Checked)
                    {
                        DataTable dt = ctrl.GetSurgeriesCount();

                        if (dt != null)
                        {
                            foreach (DataRow i in dt.Rows)
                            {
                                chart.Series["Count"].Points.AddXY(i[0], i[1]);
                            }
                        }
                    }
                    else
                    {
                        string format = "yyyy-MM-dd HH:mm:ss";
                        DataTable dt = ctrl.GetSurgeriesCountBetween(Start.Value.ToString(format), End.Value.ToString(format));
                        if (dt != null)
                        {
                            foreach (DataRow i in dt.Rows)
                            {
                                chart.Series["Count"].Points.AddXY(i[0], i[1]);
                            }
                        }
                    }
                }
            }
        }

        private void kryptonCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (kryptonCheckBox1.Checked)
            {
                Start.Enabled = true;
                End.Enabled = true;
            }
            else
            {
                Start.Enabled = false;
                End.Enabled = false;
            }
        }

        private void kryptonComboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void chart_Click(object sender, EventArgs e)
        {

        }
    }
}
