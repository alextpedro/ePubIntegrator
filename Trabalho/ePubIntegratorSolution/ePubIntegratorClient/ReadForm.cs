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
    public partial class ReadForm : Form
    {
        private Book selectedBook;

        public ReadForm(Book selectedBook)
        {
            this.selectedBook = selectedBook;
            this.Text = selectedBook.Title;
        }
    }
}
