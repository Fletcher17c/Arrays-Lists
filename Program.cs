using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lists_Arrays.Models;

namespace Lists_Arrays
{
    internal class Program
    {
        


        static void Main(string[] args)
        {
            ExamplesList examplesList = new ExamplesList();

            examplesList.add();
   

            // No se crea un objeto de Helpers para usar sus metodos 
            Helpers.DisplayC(examplesList.list);
                

            Console.ReadKey();


        }
            
    }
}

