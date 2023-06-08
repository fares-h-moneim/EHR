using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Add_Family : Form
    {
        Controller ctrl;
        string ID;
        public Add_Family(string idt)
        {
            InitializeComponent();
            ctrl = new Controller();
            ID = idt;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            //add family
            DataTable Check = ctrl.CheckforReletiveRequest(ID, Relative.Text);
            if (Check == null)
            {
                int res = ctrl.InsertRelative(ID, Relative.Text);

                if (res == 0)
                {
                    MessageBox.Show("ID doesn't exist");
                }
                else
                {
                    MessageBox.Show("Sent!");
                }
            }
            else
            {
                ctrl.AcceptRelative(ID, Relative.Text);
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Relative_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Relative.Text.ToString().Length >= 16)
            {
                if (!char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
