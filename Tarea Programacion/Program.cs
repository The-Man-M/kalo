using Sistema;
using System.Data.SqlTypes;
namespace Tarea_programacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                SQLite BaseDeDatos = new SQLite();

                int Menu = 0;

                do
                {
                    Console.WriteLine("Menu\n1. Menu de cliente ejecutivo 2. Menu de cliente normal 3. Salir");
                    while (!int.TryParse(Console.ReadLine(), out Menu))
                    {

                    }

                    switch (Menu)
                    {
                        case 1:

                            BaseDeDatos.mostrarMenuEjecutivo();
                            break;
                        case 2:

                            BaseDeDatos.mostrarMenu();
                            break;
                    }
                } while (Menu != 3);
            }


            Console.WriteLine("\n");

            Console.WriteLine("vuelva Pronto");
        }

      
    }
}