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
    public partial class Form6 : Form
    {
        List<process> processes;
        memory memory;
        public Form6(List<process> p, memory m)
        {
            InitializeComponent();
            processes = p;
            memory = m;
            memory.calulate_memory_processes();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            int i = 0;
            //Processes in waiting state
            foreach (process p in processes)
            {
                Label lbl = new Label();
                lbl.BackColor = p.get_color();
                lbl.Size = new Size(100, 30);
                lbl.Location = new Point(5, (40 * i));
                lbl.Text = "Process" + p.get_index().ToString();
                lbl.Name = "process" + p.get_index().ToString();
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lst_process.Controls.Add(lbl);

                Button btn = new Button();
                btn.Size = new Size(50, 30);
                btn.Location = new Point(120, (40 * i));
                btn.Text = "Add";
                btn.Click += (sender2, e2) => add_to_memory(sender2, e2, lbl, p);
                lst_process.Controls.Add(btn);

                i++;
            }
            //Drawing holes and processes  in memory
            memory_draw();
            firstfit.Checked = true;
        }

        private void home_Click(object sender, EventArgs e)
        {
            frm_number_of_processes frm = new frm_number_of_processes();
            Visible = false;
            frm.ShowDialog();
            Close();
        }

        private void add_to_memory(object sender, EventArgs e, Label lbl, process p)
        {
            Button b = sender as Button;
            //sorting descendingly according to size:: try ex p=50,100,200 ;holes sizes=300,100,100;it will not work
            ////// p.segments_sort_desc();///ES2L FEEHA
            //renew the holes list and current process in memory Clear the memory panel and then draw it again
            if (p.get_size() > memory.get_total_empty_space())
            {
                MessageBox.Show("Process" + p.get_index().ToString() + " cannot be added to memory");
                return;
            }
            //Colning the memory because the defalult assign is by referance in c# ex:memory temp=memory => if we change temp the memory will change  due to copying by referrence

            if (firstfit.Checked == true)
            {
                memory temp = memory.copy();
                foreach (segment s in p.get_segments())
                {
                    int success = 0;
                    foreach (hole h in temp.get_holes())
                    {
                        if (h.get_size() >= s.get_size())
                        {
                            hole np = new hole(s.get_size(), h.get_start_location());
                            np.set_color(s.get_color());
                            np.set_text(s.get_text());
                            temp.add_process(np);

                            h.set_size(h.get_size() - s.get_size());
                            h.set_start_location(h.get_start_location() + s.get_size());
                            success = 1;
                            break;
                        }
                    }
                    if (success == 0)
                    {
                        MessageBox.Show("Process cannot be added to memory");
                        return;
                    }
                }
                memory = temp;
                lst_memory.Controls.Clear();
                memory_draw();
                /*if added successfully  remove the process from wait list*/
                b.Enabled = false;
                lbl.Enabled = false;
                b.Hide();
                lbl.Hide();
                /**END OF FIRST FIT*/
            }
            else if (bestfit.Checked == true)
            {
                memory temp = memory;
                bool check = false;
                List<bool> x = new List<bool>();
                for (int i = 0; i < temp.get_number_holes_after_merge(); i++)
                    x.Add(true);

                temp.arrange_memory_ascending_size();
                foreach (segment s in p.get_segments())
                {
                    int i = 0;
                    foreach (hole h in temp.get_holes())
                    {
                        if (x[i])
                        {
                            if (s.get_size() > h.get_size()) { check = false; continue; }
                            else
                            {
                                x[i] = false;
                                check = true;
                                break;
                            }
                        }
                        i++;
                    }
                }
                if (check)
                {
                    foreach (segment s in p.get_segments())
                    {
                        foreach (hole h in temp.get_holes())
                        {
                            if (s.get_size() > h.get_size()) continue;
                            else
                            {
                                hole get_in = new hole(s.get_size(), h.get_start_location());
                                get_in.set_color(s.get_color());
                                get_in.set_text(s.get_text());
                                    h.set_size(h.get_size() - s.get_size());
                                    h.set_start_location(h.get_start_location() + s.get_size());
                                    
                                temp.add_process(get_in);
                                break;
                            }
                        }
                    }
                    temp.merge_holes();
                }
                else
                {
                    MessageBox.Show("Process cannot be added to memory");
                    return;
                }
                memory = temp;
                lst_memory.Controls.Clear();
                memory_draw();
                b.Enabled = false;
                lbl.Enabled = false;
                b.Hide();
                lbl.Hide();
            }
            else if (worstfit.Checked == true)
            {
                memory temp = memory;
                bool check = false;
                List<bool> x = new List<bool>();
                for (int i = 0; i < temp.get_number_holes_after_merge(); i++)
                    x.Add(true);

                temp.arrange_memory_descending_size();
                foreach (segment s in p.get_segments())
                {
                    int i = 0;
                    foreach (hole h in temp.get_holes())
                    {
                        if (x[i])
                        {
                            if (s.get_size() > h.get_size()) { check = false; continue; }
                            else
                            {
                                x[i] = false;
                                check = true;
                                break;
                            }
                        }
                        i++;
                    }
                }
                if (check)
                {
                    foreach (segment s in p.get_segments())
                    {
                        foreach (hole h in temp.get_holes())
                        {
                            if (s.get_size() > h.get_size()) continue;
                            else
                            {
                                hole get_in = new hole(s.get_size(), h.get_start_location());
                                get_in.set_color(s.get_color());
                                get_in.set_text(s.get_text());
                                h.set_size(h.get_size() - s.get_size());
                                h.set_start_location(h.get_start_location() + s.get_size());

                                temp.add_process(get_in);
                                break;
                            }
                        }
                    }
                    temp.merge_holes();
                }
                else
                {
                    MessageBox.Show("Process cannot be added to memory");
                    return;
                }
                memory = temp;
                lst_memory.Controls.Clear();
                memory_draw();
                b.Enabled = false;
                lbl.Enabled = false;
                b.Hide();
                lbl.Hide();

            }
        }
        private void remove_from_memory(object sender, EventArgs e, Panel p, hole h)
        {
            Label lbl = sender as Label;
            int pos = p.VerticalScroll.Value;
            //p.clear and then change the holes and then merge adjecent holes and the draw again
            p.Controls.Clear();
            if (h.get_color() == Color.Black)
            {
                int index = memory.search_process(h);
                memory.add_hole(h);
                memory.remove_process(index);
                memory.merge_holes();
            }
            else  {
                int count = memory.get_memory_processes().Count;
                for (int j = 0; j < count;j++)
                {
                    List<hole> t = memory.get_memory_processes();
                    hole q = t[j];
                    if (q.get_color() == h.get_color())
                    {
                        int index = memory.search_process(q);
                        memory.add_hole(q);
                        memory.remove_process(index);
                        memory.merge_holes();
                        j--;
                        count--;
                    }
                }
            }
            memory_draw();
            p.VerticalScroll.Value = pos;
        //    MessageBox.Show("Process has been removed successfully");
        }


        private void memory_draw()
        {

            label2.Text = "Memory     -Free Size:" + memory.get_total_empty_space().ToString();
            //drawing holes
            foreach (hole h in memory.get_holes())
            {
                Label lbl = new Label();
                lbl.BackColor = Color.White;
                lbl.Size = new Size(120, h.get_size());
                lbl.Location = new Point(40, h.get_start_location());
                lst_memory.Controls.Add(lbl);

                //postion of hole
                Label lbl2 = new Label();
                lbl2.Size = new Size(40, 13);
                lbl2.Location = new Point(0, h.get_start_location());
                lbl2.Text = h.get_start_location().ToString();
                lst_memory.Controls.Add(lbl2);
            }

            int index = 0;
            //Drawing old processes in memoey
            foreach (hole h in memory.get_memory_processes())
            {
                Label lbl = new Label();
                lbl.BackColor = h.get_color();
                lbl.Text = h.get_text();
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.Size = new Size(120, h.get_size());
                lbl.Location = new Point(40, h.get_start_location());
                lbl.BorderStyle = BorderStyle.Fixed3D;
                lbl.Click += (sender2, e2) => remove_from_memory(sender2, e2, lst_memory, h);
                lst_memory.Controls.Add(lbl);

                //postion of hole
                Label lbl2 = new Label();
                lbl2.Size = new Size(40, 13);
                lbl2.Location = new Point(0, h.get_start_location());
                lbl2.Text = h.get_start_location().ToString();
                lst_memory.Controls.Add(lbl2);
                index++;
            }
            //Last index in memory  (memory size)
            Label lbl3 = new Label();
            lbl3.Size = new Size(40, 13);
            lbl3.Location = new Point(0, memory.get_size());
            lbl3.Text = memory.get_size().ToString();
            lst_memory.Controls.Add(lbl3);
        }
    }
}

