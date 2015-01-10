using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePubIntegratorClient
{
    class Statistics
    {
        BookFavHandler bfh = new BookFavHandler();
        ConfigHandler ch = new ConfigHandler();
        string user;
        DateTime startRead, stopRead;

        public Statistics(string user)
        {
            this.user = user;
            ch.setFavourites(bfh.getFavourites(user).ToString(), user);
            ch.setBookmarks(bfh.getBookmarks(user).ToString(), user);
        }

        internal void countLogin()
        {
            if (ch.getLoginCount(user) != "")
            {
                int value = Convert.ToInt32(ch.getLoginCount(user));
                value++;
                ch.setLoginCount(value.ToString(), user);
            }
            else ch.setLoginCount("1", user);
        }

        internal void bookCount(int value)
        {
            ch.setBooks(value.ToString(), user);
        }

        internal void startReading(DateTime dateTime)
        {

        }

        internal void stopReading(DateTime dateTime)
        {
            ;
        }

        private string calcTime()
        {
            return null;
            //const int SECOND = 1;
            //const int MINUTE = 60 * SECOND;
            //const int HOUR = 60 * MINUTE;

            //var timeSpan = new TimeSpan(DateTime.UtcNow.Ticks - yourDate.Ticks);
            //double delta = Math.Abs(timeSpan.TotalSeconds);

            //if (delta < 0)return "not yet";
            //if (delta < 1 * MINUTE)return timeSpan.Seconds == 1 ? "one second ago" : timeSpan.Seconds + " seconds ago";
            //if (delta < 2 * MINUTE)return "a minute ago";
            //if (delta < 45 * MINUTE)return timeSpan.Minutes + " minutes ago";
            //if (delta < 90 * MINUTE)return "an hour ago";
            //if (delta < 24 * HOUR)return timeSpan.Hours + " hours ago";
        }

        public String getLoginCount()
        {
            return ch.getLoginCount(user);
        }

        public String getBooks()
        {
            return ch.getBooks(user);
        }

        public String getReadtimes()
        {
            return ch.getReadTime(user);
        }

        public String getFavourites()
        {
            return ch.getFavourites(user);
        }

        public String getBookmarks()
        {
            return ch.getBookmarks(user);
        }
    }
}
