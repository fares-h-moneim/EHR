using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
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

            DataTable dt = null;
            if (kryptonComboBox1.SelectedValue != null)
            {
                dt = ctrl.SelectLabDates(PatientID, kryptonComboBox1.SelectedValue.ToString());
                if (dt != null)
                {
                    kryptonComboBox2.DataSource = dt;
                    kryptonComboBox2.ValueMember = "ID";
                    kryptonComboBox2.DisplayMember = "Date_Time";
                }
            }
            kryptonButton3.Enabled = false;
            kryptonButton2.Enabled = false;
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

        private void button2_Click(object sender, System.EventArgs e)
        {
            
        }

        private void myPrintDocument2_PrintPage(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap myBitmap1 = new Bitmap(pictureBox1.Width*7, pictureBox1.Height*7);
            pictureBox1.DrawToBitmap(myBitmap1, new Rectangle(0, 0, pictureBox1.Width*7, pictureBox1.Height * 7));
            e.Graphics.DrawImage(myBitmap1, 0, 0);
            myBitmap1.Dispose();
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

                kryptonButton3.Enabled = true;
                kryptonButton2.Enabled = true;
            }

            if(pictureBox1.Image == null)
            {
                kryptonButton3.Enabled = false;
                kryptonButton2.Enabled = false;
            }
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            System.Drawing.Printing.PrintDocument myPrintDocument1 = new System.Drawing.Printing.PrintDocument();
            PrintDialog myPrinDialog1 = new PrintDialog();
            myPrintDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(myPrintDocument2_PrintPage);
            myPrinDialog1.Document = myPrintDocument1;
            if (myPrinDialog1.ShowDialog() == DialogResult.OK)
            {
                myPrintDocument1.Print();
            }
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            // Displays a SaveFileDialog so the Username can save the Image
            // assigned to Button2.
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPeg Image|.jpg|Bitmap Image|.bmp|Gif Image|*.gif";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();

            // If the file Name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                System.IO.FileStream fs =
                    (System.IO.FileStream)saveFileDialog1.OpenFile();
                // Saves the Image in the appropriate ImageFormat based upon the
                // File type selected in the dialog box.
                // NOTE that the FilterIndex property is one-based.
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        this.pictureBox1.Image.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        this.pictureBox1.Image.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        this.pictureBox1.Image.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }

                fs.Close();
            }
        }
    }
}
