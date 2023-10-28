
using Usuario;
namespace Sistema
{
    interface IBaseDeDatos
    {
        public void verCliente();
        public void agregarCliente(Cliente cliente);
        public void eliminarCliente(Cliente cliente);
    }
    class SQLite : IBaseDeDatos
    {
        private List<Cliente> clientes = new List<Cliente>()
        {
        };



        public void mostrarMenuEjecutivo()
        {
            int clienteEjecutivo = 0;
            string usuario = "", password = "";
            int indice = 1;
            int Menu = 0;
            bool acceso = false;
            Console.Clear();
            Console.WriteLine("Inicie sesión.");
            Thread.Sleep(500);

            Console.Write("Ingrese el usuario: ");
            usuario = Console.ReadLine();

            Console.Write("Ingrese la contraseña: ");
            password= Console.ReadLine();


            for (int i = 0; i < clientes.Count; i++)
            {
                if (clientes[i].Admin)
                {
                    clienteEjecutivo = i;
                    acceso = clientes[i].iniciarsecion(password, usuario);
                   
                }
            }
            if (acceso)
            {
                do
                {


                    Console.WriteLine("Menu de cliente ejecutivo\n1. Ver clientes\n2. Agregar clientes\n3. Eliminar clientes\n4. Salir");
                    while (!int.TryParse(Console.ReadLine(), out Menu))
                    {

                    }

                    switch (Menu)
                    {
                        case 1: verCliente(); Console.ReadKey(); break;

                        case 2:
                            indice = clientes.Count - 1;
                            agregarCliente(clientes[indice]); break;

                        case 3:
                            eliminarCliente(clientes[indice]);
                            break;
                    }
                } while (Menu != 4);
            }
            else { Console.WriteLine("El usuario no existe"); }

        }


        public void mostrarMenu()
        {

            string usuario = "", password = "";
            bool user = false;
            int Menu = 0;
            
           


            do
            {
                Console.WriteLine("Menu cliente normal\n1. Mostrar datos \n2. salir");
                while (!int.TryParse(Console.ReadLine(), out Menu))
                {

                }

                if (Menu == 1)
                {


                    Console.Write("Ingrese el usuario: ");
                    usuario = Console.ReadLine();

                    Console.Write("Ingrese la contraseña: ");
                    password = Console.ReadLine();

                    for (int i = 0; i < clientes.Count; i++)
                    {
                        if (clientes[i].iniciodesecion(usuario, password))
                        {
                            user = true;
                            clientes[i].mostrardatos(0);
                        }
                    }
                    if (!user)
                    {
                        Console.WriteLine("El usuario no existe");
                    }
                }
            } while (Menu != 2);
        }




        public void verCliente()
        {
           
        }


        public void agregarCliente(Cliente cliente)
        {
            string Nombre = "";
            string Apellido = "";
            int Edad = 0;
            string Usuario = "";
            string Contraseña = "";

            Console.WriteLine("Ingrese el nombre del cliente:");
            Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el apellido del cliente:");
            Apellido = Console.ReadLine();

            Console.WriteLine("Ingrese la edad del cliente:");

            while (!int.TryParse(Console.ReadLine(), out Edad))
            {

            }

            Console.WriteLine("Ingrese el nombre de usuario del cliente:");
            Usuario = Console.ReadLine();

            Console.WriteLine("Ingrese la contraseña del cliente:");
            Contraseña = Console.ReadLine();

            clientes.Add(new Cliente(Nombre, Apellido, Edad, Usuario, Contraseña));
        }


        public void eliminarCliente(Cliente cliente)
        {



        }
    }
}