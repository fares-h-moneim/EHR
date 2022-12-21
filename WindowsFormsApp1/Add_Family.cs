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
        string id;
        public Add_Family(string idt)
        {
            InitializeComponent();
            ctrl = new Controller();
            id = idt;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            //add family
            int res = ctrl.InsertRelative(id, Relative.Text);

            if(res == 0)
            {
                MessageBox.Show("ID doesn't exist");
            }
            else
            {
                MessageBox.Show("Sent!");
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
