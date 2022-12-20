﻿using System;
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
            DataTable dt = ctrl.SelectDescriptions(id);
            kryptonComboBox1.DataSource = dt;
            kryptonComboBox1.DisplayMember = "Description";
            kryptonComboBox1.ValueMember = "Description";

            DataTable dt2 = ctrl.SelectLabDates(id, kryptonComboBox1.SelectedValue.ToString());
            kryptonComboBox2.DataSource = dt2;
            kryptonComboBox2.DisplayMember = "Date_Time";
            kryptonComboBox2.ValueMember = "ID";

            kryptonTextBox1.ReadOnly = true;
        }

        byte[] ConvertImageToBytes(Image img) { 
            using(MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog() {Filter = "Image files(*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png", Multiselect = false })
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                    kryptonTextBox1.Text = ofd.FileName;
                }
            }
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            int x = ctrl.InsertLabResult(Convert.ToInt32(kryptonComboBox2.SelectedValue), ConvertImageToBytes(pictureBox1.Image), idlab);
            if(x == 0)
            {
                MessageBox.Show("Failed");
            }
            else
            {
                MessageBox.Show("Success");
            }
        }

        private void kryptonComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            DataTable dt2 = ctrl.SelectLabDates(id, kryptonComboBox1.SelectedValue.ToString());
            kryptonComboBox2.DataSource = dt2;
            kryptonComboBox2.DisplayMember = "Date_Time";
            kryptonComboBox2.ValueMember = "ID";
        }
    }
}
