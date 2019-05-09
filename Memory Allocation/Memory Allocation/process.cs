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
    public class process
    {

        int index;
        int number_segments;
        Color color;
        List<segment> segments =new List<segment>();

        public process(int index, int number_segments, Color color)
        {
            this.index = index;
            this.number_segments = number_segments;
            this.color = color;
        }

        public void set_color(Color color)
        {
            this.color = color;
        }
        public Color get_color()
        {
            return this.color;
        }

        public int get_number_segments()
        {
            return this.number_segments;
        }

        public int get_index()
        {
            return this.index;
        }
        public void add_segment(segment seg)
        {
            this.segments.Add(seg);
        }

        public List<segment> get_segments()
        {
            return this.segments;
        }

        public int get_size()
        {
            int sum = 0;
            foreach (segment s in segments)
                sum += s.get_size();
            return sum;
        }
        public void segments_sort_desc()
        {
            for (int i = 0; i < number_segments; i++)
            { 
                   for(int j=1;j<number_segments-i;j++)
                   {
                       if (segments[i].get_size() < segments[j].get_size())
                       {
                           segment t = segments[i];
                           segments[i] = segments[j];
                           segments[j] = t;
                       }

                   }
            }
        }

        public void clear_segments()
        {
            this.segments.Clear();
        }
    }
}
