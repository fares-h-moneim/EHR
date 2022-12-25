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
        string format = "yyyy-MM-dd HH:mm:ss";
        public Report()
        {
            InitializeComponent();
            ctrl = new Controller();
            Start.Enabled = false;
            End.Enabled = false;
            chart.Titles.Clear();
            chart.Series.Add("Female");
            chart.Series.Add("Male");
        }

        private void Report_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            chart.Titles.Clear();
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
                    chart.Series["Count"].Enabled = true;
                    if (!kryptonCheckBox1.Checked) //No Date
                    {
                        if (!kryptonCheckBox2.Checked)
                        {
                            DataTable dt = ctrl.GetDiagnosisCount();

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
                            chart.Series["Count"].Enabled = false;
                            DataTable male = ctrl.GetDiagnosisCountMale();
                            DataTable female = ctrl.GetDiagnosisCountFemale();
                            if (male != null)
                            {
                                foreach (DataRow i in male.Rows)
                                {
                                    chart.Series["Male"].Points.AddXY(i[0], i[1]);
                                }
                            }
                            if(female != null)
                            {
                                foreach (DataRow i in female.Rows)
                                {
                                    chart.Series["Female"].Points.AddXY(i[0], i[1]);
                                }
                            }
                        }
                    }
                    else
                    {
                        if (!kryptonCheckBox2.Checked)
                        {
                            
                            DataTable dt = ctrl.GetDiagnosisCountBetween(Start.Value.ToString(format), End.Value.ToString(format));
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
                            chart.Series["Count"].Enabled = false;
                            DataTable male = ctrl.GetDiagnosisCountMaleDate(Start.Value.ToString(format), End.Value.ToString(format));
                            DataTable female = ctrl.GetDiagnosisCountFemaleDate(Start.Value.ToString(format), End.Value.ToString(format));
                            if (male != null)
                            {
                                foreach (DataRow i in male.Rows)
                                {
                                    chart.Series["Male"].Points.AddXY(i[0], i[1]);
                                }
                            }
                            if (female != null)
                            {
                                foreach (DataRow i in female.Rows)
                                {
                                    chart.Series["Female"].Points.AddXY(i[0], i[1]);
                                }
                            }
                        }
                    }
                }
                else if(selector.Text == "Medications")
                {
                    chart.Series["Count"].Enabled = true;
                    if (!kryptonCheckBox1.Checked)//No Date
                    {
                        if (!kryptonCheckBox2.Checked)
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
                            chart.Series["Count"].Enabled = false;
                            DataTable male = ctrl.GetMedicationCountMale();
                            DataTable female = ctrl.GetMedicationCountFemale();
                            if (male != null)
                            {
                                foreach (DataRow i in male.Rows)
                                {
                                    chart.Series["Male"].Points.AddXY(i[0], i[1]);
                                }
                            }
                            if (female != null)
                            {
                                foreach (DataRow i in female.Rows)
                                {
                                    chart.Series["Female"].Points.AddXY(i[0], i[1]);
                                }
                            }
                        }
                    }
                    else
                    {
                        if (!kryptonCheckBox2.Checked)
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
                        else
                        {
                            chart.Series["Count"].Enabled = false;
                            DataTable male = ctrl.GetMedicationMaleDate(Start.Value.ToString(format), End.Value.ToString(format));
                            DataTable female = ctrl.GetMedicationFemaleDate(Start.Value.ToString(format), End.Value.ToString(format));
                            if (male != null)
                            {
                                foreach (DataRow i in male.Rows)
                                {
                                    chart.Series["Male"].Points.AddXY(i[0], i[1]);
                                }
                            }
                            if (female != null)
                            {
                                foreach (DataRow i in female.Rows)
                                {
                                    chart.Series["Female"].Points.AddXY(i[0], i[1]);
                                }
                            }
                        }
                    }

                }
                else if (selector.Text == "Lab Tests")
                {
                    chart.Series["Count"].Enabled = true;

                    if (!kryptonCheckBox1.Checked)
                    {
                        if (!kryptonCheckBox2.Checked)
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
                            chart.Series["Count"].Enabled = false;
                            DataTable male = ctrl.GetLabMale();
                            DataTable female = ctrl.GetLabFemale();
                            if (male != null)
                            {
                                foreach (DataRow i in male.Rows)
                                {
                                    chart.Series["Male"].Points.AddXY(i[0], i[1]);
                                }
                            }
                            if (female != null)
                            {
                                foreach (DataRow i in female.Rows)
                                {
                                    chart.Series["Female"].Points.AddXY(i[0], i[1]);
                                }
                            }
                        }
                    }
                    else
                    {
                        if (!kryptonCheckBox2.Checked)
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
                        else
                        {
                            chart.Series["Count"].Enabled = false;
                            DataTable male = ctrl.GetLabMaleDate(Start.Value.ToString(format), End.Value.ToString(format));
                            DataTable female = ctrl.GetLabFemaleDate(Start.Value.ToString(format), End.Value.ToString(format));
                            if (male != null)
                            {
                                foreach (DataRow i in male.Rows)
                                {
                                    chart.Series["Male"].Points.AddXY(i[0], i[1]);
                                }
                            }
                            if (female != null)
                            {
                                foreach (DataRow i in female.Rows)
                                {
                                    chart.Series["Female"].Points.AddXY(i[0], i[1]);
                                }
                            }
                        }
                    }

                }
                else
                {
                    if (!kryptonCheckBox1.Checked)
                    {
                        if (!kryptonCheckBox2.Checked)
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
                            chart.Series["Count"].Enabled = false;
                            DataTable male = ctrl.GetSurgeriesMale();
                            DataTable female = ctrl.GetSurgeriesFemale();
                            if (male != null)
                            {
                                foreach (DataRow i in male.Rows)
                                {
                                    chart.Series["Male"].Points.AddXY(i[0], i[1]);
                                }
                            }
                            if (female != null)
                            {
                                foreach (DataRow i in female.Rows)
                                {
                                    chart.Series["Female"].Points.AddXY(i[0], i[1]);
                                }
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
