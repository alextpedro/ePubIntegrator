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

        public ChapterForm(Epub epub)
        {
            _epub = epub;
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
                }
            }
            else
            {
                tocAvailable = false;
                int chIdx = 0;
                foreach (DictionaryEntry item in _epub.Content)
                {
                    chIdx++;
                    listBox.Items.Add("Chapter " + chIdx);
                }
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String htmlText;
            if (tocAvailable) htmlText = navPoints[listBox.SelectedIndex].ContentData.Content;
            else htmlText = ((ContentData)_epub.Content[listBox.SelectedIndex]).Content;
            webBrowser1.DocumentText = htmlText;
        }
    }
}
