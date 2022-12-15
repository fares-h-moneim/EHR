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
    public partial class Apply_Organ : Form
    {
        Controller ctrl;
        string id;
        
        public Apply_Organ(string idt)
        {
            InitializeComponent();
            id = idt;
            ctrl = new Controller();
        }

        private void Oragn_Dono_Load(object sender, EventArgs e)
        {
            
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            
            if(kryptonCheckBox6.Checked == true)
            {
                DataTable dt2 = ctrl.GetOrgan_Donor("Liver", id);
                if(dt2 != null)
                {
                    MessageBox.Show("You have already chose to donate all your organs");
                    return;
                }
                if (ctrl.GetOrgan_Donor(Kidney.Text, id) == null)
                {
                    ctrl.InsertOrganDonor(Kidney.Text, id, 1);
                }
                if (ctrl.GetOrgan_Donor(kryptonCheckBox1.Text, id) == null)
                {
                    ctrl.InsertOrganDonor(kryptonCheckBox1.Text, id, 1);
                }
                if (ctrl.GetOrgan_Donor(kryptonCheckBox2.Text, id) == null)
                {
                    ctrl.InsertOrganDonor(kryptonCheckBox2.Text, id, 1);
                }
                if (ctrl.GetOrgan_Donor(Lung.Text, id) == null)
                {
                    ctrl.InsertOrganDonor(Lung.Text, id, 1);
                }

                ctrl.InsertOrganDonor("Liver", id, 1);
                ctrl.InsertOrganDonor("Pancreas", id, 1);
                ctrl.InsertOrganDonor("Intestine", id, 1);
                MessageBox.Show("Thank you for your contribution");
            }
            if (Kidney.Checked == true)
            {
                DataTable dt = ctrl.GetOrgan_Donor(Kidney.Text, id);
                if (dt != null)
                {
                    MessageBox.Show("You have already signed up this organ");
                    return;
                }
                ctrl.InsertOrganDonor(Kidney.Text, id, 1);
                MessageBox.Show("Thank you for your contribution");
            }
            if (kryptonCheckBox1.Checked == true)
            {
                DataTable dt = ctrl.GetOrgan_Donor(kryptonCheckBox1.Text, id);
                if (dt != null)
                {
                    MessageBox.Show("You have already signed up this organ");
                    return;
                }
                ctrl.InsertOrganDonor(kryptonCheckBox1.Text, id, 1);
                MessageBox.Show("Thank you for your contribution");
            }
            if (Intestine.Checked == true)
            {
                DataTable dt = ctrl.GetOrgan_Donor(Intestine.Text, id);
                if (dt != null)
                {
                    MessageBox.Show("You have already signed up this organ");
                    return;
                }
                ctrl.InsertOrganDonor(Intestine.Text, id, 1);
                MessageBox.Show("Thank you for your contribution");
            }
            if (Pancreas.Checked == true)
            {
                DataTable dt = ctrl.GetOrgan_Donor(Pancreas.Text, id);
                if (dt != null)
                {
                    MessageBox.Show("You have already signed up this organ");
                    return;
                }
                ctrl.InsertOrganDonor(Pancreas.Text, id, 1);
                MessageBox.Show("Thank you for your contribution");
            }
            if (Liver.Checked == true)
            {
                DataTable dt = ctrl.GetOrgan_Donor(Liver.Text, id);
                if (dt != null)
                {
                    MessageBox.Show("You have already signed up this organ");
                    return;
                }
                ctrl.InsertOrganDonor(Liver.Text, id, 1);
                MessageBox.Show("Thank you for your contribution");
            }
            if (Lung.Checked == true)
            {
                DataTable dt = ctrl.GetOrgan_Donor(Lung.Text, id);
                if (dt != null)
                {
                    MessageBox.Show("You have already signed up this organ");
                    return;
                }
                ctrl.InsertOrganDonor(Lung.Text, id, 1);
                MessageBox.Show("Thank you for your contribution");
            }
            if (kryptonCheckBox2.Checked == true)
            {
                DataTable dt = ctrl.GetOrgan_Donor(kryptonCheckBox2.Text, id);
                if (dt != null)
                {
                    MessageBox.Show("You have already signed up this organ");
                    return;
                }
                ctrl.InsertOrganDonor(kryptonCheckBox2.Text, id, 1);
                MessageBox.Show("Thank you for your contribution");
            }
        }

        private void kryptonCheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            kryptonCheckBox1.Checked = false;
            kryptonCheckBox2.Checked = false;
            Liver.Checked = false;
            Lung.Checked = false;
            Kidney.Checked = false;
            Pancreas.Checked = false;
            Intestine.Checked = false;
        }

        private void Kidney_CheckedChanged(object sender, EventArgs e)
        {
            kryptonCheckBox6.Checked = false;

        }

        private void kryptonCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            kryptonCheckBox6.Checked = false;
        }

        private void kryptonCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            kryptonCheckBox6.Checked = false;
        }

        private void Lung_CheckedChanged(object sender, EventArgs e)
        {
            kryptonCheckBox6.Checked = false;
        }

        private void Liver_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Pancreas_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Intestine_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
