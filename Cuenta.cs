using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejericio2_Cuenta
{
    class Cuenta
    {
        private string t;
        private int r, d, c = 3000;

        public string titular
        {
            get
            {
                return t;
            }

            set
            {
                t = value;
            }
        }

        public int cantidad
        {
            get
            {
                return c;
            }

            set
            {
                c = value;
            }
        }

        public int retiro
        {
            get
            {
                return r;
            }

            set
            {
                r = value;
            }
        }

        public int deposito
        {
            get
            {
                return d;
            }

            set
            {
                d = value;
            }
        }

        public void Mostrar()
        {
            Console.WriteLine(" ");
            Console.WriteLine("- Informacion de Cuenta:");
            Console.WriteLine(" ");
            Console.WriteLine("Titular: {0}", titular);
            Console.WriteLine("Cantidad: {0}", cantidad);
            Console.WriteLine(" ");
            Console.WriteLine("Presione la tecla <ENTER> para continuar.");
            Console.ReadKey();
        }

        public void Ingresar()
        {
            Console.WriteLine(" ");
            Console.Write("- Ingrese la cantidad que desea depositar a la Cuenta:");
            deposito = Convert.ToInt32(Console.ReadLine());
            cantidad = cantidad + deposito;
            Console.WriteLine("Deposito: {0}", deposito);
            Console.WriteLine("Cantidad: {0}", cantidad);
            deposito = 0;
            Console.WriteLine(" ");
            Console.WriteLine("Presione la tecla <ENTER> para continuar.");
            Console.ReadKey();
        }

        public void Retirar()
        {
            Console.WriteLine(" ");
            Console.Write("- Ingrese la cantidad que desea retirar a la Cuenta:");
            retiro = Convert.ToInt32(Console.ReadLine());
            cantidad = cantidad - retiro;
            Console.WriteLine("Retiro: {0}", retiro);
            Console.WriteLine("Cantidad: {0}", cantidad);
            retiro = 0;
            Console.WriteLine(" ");
            Console.WriteLine("Presione la tecla <ENTER> para continuar.");
            Console.ReadKey();
        }
    }
}
