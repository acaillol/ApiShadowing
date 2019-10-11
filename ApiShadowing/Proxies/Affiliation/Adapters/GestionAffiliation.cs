using System;

namespace APE.Exposition.Vente.Api.Proxies.Affiliation.Adapters
{
    public class GestionAffiliation
    {
        public string Civilite { get; set; }

        public string College { get; set; }

        public string DenominationSociale { get; set; }

        public string Etat { get; set; }

        public int? IdentifiantDemandeAffiliation { get; set; }

        public string IdentifiantEntreprise { get; set; }

        public int? IdentifiantProjet { get; set; }

        public string IdentifiantProprietaire { get; set; }

        public string Marche { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public string Statut { get; set; }

        public string Type { get; set; }

        public DateTime DateAffiliation { get; set; }
    }
}
