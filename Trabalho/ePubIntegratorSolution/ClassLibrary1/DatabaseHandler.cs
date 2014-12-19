using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eBdb.EpubReader;

namespace ePubCloudDatabaseLibrary
{
    public static class DatabaseHandler
    {
        static ServiceePubModelContainer context = new ServiceePubModelContainer();

        public static void AddUserWLogin(string username, string password, string email, string address, DateTime birthdate)
        {

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

                    newUser.Login = newLogin;

                    context.UserSet.Add(newUser);
                    context.LoginSet.Add(newLogin);
                    context.SaveChanges();
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


        public static void GetUserStatistics(int userID)
        {
            throw new NotImplementedException();
        }

        public static void RegistereBook(Epub neweBook)
        {
            //throw new NotImplementedException();
            eBook ebook = new eBook();
            ebook.Language = neweBook.Language.ToString(); //Maybe the database needs to handle multiple languages?
            ebook.Category = neweBook.Subject.ToString(); //Maybe several categories

            foreach (string title in neweBook.Title)
	        {
		        eBookTitles newTitle = new eBookTitles();
                newTitle.Title = title;
                context.eBookTitlesSet.Add(newTitle);

                ebook.eBookTitles.Add(newTitle);
	        }
            
            foreach (string author in neweBook.Contributer)
            {
                eBookAuthors newAuthor = new eBookAuthors();
                newAuthor.Name = author;
                context.eBookAuthorsSet.Add(newAuthor);

                ebook.eBookAuthors.Add(newAuthor);

            }

            foreach (string publisher in neweBook.Publisher)
            {
                eBookPublisher newPublisher = new eBookPublisher();
                newPublisher.Name = publisher;
                context.eBookPublisherSet.Add(newPublisher);

                ebook.eBookPublisher.Add(newPublisher);
            }


            context.eBookSet.Add(ebook);
            context.SaveChanges();
        }
    }
}
