namespace AS2122_4E_INF_UbalducciMattia_GestioneArticoli.Library
{
    public class Articolo
    {
        string codice;
        string descrizione;
        string unitaDiMisura;
        double prezzo;


        string Codice { get { return codice; } }

        string Descrizione { get { return descrizione; } }

        string UnitaDiMisura { get { return unitaDiMisura; } }
        double Prezzo { get { return prezzo; } }



        public Articolo(string codice,string descrizione,string unitaDiMisura,double prezzo)
        {
            this.codice= codice;
            this.descrizione= descrizione;
            this.unitaDiMisura= unitaDiMisura;
            this.prezzo= prezzo;
        }
    }
}