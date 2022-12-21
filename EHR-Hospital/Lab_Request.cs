﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EHR_Hospital
{
    public partial class Lab_Request : Form
    {
        Controller ctrl;
        public Lab_Request()
        {
            InitializeComponent();
            ctrl = new Controller();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            string format = "yyyy-MM-dd HH:mm:ss";
            if (PatientID.Text != "" && Description.Text != "")
            {
                int res = ctrl.InsertLabTest(PatientID.Text, DateTime.Now.ToString(format), Description.Text);

                if(res == 0)
                {
                    MessageBox.Show("Patient ID does not exist");
                }
                else
                {
                    MessageBox.Show("Inserted Successfully");
                }
            }
            else
            {
                MessageBox.Show("Make sure to fill all the fields");
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}