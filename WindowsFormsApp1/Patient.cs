using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp1
{
    public partial class Patient : Form
    {
        string user, pass;
        Controller ctrl;
        public Patient(string email, string password)
        {
            InitializeComponent();
            user = email;
            pass = password;
            ctrl = new Controller();
            DataTable patient = ctrl.GetPatient(user, pass);


            if (patient != null)
            {
                DataRowCollection dataRow = patient.Rows;

                Hello.Text = "Hello " + dataRow[0][1].ToString() + "!";
                Email.Text = "Email: " + dataRow[0][3].ToString();
                Phone.Text = "Phone #: " + dataRow[0][5].ToString();
                Blood.Text = "Blood Type: " + dataRow[0][7].ToString();
                Birthday.Text = "Age: " + dataRow[0][9];
                string gender;
                if (dataRow[0][6].ToString() == "0")
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                Gender.Text = "Gender: " + gender;

            }

        }

        public void RefreshOnSave(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void EditUserDetails_Click(object sender, EventArgs e)
        {
            EditInfo myForm = new EditInfo(user, pass, this);
            myForm.ShowDialog();
        }

        private void Hospital_Click(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(255, 87, 139, 255);
            img1.StateNormal.Border.Color1 = color;
            img1.StateNormal.Border.Color2 = color;
            img1.StateNormal.Border.Width = 5;
            img1.StateNormal.Border.Rounding = 25;
            img1.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;

            img2.StateNormal.Border.Width = 0;
            img3.StateNormal.Border.Width = 0;
            img4.StateNormal.Border.Width = 0;
            img5.StateNormal.Border.Width = 0;
            img6.StateNormal.Border.Width = 0;

            Hospital.Text = "";
            Pharmacy.Text = "View Prescriptions";
            Labs.Text = "View Lab Results";
            Family.Text = "Add Family Members";
            Organs.Text = "Apply for Organ Donation";
            Surgery.Text = "View Surgeries";
            DataTable patient = ctrl.GetPatient(user, pass);
            DataRowCollection dataRow = patient.Rows;

            View_History myForm = new View_History(dataRow[0][0].ToString());
            myForm.ShowDialog();

        }

        private void Labs_Click(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(255, 87, 139, 255);
            img2.StateNormal.Border.Color1 = color;
            img2.StateNormal.Border.Color2 = color;
            img2.StateNormal.Border.Width = 5;
            img2.StateNormal.Border.Rounding = 25;
            img2.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;

            img1.StateNormal.Border.Width = 0;
            img3.StateNormal.Border.Width = 0;
            img4.StateNormal.Border.Width = 0;
            img5.StateNormal.Border.Width = 0;
            img6.StateNormal.Border.Width = 0;

            Labs.Text = "";
            Hospital.Text = "View Medical History";
            Pharmacy.Text = "View Prescriptions";
            Family.Text = "Add Family Members";
            Organs.Text = "Apply for Organ Donation";
            Surgery.Text = "View Surgeries";
        }

        private void Pharmacy_Click(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(255, 87, 139, 255);
            img3.StateNormal.Border.Color1 = color;
            img3.StateNormal.Border.Color2 = color;
            img3.StateNormal.Border.Width = 5;
            img3.StateNormal.Border.Rounding = 25;
            img3.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;

            img1.StateNormal.Border.Width = 0;
            img2.StateNormal.Border.Width = 0;
            img4.StateNormal.Border.Width = 0;
            img5.StateNormal.Border.Width = 0;
            img6.StateNormal.Border.Width = 0;

            Pharmacy.Text = "";
            Hospital.Text = "View Medical History";
            Labs.Text = "View Lab Results";
            Family.Text = "Add Family Members";
            Organs.Text = "Apply for Organ Donation";
            Surgery.Text = "View Surgeries";

            DataTable patient = ctrl.GetPatient(user, pass);
            DataRowCollection dataRow = patient.Rows;

            View_Prescriptions myForm = new View_Prescriptions(dataRow[0][0].ToString());
            myForm.ShowDialog();
        }

        private void Family_Click(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(255, 87, 139, 255);
            img4.StateNormal.Border.Color1 = color;
            img4.StateNormal.Border.Color2 = color;
            img4.StateNormal.Border.Width = 5;
            img4.StateNormal.Border.Rounding = 25;
            img4.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;

            img1.StateNormal.Border.Width = 0;
            img2.StateNormal.Border.Width = 0;
            img3.StateNormal.Border.Width = 0;
            img5.StateNormal.Border.Width = 0;
            img6.StateNormal.Border.Width = 0;

            Family.Text = "";
            Hospital.Text = "View Medical History";
            Labs.Text = "View Lab Results";
            Pharmacy.Text = "View Prescriptions";
            Organs.Text = "Apply for Organ Donation";
            Surgery.Text = "View Surgeries";
            DataTable patient = ctrl.GetPatient(user, pass);
            DataRowCollection dataRow = patient.Rows;

            AddFamilyMembers myForm = new AddFamilyMembers(dataRow[0][0].ToString());
            myForm.ShowDialog();
        }

        private void Avatar_Click(object sender, EventArgs e)
        {

        }

        private void Hello_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Patient_Load(object sender, EventArgs e)
        {
            
        }

        private void kryptonLabel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void img6_Click(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(255, 87, 139, 255);
            img6.StateNormal.Border.Color1 = color;
            img6.StateNormal.Border.Color2 = color;
            img6.StateNormal.Border.Width = 5;
            img6.StateNormal.Border.Rounding = 25;
            img6.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;

            img1.StateNormal.Border.Width = 0;
            img2.StateNormal.Border.Width = 0;
            img3.StateNormal.Border.Width = 0;
            img4.StateNormal.Border.Width = 0;
            img5.StateNormal.Border.Width = 0;

            Surgery.Text = "";
            Hospital.Text = "View Medical History";
            Labs.Text = "View Lab Results";
            Pharmacy.Text = "View Prescriptions";
            Family.Text = "Add Family Members";
            Organs.Text = "Apply for Organ Donation";

            DataTable patient = ctrl.GetPatient(user, pass);
            DataRowCollection dataRow = patient.Rows;


            View_Surgeries myForm = new View_Surgeries(dataRow[0][0].ToString());
            myForm.ShowDialog();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            SignIn SI = new SignIn();

            this.Close();
            SI.ShowDialog();

        }

        private void Organs_Click(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(255, 87, 139, 255);
            img5.StateNormal.Border.Color1 = color;
            img5.StateNormal.Border.Color2 = color;
            img5.StateNormal.Border.Width = 5;
            img5.StateNormal.Border.Rounding = 25;
            img5.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;

            img1.StateNormal.Border.Width = 0;
            img2.StateNormal.Border.Width = 0;
            img3.StateNormal.Border.Width = 0;
            img4.StateNormal.Border.Width = 0;
            img6.StateNormal.Border.Width = 0;

            Organs.Text = "";
            Hospital.Text = "View Medical History";
            Labs.Text = "View Lab Results";
            Pharmacy.Text = "View Prescriptions";
            Family.Text = "Add Family Members";
            Surgery.Text = "View Surgeries";
            DataTable patient = ctrl.GetPatient(user, pass);
            DataRowCollection dataRow = patient.Rows;

            

            Apply_Organ myForm = new Apply_Organ(dataRow[0][0].ToString());
            myForm.ShowDialog();
        }
    }
}
