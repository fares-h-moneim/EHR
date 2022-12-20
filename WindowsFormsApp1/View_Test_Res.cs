using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class View_Test_Res : Form
    {
        Controller ctrl;
        string ID;
        byte[] img;
        public View_Test_Res(string PatientID)
        {
            InitializeComponent();
            ID = PatientID;
            ctrl = new Controller();
            DataTable descriptions = ctrl.SelectDescriptions(PatientID);

            if(descriptions != null)
            {
                kryptonComboBox1.DataSource = descriptions;
                kryptonComboBox1.ValueMember = "Description";
                kryptonComboBox1.DisplayMember = "Description";
            }

            DataTable dt = ctrl.SelectLabDates(PatientID, kryptonComboBox1.SelectedValue.ToString());
            if (dt != null)
            {
                kryptonComboBox2.DataSource = dt;
                kryptonComboBox2.ValueMember = "ID";
                kryptonComboBox2.DisplayMember = "Date_Time";
            }
        }

        private void View_Test_Res_Load(object sender, EventArgs e)
        {

        }

        private void kryptonComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            DataTable dt = ctrl.SelectLabDates(ID, kryptonComboBox1.SelectedValue.ToString());
            if (dt != null)
            {
                kryptonComboBox2.DataSource = dt;
                kryptonComboBox2.ValueMember = "ID";
                kryptonComboBox2.DisplayMember = "Date_Time";
            }
        }

        private Image ConvertByteArrayToImage(byte[] data)
        {
            using(MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            
            if (kryptonComboBox1.SelectedValue != null && kryptonComboBox2.SelectedValue != null) {
                DataTable image = ctrl.GetResult(ID, kryptonComboBox1.SelectedValue.ToString(), kryptonComboBox2.SelectedValue.ToString());
                img = (byte[])image.Rows[0][4];

                pictureBox1.Image = ConvertByteArrayToImage(img);
            }
        }
    }
}
