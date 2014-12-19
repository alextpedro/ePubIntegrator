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
using ePubIntegratorClient;

namespace ePubIntegratorClient
{
    public partial class ClientForm : Form
    {
        List<Epub> bookList;
        Book selectedBook;
        Epub selectedEpub;
        String user;
        BookFavHandler bfHandler = new BookFavHandler(Application.StartupPath);

        public ClientForm(String user)
        {
            InitializeComponent();
            this.user = user;
            labelUser.Text = user;
            reloadBooks();

        }

        private void buttonBookPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxBookPath.Text = folderBrowserDialog1.SelectedPath;
                reloadBooks();
            }
        }

        private void listBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedEpub = bookList[listBooks.SelectedIndex];
            selectedBook = new Book(selectedEpub);
            checkBoxFav.Checked = bfHandler.getFavValue(user, selectedBook);

            labelTitle.Text = selectedBook.Title;
            labelPublisher.Text = selectedBook.Publisher;
            labelDate.Text = selectedBook.Date;
            labelLanguage.Text = selectedBook.Language;
            labelCreator.Text = selectedBook.Creator;
            labelSubject.Text = selectedBook.Subject;
            labelDesc.Text = selectedBook.Description;
        }

        private void clearBooks()
        {
            buttonRead.Enabled = false;
            buttonChapters.Enabled = false;
            checkBoxFav.Enabled = false;
            checkBoxBkmrk.Enabled = false;
            listBooks.Items.Clear();
            labelTitle.Text = "";
            labelPublisher.Text = "";
            labelDate.Text = "";
            labelLanguage.Text = "";
            labelCreator.Text = "";
            labelSubject.Text = "";
            labelDesc.Text = "";
        }
        
        private void reloadBooks()
        {
            string[] epubList;
            clearBooks();
            try
            {
                epubList = System.IO.Directory.GetFiles(@textBoxBookPath.Text, "*.epub");
            }
            catch (Exception)
            {
                epubList = null;
            }
            try
            {
                if (epubList != null)
                {
                    bookList = new List<Epub>();

                    foreach (string epubfile in epubList)
                    {
                        bookList.Add(new Epub(epubfile));
                        listBooks.Items.Add(new Epub(epubfile).Title[0]);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                //DEU ERRO A LER ALGUM LIVRO ESTUPIDO
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            if (listBooks.Items.Count != 0)
            {
                listBooks.SelectedIndex = 0; //Seleciona o primeiro livro
                buttonRead.Enabled = true;
                buttonChapters.Enabled = true;
                checkBoxFav.Enabled = true;
            }
        }

        private void buttonChapters_Click(object sender, EventArgs e)
        {
            ChapterForm chapterForm = new ChapterForm(selectedEpub);
            chapterForm.ShowDialog();
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            ReadForm readForm = new ReadForm(selectedEpub);
            readForm.ShowDialog();
        }

        private void buttonRefresh_Click_1(object sender, EventArgs e)
        {
            reloadBooks();
        }

        private void checkBoxFav_CheckedChanged(object sender, EventArgs e)
        {
            bfHandler.updateFavorite(user, selectedBook, checkBoxFav.Checked);
        }
    }
}
