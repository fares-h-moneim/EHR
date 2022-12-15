using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace EHR_Admin
{
    public partial class SignIn : Form
    {
        Controller ctrl;
        public SignIn()
        {
            InitializeComponent();
            ctrl = new Controller();
            kryptonLabel1.Visible = false;
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

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

        private void Email_Validating(object sender, CancelEventArgs e)
        {
            Regex expression = new Regex("^[a-zA-Z0-9.!#$%&'+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:.[a-zA-Z0-9-]+)$");

            if (!expression.IsMatch(Email.Text))
            {
                //emailerror.SetError(Email, "Enter a Correct Email");
            }
            else
            {
                //emailerror.SetError(Email, "");
            }
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            if (Password.Text == "Password")
            {
                Password.Text = "";
                Password.StateActive.Content.Color1 = System.Drawing.Color.Black;
                Password.PasswordChar = '*';
            }
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if (Password.Text == "")
            {
                Password.Text = "Password";
                Password.StateActive.Content.Color1 = System.Drawing.Color.Silver;
                Password.PasswordChar = Email.PasswordChar;
            }
            else
            {
                Password.StateActive.Content.Color1 = System.Drawing.Color.Black;
            }
        }

        private void Password_Validating(object sender, CancelEventArgs e)
        {

        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            var bytes = new UTF8Encoding().GetBytes(Password.Text);
            byte[] hashBytes;
            using (var algorithm = new System.Security.Cryptography.SHA512Managed())
            {
                hashBytes = algorithm.ComputeHash(bytes);
            }
            string savedPasswordHash = Convert.ToBase64String(hashBytes);
            DataTable dt = ctrl.GetAdmin(Email.Text.ToString(), savedPasswordHash);

            if(dt != null)
            {
                Admin myForm = new Admin(Email.Text);
                this.Hide();
                myForm.ShowDialog();
                this.Close();
                kryptonLabel1.Visible = false;
            }
            else
            {
                kryptonLabel1.Visible = true;
                kryptonLabel1.Text = "Invalid Username or Password";
            }
        }
    }
}
