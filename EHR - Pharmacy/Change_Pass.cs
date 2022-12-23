using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EHR___Pharmacy
{
    public partial class Change_Pass : Form
    {
        Controller ctrl;
        public Change_Pass()
        {
            InitializeComponent();
            ctrl = new Controller();
        }

        private void Change_Pass_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            this.Close();
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
