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
        bool[] check = new bool[] { false, false, false, false, false, false, false, false, false, false };
        Controller ctrl = new Controller();
        string user;
        string prevemail;
        Patient parent;
        public EditInfo(string user, string pass, Patient form)
        {
            InitializeComponent();
            DataTable patient = ctrl.GetPatient(user, pass);
            parent = form;
            object sender = null;
            EventArgs e = new EventArgs();
            if (patient != null)
            {
                DataRowCollection dataRow = patient.Rows;

                First_Name.Text = dataRow[0][1].ToString();
                Last_Name.Text = dataRow[0][2].ToString();
                Email.Text = user;
                this.prevemail = user;
                Pass.Text = pass;
                Pass2.Text = pass;
                ID.Text = dataRow[0][0].ToString();
                this.user = dataRow[0][0].ToString();
                string gender;
                if (dataRow[0][6].ToString() == "0")
                {
                    Gender.Text = "Male";
                    gender = "Male";
                }
                else {
                    Gender.Text = "Female";
                    gender = "Female";
                }
                Emergency_Contact.Text = dataRow[0][8].ToString();
                Phone.Text = dataRow[0][5].ToString();
                Blood_type.Text = dataRow[0][7].ToString();

            }
        }



        private void Submit_Click(object sender, EventArgs e)
        {
            string gender = (Gender.Text == "Male") ? "0" : "1";
            DateTime now = DateTime.Now;
            string Today = now.Year.ToString();
            string B_Year = Birth_day.Value.Year.ToString();

            string Age = (Convert.ToInt32(Today) - Convert.ToInt32(B_Year)).ToString();
            int up = ctrl.UpdatePatient(user, ID.Text, First_Name.Text, Last_Name.Text, Email.Text, Pass.Text, gender, Age, Blood_type.Text, Phone.Text, Emergency_Contact.Text);

            bool submitvalid = true;
            for (int i = 0; i < 10; i++)
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
                parent.Refresh();
                submiterror.SetError(Submit, "");
                this.Hide();
                this.Close();
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (ID.Text.Length != 16)
            {

                check[2] = false;
                iderror.SetError(ID, "ID Must be 16 digits!");
            }

            else if (ctrl.IDExist(ID.Text) != 0 && ID.Text != user)
            {
                check[2] = false;
                iderror.SetError(ID, "ID Already exists");
            }

            else
            {
                iderror.SetError(ID, "");
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
            string password = Pass.Text;
            if (!(password.Any(char.IsLower) && password.Any(char.IsUpper) && password.Any(char.IsDigit) && Pass.Text.Length > 8))
            {

                check[6] = false;
                passerror.SetError(Pass, "Make sure your password contains 1 Upper Letter, 1 Lower Letter, 1 Digit and More than 8 Characters Long");
            }
            else
            {
                passerror.SetError(Pass, "");
                check[6] = true;
            }

        }

        private void Pass2_Validated(object sender, EventArgs e)
        {
            if (Pass2.Text != Pass.Text)
            {

                check[7] = false;
                pass2error.SetError(Pass2, "Make sure Both Passwords Match!");
            }
            else
            {
                pass2error.SetError(Pass2, "");
                check[7] = true;
            }
        }

        private void Gender_Validating(object sender, CancelEventArgs e)
        {
            if (Gender.SelectedIndex == -1)
            {

                check[8] = false;
                gendererror.SetError(Gender, "Pick a Gender!");
            }
            else
            {
                gendererror.SetError(Gender, "");
                check[8] = true;
            }
        }

        private void Blood_type_Validated(object sender, EventArgs e)
        {
            if (Blood_type.SelectedIndex == -1)
            {

                check[9] = false;
                blooderror.SetError(Blood_type, "Pick a Blood Type!");
            }
            else
            {
                blooderror.SetError(Blood_type, "");
                check[9] = true;
            }
        }
    }
}
