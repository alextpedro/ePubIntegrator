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
        public ReadForm(Epub epub)
        {
            InitializeComponent();
            openBookAsHTML(epub);
        }

        private void openBookAsHTML(Epub epub)
        {
            Book book = new Book(epub);
            this.Text = "Reading: " + book.Title;
            string htmlText = epub.GetContentAsHtml();
            webBrowser1.DocumentText = htmlText;
        }

        private void ReadForm_Load(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri("https://www.facebook.com/dialog/feed?%20app_id=145634995501895%20&display=popup&caption=An%20example%20caption%20&link=https%3A%2F%2Fdevelopers.facebook.com%2Fdocs%2F%20&redirect_uri=https://developers.facebook.com/tools/explorer");
        }
    }
}
