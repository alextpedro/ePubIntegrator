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
            startRead = dateTime;
        }

        internal void stopReading(DateTime dateTime)
        {
            stopRead = dateTime;
            double time = calcTime();
            string xmlTime = ch.getReadTime(user);
            if (xmlTime == "") xmlTime = "0";
            double oldTime = Convert.ToDouble(xmlTime);
            ch.setReadtime((oldTime + time).ToString(), user);
        }

        private double calcTime()
        {
            var timeSpan = new TimeSpan(startRead.Ticks - stopRead.Ticks);
            double seconds = Math.Abs(timeSpan.TotalSeconds);
            return seconds;
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
            const int MINUTE = 60;
            const int HOUR = 60 * MINUTE;
            double dbl = Convert.ToDouble(ch.getReadTime(user));
            int seconds = Convert.ToInt32(dbl);
            
            if (seconds < MINUTE) return seconds+"s";
            if (seconds >= MINUTE && seconds < HOUR) return seconds / MINUTE + "m";
            if (seconds >= HOUR) return seconds / MINUTE / HOUR + "h";
            else return "Unknown";
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
