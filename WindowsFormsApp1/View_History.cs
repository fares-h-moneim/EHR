﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class View_History : Form
    {
        Controller ctrl;
        string id;
        public View_History(string idt)
        {
            InitializeComponent();
            id = idt;
            ctrl = new Controller();
        }

        private void View_History_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            DataTable dt = ctrl.viewmedicalhistory(kryptonDateTimePicker1.Value.ToShortTimeString(), kryptonDateTimePicker2.Value.ToString(), id);
            kryptonDataGridView1.DataSource = dt;
        }
    }
}
