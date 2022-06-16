using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListadoDeNumeros
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.CursorLeft = 30;


            Console.WriteLine("Ingresa numeros y cambia los colores:");

            Console.WriteLine("Ingresa la cantiada de numeros que quieres introducir:");
            

            int CantNum = Convert.ToInt32(Console.ReadLine());

            List<int> ListNum = new List<int>();

            Console.WriteLine("Ahora ingresa los numeros:");

            for (int i=0; i<CantNum; i++)
            {
                int IngNum = Convert.ToInt32(Console.ReadLine());


                if (IngNum % 2 == 0)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;

                    Console.Clear(); /*El 'Clear' es lo que permite el cambio de fondo
                                      *sin el 'Clear' el cambio de color se limita a las letras*/
                }
                else if (IngNum % 2 != 0)
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.Clear();

                }
                Console.WriteLine("Sorprendido?,vamos, ingresa otro numero:");

                ListNum.Add(IngNum);

            }

            Console.Clear();

            Console.WriteLine("Listado de numeros ingresados:");

            for (int i=0; i<ListNum.Count; i++)
            {
                int Listado = ListNum[i];

                Console.WriteLine("El numero de la posicion"  +" "+ (i+1) + " es: " +Listado);

            }
            Console.WriteLine("La cantidad de numeros ingresados es de:" + " " + ListNum.Count);

            Console.ReadKey();
        }
    }
}
