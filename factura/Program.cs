using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
 class Program
 {
  static void Main(string[] args)
  {
   float st; //solo este es float ya que es una variable que almacena los valores decimales
    double dt,bt, it; // le trabajas como double ya que utilizas constantes con decimales
   Console.WriteLine("ingrese el sub total de la factura:");
   st = float.Parse(Console.ReadLine()); //lo lees como float solo al subtotal
   

   if (st <= 10)
   {
    dt = 0;
   }
   else
   {
    if (st <= 500)
    {
     dt = st * 0.2;
    }
    else
    {
     if (st <= 1000)
     {
      dt = st * 0.25;
     }
     else
     {
      if (st<= 1500) // esta linea tenias mal xq le pusiste dt<=1500
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
   Console.ReadKey(); //EDITADO POR PALTAN :v
  }
 }
}
