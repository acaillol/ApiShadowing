using System.Collections.Generic;

namespace APE.Exposition.Vente.Api
{
    public static class Constants
    {
        internal const string SecurityContextKey = "SecurityContextKey";

        internal const int SecondsValidityUrlRSA = 60;

        internal const int SecondsCacheToken = 1800;

        internal static readonly Dictionary<Canal, string> Licences = new Dictionary<Canal, string>()
        {
            { Canal.ExtranetCourtier, "{AAAAAA}" },
            { Canal.Referentiel, "{BBBBB}" }
        };

        public enum Canal
        {
            ExtranetCourtier,
            Referentiel,
            siteassure,
            mailsmalldata,
            mailodv,
            siteentreprise
        }

        public enum TypeAffiliation
        {
            Digital,
            Papier
        }

        public enum RegimeObligatoire
        {
            SS,
            TNS,
            Agricole,
            AlsaceMoselle
        }
    }
}
