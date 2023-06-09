﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EHR___Pharmacy
{
    public partial class Form1 : Form
    {
        Controller ctrl = new Controller();
        public Form1()
        {
            InitializeComponent();
        }

        private void Email_Enter(object sender, EventArgs e)
        {
            if (Email.Text == "Username")
            {
                Email.Text = "";
                Email.StateActive.Content.Color1 = System.Drawing.Color.Black;
            }
        }

        private void Email_Leave(object sender, EventArgs e)
        {
            if (Email.Text == "")
            {
                Email.Text = "Username";
                Email.StateActive.Content.Color1 = System.Drawing.Color.Silver;
            }
            else
            {
                Email.StateActive.Content.Color1 = System.Drawing.Color.Black;
            }
        }

        private void Email_Validating(object sender, CancelEventArgs e)
        {
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
            DataTable dt = ctrl.GetPharmacy(Email.Text, savedPasswordHash);
            if (dt == null)
            {
                MessageBox.Show("Email or Password inserted incorrectly");
                return;
            }
            else
            {
                DataTable ds = ctrl.GetPharmacyID(Email.Text);
                int x = Convert.ToInt32(ds.Rows[0][0]);
                Pharmacy myForm = new Pharmacy(x);
                this.Hide();
                myForm.ShowDialog();
                this.Close();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            Change_Pass myForm = new Change_Pass();
            myForm.ShowDialog();
        }
    }
}
