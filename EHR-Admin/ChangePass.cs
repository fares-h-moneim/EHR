﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EHR_Admin
{
    public partial class ChangePass : Form
    {
        Controller ctrl = new Controller();
        public ChangePass()
        {
            
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (pass1.Text == pass2.Text)
            {
                var bytes = new UTF8Encoding().GetBytes(pass1.Text);
                byte[] hashBytes;
                using (var algorithm = new System.Security.Cryptography.SHA512Managed())
                {
                    hashBytes = algorithm.ComputeHash(bytes);
                }
                string savedPasswordHash = Convert.ToBase64String(hashBytes);
                ctrl.ChangePass(Name.Text, savedPasswordHash);
            }
            else
            {
                MessageBox.Show("Password Does not Match");
            }
        }
    }
}