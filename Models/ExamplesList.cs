using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_Arrays.Models
{
    internal class ExamplesList
    {
        public List<int> list = new List<int>();

        public void add()
        {
            list.Add(0);
            list.Add(1);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

        }

        public void remove(int x)
        {
            list.Remove(x);

        }

    }
}
