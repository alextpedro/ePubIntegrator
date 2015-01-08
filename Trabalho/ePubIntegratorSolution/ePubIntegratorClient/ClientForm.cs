using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eBdb.EpubReader;
using ePubIntegratorClient;
using System.IO;

namespace ePubIntegratorClient
{
    public partial class ClientForm : Form
    {
        private const string FAV = "favourite";
        private const string BMRK = "bookmark";

        List<Epub> bookList;
        Book selectedBook;
        Epub selectedEpub;
        String user;
        BookFavHandler bfHandler = new BookFavHandler();
        ConfigHandler configHandler = new ConfigHandler();
        Boolean offline;

        public ClientForm(String user, Boolean offline)
        {
            InitializeComponent();
            this.user = user;
            this.offline = offline;
            labelUser.Text = user;
            if (offline) buttonStats.Enabled = false;
            textBoxBookPath.Text = configHandler.getUserBookPath(user);
            reloadBooks();
        }

        private void buttonBookPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxBookPath.Text = folderBrowserDialog1.SelectedPath;
                configHandler.setBookPath(user, folderBrowserDialog1.SelectedPath);
                reloadBooks();
            } 
        }

        private void listBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedEpub = bookList[listBooks.SelectedIndex];
            selectedBook = new Book(selectedEpub);
            checkBoxFav.Checked = bfHandler.getFavValue(user, selectedBook);
            checkBoxBkmrk.Checked = bfHandler.getBmrkValue(user, selectedBook);

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

            int idx = 0;
            try
            {
                if (epubList != null)
                {
                    bookList = new List<Epub>();
                    
                    foreach (string epubfile in epubList)
                    {
                        bookList.Add(new Epub(epubfile));
                        listBooks.Items.Add(new Epub(epubfile).Title[0]);
                        idx++;
                    }
                    
                }
            }
            catch (Exception ex)
            {
                //DEU ERRO A LER ALGUM LIVRO ESTUPIDO
                MessageBox.Show("An error ocurred on book:\n"+epubList[idx]+
                    "\nPlease remove or fix selected book. Book list will now turn up blank. Sorry for the inconvenience.",
                    "Error loading books!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                clearBooks();
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                return;
            }
            enableButtons();
        }

        private void enableButtons()
        {
            if (listBooks.Items.Count != 0)
            {
                listBooks.SelectedIndex = 0; //Seleciona o primeiro livro
                buttonRead.Enabled = true;
                buttonChapters.Enabled = true;
                checkBoxFav.Enabled = true;
                checkBoxBkmrk.Enabled = true;
                checkBoxFav.Checked = bfHandler.getFavValue(user, selectedBook);
                checkBoxBkmrk.Checked = bfHandler.getBmrkValue(user, selectedBook);
            }
        }

        private void buttonChapters_Click(object sender, EventArgs e)
        {
            ChapterForm chapterForm = new ChapterForm(user, selectedEpub);
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
            bfHandler.updateFavBmrk(user, selectedBook, checkBoxFav.Checked, FAV);
        }

        private void checkBoxBkmrk_CheckedChanged(object sender, EventArgs e)
        {
            bfHandler.updateFavBmrk(user, selectedBook, checkBoxBkmrk.Checked, BMRK);
        }

        private void radioButtonAll_CheckedChanged(object sender, EventArgs e)
        {
            reloadBooks();
        }

        //filtra a lista por favoritos ou bookmarks (favoritos = true, bookmarks = false)
        private void filter(Boolean isfavourite)
        {
            reloadBooks();
            clearBooks();
            List<Epub> newBookList = new List<Epub>();
            foreach (Epub epub in bookList)
            {
                Book book = new Book(epub);
                Boolean value = false;
                if (isfavourite)
                {
                    value = bfHandler.getFavValue(user, book);
                }
                else
                {
                    value = bfHandler.getBmrkValue(user, book);
                }
                
                if (value)
                {
                    newBookList.Add(epub);
                    listBooks.Items.Add(epub.Title[0]);
                }
            }
            bookList = newBookList;
            enableButtons();
        }

        private void radioButtonFav_CheckedChanged(object sender, EventArgs e)
        {
            filter(true);
        }

        private void radioButtonBmrk_CheckedChanged(object sender, EventArgs e)
        {
            filter(false);
        }

        private void buttonFacebook_Click(object sender, EventArgs e)
        {
            FacebookForm faceForm = new FacebookForm();
            faceForm.ShowDialog();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {

        }
    }
}
