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
    public partial class Check_Family : Form
    {
        string id;
        Controller ctrl;
        DataTable dt;
        public Check_Family(string idt)
        {
            InitializeComponent();
            ctrl = new Controller();
            id = idt;

            Name1.Visible = false;
            Name2.Visible = false;
            Name3.Visible = false;
            Name4.Visible = false;

            Phone1.Visible = false;
            Phone2.Visible = false;
            Phone3.Visible = false;
            Phone4.Visible = false;

            Accept1.Visible = false;
            Accept2.Visible = false;
            Accept3.Visible = false;
            Accept4.Visible = false;

            Reject1.Visible = false;
            Reject2.Visible = false;
            Reject3.Visible = false;
            Reject4.Visible = false;


            DataTable requests = ctrl.GetRelativeRequests(idt);
            dt = requests;
            if(dt != null)
            {
                int count = requests.Rows.Count;
                if (count == 1)
                {
                    Name1.Text = requests.Rows[0][0].ToString();
                    Name1.Text += " ";
                    Name1.Text += requests.Rows[0][1].ToString();
                    Name1.Visible = true;

                    Phone1.Text = requests.Rows[0][2].ToString();
                    Phone1.Visible = true;

                    Accept1.Visible = true;
                    Reject1.Visible = true;
                }
                else if (count == 2)
                {
                    Name1.Text = requests.Rows[0][0].ToString();
                    Name1.Text += " ";
                    Name1.Text += requests.Rows[0][1].ToString();
                    Name1.Visible = true;

                    Phone1.Text = requests.Rows[0][2].ToString();
                    Phone1.Visible = true;

                    Name2.Text = requests.Rows[1][0].ToString();
                    Name2.Text += " ";
                    Name2.Text += requests.Rows[1][1].ToString();
                    Name2.Visible = true;

                    Phone2.Text = requests.Rows[1][2].ToString();
                    Phone2.Visible = true;

                    Accept1.Visible = true;
                    Reject1.Visible = true;
                    Accept2.Visible = true;
                    Reject2.Visible = true;
                }
                else if (count == 3)
                {
                    Name1.Text = requests.Rows[0][0].ToString();
                    Name1.Text += " ";
                    Name1.Text += requests.Rows[0][1].ToString();
                    Name1.Visible = true;

                    Phone1.Text = requests.Rows[0][2].ToString();
                    Phone1.Visible = true;

                    Name2.Text = requests.Rows[1][0].ToString();
                    Name2.Text += " ";
                    Name2.Text += requests.Rows[1][1].ToString();
                    Name2.Visible = true;

                    Phone2.Text = requests.Rows[1][2].ToString();
                    Phone2.Visible = true;

                    Name3.Text = requests.Rows[2][0].ToString();
                    Name3.Text += " ";
                    Name3.Text += requests.Rows[2][1].ToString();
                    Name3.Visible = true;

                    Phone3.Text = requests.Rows[2][2].ToString();
                    Phone3.Visible = true;

                    Accept1.Visible = true;
                    Reject1.Visible = true;
                    Accept2.Visible = true;
                    Reject2.Visible = true;
                    Accept3.Visible = true;
                    Reject3.Visible = true;
                }
                else
                {
                    Name1.Text = requests.Rows[0][0].ToString();
                    Name1.Text += " ";
                    Name1.Text += requests.Rows[0][1].ToString();
                    Name1.Visible = true;

                    Phone1.Text = requests.Rows[0][2].ToString();
                    Phone1.Visible = true;

                    Name2.Text = requests.Rows[1][0].ToString();
                    Name2.Text += " ";
                    Name2.Text += requests.Rows[1][1].ToString();
                    Name2.Visible = true;

                    Phone2.Text = requests.Rows[1][2].ToString();
                    Phone2.Visible = true;

                    Name3.Text = requests.Rows[2][0].ToString();
                    Name3.Text += " ";
                    Name3.Text += requests.Rows[2][1].ToString();
                    Name3.Visible = true;

                    Phone3.Text = requests.Rows[2][2].ToString();
                    Phone3.Visible = true;

                    Accept1.Visible = true;
                    Reject1.Visible = true;
                    Accept2.Visible = true;
                    Reject2.Visible = true;
                    Accept3.Visible = true;
                    Reject3.Visible = true;

                    Name4.Text = requests.Rows[3][0].ToString();
                    Name4.Text += " ";
                    Name4.Text += requests.Rows[3][1].ToString();
                    Name4.Visible = true;

                    Phone4.Text = requests.Rows[3][2].ToString();
                    Phone4.Visible = true;
                    Accept4.Visible = true;
                    Reject4.Visible = true;
                }
            }
        }

        private void Accept1_Click(object sender, EventArgs e)
        {
            ctrl.AcceptRelative(id, dt.Rows[0][4].ToString());
            Name1.Visible = false;
            Phone1.Visible = false;
            Accept1.Visible = false;
            Reject1.Visible = false;
        }

        private void Reject1_Click(object sender, EventArgs e)
        {
            ctrl.RejectRelative(id, dt.Rows[0][4].ToString());
            Name1.Visible = false;
            Phone1.Visible = false;
            Accept1.Visible = false;
            Reject1.Visible = false;
        }

        private void Accept2_Click(object sender, EventArgs e)
        {
            ctrl.AcceptRelative(id, dt.Rows[1][4].ToString());
            Name2.Visible = false;
            Phone2.Visible = false;
            Accept2.Visible = false;
            Reject2.Visible = false;
        }

        private void Reject2_Click(object sender, EventArgs e)
        {
            ctrl.RejectRelative(id, dt.Rows[1][4].ToString());
            Name2.Visible = false;
            Phone2.Visible = false;
            Accept2.Visible = false;
            Reject2.Visible = false;
        }

        private void Accept3_Click(object sender, EventArgs e)
        {
            ctrl.AcceptRelative(id, dt.Rows[2][4].ToString());
            Name3.Visible = false;
            Phone3.Visible = false;
            Accept3.Visible = false;
            Reject3.Visible = false;
        }

        private void Reject3_Click(object sender, EventArgs e)
        {
            ctrl.RejectRelative(id, dt.Rows[2][4].ToString());
            Name3.Visible = false;
            Phone3.Visible = false;
            Accept3.Visible = false;
            Reject3.Visible = false;
        }

        private void Accept4_Click(object sender, EventArgs e)
        {
            ctrl.AcceptRelative(id, dt.Rows[3][4].ToString());
            Name4.Visible = false;
            Phone4.Visible = false;
            Accept4.Visible = false;
            Reject4.Visible = false;
        }

        private void Reject4_Click(object sender, EventArgs e)
        {
            ctrl.RejectRelative(id, dt.Rows[3][4].ToString());
            Name4.Visible = false;
            Phone4.Visible = false;
            Accept4.Visible = false;
            Reject4.Visible = false;
        }

        private void Check_Family_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
