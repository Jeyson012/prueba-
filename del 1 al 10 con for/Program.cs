using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class del_1_al_10_con_for
    {
        static void Main(string[] args)
        {
            int i;
            i = Convert.ToInt32(Console.ReadLine());

          
            for(i=1; i<=10; i++)
            {
                Console.WriteLine(i);
                Console.ReadKey();
            }
        }
    }
}
