using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace EHR_Admin
{
    public partial class AddAdmin : Form
    {
        Controller ctrl;
        public AddAdmin()
        {
            InitializeComponent();
            ctrl = new Controller();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            var bytes = new UTF8Encoding().GetBytes(kryptonTextBox3.Text);
            byte[] hashBytes;
            using (var algorithm = new System.Security.Cryptography.SHA512Managed())
            {
                hashBytes = algorithm.ComputeHash(bytes);
            }
            string savedPasswordHash = Convert.ToBase64String(hashBytes);
            ctrl.InsertAdmin(fname.Text, kryptonTextBox1.Text, kryptonTextBox2.Text, savedPasswordHash);
            MessageBox.Show("Admin inserted successfully");
        }
    }
}
