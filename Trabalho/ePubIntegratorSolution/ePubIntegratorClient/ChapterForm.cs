using eBdb.EpubReader;
using System;
using System.Collections;
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
    public partial class ChapterForm : Form
    {

        List<NavPoint> navPoints;
        Boolean tocAvailable;
        Epub _epub;
        Book book;
        String user;
        BookFavHandler bfHandler = new BookFavHandler();
        List<String> chapters = new List<string>();

        public ChapterForm(String user, Epub epub)
        {
            this.user = user;
            _epub = epub;
            book = new Book(epub);
            InitializeComponent();
            loadContents();
        }

        private void loadContents()
        {
            navPoints = _epub.TOC;

            if (navPoints.Count != 0) 
            {
                tocAvailable = true;
                foreach (NavPoint item in navPoints)
                {
                    listBox.Items.Add(item.Title);
                    chapters.Add(item.Title);
                }
            }
            else //se não existirem navPoints
            {
                tocAvailable = false;
                int chIdx = 0;
                foreach (DictionaryEntry item in _epub.Content)
                {
                    chIdx++;
                    String ch = "Chapter " + chIdx;
                    listBox.Items.Add(ch);
                    chapters.Add(ch);
                }
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //escrever conteudo do capítulo no webBrowserObject
            String htmlText;
            if (tocAvailable) htmlText = navPoints[listBox.SelectedIndex].ContentData.Content;
            else htmlText = ((ContentData)_epub.Content[listBox.SelectedIndex]).Content;
            webBrowser1.DocumentText = htmlText;
            
            //carregar favoritos/bookmarks
            String chapter = chapters[listBox.SelectedIndex];
            checkBoxFav.Checked = bfHandler.getFavChapterValue(user, book, chapter);
            checkBoxBkmrk.Checked = bfHandler.getBmrkChapterValue(user, book, chapter);
        }

        private void checkBoxFav_Click(object sender, EventArgs e)
        {
            bfHandler.updateChapterNode(user, book, "favourite", chapters[listBox.SelectedIndex], checkBoxFav.Checked);
        }

        private void radioButtonFav_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonBmrk_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonGoBmrk_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonAll_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxBkmrk_Click(object sender, EventArgs e)
        {
            bfHandler.updateChapterNode(user, book, "bookmark", chapters[listBox.SelectedIndex], checkBoxBkmrk.Checked);
        }
    }
}
