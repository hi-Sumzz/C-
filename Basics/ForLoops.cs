using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Basics
{
    class ForLoops
    {
        public static void Main()
        {
            int[] marks = new int[5] { 99, 98, 92, 97, 95 };
            string[] yes =  { "sumeet", "hiremath" };
            int b = 20;
            for (int a=10 ; a < b; a++)
            {
                Console.WriteLine("a="+a);

            }
            Console.WriteLine("-------------------------");
            foreach (int i  in marks)
            {
                Console.WriteLine("i="+i);
            }
            Console.WriteLine("-------------------------");
            foreach (string i in yes)
            {
                Console.WriteLine(i);
            }
            
            
            

            

        }
       
    }
}
