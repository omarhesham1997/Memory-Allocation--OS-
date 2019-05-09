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
    public class memory
    {
        int size;
        int number_holes;
        List<hole> holes = new List<hole>();
        List<hole> processes = new List<hole>();

        
        public memory(int size, int number_holes)
        {
            this.size = size;
            this.number_holes = number_holes;

        }

        public memory(int size, int number_holes, List<hole> holes)
        {
            this.size = size;
            this.number_holes = number_holes;
            this.holes = holes;
        }
        public memory(int size, int number_holes, List<hole> holes, List<hole> processes)
        {
            this.size = size;
            this.number_holes = number_holes;
            this.holes = holes;
            this.processes = processes;
        }

        public memory()
        {

        }
        public int get_size()
        {
            return this.size;
        }
        public void add_hole(hole nh)
        {
            this.holes.Add(nh);
        }
        public int get_initial_number_of_holes()
        {
            return this.number_holes;
        }
        public void set_holes(List<hole> h)
        {
            this.holes = h;
        }


        public void merge_holes()
        {
            List<Tuple<int, int>> start_end = new List<Tuple<int, int>>();
            for (int i = 0; i < get_number_holes_after_merge(); i++)
            {
                Tuple<int, int> tup = new Tuple<int, int>(holes[i].get_start_location(), holes[i].get_end_location());
                start_end.Add(tup);
            }

            start_end.Sort();
            holes.Clear();
            foreach (Tuple<int, int> tup in start_end)
            {
                hole nh = new hole(tup.Item2 - tup.Item1, tup.Item1);
                holes.Add(nh);

            }

            List<hole> temp = new List<hole>();
            int index = 0;
            temp.Add(holes[index]);
            for (int i = 1; i < get_number_holes_after_merge(); i++)
            {
                if (holes[i].get_start_location() >= temp[index].get_start_location() && holes[i].get_start_location() <= temp[index].get_end_location())
                {
                    if (holes[i].get_end_location() > temp[index].get_end_location())
                    {
                        hole nh = new hole(holes[i].get_end_location() - temp[index].get_start_location(), temp[index].get_start_location());
                        temp[index] = nh;
                    }

                    else if (holes[i].get_end_location() < temp[index].get_end_location())
                    {
                        hole nh = temp[index];
                        temp[index] = nh;
                    }

                }
                else
                {
                    temp.Add(holes[i]);
                    index++;
                }

            }

            holes = temp;

        }
        public int get_total_empty_space()
        {
            int sum = 0;
            foreach (hole h in holes)
                sum += h.get_size();
            return sum;
        }

        public List<hole> get_holes()
        {
            return this.holes;
        }

        public int get_number_holes_after_merge()
        {
            int sum = 0;
            foreach (hole h in holes)
                sum++;
            return sum;


        }
        public void calulate_memory_processes()
        {
            List<hole> temp = new List<hole>();
            int start = 0;
            for (int i = 0; i < get_number_holes_after_merge(); i++)
            {
                //special case for the  process that have start location at zerp
                if (holes[i].get_start_location() == 0)
                    start = holes[i].get_end_location();
                if (holes[i].get_start_location() > start)
                {
                    hole nh = new hole(holes[i].get_start_location() - start, start);
                    temp.Add(nh);
                    start = holes[i].get_end_location();
                }
            }
            //for adding the last old process after the last hole
            if (holes[get_number_holes_after_merge() - 1].get_end_location() != size)
            {
                hole nh = new hole(size - holes[get_number_holes_after_merge() - 1].get_end_location(), holes[get_number_holes_after_merge() - 1].get_end_location());
                temp.Add(nh);
            }
            processes = temp;

        }
        public List<hole> get_memory_processes()
        {
            return this.processes;
        }
        public void add_process(hole p)
        {
            this.processes.Add(p);

        }

        public void set_processes(List<hole> p)
        {
            this.processes = p;

        }

        public int search_process(hole h)
        {
            for (int i = 0; i < get_memory_processes().Count; i++)
                if (processes[i] == h) return i;
            return -1;
        }
        public void remove_process(int index)
        {
            processes.RemoveAt(index);
        }

        public memory copy()
        {
            memory other = new memory(get_size(), get_number_holes_after_merge());
            List<hole> tholes = new List<hole>();
            foreach (hole h in holes)
            {
                hole nh = new hole(h.get_size(), h.get_start_location(), h.get_end_location(), h.get_color(), h.get_text());
                tholes.Add(nh);
            }
            List<hole> tpro = new List<hole>();
            foreach (hole h in processes)
            {
                hole nh = new hole(h.get_size(), h.get_start_location(), h.get_end_location(), h.get_color(), h.get_text());
                tpro.Add(nh);
            }
            other.set_holes(tholes);
            other.set_processes(tpro);

            return other;

        }

        public int search_by_color(Color color)
        {

            int i = 0;
            foreach (hole h in processes)
            {
                if (h.get_color() == color)
                    return i;
                i++;
            }
            return -1;
        }

        public void arrange_memory_ascending_size()
        {
            for (int i = 0; i < this.get_number_holes_after_merge(); i++)
            {
                for (int j = 0; j < this.get_number_holes_after_merge() - i - 1; j++)
                {
                    if (this.holes[j + 1].get_size() < this.holes[j].get_size())
                    {
                        hole temp = this.holes[j];
                        this.holes[j] = this.holes[j + 1];
                        this.holes[j + 1] = temp;
                    }
                }
            }

        }
        public void arrange_memory_descending_size()
        {
            for (int i = 0; i < this.get_number_holes_after_merge(); i++)
            {
                for (int j = 0; j < this.get_number_holes_after_merge() - i - 1; j++)
                {
                    if (this.holes[j + 1].get_size() > this.holes[j].get_size())
                    {
                        hole temp = this.holes[j];
                        this.holes[j] = this.holes[j + 1];
                        this.holes[j + 1] = temp;
                    }
                }
            }

        }
    }
}

