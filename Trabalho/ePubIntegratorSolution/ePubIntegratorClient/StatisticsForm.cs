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
        public StatisticsForm(string user)
        {
            InitializeComponent();
            Statistics stats = new Statistics(user);

            labelUser.Text = "User: "+user;
            labelLogin.Text = "Times Logged: "+stats.getLoginCount();
            labelBooks.Text = "Books in Library: "+stats.getBooks();
            labelReadtime.Text = "Reading Time: " + stats.getReadtimes();
            labelFavourites.Text = "Favourites: "+stats.getFavourites();
            labelBookmarks.Text = "Bookmarks: "+stats.getBookmarks();
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
