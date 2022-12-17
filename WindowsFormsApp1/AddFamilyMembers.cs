using System;
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
    public partial class AddFamilyMembers : Form
    {
        string id;
        Controller ctrl;
        public AddFamilyMembers(string idt)
        {
            InitializeComponent();
            ctrl = new Controller();
            id = idt;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            ctrl.InsertRelative(id, PatientID.Text);
            ctrl.InsertRelative(PatientID.Text, id);
            MessageBox.Show("Relative inserted successfully");
        }
    }
}
