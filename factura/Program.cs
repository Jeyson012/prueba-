using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace division_con_restas
{
    class Program
    {
        static void Main(string[] args)
        {
            double st, bt, it, m, dt;
            Console.WriteLine("ingrese el sub total de la factura:");
            st = Convert.ToInt32(Console.ReadLine());
            bt= Convert.ToInt32(Console.ReadLine());
            it = Convert.ToInt32(Console.ReadLine());
            m= Convert.ToInt32(Console.ReadLine());
            dt = Convert.ToInt32(Console.ReadLine());

            if (st<=10)
            {
                dt = 0;
            }
            else
            {
                if(st<= 500)
                {
                    dt = st * 0.20;
                }
                else
                {
                    if(st<=1000)
                    {
                        dt = st * 0.25;
                    }
                    else
                    {
                        if(dt<=1500)
                        {
                            dt = st * 0.30;
                        }
                        else
                        {
                            dt = st * 0.35;
                        }
                    }
                }
            }
            bt = st - dt;
            it = bt * 0.12;
            Console.WriteLine("EL VALOR TOTAL A PAGAR ES: " + (it + bt));
            Console.ReadKey();


        }
    }
}
