using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePubCloudDatabaseLibrary
{
    public class DatabaseHandler
    {
        public void AddUserWLogin(string username, string password, string email, string address, DateTime birthdate)
        {
            ServiceePubModelContainer context = new ServiceePubModelContainer();

            try
            {
                Login l = context.LoginSet.Where(i => i.Username == username).FirstOrDefault();
                if (l == null)
                {
                    User newUser = new User();
                    newUser.Email = email;
                    newUser.Address = address;
                    newUser.DateOfBirth = birthdate;
                    

                    Login newLogin = new Login();
                    newLogin.Username = username;
                    newLogin.Password = password;
                    newLogin.User = newUser;
                }
                else
                {
                    throw new TaskCanceledException("User already exists!");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        

    }
}
