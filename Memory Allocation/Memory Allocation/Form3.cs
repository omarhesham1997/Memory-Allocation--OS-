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
    public partial class Form3 : Form
    {
        int number_of_processes;
        List<process> processes;
        Dictionary<int, List<Tuple<TextBox, TextBox>>> segments_size = new Dictionary<int, List<Tuple<TextBox, TextBox>>>();
      //  Dictionary<int, List<TextBox>> segments_text = new Dictionary<int, List<TextBox>>();

        public Form3(List<process> processes)
        {
            InitializeComponent();
            number_of_processes = processes.Count;
            this.processes = processes;
        }


        private void Form3_Load(object sender, EventArgs e)
        {
         
            int pointY_grp = 0;
            this.Location = new Point(200, 200);
            foreach (process p in processes)
            {
                List<Tuple<TextBox, TextBox>> temp = new List<Tuple<TextBox, TextBox>>();
            

                GroupBox grp = new GroupBox();
                grp.Name = "Process " + (p.get_index()).ToString() + ":";
                grp.Text = "Process " + (p.get_index()).ToString().ToString() + ":";
                grp.Location = new Point(20, pointY_grp);
                grp.ForeColor = p.get_color();
                grp.AutoSize = true;
                int pointY_lbl = 0;

                for (int i = 1; i <= p.get_number_segments(); i++)
                {
  
                    Label lbl_segment = new Label();
                    lbl_segment.Text = "Segment" + i.ToString() + " :";
                    lbl_segment.Location = new Point(5, 35 * i);
                    lbl_segment.Size = new Size(80, 20);
                    grp.Controls.Add(lbl_segment);

                    TextBox txt_segment_text = new TextBox();
                    txt_segment_text.Location = new Point(90, 35 * i);
                    txt_segment_text.Size = new Size(60, 20);
                    txt_segment_text.Name = "txt_segment_text" + i.ToString();
                    txt_segment_text.Text = "Segment " + i.ToString();
                    grp.Controls.Add(txt_segment_text);

                    TextBox txt_segment_size = new TextBox();
                    txt_segment_size.Location = new Point(160, 35 * i);
                    txt_segment_size.Size = new Size(50, 20);
                    txt_segment_size.Name = "txt_segment_size" + i.ToString();
                    txt_segment_size.Text = "Size";
                    grp.Controls.Add(txt_segment_size);

                    pointY_lbl += 35;

                    Tuple<TextBox, TextBox> tp = new Tuple<TextBox, TextBox>(txt_segment_size, txt_segment_text);
                    temp.Add(tp);

                }
                segments_size.Add(p.get_index(), temp);
                pointY_grp += pointY_lbl + 65;
                panel_of_processes.Controls.Add(grp);
            }
        }

        private void back_form2_Click(object sender, EventArgs e)
        {
            processes.Clear();
            segments_size.Clear();
            Form2 frm = new Form2(number_of_processes);
            Visible = false;
            frm.ShowDialog();
            Close();
        }

        private void btn_to_form4_Click(object sender, EventArgs e)
        {
            bool success = true;
       
            foreach (KeyValuePair<int, List<Tuple<TextBox,TextBox>>> element in segments_size)
            {
                int index = element.Key;
                int test;
                for (int i = 0; i < processes[index - 1].get_number_segments(); i++)
                {
                    string s = element.Value[i].Item1.Text;
                    string name = element.Value[i].Item2.Text;
                    if (s == null || int.TryParse(s, out test) == false || int.Parse(s) <= 0)
                    {
                        MessageBox.Show("Please enter a valid number\n" + "Processs" + index.ToString() + " :Segment" + (i + 1).ToString());
                        success = false;
                        processes[index - 1].clear_segments();
                        break;
                    }

                    else if (name=="")
                    {
                        MessageBox.Show("Please enter a valid Name\n" + "Processs" + index.ToString() + " :Segment" + (i + 1).ToString());
                        success = false;
                        processes[index - 1].clear_segments();
                        break;
                    }

                    else
                    {
                        segment q = new segment(processes[index - 1], int.Parse(element.Value[i].Item1.Text), processes[index - 1].get_color());
                        q.set_index(i+1);
                        q.set_text(name);
                        processes[index - 1].add_segment(q);
                    }


                }
                if (!success ) break;
            }

          

            if (success)
            {
                Form4 frm = new Form4(processes);
                Visible = false;
                frm.ShowDialog();
                Close();
            }
        }
    }
}