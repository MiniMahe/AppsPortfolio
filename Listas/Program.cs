using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que quiere hacer?(1-10)");
            string op = Console.ReadLine();
            switch (op)
            {
                case "1":
                    Ejer1();
                    Console.ReadLine();
                    break;
                case "2":
                    Ejer2();
                    Console.ReadLine();
                    break;
                case "3":
                    Ejer3();
                    Console.ReadLine();
                    break;
                case "4":
                    Ejer4();
                    Console.ReadLine();
                    break;
                case "5":
                    Ejer5();
                    Console.ReadLine();
                    break;
                case "6":
                    Ejer6();
                    Console.ReadLine();
                    break;
                case "7":
                    Ejer7();
                    Console.ReadLine();
                    break;
                case "8":
                    Ejer8();
                    Console.ReadLine();
                    break;
                case "9":
                    Ejer9();
                    Console.ReadLine();
                    break;
                    //case "10":
                    //    Ejer10();
                    //    Console.ReadLine();
                    //    break;
            }

        }
        static string Ejer1()
        {
            string num = default;
            List<string> asign = new List<string>();
            bool loop = false;
            while (!loop)
            {
                Console.WriteLine("Número de asignaturas");
                num = Console.ReadLine();
                loop = int.TryParse(num, out _);
            }
            for (int i = 0; i < Convert.ToInt32(num); i++)
            {
                Console.WriteLine("Nombre de la asignatura");
                asign.Add(Console.ReadLine());
            }
            foreach (string nombre in asign)
            {
                Console.WriteLine(nombre);
            }
            return num;
        }
        static string Ejer2()
        {
            string num = default;
            List<string> asign = new List<string>();
            bool loop = false;
            while (!loop)
            {
                Console.WriteLine("Número de asignaturas");
                num = Console.ReadLine();
                loop = int.TryParse(num, out _);
            }
            for (int i = 0; i < Convert.ToInt32(num); i++)
            {
                Console.WriteLine("Nombre de la asignatura");
                asign.Add(Console.ReadLine());
            }
            foreach (string nombre in asign)
            {
                Console.WriteLine("Yo estudio " + nombre);
            }
            return num;
        }
        static string Ejer3()
        {
            string num = default;
            List<string> asign = new List<string>();
            List<string> notas = new List<string>();
            bool loop = false;
            while (!loop)
            {
                Console.WriteLine("Número de asignaturas");
                num = Console.ReadLine();
                loop = int.TryParse(num, out _);
            }
            for (int i = 0; i < Convert.ToInt32(num); i++)
            {
                Console.WriteLine("Nombre de la asignatura");
                asign.Add(Console.ReadLine());
                Console.WriteLine("Nota de la asignatura");
                notas.Add(Console.ReadLine());
            }
            for (int j = 0; j < Convert.ToInt32(num); j++)
            {
                Console.WriteLine("En " + asign[j] + " has sacado " + notas[j]);
            }
            return num;
        }
        static string Ejer4()
        {
            string num = default, lot = default;
            List<int> win = new List<int>();
            bool loop = false;
            while (!loop)
            {
                Console.WriteLine("Número de ganadores");
                num = Console.ReadLine();
                loop = int.TryParse(num, out _);
            }

            for (int i = 0; i < Convert.ToInt32(num); i++)
            {
                bool loop2 = false;
                while (!loop2)
                {
                    Console.WriteLine("Número ganador");
                    lot = Console.ReadLine();
                    loop2 = int.TryParse(lot, out _);
                }
                win.Add(Convert.ToInt32(lot));
            }
            win.Sort();
            foreach (int name in win)
            {
                Console.WriteLine("Ganador " + name);
            }
            return num;
        }
        static string Ejer5()
        {
            string num = default, lot = default;
            List<int> n = new List<int>();
            bool loop = false;
            while (!loop)
            {
                Console.WriteLine("Números ha introducir");
                num = Console.ReadLine();
                loop = int.TryParse(num, out _);
            }

            for (int i = 0; i < Convert.ToInt32(num); i++)
            {
                bool loop2 = false;
                while (!loop2)
                {
                    Console.WriteLine("Introduzca un número");
                    lot = Console.ReadLine();
                    loop2 = int.TryParse(lot, out _);
                }
                n.Add(Convert.ToInt32(lot));
            }
            n.Reverse();
            string coma = string.Join(",", n);
            Console.WriteLine(coma);
            return num;
        }
        static string Ejer6()
        {
            string num = default, st = default;
            List<string> n = new List<string>();
            List<char> inv = new List<char>();
            Console.WriteLine("Introduzca una cadena de carácteres");
            st = Console.ReadLine();
            n.Add(st);
            char[] ch = n[0].ToCharArray();
            Array.Reverse(ch);
            for (int i = 0; i < ch.Length; i++)
            {
                inv.Add(ch[i]);
            }
            foreach (char name in inv)
            {
                Console.Write(name);
            }
            return num;
        }
        static string Ejer7()
        {
            string num = default, nota = default, asig = default;
            List<string> asign = new List<string>();
            List<string> notas = new List<string>();
            int cont = default;
            bool loop = false;
            while (!loop)
            {
                Console.WriteLine("Número de asignaturas");
                num = Console.ReadLine();
                loop = int.TryParse(num, out _);
            }
            for (int i = 0; i < Convert.ToInt32(num); i++)
            {
                Console.WriteLine("Nombre de la asignatura");
                asig = Console.ReadLine();
                asign.Add(asig);

                bool loop2 = false;
                while (!loop2)
                {
                    Console.WriteLine("Nota de la asignatura");
                    nota = Console.ReadLine();
                    loop2 = int.TryParse(nota, out _);
                }                
                notas.Add(nota);

                if (Convert.ToInt32(nota) < 5)
                {
                    cont++;
                }
                else
                {
                    notas.Remove(nota);
                    asign.Remove(asig);
                }
            }
            for (int j = 0; j < cont; j++)
            {
                Console.WriteLine("Tienes que repetir " + asign[j] + " porque has sacado " + notas[j]);
            }
            return num;
        }
        static string Ejer8()
        {
            string abc = "abcdefghijklmnñopqrstuvwxyz";
            int mult = default;
            List<string> a = new List<string>();
            List<char> ab = new List<Char>();
            a.Add(abc);
            foreach (string name in a)
            {
                Console.WriteLine(name);
            }
            char[] ch = a[0].ToCharArray();
            for (int i = 1; i < abc.Length; i++)
            {
                mult = i % 3;
                if (mult != 0)
                {
                    ab.Add(ch[i -1]);
                }
            }
            foreach (char name in ab)
            {
                Console.Write(name);
            }
            return abc;
        }
        static string Ejer9()
        {
            string num = default, st = default, x = default;
            List<string> n = new List<string>();
            List<char> inv = new List<char>();
            List<char> cad = new List<char>();
            Console.WriteLine("Introduzca una cadena de carácteres");
            st = Console.ReadLine();
            n.Add(st);
            char[] ch = n[0].ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                cad.Add(ch[i]);
            }
            Array.Reverse(ch);
            for (int i = 0; i < ch.Length; i++)
            {
                inv.Add(ch[i]);
            }
            for(int k = 0; k < ch.Length; k++)
            {
                x += ch[k];
            }
            if (x == st)
            {
                Console.WriteLine("Es palindromo");
            }
            else
                Console.WriteLine("No es palindromo");
            return num;
        }
    } 
}
