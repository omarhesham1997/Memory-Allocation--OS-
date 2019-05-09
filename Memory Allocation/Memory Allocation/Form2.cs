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
    public partial class Form2 : Form
    {
        public Form2(int n)
        {
            InitializeComponent();
            txt_number_of_processes.Enabled = false;
            txt_number_of_processes.Text = n.ToString();
        }

        Dictionary<int, TextBox> number_of_segments = new Dictionary<int, TextBox>();
        public List<process> processes=new List<process>();

        private void Form2_Load(object sender, EventArgs e)
        {
            int number_processes = int.Parse(txt_number_of_processes.Text);
            this.Location = new Point(200, 200);
            number_of_segments.Clear();
            processes.Clear();
            for (int i = 1; i <= number_processes; i++)
            {
                GroupBox grp = new GroupBox();
                grp.Name = "Process " + (i).ToString() + ":";
                grp.Text = "Process " + (i).ToString() + ":";
                grp.Size = new Size(200, 80);
                grp.Location = new Point(20, 100 * (i-1));

                Label lbl_number_of_segments = new Label();
                lbl_number_of_segments.Text = "Number of Segments: ";
                lbl_number_of_segments.Location = new Point(5, 25);
                lbl_number_of_segments.Size = new Size(300, 20);
                grp.Controls.Add(lbl_number_of_segments);

                TextBox txt_number_of_segments = new TextBox();
                txt_number_of_segments.Location = new Point(5, 50);
                txt_number_of_segments.Size = new Size(100, 10);
                txt_number_of_segments.Name = "txt_number_of_segments" + i.ToString();
                number_of_segments.Add(i, txt_number_of_segments);
                grp.Controls.Add(txt_number_of_segments); 

                panel_of_processes.Controls.Add(grp);
            }
        }

        private void back_form1_Click(object sender, EventArgs e)
        {
            frm_number_of_processes frm = new frm_number_of_processes();
            Visible = false;
            frm.ShowDialog();
            Close();
        }

        private void btn_to_form3_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int success = 1;
               foreach (KeyValuePair<int, TextBox> element in number_of_segments)
            {
                   string s=element.Value.Text;
                   int test;
                   if (s == null || int.TryParse(s, out test) == false || int.Parse(s) <= 0)
                   {
                       MessageBox.Show("Please enter a valid number \n \tProcess"+element.Key.ToString());
                       success = 0;
                       processes.Clear();
                       break;
                   }

                   else
                   {
                       processes.Add(new process(element.Key, int.Parse(s),
                       Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255))));
                   }

          }
               
               if (success == 1)
               {
                   Form3 frm = new Form3(processes);
                   Visible = false;
                   frm.ShowDialog();
                   Close();
               }
        }
    }
}
