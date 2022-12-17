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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EHR_Lab
{
    public partial class Lab_Login : Form
    {
        Controller ctrl;
        public Lab_Login()
        {
            InitializeComponent();
            ctrl = new Controller();
        }

        private void Email_Enter(object sender, EventArgs e)
        {
            if (Email.Text == "kryptonTextBox1 (example@email.com)")
            {
                Email.Text = "";
                Email.StateActive.Content.Color1 = System.Drawing.Color.Black;
            }
        }

        private void Email_Leave(object sender, EventArgs e)
        {
            if (Email.Text == "")
            {
                Email.Text = "kryptonTextBox1 (example@email.com)";
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
                //emailerror.SetError(kryptonTextBox1, "Enter a Correct kryptonTextBox1");
            }
            else
            {
                //emailerror.SetError(kryptonTextBox1, "");
            }
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            if (Password.Text == "kryptonTextBox2")
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
                Password.Text = "kryptonTextBox2";
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
            DataTable dt = ctrl.GetLaboratory(Email.Text, savedPasswordHash);
            if(dt == null)
            {
                MessageBox.Show("username or password entered incorrectly");
                return;
            }
            DataRowCollection dt2 = dt.Rows;
            Lab myForm = new Lab(Convert.ToInt32(dt2[0][1]));
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
