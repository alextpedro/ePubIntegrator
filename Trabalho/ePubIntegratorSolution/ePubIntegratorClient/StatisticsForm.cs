using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ePubIntegratorClient
{
    public partial class StatisticsForm : Form
    {
        Statistics stats;
        List<string> descAchiev;
        List<int> myAchiev;

        public StatisticsForm(string user)
        {
            InitializeComponent();
            stats = new Statistics(user);

            labelUser.Text = "User: "+user;
            labelLogin.Text = "Times Logged: "+stats.getLoginCount();
            labelBooks.Text = "Books in Library: "+stats.getBooks();
            labelReadtime.Text = "Reading Time: " + stats.getReadtimes();
            labelFavourites.Text = "Favourites: "+stats.getFavourites();
            labelBookmarks.Text = "Bookmarks: "+stats.getBookmarks();
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            List<string> listAchiev = new List<string>();
            descAchiev = new List<string>();
            myAchiev = new List<int>();

            listAchiev.Add("First time!, Yey");
            listAchiev.Add("50 Gates of Wisdom");
            listAchiev.Add("A small bookshelf");
            listAchiev.Add("Librarian");
            listAchiev.Add("Top5");
            listAchiev.Add("Top10");
            listAchiev.Add("Everything is my Favourite!");
            listAchiev.Add("Reading one at the time.");
            listAchiev.Add("Ribbon Partey");

            descAchiev.Add("Log in for the first time ever.");
            descAchiev.Add("Log in 50 times or more.");
            descAchiev.Add("Have less than 10 books in your library");
            descAchiev.Add("Have more than 10 books in your library");
            descAchiev.Add("Have 5 favourite books");
            descAchiev.Add("Have 10 favourite books");
            descAchiev.Add("Have more than 10 favourite books");
            descAchiev.Add("Have one bookmarked book");
            descAchiev.Add("Have more than one bookmarked book");


            if (Convert.ToInt32(stats.getLoginCount()) == 1)
            {
                comboBox1.Items.Add(listAchiev[0]);
                myAchiev.Add(0);
            }
            else if (Convert.ToInt32(stats.getLoginCount()) >= 50)
            {
                comboBox1.Items.Add(listAchiev[1]);
                myAchiev.Add(1);
            }
            if (Convert.ToInt32(stats.getLoginCount()) <= 10)
            {
                comboBox1.Items.Add(listAchiev[2]);
                myAchiev.Add(2);
            }
            else
            {
                comboBox1.Items.Add(listAchiev[3]);
                myAchiev.Add(3);
            }
            if (Convert.ToInt32(stats.getFavourites()) == 5)
            {
                comboBox1.Items.Add(listAchiev[4]);
                myAchiev.Add(4);
            }
            else if (Convert.ToInt32(stats.getFavourites()) == 10)
            {
                comboBox1.Items.Add(listAchiev[5]);
                myAchiev.Add(5);
            }
            else if (Convert.ToInt32(stats.getFavourites()) > 10)
            {
                comboBox1.Items.Add(listAchiev[6]);
                myAchiev.Add(6);
            }
            if (Convert.ToInt32(stats.getBookmarks()) == 1)
            {
                comboBox1.Items.Add(listAchiev[7]);
                myAchiev.Add(7);
            }
            else
            {
                comboBox1.Items.Add(listAchiev[8]);
                myAchiev.Add(8);
            }

            labelAchievNum.Text = myAchiev.Count.ToString();
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = descAchiev[7];
            labelText.Text = descAchiev[myAchiev[comboBox1.SelectedIndex]];
        }
    }
}
