using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Codigo de ciclo tipo FOR
namespace ciclo4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("Hagamos un salto en el TIEMPOxd");
            Console.WriteLine("Dime que dia nos vamos (Numero)");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dime que dia regresaremos (Numero)");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Cada cuanto quieres detenerte para hacer tus necesidades (Parada c/Numero = i) ");
            z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nos detuvimos estos dias: ");
            if (x > y)
            {
                for (int i = x; i > y; i -= z)
                {
                    Console.WriteLine("i = " + i);
                }

            }
            else
            {
                for (int i = x; i < y; i += z)
                {
                    Console.WriteLine("i = " + i);
                }


            }

        }
    }
}
