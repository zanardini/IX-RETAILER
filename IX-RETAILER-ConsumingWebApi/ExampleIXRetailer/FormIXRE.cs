using Org.BouncyCastle.Cms;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ExampleIXRetailer
{
    public partial class FormIXRE : Form
    {
        private const string ClientId = "My Client ID";
        private const string ClientSecret = "My Client Secret";
        // To request a couple of ClientID and ClientSECRET for your team navigate this link: https://www.arxivar.it/it/richiesta-clientid-ixfe-v3

        private string _urlWebApiOAuth = "https://ixapidemo.arxivar.it/oauth/";
        private string _urlWebApiRetailer = "https://ixapidemo.arxivar.it/Retailer/";

        private string _authToken;



        public FormIXRE()
        {
            InitializeComponent();

            if (System.IO.File.Exists(@"c:\temp\Ix\UsernameIxFe.txt"))
                textBoxUsernameIxV3.Text = System.IO.File.ReadAllText(@"c:\temp\Ix\UsernameIxFe.txt");
            if (System.IO.File.Exists(@"c:\temp\Ix\PasswordIxFe.txt"))
                textBoxPasswordIxV3.Text = System.IO.File.ReadAllText(@"c:\temp\Ix\PasswordIxFe.txt");
        }

        private void buttonLoginIxV3_Click(object sender, EventArgs e)
        {
            try
            {
                IO.Swagger.Api.AuthorizationApi authorizationApi = new IO.Swagger.Api.AuthorizationApi(_urlWebApiOAuth);
                try
                {
                    var tokenResult = authorizationApi.Token(new IO.Swagger.Model.TokenRequest(ClientId, ClientSecret, IO.Swagger.Model.TokenRequest.GrantTypeEnum.Password, textBoxUsernameIxV3.Text, textBoxPasswordIxV3.Text, null, null, "1.0"));
                    _authToken = tokenResult.AccessToken;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error during login: " + ex.ToString());
                }
                tabControl1.Enabled = true;
                // If the connection is established correctly I load the aoo collection
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Esito Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
    }
}