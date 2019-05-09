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
   public class hole
    {
        int start_location;
        int size;
        int end_location;
        Color color;
        string label = "";
        public hole()
        { }
        public hole(int size, int start_location)
        {
            this.size = size;
            this.start_location = start_location;
            this.end_location = size + start_location;
            this.color = Color.Black;
        }
        public hole(int size, int start_location, int end_location, Color color, string label)
        {
            this.size = size;
            this.start_location = start_location;
            this.end_location = end_location;
            this.color = color;
            this.label = label;
        
        }
        public int get_size()
        {
            return this.size;
        }

        public int get_start_location()
        {
            return this.start_location;
        }
        public int get_end_location()
        {

                this.end_location= this.start_location+this.size;
                return this.end_location;
        }
        public void set_color(Color color)
        {
            this.color = color;
        }
        public Color get_color( )
        {
            return this.color;
        }
        public void set_size(int s)
        {
            this.size = s;
        }
        public void set_start_location(int s)
        {
            this.start_location = s;
        }
        public void set_text(string s)
        {
           this. label=s;
        }

        public string get_text()
        {
            return this.label;
        }

    }
}
