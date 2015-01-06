using System;
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
    public partial class FacebookForm : Form
    {
        public FacebookForm()
        {
            InitializeComponent();
        }

        private void FacebookForm_Load(object sender, EventArgs e)
        {
            String website = "http://epubintegrator.byethost7.com/";
            String uri = "https://www.facebook.com/sharer/sharer.php?app_id=309437425817038&u="+website+"&display=popup&ref=plugin";
            webBrowser1.Url = new Uri(uri);
        }
    }
}
