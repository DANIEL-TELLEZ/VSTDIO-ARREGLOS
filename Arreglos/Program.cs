using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aumento_de_sueldos
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("DANIEL TELLEZ PRADA");
            Console.WriteLine("Restaurante");
            Console.WriteLine("Este programa calcula el aumento  de salario");
            Console.WriteLine("___________________________________________________________");

            double salario;
            double nuevo, porc;
            double[] Arreglo = new double[3];
            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine("Salario a consultar");
                salario = double.Parse(Console.ReadLine());
                if (salario <= 700000)
                {
                    porc = ((salario * 10) / 100);
                    nuevo = porc + salario;
                    Arreglo[i] = nuevo;

                }
                if (salario > 700000 & salario <= 1000000)
                {
                    porc = ((salario * 7) / 100);
                    nuevo = porc + salario;
                    Arreglo[i] = nuevo;

                }
                if (salario > 1000000 & salario <= 1500000)
                {
                    porc = ((salario * 5) / 100);
                    nuevo = porc + salario;


                    Arreglo[i] = nuevo;
                }





            }

            Console.WriteLine("___________________________________________________________");

            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine("Nuevo salario:" + "" + Arreglo[i]);
            }




            Console.ReadKey();
        }
    }
}






