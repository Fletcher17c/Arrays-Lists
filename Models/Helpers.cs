using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_Arrays.Models
{
    internal class Helpers
    {

        

        public static void DisplayLenght(Array arr)
        {
            Console.WriteLine(arr.Length);
        }


        // overload de DisplayC para arreglos y listas<int>
        public static void DisplayC(Array arr)
        {
            Console.WriteLine("*--------------------");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr.GetValue(i));
            }
        }
        public static void DisplayC(List<int> list)
        {
            Console.WriteLine("*--------------------");
            list.ForEach(Console.WriteLine);
        }

    }
}
   
