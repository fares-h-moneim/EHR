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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EHR_Admin
{
    public partial class Admin : Form
    {
        Controller ctrl;
        string user;
        public Admin(string muser)
        {
            InitializeComponent();
            user = muser;
            ctrl = new Controller();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Hello.Text = "Hello " + user;
            
        }

        private void kryptonLabel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pharmacy_Click(object sender, EventArgs e)
        {
            Label_Name.Text = "Pharmacy Name";
            Phar.Text = "";
            kryptonLabel1.Visible = false;
            Hos.Text = "Add Hospital";
            Lab.Text = "Add Laboratory";
            Sta.Text = "Show Statistics";
            H_Name.Text = "";
            H_User.Text = "";
            H_Pass.Text = "";
            kryptonTextBox4.Text = "";
            H_Street.Text = "";
            kryptonTextBox8.Text = "";
            kryptonTextBox10.Text = "";
            kryptonTextBox9.Text = "";
        }

        private void Hospital_Click(object sender, EventArgs e)
        {
            Label_Name.Text = "Hospital Name";
            kryptonLabel1.Visible = true;
            Hos.Text = "";
            Phar.Text = "Add Pharmacy";
            Lab.Text = "Add Laboratory";
            Sta.Text = "Show Statistics";
            H_Name.Text = "";
            H_User.Text = "";
            H_Pass.Text = "";
            kryptonTextBox4.Text = "";
            H_Street.Text = "";
            kryptonTextBox8.Text = "";
            kryptonTextBox10.Text = "";
            kryptonTextBox9.Text = "";
        }

        private void Labs_Click(object sender, EventArgs e)
        {
            Label_Name.Text = "Lab Name";
            kryptonLabel1.Visible = false;
            Lab.Text = "";
            Phar.Text = "Add Pharmacy";
            Hos.Text = "Add Hospital";
            Sta.Text = "Show Statistics";
            H_Name.Text = "";
            H_User.Text = "";
            H_Pass.Text = "";
            kryptonTextBox4.Text = "";
            H_Street.Text = "";
            kryptonTextBox8.Text = "";
            kryptonTextBox10.Text = "";
            kryptonTextBox9.Text = "";
        }

        private void Statistics_Click(object sender, EventArgs e)
        {
            Sta.Text = "";
            Phar.Text = "Add Pharmacy";
            Hos.Text = "Add Hospital";
            Lab.Text = "Add Laboratory";

            Report myForm = new Report();
            myForm.ShowDialog();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            object[] address = {H_Street.Text, kryptonTextBox8.Text, kryptonTextBox10.Text, kryptonTextBox9.Text};
            string addressj = string.Join(", ", address);
            var bytes = new UTF8Encoding().GetBytes(H_Pass.Text);
            byte[] hashBytes;
            using (var algorithm = new System.Security.Cryptography.SHA512Managed())
            {
                hashBytes = algorithm.ComputeHash(bytes);
            }
            string savedPasswordHash = Convert.ToBase64String(hashBytes);
            if (Label_Name.Text == "Hospital Name")
            {
                int x = ctrl.InsertHospital(H_Name.Text, H_User.Text, savedPasswordHash, addressj);
                string[] ch = kryptonTextBox4.Text.Split(',');
                DataTable dt = ctrl.GetHospital(H_User.Text);
                DataRowCollection dtr = dt.Rows;
                if (x == 1)
                {
                    H_Name.Text = "";
                    H_User.Text = "";
                    H_Pass.Text = "";
                    kryptonTextBox4.Text = "";
                    H_Street.Text = "";
                    kryptonTextBox8.Text = "";
                    kryptonTextBox10.Text = "";
                    kryptonTextBox9.Text = "";
                }
                for (int i = 0; i < ch.Length; i++)
                {
                    int y = ctrl.InsertPhonenumbers(ch[i], Convert.ToInt32(dtr[0][0]));
                }

            }
            if (Label_Name.Text == "Pharmacy Name"){
                int z = ctrl.InsertPharmacy(H_Name.Text, H_User.Text, savedPasswordHash, addressj, kryptonTextBox4.Text);
                if (z == 1)
                {
                        H_Name.Text = "";
                        H_User.Text = "";
                        H_Pass.Text = "";
                        kryptonTextBox4.Text = "";
                        H_Street.Text = "";
                        kryptonTextBox8.Text = "";
                        kryptonTextBox10.Text = "";
                        kryptonTextBox9.Text = "";
                }
            }
            if (Label_Name.Text == "Lab Name")
            {
                int w = ctrl.InsertLaboratory(H_Name.Text, H_User.Text, savedPasswordHash, addressj, kryptonTextBox4.Text);
                if (w == 1)
                {
                    H_Name.Text = "";
                    H_User.Text = "";
                    H_Pass.Text = "";
                    kryptonTextBox4.Text = "";
                    H_Street.Text = "";
                    kryptonTextBox8.Text = "";
                    kryptonTextBox10.Text = "";
                    kryptonTextBox9.Text = "";
                }
            }

        }

        private void kryptonLabel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void Hello_Paint(object sender, PaintEventArgs e)
        {

        }

        private void H_Pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void H_Pass_Enter(object sender, EventArgs e)
        {
            H_Pass.PasswordChar = '*';
        }

        private void Back_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(Add_Admin, "Add Admin");
        }

        private void Add_Admin_Click(object sender, EventArgs e)
        {
            AddAdmin AA = new AddAdmin();
               AA.Show();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            SignIn myForm = new SignIn();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
