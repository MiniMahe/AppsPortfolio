using System;
using System.Collections.Generic;
using System.Linq;

namespace ordenar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> ordenar = new List<string>();
            List<int> ordenados = new List<int>();
            ordenar = Listo();
            Console.WriteLine("1. Directa");
            Console.WriteLine("2. Directa binaria");
            Console.WriteLine("3. Burbuja");
            string op = Console.ReadLine();

            for (int i = 0; i < ordenar.Count; i++)
            {
                if (ordenar[i] != " ")
                {
                    ordenados.Add(Convert.ToInt32(ordenar[i]));
                }
            }
            switch (op)
            {
                case "1":
                    {
                        Directa(ordenados);
                        Console.ReadLine();
                        break;
                    }
                case "2":
                    {
                        Binaria(ordenados);
                        Console.ReadLine();
                        break;
                    }
                case "3":
                    {
                        Burbuja(ordenados);
                        Console.ReadLine();
                        break;
                    }
            }
        }
        public static void Binaria(List<int> ordenados)
        {
            int num;
            int ia;
            int d;
            int q;
            for (int k = 0; k < ordenados.Count; k++)
            {
                num = ordenados[k];
                ia = 0;
                d = k - 1;
                while (ia <= d)
                {
                    q = (ia + d) / 2;
                    if (num <= ordenados[q])
                    {
                        d = q - 1;
                    }
                    else
                    {
                        ia = q + 1;
                    }
                }
                for (int i = k - 1; i >= ia; i--)
                {
                    ordenados[i + 1] = ordenados[i];
                }
                ordenados[ia] = num;
            }
            Imprimir(ordenados);
        }
        static public void Directa(List<int> ordenados)
        {
            int x;
            int p;
            for (int i = 0; i < ordenados.Count; i++)
            {
                x = ordenados[i];
                p = i - 1;
                while (p >= 0 && ordenados[p] > x)
                {
                    ordenados[p + 1] = ordenados[p];
                    p--;
                }
                ordenados[p + 1] = x;
            }
            Imprimir(ordenados);
        }
        static public void Burbuja(List<int> ordenados)
        {
            int t;
            for (int a = 1; a < ordenados.Count; a++)
                for (int b = ordenados.Count - 1; b >= a; b--)
                {
                    if (ordenados[b - 1] > ordenados[b])
                    {
                        t = ordenados[b - 1];
                        ordenados[b - 1] = ordenados[b];
                        ordenados[b] = t;
                    }
                }
            Imprimir(ordenados);
        }

        static public void Imprimir(List<int> ordenados)
        {
            for (int i = 0; i < ordenados.Count; i++)
            {
                Console.Write(ordenados[i] + "<");
            }
            Console.ReadKey();
        }
        public static List<string> Listo()
        {
            List<double> accept = new List<double> { ',', ' ', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            List<string> ordenar = new List<string>();
            bool loop = false;
            string orden = "";
            while (!loop)
            {
                Console.WriteLine("Números a ordenar:(separados por espacios)");
                orden = Console.ReadLine();
                for (int i = 0; i < orden.Length; i++)
                {
                    if (!accept.Contains(orden[i]))
                    {
                        loop = false;
                    }
                    else
                        loop = true;
                }
            }
            ordenar = orden.Split(' ').ToList();
            return ordenar;
        }
    }
}
