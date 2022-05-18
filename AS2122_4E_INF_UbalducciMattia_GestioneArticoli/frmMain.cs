using AS2122_4E_INF_UbalducciMattia_GestioneArticoli.Library;
namespace AS2122_4E_INF_UbalducciMattia_GestioneArticoli
{
    public partial class frmMain : Form
    {
        Dictionary<string, Articolo> articoli;
        public frmMain()
        {
            InitializeComponent();
            articoli = new Dictionary<string, Articolo>();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnAggiungiModifica_Click(object sender, EventArgs e)
        {
           if(articoli.ContainsKey(txtCodice.Text))
            {
                articoli[txtCodice.Text] = new Articolo(txtCodice.Text,cmbUnitaDiMisura.Text,txtDescrizione.Text,Convert.ToDouble(txtPrezzo.Text));
            }
            else
            {
                articoli.Add(txtCodice.Text, new Articolo(txtCodice.Text, cmbUnitaDiMisura.Text, txtDescrizione.Text, Convert.ToDouble(txtPrezzo.Text)));
            }
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            switch (cmbVisualizza.Text)
            {
                case "Visualizza Articoli":

                lstVisualizza.Items.Clear();
                foreach (KeyValuePair<string, Articolo> articolo in articoli)
                {
                    lstVisualizza.Items.Add(articolo.Value.ToString());
                }

                    break;

            }
        }
    }
}
