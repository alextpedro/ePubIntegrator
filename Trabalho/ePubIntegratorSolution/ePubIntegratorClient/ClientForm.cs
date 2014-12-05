﻿using System;
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
        Book selectedBook;

        public ClientForm(String user)
        {
            InitializeComponent();
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
                clearBook();
                reloadBooks();
            }
        }

        private void listBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            Epub selectedEpub = bookList[listBooks.SelectedIndex];
            selectedBook = new Book(selectedEpub);
            labelTitle.Text = selectedBook.Title;
            labelPublisher.Text = selectedBook.Publisher;
            labelDate.Text = selectedBook.Date;
            labelLanguage.Text = selectedBook.Language;
            labelCreator.Text = selectedBook.Creator;
            labelSubject.Text = selectedBook.Subject;
            labelDesc.Text = selectedBook.Description;
        }

        private void clearBook()
        {
            listBooks.Items.Clear();
            labelTitle.Text = "";
            labelPublisher.Text = "";
            labelDate.Text = "";
            labelLanguage.Text = "";
            labelCreator.Text = "";
            labelSubject.Text = "";
            labelDesc.Text = "";
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            ReadForm readForm = new ReadForm(selectedBook);
            readForm.ShowDialog();
        }

        private void reloadBooks()
        {
            string[] epubList;
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
            catch (Exception)
            {
                //DEU ERRO A LER ALGUM LIVRO ESTUPIDO
                throw;
            }
            if (listBooks.Items.Count != 0) listBooks.SelectedIndex = 0; //Seleciona o primeiro livro
        }
    }
}
