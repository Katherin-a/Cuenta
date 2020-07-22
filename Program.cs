using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejericio2_Cuenta
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta = new Cuenta();

           


            int menu = 1;
            int opcion = 0;

            Console.WriteLine("Ejercicio 2: Clase Cuenta.");
            Console.WriteLine(" ");
            Console.Write("- Digite el nombre del titular de la cuenta: ");
            cuenta.titular = Convert.ToString(Console.ReadLine());
            Console.WriteLine(" ");

            do
            {
                Console.WriteLine("Opciones del Sistema:");
                Console.WriteLine(" ");
                Console.WriteLine("1- Depositar.");
                Console.WriteLine("2- Retirar.");
                Console.WriteLine("3- Mostrar datos de la Cuenta.");
                Console.WriteLine("4- Salir.");
                Console.WriteLine(" ");
                Console.Write("- Digite el numero de la opcion deseada: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        cuenta.Ingresar();
                        break;
                    case 2:
                        cuenta.Retirar();
                        break;
                    case 3:
                        cuenta.Mostrar();
                        break;
                    case 4:
                        menu = 0;
                        break;
                }
            }
            while (menu != 0);
        }
    }
}
