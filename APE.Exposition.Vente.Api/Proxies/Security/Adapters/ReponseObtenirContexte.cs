namespace APE.Exposition.Vente.Api.Proxies.Security.Adapters
{
    public class ReponseObtenirContexte
    {
        public string TokenType { get; set; }
        public string Canal { get; set; }
        public string IdentiteConnectee { get; set; }
        public string IdentiteActive { get; set; }
        public string IdentitePresentee { get; set; }
        public string IdentifiantDADH { get; set; }
        public string IdentifiantEntreprise { get; set; }
        public string IdentifiantParticipant { get; set; }
        public int IdentifiantProjet { get; set; }
        public string Portefeuille { get; set; }
        public System.DateTime DateCreation { get; set; }
        public System.DateTime DateFinValidite { get; set; }

    }
}
