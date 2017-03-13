using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelManagerModels;
using HotelManagerCommon;
namespace HotelManagerBLL
{
    public class UserManager
    {
        FileOperation file = new FileOperation();
        public User LoginInitial()
        {
            User u = new User();
            u=file.LoadPassword();
            return u;
        }

        
        public User LoginInfo(bool state,User user)
        {
            User u = new User();
            if (state == true)
            {
                file.SavePassword(state,user);

            }
            else
            {
                u = file.LoadPassword();
            }
            return user;
        }
    }
}
