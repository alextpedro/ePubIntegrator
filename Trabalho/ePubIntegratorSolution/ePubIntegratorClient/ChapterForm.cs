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
        List<int> chapterIdx = new List<int>();
        int bookmarkIndex;

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

            listBox.Items.Clear();
            chapters.Clear();
            chapterIdx.Clear();

            navPoints = _epub.TOC;
            int chIdx = 0;
            if (navPoints.Count != 0) 
            {
                tocAvailable = true;
                
                foreach (NavPoint item in navPoints)
                {
                    listBox.Items.Add(item.Title);
                    chapterIdx.Add(chIdx);
                    chapters.Add(item.Title);
                    chIdx++;
                }
            }
            else //se não existirem navPoints
            {
                tocAvailable = false;
                int chNameIdx = 0;
                foreach (DictionaryEntry item in _epub.Content)
                {
                    chNameIdx++;
                    String ch = "Chapter " + chNameIdx;
                    listBox.Items.Add(ch);
                    chapterIdx.Add(chIdx);
                    chapters.Add(ch);
                    chIdx++;
                }
            }
        }

        private void repopulateLists(List<string> chapters, List<int> chapterIdx)
        {
            this.chapters = chapters;
            this.chapterIdx = chapterIdx;
            listBox.Items.Clear();
            foreach (String chapter in this.chapters)
            {
                listBox.Items.Add(chapter);
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //escrever conteudo do capítulo no webBrowserObject
            String htmlText;
            if (tocAvailable) htmlText = navPoints[chapterIdx[listBox.SelectedIndex]].ContentData.Content;
            else htmlText = ((ContentData)_epub.Content[chapterIdx[listBox.SelectedIndex]]).Content;
            webBrowser1.DocumentText = htmlText;
            
            //carregar favoritos/bookmarks
            String chapter = chapters[listBox.SelectedIndex];
            checkBoxFav.Checked = bfHandler.getFavChapterValue(user, book, chapter);
            checkBoxBkmrk.Checked = bfHandler.getBmrkChapterValue(user, book, chapter);
        }

        private void checkBoxFav_Click(object sender, EventArgs e)
        {
            bfHandler.updateChapterNode(user, book, "favourite", chapters[chapterIdx[listBox.SelectedIndex]], checkBoxFav.Checked);
        }

        private void filter(Boolean favourite)
        {
            loadContents();
            List<String> newChapters = new List<string>();
            List<int> newChapterIdx = new List<int>();
            int counter = 0;
            foreach (string chapter in chapters)
            {
                if (favourite)
                {
                    if (bfHandler.getFavChapterValue(user, book, chapter))
                    {
                        newChapters.Add(chapter);
                        newChapterIdx.Add(chapterIdx[counter]);
                    }
                }
                else
                {
                    if (bfHandler.getBmrkChapterValue(user, book, chapter))
                    {
                        newChapters.Add(chapter);
                        newChapterIdx.Add(chapterIdx[counter]);
                    }
                }
                counter++;
            } repopulateLists(newChapters, newChapterIdx);
        }

        private void radioButtonFav_CheckedChanged(object sender, EventArgs e)
        {
            filter(true);
        }

        private void radioButtonBmrk_CheckedChanged(object sender, EventArgs e)
        {
            filter(false);
        }

        private void buttonGoBmrk_Click(object sender, EventArgs e)
        {
            int idx = 0;
            List<int> bookmarks = new List<int>();
            foreach (string chapter in chapters)
            {
                if (bfHandler.getBmrkChapterValue(user, book, chapter))
                {
                    bookmarks.Add(idx);
                }
                idx++;
            }
            bookmarkIndex = bookmarks[idx];
        }

        private void radioButtonAll_CheckedChanged(object sender, EventArgs e)
        {
            loadContents();
        }

        private void checkBoxBkmrk_Click(object sender, EventArgs e)
        {
            bfHandler.updateChapterNode(user, book, "bookmark", chapters[chapterIdx[listBox.SelectedIndex]], checkBoxBkmrk.Checked);
        }
    }
}
