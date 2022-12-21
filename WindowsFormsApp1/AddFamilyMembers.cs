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

        private void AddFamilyMembers_Load(object sender, EventArgs e)
        {

        }

        private void View_Click(object sender, EventArgs e)
        {
            View_Family myForm = new View_Family(id);
            myForm.ShowDialog();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Add_Family myForm = new Add_Family(id);
            myForm.ShowDialog();
        }

        private void Req_Click(object sender, EventArgs e)
        {
            Check_Family myForm = new Check_Family(id);
            myForm.ShowDialog();
        }
    }
}
