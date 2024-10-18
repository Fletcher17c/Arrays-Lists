using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_Arrays.Models
{
    internal class Examples
    {
        public int[] array1 = new int[5];
        public int[] copyArray = new int[6];
        public int[] exampleArray = { 2, 2, 1, 3,5};

        public void add(int index, int value)
        {
            array1[index] = value;
        }

        public void UsingSetValue(int index, int value)
        {
            array1.SetValue(value, index);
        }

        public void copyarray()
        {
            exampleArray.CopyTo(copyArray,0);
        }

       
    }
}
