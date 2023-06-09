using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.ServiceProcess;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp1
{

    public partial class EditInfo : Form
    {
        bool[] check = new bool[] { false, false, false, false, false, false, false, false};
        Controller ctrl = new Controller();
        string Username;
        string prevemail;
        string ID1;
        string Password;
        Patient parent;
        public EditInfo(string Username, string Password, Patient form)
        {
            InitializeComponent();
            var bytes = new UTF8Encoding().GetBytes(Password);
            byte[] hashBytes;
            using (var algorithm = new System.Security.Cryptography.SHA512Managed())
            {
                hashBytes = algorithm.ComputeHash(bytes);
            }
            string savedPasswordHash = Convert.ToBase64String(hashBytes);
            DataTable patient = ctrl.GetPatient(Username, savedPasswordHash);
            parent = form;
            Password = Password;
            object sender = null;
            EventArgs e = new EventArgs();
            if (patient != null)
            {
                DataRowCollection dataRow = patient.Rows;
                DataTable dt = ctrl.GetChronic(dataRow[0][0].ToString());
                ID1 = dataRow[0][0].ToString();
                First_Name.Text = dataRow[0][1].ToString();
                Last_Name.Text = dataRow[0][2].ToString();
                Email.Text = Username;
                this.prevemail = Username;
                Pass.Text = "";
                Pass2.Text = "";
                ID1.Text = dataRow[0][0].ToString();
                this.Username = dataRow[0][0].ToString();
                string gender;
                if (dataRow[0][6].ToString() == "0")
                {
                    Gender.Text = "Male";
                }
                else {
                    Gender.Text = "Female";
                }
                Emergency_Contact.Text = dataRow[0][8].ToString();
                Phone.Text = dataRow[0][5].ToString();
                Blood_type.Text = dataRow[0][7].ToString();

                if (dt != null)
                {

                    string chronic = "";
                    Chronic.Text = "";
                    foreach (DataRow row in dt.Rows)
                    {
                        chronic += row[0].ToString();
                        chronic += ", ";
                    }
                    for (int i = 0; i < chronic.Length - 2; i++)
                    {
                        Chronic.Text += chronic[i];
                    }
                }

            }
        }



        private void Submit_Click(object sender, EventArgs e)
        {
            string gender = (Gender.Text == "Male") ? "0" : "1";
            DateTime now = DateTime.Now;
            string Today = now.Year.ToString();
            string B_Year = Birth_day.Value.Year.ToString();

            string Age = (Convert.ToInt32(Today) - Convert.ToInt32(B_Year)).ToString();


            string[] ch = Chronic.Text.Split(',');


            bool submitvalid = true;
            for (int i = 0; i < 8; i++)
            {
                submitvalid = submitvalid && check[i];
            }
            submitvalid = true;
            if (!submitvalid)
            {
                submiterror.SetError(Submit, "Fill all the Above fields correctly");

            }
            else
            {
                if (Pass.Text == "" && Pass2.Text == "")
                {

                    ctrl.DeleteChronic(ID1);
                    foreach (string disease in ch)
                    {
                        ctrl.InsertChronicDisease(disease, ID1);
                    }
                    var bytes = new UTF8Encoding().GetBytes(Password);
                    byte[] hashBytes;
                    using (var algorithm = new System.Security.Cryptography.SHA512Managed())
                    {
                        hashBytes = algorithm.ComputeHash(bytes);
                    }
                    string savedPasswordHash = Convert.ToBase64String(hashBytes);
                    int up = ctrl.UpdatePatient(Username, ID1, First_Name.Text, Last_Name.Text, Email.Text, savedPasswordHash, Gender.Text, Blood_type.Text, Phone.Text, Emergency_Contact.Text);
                }
                else
                {
                    ctrl.DeleteChronic(ID1);
                    foreach (string disease in ch)
                    {
                        ctrl.InsertChronicDisease(disease, ID1);
                    }
                    var bytes = new UTF8Encoding().GetBytes(Pass.Text);
                    byte[] hashBytes;
                    using (var algorithm = new System.Security.Cryptography.SHA512Managed())
                    {
                        hashBytes = algorithm.ComputeHash(bytes);
                    }
                    string savedPasswordHash = Convert.ToBase64String(hashBytes);
                    int up = ctrl.UpdatePatient(Username, ID1, First_Name.Text, Last_Name.Text, Email.Text, savedPasswordHash, Gender.Text, Blood_type.Text, Phone.Text, Emergency_Contact.Text);
                }
                submiterror.SetError(Submit, "");
                if (Pass.Text == "")
                {
                    Patient myForm = new Patient(Email.Text, Password);
                    this.Hide();
                    myForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    Patient myForm = new Patient(Email.Text, Pass.Text);
                    this.Hide();
                    myForm.ShowDialog();
                    this.Close();
                }

            }

            
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (Pass.Text == "")
            {
                Patient myForm = new Patient(Email.Text, Password);
                this.Hide();
                myForm.ShowDialog();
                this.Close();
            }
            else
            {
                Patient myForm = new Patient(Email.Text, Pass.Text);
                this.Hide();
                myForm.ShowDialog();
                this.Close();
            }
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
            if (ID1.Length != 16)
            {

                check[2] = false;
            }

            else if (ctrl.IDExist(ID1) != 0 && ID1 != Username)
            {
                check[2] = false;
            }

            else
            {
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
            else if (ctrl.EmailExist(Email.Text) != 0 && Email.Text != prevemail)
            {
                check[5] = false;
                emailerror.SetError(Email, "Email already exists");
            }
            else
            {
                emailerror.SetError(Email, "");
                check[5] = true;
            }
        }

        private void Pass_Validated(object sender, EventArgs e)
        {
            string Password = Pass.Text;
            if (!(Password.Any(char.IsLower) && Password.Any(char.IsUpper) && Password.Any(char.IsDigit) && Pass.Text.Length > 8))
            {

                passerror.SetError(Pass, "Make sure your Password contains 1 Upper Letter, 1 Lower Letter, 1 Digit and More than 8 Characters Long");
            }
            else
            {
                passerror.SetError(Pass, "");
            }

        }

        private void Pass2_Validated(object sender, EventArgs e)
        {
            if (Pass2.Text != Pass.Text)
            {

                pass2error.SetError(Pass2, "Make sure Both Passwords Match!");
            }
            else
            {
                pass2error.SetError(Pass2, "");
            }
        }

        private void Gender_Validating(object sender, CancelEventArgs e)
        {
            if (Gender.SelectedIndex == -1)
            {

                check[6] = false;
                gendererror.SetError(Gender, "Pick a Gender!");
            }
            else
            {
                gendererror.SetError(Gender, "");
                check[6] = true;
            }
        }

        private void Blood_type_Validated(object sender, EventArgs e)
        {
            if (Blood_type.SelectedIndex == -1)
            {

                check[7] = false;
                blooderror.SetError(Blood_type, "Pick a Blood Type!");
            }
            else
            {
                blooderror.SetError(Blood_type, "");
                check[7] = true;
            }
        }

        private void EditInfo_Load(object sender, EventArgs e)
        {

        }

        private void ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ID1.Text.ToString().Length >= 16)
            {
                if (!char.IsControl(e.KeyChar))
                    e.Handled = true;
            }
            else
            {
                if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                    e.Handled = true;
            }
        }

        private void Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Phone.Text.ToString().Length >= 16)
            {
                if (!char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void Emergency_Contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Emergency_Contact.Text.ToString().Length >= 16)
            {
                if (!char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
