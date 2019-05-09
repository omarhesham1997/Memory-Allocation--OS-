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
    public partial class Form4 : Form
    {
        List<process> processes;
        public Form4(List<process>p)
        {
            InitializeComponent();
            processes = p;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.Location = new Point(200, 200);
        }

        private void btn_to_form5_Click(object sender, EventArgs e)
        {
            string s=txt_memory_size.Text;int test;
            
            if (s == null || int.TryParse(s, out test) == false || int.Parse(s) == 0)
            {
                MessageBox.Show("enter a valid number");
                return;
            }
            s = txt_number_of_holes.Text;
            if (s == null || int.TryParse(s, out test) == false || int.Parse(s) <= 0)
            {
                MessageBox.Show("enter a valid number");
                return;
            }
            memory memory = new memory(int.Parse(txt_memory_size.Text),int.Parse(txt_number_of_holes.Text));

            Form5 frm = new Form5(memory,processes);
            Visible = false;
            frm.ShowDialog();
            Close();
        }

        private void back_form3_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3(processes);
            Visible = false;
            frm.ShowDialog();
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
