﻿using ePubIntegratorClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace ePubIntegratorClient
{
    public partial class LoginForm : Form
    {

        private XmlDocument xmlDoc;
        private String xmlPath;
        private String rootPath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));

        public LoginForm()
        {
            InitializeComponent();
            xmlDoc = new XmlDocument();
            xmlPath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "/config.xml";
            xmlDoc.Load(xmlPath);

            textBoxLogin.Text = xmlDoc.SelectSingleNode("/config/lastlogin").InnerText;
            textBoxServer.Text = xmlDoc.SelectSingleNode("/config/lastserver").InnerText;
            labelStatus.Text = "Last Login: " + xmlDoc.SelectSingleNode("/config/lasttime").InnerText;

            button1.TabIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //verificar login e pw com o webservice, se falhar entrar offline

            //Obter ultimas configurações introduzidas
            //xmlDoc.SelectSingleNode("/config/lastlogin").InnerText = textBoxLogin.Text;
            //xmlDoc.SelectSingleNode("/config/lastserver").InnerText = textBoxServer.Text;
            //xmlDoc.SelectSingleNode("/config/lasttime").InnerText = DateTime.Now.ToString();
            //xmlDoc.Save(xmlPath);

            //Login teste
            ConfigHandler ch = new ConfigHandler(rootPath);
            ch.loginUser(textBoxLogin.Text, textBoxServer.Text);

            ///////////


            ClientForm clientForm = new ClientForm(textBoxLogin.Text);
            //Esconde o formulario de login
                this.Hide();
            //Invoca o novo formulario
                clientForm.ShowDialog();
            //Fecha o formulario de login quando terminar a execução do segundo form
                this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
