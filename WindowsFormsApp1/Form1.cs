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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kryptonGroupBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonGroupBox1_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void First_Name_Enter(object sender, EventArgs e)
        {
            if (First_Name.Text == "First Name")
            {
                First_Name.Text = "";
                First_Name.StateActive.Content.Color1 = System.Drawing.Color.Black;
            }
        }

        private void First_Name_Leave(object sender, EventArgs e)
        {
            if(First_Name.Text == "")
            {
                First_Name.Text = "First Name";
                First_Name.StateActive.Content.Color1 = System.Drawing.Color.Silver;
            }
            else
            {
                First_Name.StateActive.Content.Color1 = System.Drawing.Color.Black;
            }
        }
        private void Last_Name_Enter(object sender, EventArgs e)
        {
            if (Last_Name.Text == "Last Name")
            {
                Last_Name.Text = "";
                Last_Name.StateActive.Content.Color1 = System.Drawing.Color.Black;
            }
        }

        private void Last_Name_Leave(object sender, EventArgs e)
        {
            if (Last_Name.Text == "")
            {
                Last_Name.Text = "Last Name";
                Last_Name.StateActive.Content.Color1 = System.Drawing.Color.Silver;
            }
            else
            {
                Last_Name.StateActive.Content.Color1 = System.Drawing.Color.Black;
            }
        }

        private void ID_Enter(object sender, EventArgs e)
        {
            if (ID.Text == "ID (16 Numbers)")
            {
                ID.Text = "";
                ID.StateActive.Content.Color1 = System.Drawing.Color.Black;
            }
        }

        private void ID_Leave(object sender, EventArgs e)
        {
            if (ID.Text == "")
            {
                ID.Text = "ID (16 Numbers)";
                ID.StateActive.Content.Color1 = System.Drawing.Color.Silver;
            }
            else
            {
                ID.StateActive.Content.Color1 = System.Drawing.Color.Black;
            }
        }

        private void Phone_Enter(object sender, EventArgs e)
        {
            if (Phone.Text == "Phone Number (+20 XXX XXX XXXX)")
            {
                Phone.Text = "";
                Phone.StateActive.Content.Color1 = System.Drawing.Color.Black;
            }
        }

        private void Phone_Leave(object sender, EventArgs e)
        {
            if (Phone.Text == "")
            {
                Phone.Text = "Phone Number (+20 XXX XXX XXXX)";
                Phone.StateActive.Content.Color1 = System.Drawing.Color.Silver;
            }
            else
            {
                Phone.StateActive.Content.Color1 = System.Drawing.Color.Black;
            }
        }

        private void Emergency_Contact_Enter(object sender, EventArgs e)
        {
            if (Emergency_Contact.Text == "Emergency_Contact (+20 XXX XXX XXXX)")
            {
                Emergency_Contact.Text = "";
                Emergency_Contact.StateActive.Content.Color1 = System.Drawing.Color.Black;
            }
        }

        private void Emergency_Contact_Leave(object sender, EventArgs e)
        {
            if (Emergency_Contact.Text == "")
            {
                Emergency_Contact.Text = "Emergency_Contact (+20 XXX XXX XXXX)";
                Emergency_Contact.StateActive.Content.Color1 = System.Drawing.Color.Silver;
            }
            else
            {
                Emergency_Contact.StateActive.Content.Color1 = System.Drawing.Color.Black;
            }
        }

        private void Chronic_Enter(object sender, EventArgs e)
        {
            if (Chronic.Text == "Chronic (Comma Separated)")
            {
                Chronic.Text = "";
                Chronic.StateActive.Content.Color1 = System.Drawing.Color.Black;
            }
        }

        private void Chronic_Leave(object sender, EventArgs e)
        {
            if (Chronic.Text == "")
            {
                Chronic.Text = "Chronic (Comma Separated)";
                Chronic.StateActive.Content.Color1 = System.Drawing.Color.Silver;
            }
            else
            {
                Chronic.StateActive.Content.Color1 = System.Drawing.Color.Black;
            }
        }

        private void Email_Enter(object sender, EventArgs e)
        {
            if (Email.Text == "Email (example@email.com)")
            {
                Email.Text = "";
                Email.StateActive.Content.Color1 = System.Drawing.Color.Black;
            }
        }

        private void Email_Leave(object sender, EventArgs e)
        {
            if (Email.Text == "")
            {
                Email.Text = "Email (example@email.com)";
                Email.StateActive.Content.Color1 = System.Drawing.Color.Silver;
            }
            else
            {
                Email.StateActive.Content.Color1 = System.Drawing.Color.Black;
            }
        }

        private void Pass_Enter(object sender, EventArgs e)
        {
            if (Pass.Text == "Password")
            {
                Pass.Text = "";
                Pass.StateActive.Content.Color1 = System.Drawing.Color.Black;
                Pass.PasswordChar = '*';
            }

        }

        private void Pass_Leave(object sender, EventArgs e)
        {
            if (Pass.Text == "")
            {
                Pass.Text = "Password";
                Pass.StateActive.Content.Color1 = System.Drawing.Color.Silver;
                Pass.PasswordChar  = First_Name.PasswordChar; 
            }
            else
            {
                Pass.StateActive.Content.Color1 = System.Drawing.Color.Black;
            }
        }

        private void Pass2_Enter(object sender, EventArgs e)
        {
            if (Pass2.Text == "Re-enter Password")
            {
                Pass2.Text = "";
                Pass2.StateActive.Content.Color1 = System.Drawing.Color.Black;
                Pass2.PasswordChar = '*';
            }

        }

        private void Pass2_Leave(object sender, EventArgs e)
        {
            if (Pass2.Text == "")
            {
                Pass2.Text = "Re-enter Password";
                Pass2.StateActive.Content.Color1 = System.Drawing.Color.Silver;
                Pass2.PasswordChar = First_Name.PasswordChar;
            }
            else
            {
                Pass2.StateActive.Content.Color1 = System.Drawing.Color.Black;
            }
        }

        private void kryptonTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonDropButton1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonNumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void First_Name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
