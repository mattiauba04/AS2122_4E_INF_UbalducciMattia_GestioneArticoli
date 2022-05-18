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

           lblArticolo.Text="Articolo("+ articoli.Count.ToString() + ")";
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

        private void lstVisualizza_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = lstVisualizza.SelectedItem.ToString();

            // Find the string in ListBox.
            int index = lstVisualizza.FindString(curItem);

            // visualizzazione dettaglio articolo nei textbox/combo
            // https://stackoverflow.com/questions/11000079/retrieve-dictionary-item-by-number
            txtCodice.Text = articoli.ElementAt(index).Value.ToString();
        }
    }
}
