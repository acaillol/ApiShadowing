namespace APE.Exposition.Vente.Api.Proxies.Affiliation.Adapters
{
    public class Contact
    {
        public string Commentaire { get; set; }

        private int IdPersonne { get; set; }

        private int NumeroOrdreContact { get; set; }

        private string TypeContact { get; set; }

        private string ValeurContact { get; set; }
    }
}