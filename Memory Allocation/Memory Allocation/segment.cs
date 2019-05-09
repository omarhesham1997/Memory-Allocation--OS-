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
  public  class segment
    {

        process parent_process;
        int start_location;
        int size;
        Color color;
        int index;
        string text;

        public segment( process parent_process,int size ,Color color)
        {
      
            this.size = size;
            this.parent_process = parent_process;
            this.color = parent_process.get_color();
        }

        public int get_start_location()
        {
            return this.start_location;
        }

        public int get_parent_process_index()
        {
            return parent_process.get_index();
        }
        public Color get_color()
        {
            return this.color;
        }

        public int get_size()
        {
            return size;
        }
        public void set_start_location(int start_location)
        {
            this.start_location=start_location;
        }

        public void set_index(int index)
        {
            this.index = index;
        }
        public int get_index( )
        {
            return this.index  ;
        }
        public void set_text(string text)
       {
           this.text = text;
       }
        public string get_text()
        {
            return this.text;
        }

    }
}
