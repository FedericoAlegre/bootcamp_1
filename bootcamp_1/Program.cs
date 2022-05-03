using System;
using System.Collections.Generic;

namespace bootcamp_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> m = new List<int>();
            Console.WriteLine("Bootcamp challenge 1");

            #region Ejercicio 1
            //int n = 0;
            //do {
            //    Console.WriteLine("Ejercicio 1\nIngrese un numero natural");
            //    n = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("El numero debe ser mayor a 0\nIngrese otro:");
            //} while (n<=0);
            //int suma = 0;
            //if (n <= 0) Console.WriteLine("El numero debe ser positivo");
            //else
            //{

            //    for (int i = (n + 1); i < (101 + n); i++)
            //    {
            //        suma += i;
            //    }
            //}
            //Console.WriteLine($"El resultado es {suma}");
            #endregion

            #region Ejercicio 2
            //Console.WriteLine("Ejercicio 2\nescribe 2 numeros distintos:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int n2 = Convert.ToInt32(Console.ReadLine());
            //if (n == n2) Console.WriteLine("Los numeros deben ser distintos!!");
            //else
            //{

            //    for (int i = Math.Min(n, n2); i < Math.Max(n, n2); i+=7)
            //    {
            //        Console.WriteLine($"{i}");
            //    }
            //}

            #endregion

            #region Ejercicio 3
            //Console.WriteLine("Ejercicio 3\nescribe un numero:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int cont = 1;
            //int suma = n;
            //if (n < 150)
            //{
            //    while (suma < 150)
            //    {
            //        Console.WriteLine("\nescribe un numero:");
            //        n = Convert.ToInt32(Console.ReadLine());
            //        suma += n;
            //        cont++;


            //    }
            //}

            //Console.WriteLine($"Contador: {cont}\n" +
            //    $"promedio: {suma / cont}");
            #endregion

            #region Ejercicio 4
            //Console.WriteLine("Ejercicio 4\nIngrese el trabajador:");
            //string name = Console.ReadLine();
            //Console.WriteLine("Ejercicio 4\nIngrese las horas trabajadas");
            //double n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Ejercicio 4\nIngrese el valor por hora");
            //double v = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"Salario de {name}: ${v*n}");
            #endregion

            #region Ejercicio 5
            //int v = 0, contV = 0, countE = 0, count0 = 0, count1 = 0, count2 = 0, count3 = 0;
            //int error=0;
            //Console.WriteLine("Señal:");
            //v = Convert.ToInt32(Console.ReadLine());
            //while (error < 2)
            //{


            //    switch (v)
            //    {
            //        case 0:
            //            {
            //                count0++;
            //                contV++;
            //                error = 0;
            //                break;
            //            }
            //        case 1:
            //            {
            //                count1++;
            //                contV++;
            //                error = 0;
            //                break;
            //            }
            //        case 2:
            //            {
            //                count2++;
            //                contV++;
            //                error = 0;
            //                break;
            //            }
            //        case 3:
            //            {
            //                count3++;
            //                contV++;
            //                error = 0;
            //                break;
            //            }
            //        case 4:
            //            {
            //                error++;
            //                countE++;
            //                break;
            //            }
            //        default:
            //            {
            //                Console.WriteLine("Out if bound!!");
            //                error = 0;
            //                break;
            //            }
            //    }
            //    if (error < 2)
            //    {
            //        Console.WriteLine("Señal:");
            //        v = Convert.ToInt32(Console.ReadLine());
            //    }

            //}
            #endregion

            #region pair programming 1
            //se tiene un arreglo con el nombre de X empleados
            //y se requiere una matriz para guardar los sueldos de X cantidad de meses.
            string[] personas = new string[5];
            double[,] sueldos = new double[5, 3];

            for (int i = 0; i < personas.Length; i++)
            {
                Console.Write("Ingrese empleado: ");
                personas[i] = Console.ReadLine();
            }
            for (int i = 0; i < 5; i++)
            {
                for (int x = 0; x < 3; x++)
                {
                    Console.Write($"Ingrese sueldo del empleado {personas[i]} en el mes {x}: ");
                    sueldos[i, x] = int.Parse(Console.ReadLine());
                }
            }

            #endregion






            Console.ReadKey();
        }




    }
}
