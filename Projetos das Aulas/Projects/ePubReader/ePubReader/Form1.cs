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

namespace ePubReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Init epub object.
            Epub epub = new Epub(@"C:\Users\2100970\Downloads\ebookExample1.epub");

            //Get book title (Every epub file can have multiple titles)
            string title = epub.Title[0];
            textBox1.Text = title;

            //Get book authors (Every epub file can have multiple authors)
            string author = epub.Creator[0];

            //Get all book content as plain text
            string plainText = epub.GetContentAsPlainText();

            //Get all book content as html text
            string htmlText = epub.GetContentAsHtml();

            //Get some part of book content
            ContentData contentData = epub.Content[0] as ContentData;

            //Get Table Of Contents (TOC)
            List<NavPoint> navPoints = epub.TOC;
            webBrowser1.DocumentText = htmlText;

            foreach (NavPoint item in navPoints)
            {
                listBox1.Items.Add(item.Title);
            }
        }
    }
}
