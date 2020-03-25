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

        private void button1_Click(object sender, EventArgs e)
        {

            // EndPoint per gestione anagrafiche (Distributori\Rivenditori)
            IO.Swagger.Api.AnagraficheApi anagraficheApi = new IO.Swagger.Api.AnagraficheApi(_urlWebApiRetailer);

            //EndPoint per la gestione del contratto in generale
            IO.Swagger.Api.ContrattiApi contrattiApi = new IO.Swagger.Api.ContrattiApi(_urlWebApiRetailer);

            //EndPoint per la gestione del contratto di tipo cliente finale
            IO.Swagger.Api.ContrattoClienteFinaleApi contrattoClienteFinaleApi = new IO.Swagger.Api.ContrattoClienteFinaleApi(_urlWebApiRetailer);

            //EndPoint per la gestione del cliente
            IO.Swagger.Api.ClienteApi clienteApi = new IO.Swagger.Api.ClienteApi(_urlWebApiRetailer);

            //EndPoint per la gestione dell'aoo
            IO.Swagger.Api.AoosApi aoosApi = new IO.Swagger.Api.AoosApi(_urlWebApiRetailer);

            //EndPoint per la gestione dell'utente
            IO.Swagger.Api.UtentiApi utentiApi = new IO.Swagger.Api.UtentiApi(_urlWebApiRetailer);

            //EndPoint per la gestione dell'associazione utente\aoo
            IO.Swagger.Api.UtentiAooApi utentiAooApi = new IO.Swagger.Api.UtentiAooApi(_urlWebApiRetailer);

            //EndPoint per la gestione degli elenchi di contratti
            IO.Swagger.Api.AnagraficheContrattiApi anagraficheContrattiApi = new IO.Swagger.Api.AnagraficheContrattiApi(_urlWebApiRetailer);


            string nomeDistributore = "DISTRIBUTORE UNO";
            string nomeRivenditore = "RIVENDITORE UNO";


            //dato il mio utente connesso recupero i dati dei rivenditore per cui io posso lavorare
            var rivenditori = anagraficheApi.GetRivenditori(_authToken).Rivenditori;
            //tra tutti i rivenditori cerco quello che mi interessa
            var rivenditore = rivenditori.FirstOrDefault(x => x.Nome == nomeRivenditore);

            //chiedo a IX l'elenco dei distributori per cui l'utente connesso può lavorare in funzione del rivendotore indicato
            var ditributori = anagraficheApi.GetDistributori(new Guid(rivenditore.Identificativo), _authToken).Distributori;
            var distributore = ditributori.FirstOrDefault(x => x.Nome == nomeDistributore);

            //Recupero le fasce IX FE disponibili
            List<IO.Swagger.Model.FasciaIxResponse> fasceIxFeResponse = anagraficheApi.GetFasceIxFeContrattoClienteFinale(_authToken).FasceIx;
            foreach (var fasciaIxFe in fasceIxFeResponse)
            {
                var descrizione = fasciaIxFe.Descrizione;
                var valore = fasciaIxFe.Fascia;
            }

            //Recupero le fasce IX CE disponibili
            var fasceIxCe = anagraficheApi.GetFasceIxCeContrattoClienteFinale("IXCE", _authToken).FasceIxCe;
            foreach (var fasciaIxCe in fasceIxCe)
            {
                var valore = fasciaIxCe.Valore;
                var descrizione = fasciaIxCe.Descrizione;
                var tipoFascia = fasciaIxCe.TipoFascia;
            }

            //Recupera i comuni
            List<IO.Swagger.Model.ComuneResponse> comuni = anagraficheApi.GetComuni("", _authToken).Comuni;
            //Recupera i paesi
            List<IO.Swagger.Model.PaeseResponse> paesi = anagraficheApi.GetPaesi("", _authToken).Paesi;

            //Valida una partita iva
            IO.Swagger.Model.PartitaIvaValidatorResponse validaPartitaIvaResponse = anagraficheApi.ValidaPartitaIva(new IO.Swagger.Model.PartitaIvaValidatorRequest("12345678901"), _authToken);
            //Valida un codice fiscale
            IO.Swagger.Model.ValidationResponse validaCodiceFiscaleResponse = anagraficheApi.ValidaCodiceFiscale(new IO.Swagger.Model.CodiceFiscaleValidatorRequest("ldfwjklcnfw"), _authToken);


            //Fase di creazione contratto
            var descrizioneContratto = "Mio primo contratto";
            var idEsternoContratto = "Mio ID contratto";

            //Creo un contratto cliente standard
            IO.Swagger.Model.CreateContrattoRequest createContrattoRequest = new IO.Swagger.Model.CreateContrattoRequest(descrizioneContratto, idEsternoContratto, rivenditore.Identificativo, distributore.Identificativo);
            IO.Swagger.Model.CreateContrattoResponse createContrattoResponse = contrattoClienteFinaleApi.CreateContrattoClienteFinale(createContrattoRequest, _authToken);
            var identificativoContratto = createContrattoResponse.Identificativo;

            // creo il cliente

            IO.Swagger.Model.ClienteFinaleClienteRequest clienteFinaleClienteRequest = new IO.Swagger.Model.ClienteFinaleClienteRequest
                (
                "Identificativo cliente",  //???
                new IO.Swagger.Model.ClienteRequest("P.IVA", "Ragione Sociale", "Via", "Civico", "Comune", "Codice fiscale", "email", "telefono")
                );
            IO.Swagger.Model.ContrattoClienteResponse contrattoClienteResponse = clienteApi.InsertForClienteFinale(identificativoContratto, clienteFinaleClienteRequest, _authToken);
            var identificativoCliente = contrattoClienteResponse.Identificativo;

            // creo l'Area Organizzativa Omogenea

            IO.Swagger.Model.AooRequest aooRequest = new IO.Swagger.Model.AooRequest
                (
                 new IO.Swagger.Model.SedeLegaleAoo("P.IVA", "Ragione Sociale", "Via", "Civico", "Comune", "email", "telefono"),
                 new IO.Swagger.Model.DatiFiscaliAoo("Codice Fiscale", "Registro imprese", "Codice REA", "mail PEC"),
                 new IO.Swagger.Model.LegaleRappresentanteAoo("Nome", "Cognome", "Codice fiscale", "Cittadinanza")
                );
            IO.Swagger.Model.CreateAooRequest createAooRequest = new IO.Swagger.Model.CreateAooRequest(identificativoCliente, aooRequest);
            IO.Swagger.Model.AooResponse aooResponse = aoosApi.InsertAoo(identificativoContratto, createAooRequest, _authToken);
            var identificativoAoo = aooResponse.Identificativo;

            IO.Swagger.Model.ContrattoUtenteResponse contrattoUtenteResponse = utentiApi.InsertUtente(identificativoContratto, new IO.Swagger.Model.ContrattoUtenteRequest
                (
                    "UserName",
                    new IO.Swagger.Model.DatiGeneraliUtente("Nome", "Cognome", IO.Swagger.Model.DatiGeneraliUtente.SessoEnum.M, "Cittadidanza", "Comune di Nascita", false, "Paese Nascita Estero", "Comune Nascita Estero", new DateTime(1979, 10, 26)),
                    new IO.Swagger.Model.DatiResidenzaUtente("Via", "Civico", "Comune di residenza"),
                    new IO.Swagger.Model.DatiFiscaliUtente("Codice fiscale")
                ),
                _authToken
            );
            var identificativoUtente = contrattoUtenteResponse.Identificativo;

            //associo alla

            List<IO.Swagger.Model.AooUtenteRequest> listaUtentiAoo = new List<IO.Swagger.Model.AooUtenteRequest>();
            listaUtentiAoo.Add(new IO.Swagger.Model.AooUtenteRequest(identificativoUtente, true, null, null));//???
            utentiAooApi.InsertAooUtenti(identificativoContratto, identificativoAoo, new IO.Swagger.Model.AooUtentiRequest(listaUtentiAoo), _authToken);



            //Download PDF del contratto
            Stream contrattoStream = contrattiApi.GetCartaceoContratto(identificativoContratto, _authToken);

            //Upload del contratto PDF firmato
            contrattiApi.UploadControfirmato(identificativoContratto, contrattoStream, _authToken);

            //Lettura dello stato di approvazione di un contratto
            IO.Swagger.Model.StatoContrattoResponse statoContrattoResponse = contrattiApi.GetStatoContratto(identificativoContratto, _authToken);
            switch (statoContrattoResponse.Stato)
            {
                case IO.Swagger.Model.StatoContrattoResponse.StatoEnum.INELABORAZIONE:

                    //Dopo il salvataggio il contratto è elaborato in maniera asincrona per generare il pdf contrattuale
                    break;
                case IO.Swagger.Model.StatoContrattoResponse.StatoEnum.ATTESARISCONTRO:
                    //Una volta generato il pdf del contratto il sistema rimane in attesa del caricamento del controfirmato
                    break;
                case IO.Swagger.Model.StatoContrattoResponse.StatoEnum.CONTROFIRMATO:
                    //Controfirmato caricato, contratto in attesa di validazione da parte Help Desk
                    break;
                case IO.Swagger.Model.StatoContrattoResponse.StatoEnum.ATTIVATO:
                    //Contratto correttamente attivato
                    break;
                case IO.Swagger.Model.StatoContrattoResponse.StatoEnum.INERRORE:
                    //Il contratto è in errore, è necessario un intervento manuale di indagine
                    break;
                case IO.Swagger.Model.StatoContrattoResponse.StatoEnum.ANNULLATO:
                    //Il processamento del contratto è stato annullato
                    break;
                case IO.Swagger.Model.StatoContrattoResponse.StatoEnum.RIAPERTO:
                    //Il contratto è stato riaperto(normalmente per recuperare un contratto che era in errore)
                    break;
                default:
                    break;
            }

            //???
            //anagraficheContrattiApi.ElencoContratti(rivenditore.Identificativo, distributore.Identificativo, _authToken, null, null, null, null, null, null);

        }
    }
}