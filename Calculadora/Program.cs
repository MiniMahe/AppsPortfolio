using System;

namespace Calculadora{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool cont = true;
            while (cont){
                Console.WriteLine("Menú Calculadora");
                Console.WriteLine("1. Operar");
                Console.WriteLine("2. Lista de operaciones posibles y valores espaciales");
                Console.WriteLine("3. Salir");
                Console.WriteLine("Introduzca una de las opciones siguientes...");
                int n1 = 0;
                int n2 = 0;
                int aux = 0;
                const double pi = System.Math.PI;
                string option = Console.ReadLine();
                switch(option)
                {
                    case "1":
                        bool contOper = true;
                        while (contOper){
                            Console.WriteLine("Seleccione el tipo de operación a realizar");
                            Console.WriteLine("1. Suma");
                            Console.WriteLine("2. Sustración");
                            Console.WriteLine("3. Producto");
                            Console.WriteLine("4. Cociente");
                            Console.WriteLine("5. Salir de la sección");
                            option = Console.ReadLine();
                            switch(option){
                                case "1":
                                    Console.WriteLine("Valor 1: ");
                                    n1 = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Valor 2: ");
                                    n2 = Convert.ToInt32(Console.ReadLine());
                                    aux = n1 + n2;
                                    Console.WriteLine("N1+N2 es igual a "+aux);
                                    break;
                                case "2":
                                    Console.WriteLine("Valor 1: ");
                                    n1 = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Valor 2: ");
                                    n2 = Convert.ToInt32(Console.ReadLine());
                                    aux = n1 - n2;
                                    Console.WriteLine("N1-N2 es igual a "+ aux);
                                    break;
                                case "3":
                                    Console.WriteLine("Valor 1: ");
                                    n1 = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Valor 2: ");
                                    n2 = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("N1*N2 es igual a "+n1*n2);
                                    break;
                                case "4":
                                    Console.WriteLine("Valor 1: ");
                                    n1 = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Valor 2: ");
                                    n2 = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("N1/N2 es igual a "+n1/n2);
                                    break;
                                case "5":
                                    contOper = false;
                                    Console.WriteLine("Salir");
                                    break;
                                default:
                                    Console.WriteLine("No existe valor para las opciones disponibles.");
                                    break;
                            }
                        }
                        break;
                    case "2":
                        Console.WriteLine("Operaciones posibles:");
                        Console.WriteLine("Suma, Sutracción, Productos, Cociente");
                        Console.WriteLine("Valores espaciales: "+pi);
                        break;
                    case "3":
                        cont = false;
                        Console.WriteLine("Fin del programa");
                        break;
                    default:
                        Console.WriteLine("No existe valor comprendido para la opción deseada");
                        break;
                    
                }
            }
        }
    }
}