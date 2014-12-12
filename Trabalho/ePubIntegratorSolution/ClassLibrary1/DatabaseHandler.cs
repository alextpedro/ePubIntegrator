using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePubCloudDatabaseLibrary
{
    public class DatabaseHandler
    {
        public void addUserWLogin(string username, string password)
        {
            ServiceePubModelContainer context = new ServiceePubModelContainer();

            try
            {
                Login l = context.LoginSet.Where(i => i.Username == username).FirstOrDefault();
                if (l == null)
                {
                    User newUser = new User();
                    //newUser = context.UserSet.where(

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

                throw new TaskCanceledException("An unknown error occurred.");
            }
        }
    }
}
