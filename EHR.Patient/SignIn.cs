using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public partial class SignIn : Form
    {
        Controller ctrl;
        public SignIn()
        {
            InitializeComponent();
            ctrl = new Controller();

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            var bytes = new UTF8Encoding().GetBytes(Pass.Text);
            byte[] hashBytes;
            using (var algorithm = new System.Security.Cryptography.SHA512Managed())
            {
                hashBytes = algorithm.ComputeHash(bytes);
            }
            string savedPasswordHash = Convert.ToBase64String(hashBytes);
            DataTable dt = ctrl.GetPatient(Email.Text,savedPasswordHash);
            if(dt == null)
            {
                MessageBox.Show("Incorrect Email or Password");
                return;
            }
            if (Convert.ToBoolean(dt.Rows[0][11]) == true)
            {
                MessageBox.Show("Patient is dead. Cannot access account");
                return;
            }
            Patient myForm = new Patient(Email.Text, Pass.Text);
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            SignUp myForm = new SignUp();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void Email_Enter(object sender, EventArgs e)
        {
            if (Email.Text == "Email (example@Email.com)")
            {
                Email.Text = "";
                Email.StateActive.Content.Color1 = System.Drawing.Color.Black;
            }
        }

        private void Email_Leave(object sender, EventArgs e)
        {
            if (Email.Text == "")
            {
                Email.Text = "Email (example@Email.com)";
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
                Pass.PasswordChar = Email.PasswordChar;
            }
            else
            {
                Pass.StateActive.Content.Color1 = System.Drawing.Color.Black;
            }
        }

        private void Email_Validating(object sender, CancelEventArgs e)
        {
            Regex expression = new Regex("^[a-zA-Z0-9.!#$%&'+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:.[a-zA-Z0-9-]+)$");

            if (!expression.IsMatch(Email.Text))
            {
                emailerror.SetError(Email, "Enter a Correct Email");
            }
            else
            {
                emailerror.SetError(Email, "");
            }
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }
    }
}
