using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
        }

        private void Report_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            chart.ChartAreas["ChartArea1"].AxisX.Interval = 1;
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
                if (selector.Text == "Diagnosis")
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
                                info.Text = "The most spread disease was " + dt.Rows[0][0] + "and it was diagnosed for " + dt.Rows[0][1] + "times";
                            }
                        }
                        else
                        {
                            chart.Series["Count"].Enabled = false;
                            DataTable male = ctrl.GetDiagnosisCountMale();
                            DataTable female = ctrl.GetDiagnosisCountFemale();
                            DataTable all = ctrl.GetDiagnosisCountAll();
                            if (all != null)
                            {
                                foreach (DataRow i in all.Rows)
                                {
                                    chart.Series["Male"].Points.AddXY(i[0], i[1]);
                                    chart.Series["Female"].Points.AddXY(i[0], i[2]);

                                }
                            }
                            if (male != null)
                            {
                                info.Text = "The most spread diagnosis between males during this time period is " + male.Rows[0][0];
                            }
                            if (female != null)
                            {
                                info.Text += " and " + female.Rows[0][0] + " for Females";
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
                                info.Text = "The most spread disease during this time period was " + dt.Rows[0][0] + "and it was diagnosed for " + dt.Rows[0][1] + "times";
                            }
                        }
                        else
                        {
                            chart.Series["Count"].Enabled = false;
                            DataTable male = ctrl.GetDiagnosisCountMaleDate(Start.Value.ToString(format), End.Value.ToString(format));
                            DataTable female = ctrl.GetDiagnosisCountFemaleDate(Start.Value.ToString(format), End.Value.ToString(format));
                            DataTable all = ctrl.GetDiagnosisCountAllDate(Start.Value.ToString(format), End.Value.ToString(format));
                            if (all != null)
                            {
                                foreach (DataRow i in all.Rows)
                                {
                                    chart.Series["Male"].Points.AddXY(i[0], i[1]);
                                    chart.Series["Female"].Points.AddXY(i[0], i[2]);

                                }
                            }
                            if (male != null)
                            {
                                info.Text = "The most spread diagnosis between males during this time period is " + male.Rows[0][0];
                            }
                            if (female != null)
                            {
                                info.Text += " and " + female.Rows[0][0] + " for Females";
                            }
                        }
                    }
                }
                else if (selector.Text == "Medications")
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
                                info.Text = "The most prescribed medicine was " + dt.Rows[0][0] + "and it was prescribed " + dt.Rows[0][1] + "times";
                            }
                        }
                        else
                        {
                            chart.Series["Count"].Enabled = false;
                            DataTable male = ctrl.GetMedicationCountMale();
                            DataTable female = ctrl.GetMedicationCountFemale();
                            DataTable all = ctrl.GetMedicationCountAll();
                            if (all != null)
                            {
                                foreach (DataRow i in all.Rows)
                                {
                                    chart.Series["Male"].Points.AddXY(i[0], i[1]);
                                    chart.Series["Female"].Points.AddXY(i[0], i[2]);

                                }
                            }
                            if (male != null)
                            {
                                info.Text = "The most prescribed medicine for males during this time period is " + male.Rows[0][0];
                            }
                            if (female != null)
                            {
                                info.Text += " and " + female.Rows[0][0] + " for Females";
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
                                info.Text = "The most prescribed medicine during this time period was " + dt.Rows[0][0] + "and it was prescribed " + dt.Rows[0][1] + "times";
                            }
                        }
                        else
                        {
                            chart.Series["Count"].Enabled = false;
                            DataTable male = ctrl.GetMedicationMaleDate(Start.Value.ToString(format), End.Value.ToString(format));
                            DataTable female = ctrl.GetMedicationFemaleDate(Start.Value.ToString(format), End.Value.ToString(format));
                            DataTable all = ctrl.GetMedicationCountAllDate(Start.Value.ToString(format), End.Value.ToString(format));
                            if (all != null)
                            {
                                foreach (DataRow i in all.Rows)
                                {
                                    chart.Series["Male"].Points.AddXY(i[0], i[1]);
                                    chart.Series["Female"].Points.AddXY(i[0], i[2]);

                                }
                            }
                            if (male != null)
                            {
                                info.Text = "The most prescribed medicine for males during this time period is " + male.Rows[0][0];
                            }
                            if (female != null)
                            {
                                info.Text += " and " + female.Rows[0][0] + " for Females";
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
                                info.Text = "The most tests done was " + dt.Rows[0][0] + "and it was tested for " + dt.Rows[0][1] + "times";
                            }
                        }
                        else
                        {
                            chart.Series["Count"].Enabled = false;
                            DataTable male = ctrl.GetLabMale();
                            DataTable female = ctrl.GetLabFemale();
                            DataTable all = ctrl.GetLabCountAll();
                            if (all != null)
                            {
                                foreach (DataRow i in all.Rows)
                                {
                                    chart.Series["Male"].Points.AddXY(i[0], i[1]);
                                    chart.Series["Female"].Points.AddXY(i[0], i[2]);

                                }
                            }
                            if (male != null)
                            {
                                info.Text = "The most test made by males during this time period is " + male.Rows[0][0];
                            }
                            if (female != null)
                            {
                                info.Text += " and " + female.Rows[0][0] + " for Females";
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
                                info.Text = "The most tests done was " + dt.Rows[0][0] + "and it was tested for " + dt.Rows[0][1] + "times";
                            }
                        }
                        else
                        {
                            chart.Series["Count"].Enabled = false;
                            DataTable male = ctrl.GetLabMaleDate(Start.Value.ToString(format), End.Value.ToString(format));
                            DataTable female = ctrl.GetLabFemaleDate(Start.Value.ToString(format), End.Value.ToString(format));
                            DataTable all = ctrl.GetLabCountAllDate(Start.Value.ToString(format), End.Value.ToString(format));
                            if (all != null)
                            {
                                foreach (DataRow i in male.Rows)
                                {
                                    chart.Series["Male"].Points.AddXY(i[0], i[1]);
                                    chart.Series["Female"].Points.AddXY(i[0], i[2]);

                                }
                            }
                            if (male != null)
                            {
                                info.Text = "The most test made by males during this time period is " + male.Rows[0][0];
                            }
                            if (female != null)
                            {
                                info.Text += " and " + female.Rows[0][0] + " for Females";
                            }
                        }
                    }

                }
                else
                {
                    chart.Series["Count"].Enabled = true;
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
                                info.Text = "The most operation done during this time period was " + dt.Rows[0][0] + "and it was operated " + dt.Rows[0][1] + "times";
                            }
                            else
                            {
                                chart.Series["Count"].Enabled = false;
                                DataTable male = ctrl.GetSurgeriesMale();
                                DataTable female = ctrl.GetSurgeriesFemale();
                                DataTable all = ctrl.GetSurgeriesCountAll();
                                if (all != null)
                                {
                                    foreach (DataRow i in all.Rows)
                                    {
                                        chart.Series["Male"].Points.AddXY(i[0], i[1]);
                                        chart.Series["Female"].Points.AddXY(i[0], i[2]);

                                    }
                                }
                                if (male != null)
                                {
                                    info.Text = "The most operations made by males during this time period is " + male.Rows[0][0];
                                }
                                if (female != null)
                                {
                                    info.Text += " and " + female.Rows[0][0] + " for Females";
                                }
                            }

                        }
                        else
                        {
                            if (kryptonCheckBox2.Checked)
                            {
                                chart.Series["Count"].Enabled = false;
                                DataTable male = ctrl.GetSurgeriesMaleDate(Start.Value.ToString(format), End.Value.ToString(format));
                                DataTable female = ctrl.GetSurgeriesFemaleDate(Start.Value.ToString(format), End.Value.ToString(format));
                                DataTable all = ctrl.GetSurgeriesCountAllDate(Start.Value.ToString(format), End.Value.ToString(format));
                                if (all != null)
                                {
                                    foreach (DataRow i in all.Rows)
                                    {
                                        chart.Series["Male"].Points.AddXY(i[0], i[1]);
                                        chart.Series["Female"].Points.AddXY(i[0], i[2]);

                                    }
                                }
                                if (male != null)
                                {
                                    info.Text = "The most operations made by males during this time period is " + male.Rows[0][0];
                                }
                                if (female != null)
                                {
                                    info.Text += " and " + female.Rows[0][0] + " for Females";
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
                                    info.Text = "The most operation done was " + dt.Rows[0][0] + "and it was operated " + dt.Rows[0][1] + "times";
                                }
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
