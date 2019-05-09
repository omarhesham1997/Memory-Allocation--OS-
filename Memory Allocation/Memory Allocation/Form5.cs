using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory_Allocation;

namespace Memory_Allocation
{
    public partial class Form5 : Form
    {
        memory memory; List<process> processes;
        Dictionary<int, List<TextBox>> holes=new Dictionary<int, List<TextBox>>();

        public Form5(memory m,List<process> p)
        {
            InitializeComponent();
            memory = m;
            processes = p;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.Location = new Point(200, 200);
          
            for (int i = 0; i < memory.get_initial_number_of_holes(); i++)
            { 
                
                List<TextBox>t=new List<TextBox>();

                Label lbl = new Label();
                lbl.Text = "Hole" + (i + 1).ToString();
                lbl.Location = new Point(0, 30* i);
                lbl.Size = new Size(49, 25);
                panel1.Controls.Add(lbl);

                TextBox txt = new TextBox();
                txt.Text = "Location";
                txt.Location = new Point(70, 30 * i);
                txt.Size = new Size(49, 25);
                panel1.Controls.Add(txt);
                t.Add(txt);

                TextBox txt1 = new TextBox();
                txt1.Text = "Size";
                txt1.Location = new Point(150, 30 * i);
                txt1.Size = new Size(49, 25);
                panel1.Controls.Add(txt1);
                t.Add(txt1);

                holes.Add(i + 1, t);
            }
        }

        private void btn_to_form5_Click(object sender, EventArgs e)
        {
            bool success=true;
            int index = 1;
            foreach( KeyValuePair<int, List<TextBox>> h in holes)
            {
                int location;
                int size;
                int test;
              
                string s;

                s = (h.Value[0].Text);
                if (s == null || int.TryParse(s, out test) == false)
                {
                    MessageBox.Show("Please enter a valid number\n" + "\t Hole" + index.ToString() + " Location");
                    success = false;
                    break;
                }
                location = int.Parse(s);

                 s = (h.Value[1].Text);
                if (s == null || int.TryParse(s, out test) == false || int.Parse(s) == 0)
                {
                    MessageBox.Show("Please enter a valid number\n" + "\t Hole" + index.ToString()+" Size");
                    success = false;
                    break;
                }

                size = int.Parse(s);
             
                hole nh = new hole(size,location );
                if (nh.get_size() + nh.get_start_location() > memory.get_size())
                {
                    MessageBox.Show("\t      ERROR \n  Hole"+index.ToString()+" is Outside than memory space");     
                    return;
                }
                memory.add_hole(nh);
                index++;
            }
            memory.merge_holes();
            if (memory.get_total_empty_space() > memory.get_size())
            {
                MessageBox.Show("\t       ERROR \n Size of Holes is greater than memory size");              
                return;

            }
            if (success)
            {
                Form6 frm = new Form6(processes, memory);
                Visible = false;
                frm.ShowDialog();
                Close();
            }
        }

        private void back_form3_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4(processes);
            Visible = false;
            frm.ShowDialog();
            Close();
        }
    }
}