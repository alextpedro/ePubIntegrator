using ePubIntegratorClient;
using ServiceePubCloud;
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
using ePubIntegratorClient.ServiceReference1;
using System.ServiceModel;

namespace ePubIntegratorClient
{
    public partial class LoginForm : Form
    {
        private XmlDocument xmlDoc;
        private String xmlPath;
        private String rootPath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
        ConfigHandler ch;
        ServiceReference1.IePubCloudClient webservice;

        public LoginForm()
        {
            InitializeComponent();
            
            ch = new ConfigHandler();
            
            xmlDoc = new XmlDocument();
            xmlPath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "/config.xml";
            xmlDoc.Load(xmlPath);

            //textBoxLogin.Text = xmlDoc.SelectSingleNode("/config/lastlogin").InnerText;
            textBoxServer.Text = xmlDoc.SelectSingleNode("/config/lastserver").InnerText;
            labelStatus.Text = "Last Login: " + xmlDoc.SelectSingleNode("/config/lasttime").InnerText;

            List<String> infolist = ch.getLastUserInfo();
            textBoxLogin.Text = infolist[0];
            textBoxServer.Text = infolist[1];
            labelStatus.Text = "Last Login: " + infolist[2];
            button1.TabIndex = 0;
        }

        private Boolean tryLogin()
        {
            string user = textBoxLogin.Text;
            string password = textBoxPassword.Text;
            string server = textBoxServer.Text;

            webservice = new IePubCloudClient();
            try
            {
                webservice.Endpoint.Address = new EndpointAddress(server);
                return webservice.VerifyLogin(user, password);
            }
            catch (EndpointNotFoundException)
            {
                MessageBox.Show("Server with address " + server + " not responding.",
                "Server offline",
                MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            catch (UriFormatException)
            {
                MessageBox.Show("Server address: " + server + " invalid.",
                "Invalid server address",
                MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                "Unknown Server Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //verificar login e pw com o webservice, se falhar entrar offline
            Boolean offline;

            if (tryLogin())
            {
                // login bem sucedido
                offline = false;
            }
            else
            {
                // modo offline
                offline = true;
                MessageBox.Show("Login failed on: " + textBoxServer.Text +
                "\nSystem will enter offline.",
                "Offline mode",
                MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }

            ConfigHandler ch = new ConfigHandler();
            ch.loginUser(textBoxLogin.Text, textBoxServer.Text);

            //Cria o formulário
                ClientForm clientForm = new ClientForm(textBoxLogin.Text, offline);
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

        private void button2_Click(object sender, EventArgs e)
        {
            webservice = new IePubCloudClient();
            webservice.Endpoint.Address = new EndpointAddress(textBoxServer.Text);
            webservice.RegisterUser(textBoxLogin.Text, textBoxPassword.Text, null, null, DateTime.Now);
            
            Boolean success = false;
            //success = webservice.RegisterUser(textBoxLogin.Text, textBoxPassword.Text, null, null, DateTime.Now);
            string message;
            if (success) message = "successful";
            else message = "unsuccessful";

            MessageBox.Show("User " + textBoxLogin.Text +
                " registration " + message,
                "User Registration",
                MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
    }
}
