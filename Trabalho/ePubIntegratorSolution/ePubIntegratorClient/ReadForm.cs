using ePubIntegratorClient;
using eBdb.EpubReader;
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
    public partial class ReadForm : Form
    {
        string user;
        public ReadForm(string user, Epub epub)
        {
            this.user = user;
            InitializeComponent();
            openBookAsHTML(epub);
        }

        private void openBookAsHTML(Epub epub)
        {
            Book book = new Book(epub);
            this.Text = "Reading: " + book.Title;
            string htmlText = epub.GetContentAsHtml();
            webBrowser1.DocumentText = htmlText;

            ConfigHandler ch = new ConfigHandler();
            ch.setLastBook(book.Title, user);
            ch.setLastChapter("Unknown", user);
        }

        private void ReadForm_Load(object sender, EventArgs e)
        {
        }
    }
}
