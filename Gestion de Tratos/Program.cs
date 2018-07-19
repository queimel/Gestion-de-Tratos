using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria_de_clases;
namespace Gestion_de_Tratos
{
    class Program
    {
        static void Main(string[] args)
        {
            Trato trato01 = new Trato(1, DateTime.Now, 100000, "C");
            Trato trato02 = new Trato(2, DateTime.Now, 50000, "P");
            Trato trato03 = new Trato(3, DateTime.Now, 150000, "C");

            ArrayList listaTratos = new ArrayList();
            listaTratos.Add(trato01);
            listaTratos.Add(trato02);
            listaTratos.Add(trato03);
            Empleado empleado01 = new Empleado("11111111-1", listaTratos);

            Console.WriteLine(empleado01.obtenerPorEstadoTrato("C"));
            Pausa();

        }
        public static void Pausa()
        {
            Console.WriteLine("Presione cualquier tecla para continuar ...");
            Console.ReadKey();
        }
    }
}
