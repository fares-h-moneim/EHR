using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.CodeDom;
using System.Collections.Specialized;

namespace WindowsFormsApp1
{
    public partial class SignUp : Form
    {
        int count_error;
        bool[] check = new bool[] { false, false, false, false, false, false, false, false, false,false };
        public SignUp()
        {
            InitializeComponent();
            count_error = 10;
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
            if (Emergency_Contact.Text == "Emergency Contact (+20 XXX XXX XXXX)")
            {
                Emergency_Contact.Text = "";
                Emergency_Contact.StateActive.Content.Color1 = System.Drawing.Color.Black;
            }
        }

        private void Emergency_Contact_Leave(object sender, EventArgs e)
        {
            if (Emergency_Contact.Text == "")
            {
                Emergency_Contact.Text = "Emergency Contact (+20 XXX XXX XXXX)";
                Emergency_Contact.StateActive.Content.Color1 = System.Drawing.Color.Silver;
            }
            else
            {
                Emergency_Contact.StateActive.Content.Color1 = System.Drawing.Color.Black;
            }
        }

        private void Chronic_Enter(object sender, EventArgs e)
        {
            if (Chronic.Text == "Chronic Diseases (Comma Separated)")
            {
                Chronic.Text = "";
                Chronic.StateActive.Content.Color1 = System.Drawing.Color.Black;
            }
        }

        private void Chronic_Leave(object sender, EventArgs e)
        {
            if (Chronic.Text == "")
            {
                Chronic.Text = "Chronic Diseases (Comma Separated)";
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

        private void Phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void First_Name_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(First_Name.Text) || First_Name.Text == "First Name")
            {
                check[0] = false;
                firstnameerror.SetError(First_Name, "First Name should not be left blank!");
            }
            else
            {
                firstnameerror.SetError(First_Name, "");
                check[0] = true;
            }
        }

        private void Last_Name_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Last_Name.Text) || Last_Name.Text == "Last Name")
            {
                
                check[1] = false;
                lastnameerror.SetError(Last_Name, "Last Name should not be left blank!");
            }
            else
            {
                lastnameerror.SetError(Last_Name, "");
                check[1] = true;
            }
        }

        private void ID_Validating(object sender, CancelEventArgs e)
        {
            if (ID.Text.Length != 16)
            {
               
                check[2] = false;
                iderror.SetError(ID, "ID Must be 16 digits!");
            }
            else
            {
                iderror.SetError(ID, "");
                check[2] = true;
            }
        }

        private void Phone_Validated(object sender, EventArgs e)
        {
            Regex expression = new Regex("^01[0-2]\\d{8}$");

            if (!expression.IsMatch(Phone.Text))
            {
                
                check[3] = false;
                phoneerror.SetError(Phone, "Enter a Correct Phone Number");
            }
            else
            {
                phoneerror.SetError(Phone, "");
                check[3] = true;
            }
        }

        private void Emergency_Contact_Validated(object sender, EventArgs e)
        {
            Regex expression = new Regex("^01[0-2]\\d{8}$");

            if (!expression.IsMatch(Emergency_Contact.Text))
            {
              
                check[4] = false;
                emergencyerror.SetError(Emergency_Contact, "Enter a Correct Phone Number");
            }
            else
            {
                emergencyerror.SetError(Emergency_Contact, "");
                check[4] = true;
            }
        }

        private void Email_Validated(object sender, EventArgs e)
        {
            Regex expression = new Regex("^[a-zA-Z0-9.!#$%&'+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:.[a-zA-Z0-9-]+)$");

            if (!expression.IsMatch(Email.Text))
            {
                
                check[5] = false;
                emailerror.SetError(Email, "Enter a Correct Email");
            }
            else
            {
                emailerror.SetError(Email, "");
                check[5] = true;
            }
        }

        private void Pass_Validated(object sender, EventArgs e)
        {
            string password = Pass.Text;
            if (!(password.Any(char.IsLower) && password.Any(char.IsUpper) && password.Any(char.IsDigit) && Pass.Text.Length > 8))
            {
               
                check[6] = false;
                passerror.SetError(Pass, "Make sure your password contains 1 Upper Letter, 1 Lower Letter, 1 Digit and More than 8 Characters Long");
            }
            else
            {
                passerror.SetError(Pass, "");
                check[6] = true;
            }

        }

        private void Pass2_Validated(object sender, EventArgs e)
        {
            if (Pass2.Text != Pass.Text)
            {
                
                check[7] = false;
                pass2error.SetError(Pass2, "Make sure Both Passwords Match!");
            }
            else
            {
                pass2error.SetError(Pass2, "");
                check[7] = true;
            }
        }

        private void Gender_Validating(object sender, CancelEventArgs e)
        {
            if(Gender.SelectedIndex == -1)
            {
              
                check[8] = false;
                gendererror.SetError(Gender, "Pick a Gender!");
            }
            else
            {
                gendererror.SetError(Gender, "");
                check[8] = true;
            }
        }

        private void Blood_type_Validated(object sender, EventArgs e)
        {
            if (Blood_type.SelectedIndex == -1)
            {
                
                check[9] = false;
                blooderror.SetError(Blood_type, "Pick a Blood Type!");
            }
            else
            {
                blooderror.SetError(Blood_type, "");
                check[9] = true;
            }
        }

        private void Submit_Validating(object sender, CancelEventArgs e)
        {
           

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            bool submitvalid = true;
            for (int i = 0; i < 10; i++)
            {
                submitvalid = submitvalid && check[i];
            }
            if (!submitvalid)
            {
                submiterror.SetError(Submit, "Fill all the Above fields correctly");

            }
            else
            {
                submiterror.SetError(Submit, "");
            }
        }
    }
}
