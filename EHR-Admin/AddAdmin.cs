using System;
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
            if(FirstName.Text=="" || kryptonTextBox1.Text=="" || kryptonTextBox2.Text=="" || kryptonTextBox3.Text == "")
            {
                MessageBox.Show("Please fill all fields");
                return;
            }
            var bytes = new UTF8Encoding().GetBytes(kryptonTextBox3.Text);
            byte[] hashBytes;
            using (var algorithm = new System.Security.Cryptography.SHA512Managed())
            {
                hashBytes = algorithm.ComputeHash(bytes);
            }
            string savedPasswordHash = Convert.ToBase64String(hashBytes);
            int x = ctrl.InsertAdmin(FirstName.Text, kryptonTextBox1.Text, kryptonTextBox2.Text, savedPasswordHash);
            if (x == 0)
            {
                MessageBox.Show("Insertion Failed");
            }
            else
            {
                MessageBox.Show("Admin inserted successfully");
            }
        }

        private void AddAdmin_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
