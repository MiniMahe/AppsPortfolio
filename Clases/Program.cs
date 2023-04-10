using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    int.Parse(Console.ReadLine());
            //}
            //catch(Exception ex) { 
            //    Console.WriteLine(ex.Message);
            //}
            //finally { Console.ReadLine(); }
            Interino i = new Interino("Pepe", "Interino");
            i.Imprimir();
            Console.ReadLine();
        }
        
    }
}
