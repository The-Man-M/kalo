using System;

namespace Usuario
{
    class Cliente
    {
        protected string Nombre;
        protected string Apellido;
        protected int Edad;
        public string User;
        public string Pass;
        public bool Admin = false;

        public Cliente() { }

        public Cliente(string nombre, string apellido, int edad, string user, string pass)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            User = user;
            Pass = pass;
        }


        public Cliente(string nombre, string apellido, int edad, string user, string pass, bool admin)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            User = user;
            Pass = pass;
            Admin = admin;
        }


        public bool iniciarsecion(string pass, string user)
        {
            bool pase = false;
            ClienteEjecutivo Ejecutivo = new ClienteEjecutivo();
            pase = Ejecutivo.login(this.User, this.Pass, user, pass);
            return pase;
        }


        public void mostrardatos(int ID)
        {
            if (!this.Admin)
            {
                Console.WriteLine($"{ID}- Nombre: {Nombre} Apellido: {Apellido} Edad: {Edad} Usuario: {User} ");
            }
        }
        public bool iniciodesecion(string user, string pass)
        {
            ClienteNormal clientenormal = new ClienteNormal();
            return clientenormal.consultardatos(this.User, this.Pass, user, pass);
        }
    }
    class ClienteNormal : Cliente
    {
        public bool consultardatos(string User, string Pass, string user, string pass)
        {
            bool acceso = false;
            if (User == user && Pass == pass)
            {
                acceso = true;
            }
            return acceso;
        }
    }
    class ClienteEjecutivo : Cliente
    {
        public bool login(string User, string Pass, string user, string pass)
        {
            bool pase = false;
            if (User == user && Pass == pass)
            {
                pase = true;
            }
            return pase;
        }
    }
}