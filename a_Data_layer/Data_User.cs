using System;
using System.Collections.Generic;
using System.Text;
using Entity_layer;

namespace a_Data_layer
{
    public class Data_User
    {
        Entity_User Admin = new Entity_User("William", "12345", 25, "Admin");
        Entity_User Student1 = new Entity_User("Fredy", "fred123", 27, "Student");
        public Entity_User Login(Entity_User user) {

            if (user.Name == Admin.Name & user.Password == Admin.Password)
            {
                user = Admin;
                return user;
            }
            else if (user.Name == Student1.Name & user.Password == Student1.Password)
            {
                user = Student1;
                return user;
            }
            else
            {
                return null;
            }
        }
    }
}
