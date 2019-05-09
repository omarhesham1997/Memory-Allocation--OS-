using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Allocation
{
    public partial class frm_number_of_processes : Form
    {
        int number_of_processes;
        public frm_number_of_processes()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(200, 200);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int test;
            if (txt_number_of_processes.Text == null ||int.TryParse(txt_number_of_processes.Text,out test)==false)
                MessageBox.Show("Please enter number of proccesses");
            else if (int.Parse(txt_number_of_processes.Text)<=0)
            {
                MessageBox.Show("Please enter number of proccesses");
            }
            else
            {
                number_of_processes = int.Parse(txt_number_of_processes.Text);
                Form2 frm = new Form2(number_of_processes);
                Visible = false;
                frm.ShowDialog();
                Close();
            }

        }
    }
}



