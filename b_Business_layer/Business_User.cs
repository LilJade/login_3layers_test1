using System;
using System.Collections.Generic;
using System.Text;
using Entity_layer;
using a_Data_layer;

namespace b_Business_layer
{
    public class Business_User
    {
        Data_User data = new Data_User();
        public Entity_User Business_Login(Entity_User user) {
            Entity_User access = data.Login(user);

            if (access != null)
            {
                return access;
            }
            else
            {
                return null;
            }
        }
    }
}
