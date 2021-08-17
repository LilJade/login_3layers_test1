using System;
using System.Collections.Generic;
using System.Text;

namespace Entity_layer
{
    public class Entity_User
    {
        private string name;
        private string password;
        private int age;
        private string role;

        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        public int Age { get => age; set => age = value; }
        public string Role { get => role; set => role = value; }

        public Entity_User(string Nombre, string Pass, int edad, string rol) {
            name = Nombre;
            password = Pass;
            age = edad;
            role = rol;
        }

        public Entity_User() { }
    }
}
