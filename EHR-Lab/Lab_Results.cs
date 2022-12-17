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
using WindowsFormsApp1;

namespace EHR_Lab
{
    public partial class Lab_Results : Form
    {
        string id;
        int idlab;
        Controller ctrl;
        public Lab_Results(int idl, string idt)
        {
            InitializeComponent();
            id = idt;
            idlab = idl;
            ctrl = new Controller();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog() {Filter = "Image files(*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png)", Multiselect = false })
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                    textBox1.Text = ofd.FileName;
                }
            }
        }

        byte[] ConvertImageToBytes(Image img) { 
            using(MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        public Image ConvertByteArrayToImage(byte[] data)
        {
            using(MemoryStream ms = new MemoryStream())
            {
                return Image.FromStream(ms);
            }
        }

        private void Lab_Results_Load(object sender, EventArgs e)
        {
            DataTable dt = ctrl.getResults(idlab, id);
            kryptonDataGridView1.DataSource = dt;
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            DataTable dt = ctrl.getResults(idlab, id);
            DataRowCollection dt2 = dt.Rows;
            int x = ctrl.InsertLabResult(Convert.ToInt32(dt2[0][0]), ConvertImageToBytes(pictureBox1.Image));
        }

        private void kryptonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
