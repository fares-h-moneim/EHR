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
            Hospital.StateNormal.Border.Color1 = color;
            Hospital.StateNormal.Border.Color2 = color;
            Hospital.StateNormal.Border.Width = 5;
            Hospital.StateNormal.Border.Rounding = 25;
            Hospital.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;

            Labs.StateNormal.Border.Width = 0;
            Pharmacy.StateNormal.Border.Width = 0;
            Family.StateNormal.Border.Width = 0;
            Organs.StateNormal.Border.Width = 0;

        }

        private void Labs_Click(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(255, 87, 139, 255);
            Labs.StateNormal.Border.Color1 = color;
            Labs.StateNormal.Border.Color2 = color;
            Labs.StateNormal.Border.Width = 5;
            Labs.StateNormal.Border.Rounding = 25;
            Labs.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;

            Hospital.StateNormal.Border.Width = 0;
            Pharmacy.StateNormal.Border.Width = 0;
            Family.StateNormal.Border.Width = 0;
            Organs.StateNormal.Border.Width = 0;
        }

        private void Pharmacy_Click(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(255, 87, 139, 255);
            Pharmacy.StateNormal.Border.Color1 = color;
            Pharmacy.StateNormal.Border.Color2 = color;
            Pharmacy.StateNormal.Border.Width = 5;
            Pharmacy.StateNormal.Border.Rounding = 25;
            Pharmacy.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;

            Hospital.StateNormal.Border.Width = 0;
            Labs.StateNormal.Border.Width = 0;
            Family.StateNormal.Border.Width = 0;
            Organs.StateNormal.Border.Width = 0;
        }

        private void Family_Click(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(255, 87, 139, 255);
            Family.StateNormal.Border.Color1 = color;
            Family.StateNormal.Border.Color2 = color;
            Family.StateNormal.Border.Width = 5;
            Family.StateNormal.Border.Rounding = 25;
            Family.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;

            Hospital.StateNormal.Border.Width = 0;
            Labs.StateNormal.Border.Width = 0;
            Pharmacy.StateNormal.Border.Width = 0;
            Organs.StateNormal.Border.Width = 0;
        }

        private void Avatar_Click(object sender, EventArgs e)
        {

        }

        private void Hello_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Patient_Load(object sender, EventArgs e)
        {
            DataTable patient = ctrl.GetPatient(user, pass);


            if (patient != null)
            {
                DataRowCollection dataRow = patient.Rows;

                Hello.Text = "Hello " + dataRow[0][1].ToString() + "!";
                Email.Text = "Email: " + dataRow[0][3].ToString();
                Phone.Text = "Phone #: " + dataRow[0][5].ToString();
                Blood.Text = "Blood Type: " + dataRow[0][7].ToString();
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

        private void Organs_Click(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(255, 87, 139, 255);
            Organs.StateNormal.Border.Color1 = color;
            Organs.StateNormal.Border.Color2 = color;
            Organs.StateNormal.Border.Width = 5;
            Organs.StateNormal.Border.Rounding = 25;
            Organs.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;

            Hospital.StateNormal.Border.Width = 0;
            Labs.StateNormal.Border.Width = 0;
            Pharmacy.StateNormal.Border.Width = 0;
            Family.StateNormal.Border.Width = 0;
        }
    }
}
