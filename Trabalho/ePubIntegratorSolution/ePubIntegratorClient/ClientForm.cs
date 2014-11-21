using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using eBdb.EpubReader;

namespace ePubIntegratorClient
{
    public partial class ClientForm : Form
    {

        private String user;
        public ClientForm(String user)
        {
            InitializeComponent();
            labelUser.Text = user;

            string[] epubList;
            epubList = System.IO.Directory.GetFiles(@textBoxBookPath.Text);


            Epub[] bookList;
            foreach (string epubfile in epubList)
            {

                bookList = new Epub(epubfile);

                Epub ep = new Epub(epubfile);
                if (ep != null)
                {
                    string title = "unknown";
                    if (ep.Title.Count > 0)
                    {
                        title = ep.Title[0];
                    }
                    listBooks.Items.Add(epubfile);
                }
            }
        }

        private void buttonBookPath_Click(object sender, EventArgs e)
        {

        }

        private void ClientForm_Load(object sender, EventArgs e)
        {

        }
    }
}
