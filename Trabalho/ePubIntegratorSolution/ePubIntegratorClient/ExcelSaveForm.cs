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
    public partial class ExcelSaveForm : Form
    {
        public ExcelSaveForm()
        {
            InitializeComponent();
        }

        private void buttonPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxPath.Text = folderBrowserDialog1.SelectedPath;
            } 
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            ExcelHandler eh = new ExcelHandler();
            eh.saveExcelAs(textBoxPath.Text, textBoxName.Text);
        }
    }
}
