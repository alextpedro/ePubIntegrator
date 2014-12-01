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
using ClassLibraryePub;

namespace ePubIntegratorClient
{
    public partial class ClientForm : Form
    {
        List<Epub> bookList;
        public ClientForm(String user)
        {
            InitializeComponent();
            labelUser.Text = user;
            string[] epubList;

            try
            {
                epubList = System.IO.Directory.GetFiles(@textBoxBookPath.Text, "*.epub");
            }
            catch (Exception)
            {
                epubList = null;
            }

            if (epubList != null)
            {
                bookList = new List<Epub>();
                
                foreach (string epubfile in epubList)
                {
                    bookList.Add(new Epub(epubfile));
                    listBooks.Items.Add(new Epub(epubfile).Title[0]);
                }
                listBooks.SelectedIndex = 0; //Seleciona o primeiro livro
            }
        }

        private void buttonBookPath_Click(object sender, EventArgs e)
        {

        }

        private void ClientForm_Load(object sender, EventArgs e)
        {

        }

        private void listBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            Epub selectedBook = bookList[listBooks.SelectedIndex];
            Book book = new Book(selectedBook);
            labelTitle.Text = book.Coverage;
            //labelTitle.Text = selectedBook.Title[0];
            //System.Diagnostics.Debug.WriteLine("title " + selectedBook.Title[0]);
            //if (!(selectedBook.Contributer.Count == 0)) System.Diagnostics.Debug.WriteLine("contributer " + selectedBook.Contributer[0]);


        }
    }
}
