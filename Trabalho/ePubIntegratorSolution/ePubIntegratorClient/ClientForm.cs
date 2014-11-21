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
        public ClientForm(String user)
        {
            InitializeComponent();
            labelUser.Text = user;

            string[] epubList;
            epubList = System.IO.Directory.GetFiles(@textBoxBookPath.Text);


            List<Epub> bookList = new List<Epub>();
            foreach (string epubfile in epubList)
            {
                bookList.Add(new Epub(epubfile));
                listBooks.Items.Add(new Epub(epubfile).Title[0]);
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
