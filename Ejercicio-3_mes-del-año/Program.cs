using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3_mes_del_año
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número del 1 al 12: ");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("El número {0} corresponde al mes {1}", month, translateTheMonth(month));
        }

        public static string translateTheMonth(int m)
        {
            string result = "";
            switch (m) {
                case 1:
                    result = "Enero";
                    break;
                case 2:
                    result = "Febrero";
                    break;
                case 3:
                    result = "Marzo";
                    break;
                case 4:
                    result = "Abril";
                    break;
                case 5:
                    result = "Mayo";
                    break;
                case 6:
                    result = "Junio";
                    break;
                case 7:
                    result = "Julio";
                    break;
                case 8:
                    result = "Agosto";
                    break;
                case 9:
                    result = "Septiembre";
                    break;
                case 10:
                    result = "Octubre";
                    break;
                case 11:
                    result = "Noviembre";
                    break;
                case 12:
                    result = "Diciembre";
                    break;
                default:
                    if(m < 1 || m > 12)
                    {
                    Console.WriteLine("Introduce un número válido");
                    }
                    break;
            }

            return result;
        }
    }
}
