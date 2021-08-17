using System;
using Entity_layer;
using b_Business_layer;

namespace c_UI_layer
{
    class UI_User
    {
        static void Main(string[] args)
        {
            Entity_User usuario = new Entity_User();
            Business_User business = new Business_User();

            Console.WriteLine("Bienvenidos a la clase de Refuerzos!\nPor favor Inicie Sesión:" +
                "\nNombre:");
            usuario.Name = Console.ReadLine();
            Console.WriteLine("Contraseña:");
            usuario.Password = Console.ReadLine();

            usuario = business.Business_Login(usuario);
            if (usuario != null)
            {
                //usuario = login;
                Console.WriteLine("Bienvenido " + usuario.Name + "!");
                Console.WriteLine("Role: " + usuario.Role + ".");
            }
            else 
            {
                Console.WriteLine("Lo sentimos, no estás registrado :(");
                Environment.Exit(1);
            }
        }
    }
}

//int opcion;
//Console.WriteLine("Qué deseas hacer?\n" +
//    "\n1 - Sumar" +
//    "\n2 - Restar" +
//    "\n3 - Multiplicar" +
//    "\n4 - Dividir" +
//    "\n0 - Salir");
//opcion = int.Parse(Console.ReadLine());

//switch (opcion)
//{
//    case 0:
//        Environment.Exit(1);
//        break;
//    case 1:
//        Console.WriteLine("1 + 1 = 11");
//        break;
//    default:
//        Console.WriteLine("Error!");
//        break;
//}
