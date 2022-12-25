using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace EHR_Hospital
{
    public partial class Patient_History_Bg : Form
    {
        Controller ctrl = new Controller();
        DataTable dt;
        bool islab = false;
        public Patient_History_Bg()
        {
            InitializeComponent();

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            dt = null;
            if (Request.Text == "Chronic Disease")
            {
                dt = ctrl.GetChronic(PatientID.Text);
                islab = false;
            }
            else if (Request.Text == "Diagnosis")
            {
                dt = ctrl.GetDiagnosis(PatientID.Text);
                islab = false;
            }
            else if (Request.Text == "Prescriptions")
            {
                dt = ctrl.GetPrescriptions(PatientID.Text);
                islab = false;
            }
            else if (Request.Text == "Surgeries")
            {
                dt = ctrl.GetSurgeries(PatientID.Text);
                islab = false;
            }
            else if (Request.Text == "Family Members")
            {
                dt = ctrl.GetRelativesChronic(PatientID.Text);
                islab = false;
            }
            else
            {
                if (Request.Text != "")
                    dt = ctrl.GetLabs(PatientID.Text);
                islab = true;
            }

            kryptonDataGridView1.DataSource = dt;
            kryptonDataGridView1.Refresh();
            if (PatientID.Text.Length<=15)
            {
                MessageBox.Show("fill the patient id field correctly");
            }

        }

        private void Patient_History_Bg_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Request_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kryptonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PatientID_TextChanged(object sender, EventArgs e)
        {

        }

        private void PatientID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (PatientID.Text.ToString().Length >= 16)
            {
                if (!char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
        private Image ConvertByteArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
        private void kryptonDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1&&Request.Text== "Lab Results"&&islab)
            {
                 Image img = ConvertByteArrayToImage((byte[])dt.Rows[e.RowIndex][e.ColumnIndex]);
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.Filter = "JPeg Image|.jpg|Bitmap Image|.bmp|Gif Image|*.gif";
                    saveFileDialog1.Title = "Save an Image File";
                    saveFileDialog1.ShowDialog();

                    // If the file name is not an empty string open it for saving.
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
                                img.Save(fs,
                                  System.Drawing.Imaging.ImageFormat.Jpeg);
                                break;

                            case 2:
                                img.Save(fs,
                                  System.Drawing.Imaging.ImageFormat.Bmp);
                                break;

                            case 3:
                                img.Save(fs,
                                  System.Drawing.Imaging.ImageFormat.Gif);
                                break;
                        }

                        fs.Close();
                    }

                
                    
                
               
            }
        }
    }
}

