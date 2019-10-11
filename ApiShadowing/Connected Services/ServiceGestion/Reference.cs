//------------------------------------------------------------------------------
// <généré automatiquement>
//     Ce code a été généré par un outil.
//     //
//     Les changements apportés à ce fichier peuvent provoquer un comportement incorrect et seront perdus si
//     le code est regénéré.
// </généré automatiquement>
//------------------------------------------------------------------------------

namespace ServiceGestion
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Demande", Namespace = "http://www.april.fr/APE/Services/Gestion")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceGestion.DemandeChargerEntreprise))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceGestion.DemandeRechercherEntreprises))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceGestion.DemandeTypeContratsActifsEntreprise))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceGestion.DemandeObtenirBIA))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceGestion.DemandeObtenirDocumentStatiqueAffiliation))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceGestion.DemandeEnvoyerBIA))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceGestion.DemandeProduitTechniqueSupporte))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceGestion.DemandeListerAffiliations))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceGestion.DemandeCreationAffiliation))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceGestion.DemandeChangerEtatAffiliation))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceGestion.DemandeInfoEntreprise))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceGestion.DemandeModifierTypeDemandeAffiliation))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceGestion.DemandeIdentifiantDemandeAffiliation))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceGestion.DemandeChargerAffilie))]
    public partial class Demande : object
    {

        private string IdentifiantTracabiliteField;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdentifiantTracabilite
        {
            get
            {
                return this.IdentifiantTracabiliteField;
            }
            set
            {
                this.IdentifiantTracabiliteField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "DemandeChargerEntreprise", Namespace = "http://www.april.fr/APE/Services/Gestion")]
    public partial class DemandeChargerEntreprise : ServiceGestion.Demande
    {

        private string NumEtablissementField;

        private bool ChargerContratCollectifField;

        private System.Nullable<bool> ChargerContratsPassesField;

        private System.Nullable<bool> ChargerContratsFutursField;

        private System.Nullable<bool> SubstituerDroitDeVenteKOField;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NumEtablissement
        {
            get
            {
                return this.NumEtablissementField;
            }
            set
            {
                this.NumEtablissementField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
        public bool ChargerContratCollectif
        {
            get
            {
                return this.ChargerContratCollectifField;
            }
            set
            {
                this.ChargerContratCollectifField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
        public System.Nullable<bool> ChargerContratsPasses
        {
            get
            {
                return this.ChargerContratsPassesField;
            }
            set
            {
                this.ChargerContratsPassesField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 3)]
        public System.Nullable<bool> ChargerContratsFuturs
        {
            get
            {
                return this.ChargerContratsFutursField;
            }
            set
            {
                this.ChargerContratsFutursField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 4)]
        public System.Nullable<bool> SubstituerDroitDeVenteKO
        {
            get
            {
                return this.SubstituerDroitDeVenteKOField;
            }
            set
            {
                this.SubstituerDroitDeVenteKOField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "DemandeRechercherEntreprises", Namespace = "http://www.april.fr/APE/Services/Gestion")]
    public partial class DemandeRechercherEntreprises : ServiceGestion.Demande
    {

        private string NumEtablissementField;

        private string RaisonSocialeField;

        private string CodeCourtierField;

        private System.Nullable<bool> ChargerContratsPassesField;

        private System.Nullable<bool> ChargerContratsFutursField;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NumEtablissement
        {
            get
            {
                return this.NumEtablissementField;
            }
            set
            {
                this.NumEtablissementField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RaisonSociale
        {
            get
            {
                return this.RaisonSocialeField;
            }
            set
            {
                this.RaisonSocialeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
        public string CodeCourtier
        {
            get
            {
                return this.CodeCourtierField;
            }
            set
            {
                this.CodeCourtierField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 3)]
        public System.Nullable<bool> ChargerContratsPasses
        {
            get
            {
                return this.ChargerContratsPassesField;
            }
            set
            {
                this.ChargerContratsPassesField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 4)]
        public System.Nullable<bool> ChargerContratsFuturs
        {
            get
            {
                return this.ChargerContratsFutursField;
            }
            set
            {
                this.ChargerContratsFutursField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "DemandeTypeContratsActifsEntreprise", Namespace = "http://www.april.fr/APE/Services/Gestion")]
    public partial class DemandeTypeContratsActifsEntreprise : ServiceGestion.Demande
    {

        private string NumEtablissementField;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NumEtablissement
        {
            get
            {
                return this.NumEtablissementField;
            }
            set
            {
                this.NumEtablissementField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "DemandeObtenirBIA", Namespace = "http://www.april.fr/APE/Services/Gestion")]
    public partial class DemandeObtenirBIA : ServiceGestion.Demande
    {

        private string NumEtablissementField;

        private string TypeCollegeField;

        private ServiceGestion.SalarieBIA AssureField;

        private string IdentiteActiveField;

        private string CanalField;

        private bool ForcerQMQSField;

        private string IdentifiantDemandeAffiliationField;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NumEtablissement
        {
            get
            {
                return this.NumEtablissementField;
            }
            set
            {
                this.NumEtablissementField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TypeCollege
        {
            get
            {
                return this.TypeCollegeField;
            }
            set
            {
                this.TypeCollegeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
        public ServiceGestion.SalarieBIA Assure
        {
            get
            {
                return this.AssureField;
            }
            set
            {
                this.AssureField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 3)]
        public string IdentiteActive
        {
            get
            {
                return this.IdentiteActiveField;
            }
            set
            {
                this.IdentiteActiveField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 4)]
        public string Canal
        {
            get
            {
                return this.CanalField;
            }
            set
            {
                this.CanalField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 5)]
        public bool ForcerQMQS
        {
            get
            {
                return this.ForcerQMQSField;
            }
            set
            {
                this.ForcerQMQSField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 6)]
        public string IdentifiantDemandeAffiliation
        {
            get
            {
                return this.IdentifiantDemandeAffiliationField;
            }
            set
            {
                this.IdentifiantDemandeAffiliationField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "DemandeObtenirDocumentStatiqueAffiliation", Namespace = "http://www.april.fr/APE/Services/Gestion")]
    public partial class DemandeObtenirDocumentStatiqueAffiliation : ServiceGestion.Demande
    {

        private string NumEtablissementField;

        private string TypeCollegeField;

        private string IdentiteActiveField;

        private string CanalField;

        private string IdentifiantDemandeAffiliationField;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NumEtablissement
        {
            get
            {
                return this.NumEtablissementField;
            }
            set
            {
                this.NumEtablissementField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TypeCollege
        {
            get
            {
                return this.TypeCollegeField;
            }
            set
            {
                this.TypeCollegeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
        public string IdentiteActive
        {
            get
            {
                return this.IdentiteActiveField;
            }
            set
            {
                this.IdentiteActiveField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 3)]
        public string Canal
        {
            get
            {
                return this.CanalField;
            }
            set
            {
                this.CanalField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 4)]
        public string IdentifiantDemandeAffiliation
        {
            get
            {
                return this.IdentifiantDemandeAffiliationField;
            }
            set
            {
                this.IdentifiantDemandeAffiliationField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "DemandeEnvoyerBIA", Namespace = "http://www.april.fr/APE/Services/Gestion")]
    public partial class DemandeEnvoyerBIA : ServiceGestion.Demande
    {

        private string NumeroDemandeBIAField;

        private string NumeroEtablissementField;

        private string TypeCollegeField;

        private ServiceGestion.SalarieBIA SalarieField;

        private string ObjetField;

        private string ContenuMessageField;

        private string EmailDestinataireField;

        private string EmailCopieField;

        private string IdentiteActiveField;

        private string CanalField;

        private bool ForcerQMQSField;

        private string TypeEmailField;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NumeroDemandeBIA
        {
            get
            {
                return this.NumeroDemandeBIAField;
            }
            set
            {
                this.NumeroDemandeBIAField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NumeroEtablissement
        {
            get
            {
                return this.NumeroEtablissementField;
            }
            set
            {
                this.NumeroEtablissementField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TypeCollege
        {
            get
            {
                return this.TypeCollegeField;
            }
            set
            {
                this.TypeCollegeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 3)]
        public ServiceGestion.SalarieBIA Salarie
        {
            get
            {
                return this.SalarieField;
            }
            set
            {
                this.SalarieField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 4)]
        public string Objet
        {
            get
            {
                return this.ObjetField;
            }
            set
            {
                this.ObjetField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 5)]
        public string ContenuMessage
        {
            get
            {
                return this.ContenuMessageField;
            }
            set
            {
                this.ContenuMessageField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 6)]
        public string EmailDestinataire
        {
            get
            {
                return this.EmailDestinataireField;
            }
            set
            {
                this.EmailDestinataireField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 7)]
        public string EmailCopie
        {
            get
            {
                return this.EmailCopieField;
            }
            set
            {
                this.EmailCopieField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 8)]
        public string IdentiteActive
        {
            get
            {
                return this.IdentiteActiveField;
            }
            set
            {
                this.IdentiteActiveField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 9)]
        public string Canal
        {
            get
            {
                return this.CanalField;
            }
            set
            {
                this.CanalField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 10)]
        public bool ForcerQMQS
        {
            get
            {
                return this.ForcerQMQSField;
            }
            set
            {
                this.ForcerQMQSField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 11)]
        public string TypeEmail
        {
            get
            {
                return this.TypeEmailField;
            }
            set
            {
                this.TypeEmailField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "DemandeProduitTechniqueSupporte", Namespace = "http://www.april.fr/APE/Services/Gestion")]
    public partial class DemandeProduitTechniqueSupporte : ServiceGestion.Demande
    {

        private string CodeProduitField;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodeProduit
        {
            get
            {
                return this.CodeProduitField;
            }
            set
            {
                this.CodeProduitField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "DemandeListerAffiliations", Namespace = "http://www.april.fr/APE/Services/Gestion")]
    public partial class DemandeListerAffiliations : ServiceGestion.Demande
    {

        private string NumeroEtablissementField;

        private string IdentifiantDADHField;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NumeroEtablissement
        {
            get
            {
                return this.NumeroEtablissementField;
            }
            set
            {
                this.NumeroEtablissementField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
        public string IdentifiantDADH
        {
            get
            {
                return this.IdentifiantDADHField;
            }
            set
            {
                this.IdentifiantDADHField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "DemandeCreationAffiliation", Namespace = "http://www.april.fr/APE/Services/Gestion")]
    public partial class DemandeCreationAffiliation : ServiceGestion.Demande
    {

        private string IdentiteCreateurField;

        private string IdentifiantDADHField;

        private string IdentifiantEntrepriseField;

        private string TypeField;

        private string CanalField;

        private string CiviliteField;

        private string NomField;

        private string PrenomField;

        private System.DateTime DateDeNaissanceField;

        private int SalaireAnnuelField;

        private string CollegeField;

        private string EmailField;

        private System.DateTime DateEntreeEntrepriseField;

        private System.DateTime DateAffiliationField;

        private string IdentifiantProprietaireField;

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        public string IdentiteCreateur
        {
            get
            {
                return this.IdentiteCreateurField;
            }
            set
            {
                this.IdentiteCreateurField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 1)]
        public string IdentifiantDADH
        {
            get
            {
                return this.IdentifiantDADHField;
            }
            set
            {
                this.IdentifiantDADHField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 2)]
        public string IdentifiantEntreprise
        {
            get
            {
                return this.IdentifiantEntrepriseField;
            }
            set
            {
                this.IdentifiantEntrepriseField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 3)]
        public string Type
        {
            get
            {
                return this.TypeField;
            }
            set
            {
                this.TypeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 4)]
        public string Canal
        {
            get
            {
                return this.CanalField;
            }
            set
            {
                this.CanalField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 5)]
        public string Civilite
        {
            get
            {
                return this.CiviliteField;
            }
            set
            {
                this.CiviliteField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 6)]
        public string Nom
        {
            get
            {
                return this.NomField;
            }
            set
            {
                this.NomField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 7)]
        public string Prenom
        {
            get
            {
                return this.PrenomField;
            }
            set
            {
                this.PrenomField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 8)]
        public System.DateTime DateDeNaissance
        {
            get
            {
                return this.DateDeNaissanceField;
            }
            set
            {
                this.DateDeNaissanceField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 9)]
        public int SalaireAnnuel
        {
            get
            {
                return this.SalaireAnnuelField;
            }
            set
            {
                this.SalaireAnnuelField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 10)]
        public string College
        {
            get
            {
                return this.CollegeField;
            }
            set
            {
                this.CollegeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 11)]
        public string Email
        {
            get
            {
                return this.EmailField;
            }
            set
            {
                this.EmailField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 12)]
        public System.DateTime DateEntreeEntreprise
        {
            get
            {
                return this.DateEntreeEntrepriseField;
            }
            set
            {
                this.DateEntreeEntrepriseField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 13)]
        public System.DateTime DateAffiliation
        {
            get
            {
                return this.DateAffiliationField;
            }
            set
            {
                this.DateAffiliationField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 14)]
        public string IdentifiantProprietaire
        {
            get
            {
                return this.IdentifiantProprietaireField;
            }
            set
            {
                this.IdentifiantProprietaireField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 15)]
        public string CodePostal
        { get; set; }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 16)]
        public string Ville
        { get; set; }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 17)]
        public string RegimeObligatoire
        { get; set; }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "DemandeChangerEtatAffiliation", Namespace = "http://www.april.fr/APE/Services/Gestion")]
    public partial class DemandeChangerEtatAffiliation : ServiceGestion.Demande
    {

        private System.Nullable<int> IdentifiantDemandeAffiliationField;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> IdentifiantDemandeAffiliation
        {
            get
            {
                return this.IdentifiantDemandeAffiliationField;
            }
            set
            {
                this.IdentifiantDemandeAffiliationField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "DemandeInfoEntreprise", Namespace = "http://www.april.fr/APE/Services/Gestion")]
    public partial class DemandeInfoEntreprise : ServiceGestion.Demande
    {

        private string NumeroEtablissementField;

        private string IdentifiantDADHField;

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        public string NumeroEtablissement
        {
            get
            {
                return this.NumeroEtablissementField;
            }
            set
            {
                this.NumeroEtablissementField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 1)]
        public string IdentifiantDADH
        {
            get
            {
                return this.IdentifiantDADHField;
            }
            set
            {
                this.IdentifiantDADHField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "DemandeModifierTypeDemandeAffiliation", Namespace = "http://www.april.fr/APE/Services/Gestion")]
    public partial class DemandeModifierTypeDemandeAffiliation : ServiceGestion.Demande
    {

        private string IdentifiantDemandeAffiliationField;

        private string TypeField;

        private string EmailField;

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        public string IdentifiantDemandeAffiliation
        {
            get
            {
                return this.IdentifiantDemandeAffiliationField;
            }
            set
            {
                this.IdentifiantDemandeAffiliationField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        public string Type
        {
            get
            {
                return this.TypeField;
            }
            set
            {
                this.TypeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 2)]
        public string Email
        {
            get
            {
                return this.EmailField;
            }
            set
            {
                this.EmailField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "DemandeIdentifiantDemandeAffiliation", Namespace = "http://www.april.fr/APE/Services/Gestion")]
    public partial class DemandeIdentifiantDemandeAffiliation : ServiceGestion.Demande
    {

        private string IdentifiantDemandeAffiliationField;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdentifiantDemandeAffiliation
        {
            get
            {
                return this.IdentifiantDemandeAffiliationField;
            }
            set
            {
                this.IdentifiantDemandeAffiliationField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "DemandeChargerAffilie", Namespace = "http://www.april.fr/APE/Services/Gestion")]
    public partial class DemandeChargerAffilie : ServiceGestion.Demande
    {

        private System.Nullable<int> NumParticipantField;

        private string NumEtablissementField;

        private string CodeMarcheField;

        private bool ChargerListeAssuresField;

        private bool ChargerEmploiField;

        private bool ChargerEntrepriseField;

        private bool ChargerContratCollectifField;

        private bool ChargerContratIndividuelField;

        private System.Nullable<bool> ChargerContratsPassesField;

        private System.Nullable<bool> ChargerContratsFutursField;

        private System.Nullable<bool> SubstituerDroitDeVenteKOField;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> NumParticipant
        {
            get
            {
                return this.NumParticipantField;
            }
            set
            {
                this.NumParticipantField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
        public string NumEtablissement
        {
            get
            {
                return this.NumEtablissementField;
            }
            set
            {
                this.NumEtablissementField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
        public string CodeMarche
        {
            get
            {
                return this.CodeMarcheField;
            }
            set
            {
                this.CodeMarcheField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 3)]
        public bool ChargerListeAssures
        {
            get
            {
                return this.ChargerListeAssuresField;
            }
            set
            {
                this.ChargerListeAssuresField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 4)]
        public bool ChargerEmploi
        {
            get
            {
                return this.ChargerEmploiField;
            }
            set
            {
                this.ChargerEmploiField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 5)]
        public bool ChargerEntreprise
        {
            get
            {
                return this.ChargerEntrepriseField;
            }
            set
            {
                this.ChargerEntrepriseField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 6)]
        public bool ChargerContratCollectif
        {
            get
            {
                return this.ChargerContratCollectifField;
            }
            set
            {
                this.ChargerContratCollectifField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 7)]
        public bool ChargerContratIndividuel
        {
            get
            {
                return this.ChargerContratIndividuelField;
            }
            set
            {
                this.ChargerContratIndividuelField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 8)]
        public System.Nullable<bool> ChargerContratsPasses
        {
            get
            {
                return this.ChargerContratsPassesField;
            }
            set
            {
                this.ChargerContratsPassesField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 9)]
        public System.Nullable<bool> ChargerContratsFuturs
        {
            get
            {
                return this.ChargerContratsFutursField;
            }
            set
            {
                this.ChargerContratsFutursField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 10)]
        public System.Nullable<bool> SubstituerDroitDeVenteKO
        {
            get
            {
                return this.SubstituerDroitDeVenteKOField;
            }
            set
            {
                this.SubstituerDroitDeVenteKOField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "SalarieBIA", Namespace = "http://www.april.fr/APE/Services/Gestion")]
    public partial class SalarieBIA : object
    {

        private ServiceGestion.SalarieBIAAdresseBIA AdresseField;

        private string CategoriePersonneField;

        private string CiviliteField;

        private string CommuneDeNaissanceField;

        private string CumulEmploiRetraiteField;

        private System.DateTime DateEntreeEntrepriseField;

        private System.Nullable<System.DateTime> DateNaissanceField;

        private string DepartementNaissanceField;

        private string EmailField;

        private string EmployeursMultiplesField;

        private string FonctionField;

        private string IBANField;

        private string LieuTravailField;

        private string NbEnfantsDeclaresField;

        private string NomField;

        private string NomNaissanceField;

        private string NumeroParticipantField;

        private string NumeroSecuriteSocialeField;

        private string PaysDeNaissanceField;

        private string PrenomField;

        private string SalaireAnnuelBrutField;

        private string SituationFamilialeField;

        private string TelephoneFixeField;

        private string TelephonePortableField;

        private string TempsPleinField;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public ServiceGestion.SalarieBIAAdresseBIA Adresse
        {
            get
            {
                return this.AdresseField;
            }
            set
            {
                this.AdresseField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CategoriePersonne
        {
            get
            {
                return this.CategoriePersonneField;
            }
            set
            {
                this.CategoriePersonneField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string Civilite
        {
            get
            {
                return this.CiviliteField;
            }
            set
            {
                this.CiviliteField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CommuneDeNaissance
        {
            get
            {
                return this.CommuneDeNaissanceField;
            }
            set
            {
                this.CommuneDeNaissanceField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CumulEmploiRetraite
        {
            get
            {
                return this.CumulEmploiRetraiteField;
            }
            set
            {
                this.CumulEmploiRetraiteField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.DateTime DateEntreeEntreprise
        {
            get
            {
                return this.DateEntreeEntrepriseField;
            }
            set
            {
                this.DateEntreeEntrepriseField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<System.DateTime> DateNaissance
        {
            get
            {
                return this.DateNaissanceField;
            }
            set
            {
                this.DateNaissanceField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string DepartementNaissance
        {
            get
            {
                return this.DepartementNaissanceField;
            }
            set
            {
                this.DepartementNaissanceField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string Email
        {
            get
            {
                return this.EmailField;
            }
            set
            {
                this.EmailField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string EmployeursMultiples
        {
            get
            {
                return this.EmployeursMultiplesField;
            }
            set
            {
                this.EmployeursMultiplesField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string Fonction
        {
            get
            {
                return this.FonctionField;
            }
            set
            {
                this.FonctionField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string IBAN
        {
            get
            {
                return this.IBANField;
            }
            set
            {
                this.IBANField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string LieuTravail
        {
            get
            {
                return this.LieuTravailField;
            }
            set
            {
                this.LieuTravailField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string NbEnfantsDeclares
        {
            get
            {
                return this.NbEnfantsDeclaresField;
            }
            set
            {
                this.NbEnfantsDeclaresField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string Nom
        {
            get
            {
                return this.NomField;
            }
            set
            {
                this.NomField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string NomNaissance
        {
            get
            {
                return this.NomNaissanceField;
            }
            set
            {
                this.NomNaissanceField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string NumeroParticipant
        {
            get
            {
                return this.NumeroParticipantField;
            }
            set
            {
                this.NumeroParticipantField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string NumeroSecuriteSociale
        {
            get
            {
                return this.NumeroSecuriteSocialeField;
            }
            set
            {
                this.NumeroSecuriteSocialeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string PaysDeNaissance
        {
            get
            {
                return this.PaysDeNaissanceField;
            }
            set
            {
                this.PaysDeNaissanceField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string Prenom
        {
            get
            {
                return this.PrenomField;
            }
            set
            {
                this.PrenomField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string SalaireAnnuelBrut
        {
            get
            {
                return this.SalaireAnnuelBrutField;
            }
            set
            {
                this.SalaireAnnuelBrutField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string SituationFamiliale
        {
            get
            {
                return this.SituationFamilialeField;
            }
            set
            {
                this.SituationFamilialeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string TelephoneFixe
        {
            get
            {
                return this.TelephoneFixeField;
            }
            set
            {
                this.TelephoneFixeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string TelephonePortable
        {
            get
            {
                return this.TelephonePortableField;
            }
            set
            {
                this.TelephonePortableField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string TempsPlein
        {
            get
            {
                return this.TempsPleinField;
            }
            set
            {
                this.TempsPleinField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "SalarieBIA.AdresseBIA", Namespace = "http://schemas.datacontract.org/2004/07/APE.Services.Gestion.Interfaces")]
    public partial class SalarieBIAAdresseBIA : object
    {

        private string CodePaysField;

        private string CodePostalField;

        private string LigneAdresseField;

        private string VilleField;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodePays
        {
            get
            {
                return this.CodePaysField;
            }
            set
            {
                this.CodePaysField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodePostal
        {
            get
            {
                return this.CodePostalField;
            }
            set
            {
                this.CodePostalField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LigneAdresse
        {
            get
            {
                return this.LigneAdresseField;
            }
            set
            {
                this.LigneAdresseField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ville
        {
            get
            {
                return this.VilleField;
            }
            set
            {
                this.VilleField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Reponse", Namespace = "http://schemas.datacontract.org/2004/07/APE.Services.Gestion.Interfaces")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceGestion.ReponseChargerEntreprise))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceGestion.ReponseRechercherEntreprises))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceGestion.ReponseRechercherEntreprisesAffiliation))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceGestion.ReponseTypeContratsActifsEntreprise))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceGestion.ReponseObtenirDocument))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceGestion.ReponseObtenirBIA))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceGestion.ReponseObtenirDocumentsAffiliation))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceGestion.ReponseBase))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceGestion.ReponseProduitTechniqueSupporte))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceGestion.ReponseListerAffiliations))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceGestion.ReponseCreationAffiliation))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceGestion.ReponseInfoEntreprise))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceGestion.ReponseLireAffiliation))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceGestion.ReponseChargerAffilie))]
    public partial class Reponse : object
    {

        private string StatutTechniqueField;

        private string MessageTechniqueField;

        private string StatutMetierField;

        private string[] MessagesMetierField;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StatutTechnique
        {
            get
            {
                return this.StatutTechniqueField;
            }
            set
            {
                this.StatutTechniqueField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 1)]
        public string MessageTechnique
        {
            get
            {
                return this.MessageTechniqueField;
            }
            set
            {
                this.MessageTechniqueField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 2)]
        public string StatutMetier
        {
            get
            {
                return this.StatutMetierField;
            }
            set
            {
                this.StatutMetierField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 3)]
        public string[] MessagesMetier
        {
            get
            {
                return this.MessagesMetierField;
            }
            set
            {
                this.MessagesMetierField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "ReponseChargerEntreprise", Namespace = "http://www.april.fr/APE/Services/Gestion")]
    public partial class ReponseChargerEntreprise : ServiceGestion.Reponse
    {

        private ServiceGestion.Entreprise EntrepriseField;

        private ServiceGestion.ContratCollectif[] ListeContratsCollectifsField;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public ServiceGestion.Entreprise Entreprise
        {
            get
            {
                return this.EntrepriseField;
            }
            set
            {
                this.EntrepriseField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public ServiceGestion.ContratCollectif[] ListeContratsCollectifs
        {
            get
            {
                return this.ListeContratsCollectifsField;
            }
            set
            {
                this.ListeContratsCollectifsField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "ReponseRechercherEntreprises", Namespace = "http://www.april.fr/APE/Services/Gestion")]
    public partial class ReponseRechercherEntreprises : ServiceGestion.Reponse
    {

        private ServiceGestion.Entreprise[] EntreprisesField;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public ServiceGestion.Entreprise[] Entreprises
        {
            get
            {
                return this.EntreprisesField;
            }
            set
            {
                this.EntreprisesField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "ReponseRechercherEntreprisesAffiliation", Namespace = "http://www.april.fr/APE/Services/Gestion")]
    public partial class ReponseRechercherEntreprisesAffiliation : ServiceGestion.Reponse
    {

        private ServiceGestion.EntrepriseAffiliation[] EntreprisesField;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public ServiceGestion.EntrepriseAffiliation[] Entreprises
        {
            get
            {
                return this.EntreprisesField;
            }
            set
            {
                this.EntreprisesField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "ReponseTypeContratsActifsEntreprise", Namespace = "http://www.april.fr/APE/Services/Gestion")]
    public partial class ReponseTypeContratsActifsEntreprise : ServiceGestion.Reponse
    {

        private ServiceGestion.Entreprise EntrepriseField;

        private ServiceGestion.TypeContratActif[] ListeTypeContratsActifsField;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public ServiceGestion.Entreprise Entreprise
        {
            get
            {
                return this.EntrepriseField;
            }
            set
            {
                this.EntrepriseField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public ServiceGestion.TypeContratActif[] ListeTypeContratsActifs
        {
            get
            {
                return this.ListeTypeContratsActifsField;
            }
            set
            {
                this.ListeTypeContratsActifsField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "ReponseObtenirDocument", Namespace = "http://www.april.fr/APE/Services/Gestion")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceGestion.ReponseObtenirBIA))]
    public partial class ReponseObtenirDocument : ServiceGestion.Reponse
    {

        private string NomPDFField;

        private byte[] PDFField;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string NomPDF
        {
            get
            {
                return this.NomPDFField;
            }
            set
            {
                this.NomPDFField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public byte[] PDF
        {
            get
            {
                return this.PDFField;
            }
            set
            {
                this.PDFField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "ReponseObtenirBIA", Namespace = "http://www.april.fr/APE/Services/Gestion")]
    public partial class ReponseObtenirBIA : ServiceGestion.ReponseObtenirDocument
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "ReponseObtenirDocumentsAffiliation", Namespace = "http://www.april.fr/APE/Services/Gestion")]
    public partial class ReponseObtenirDocumentsAffiliation : ServiceGestion.Reponse
    {

        private ServiceGestion.ReponseObtenirDocument[] DocumentsField;

        private string NomFichierField;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public ServiceGestion.ReponseObtenirDocument[] Documents
        {
            get
            {
                return this.DocumentsField;
            }
            set
            {
                this.DocumentsField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string NomFichier
        {
            get
            {
                return this.NomFichierField;
            }
            set
            {
                this.NomFichierField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "ReponseBase", Namespace = "http://www.april.fr/APE/Services/Gestion")]
    public partial class ReponseBase : ServiceGestion.Reponse
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "ReponseProduitTechniqueSupporte", Namespace = "http://www.april.fr/APE/Services/Gestion")]
    public partial class ReponseProduitTechniqueSupporte : ServiceGestion.Reponse
    {

        private bool ProduitSupporteField;

        private string CodeProduitField;

        private string TypeProduitField;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public bool ProduitSupporte
        {
            get
            {
                return this.ProduitSupporteField;
            }
            set
            {
                this.ProduitSupporteField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 1)]
        public string CodeProduit
        {
            get
            {
                return this.CodeProduitField;
            }
            set
            {
                this.CodeProduitField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 2)]
        public string TypeProduit
        {
            get
            {
                return this.TypeProduitField;
            }
            set
            {
                this.TypeProduitField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "ReponseListerAffiliations", Namespace = "http://www.april.fr/APE/Services/Gestion")]
    public partial class ReponseListerAffiliations : ServiceGestion.Reponse
    {

        private ServiceGestion.GestionAffiliation[] ListeDemandeAffiliationField;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceGestion.GestionAffiliation[] ListeDemandeAffiliation
        {
            get
            {
                return this.ListeDemandeAffiliationField;
            }
            set
            {
                this.ListeDemandeAffiliationField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "ReponseCreationAffiliation", Namespace = "http://www.april.fr/APE/Services/Gestion")]
    public partial class ReponseCreationAffiliation : ServiceGestion.Reponse
    {

        private int IdentifiantDemandeAffiliationField;

        private int IdentifiantProjetField;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdentifiantDemandeAffiliation
        {
            get
            {
                return this.IdentifiantDemandeAffiliationField;
            }
            set
            {
                this.IdentifiantDemandeAffiliationField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdentifiantProjet
        {
            get
            {
                return this.IdentifiantProjetField;
            }
            set
            {
                this.IdentifiantProjetField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "ReponseInfoEntreprise", Namespace = "http://www.april.fr/APE/Services/Gestion")]
    public partial class ReponseInfoEntreprise : ServiceGestion.Reponse
    {

        private string NomEntrepriseField;

        private string CodeCourtierField;

        private bool CompatibleModuleAffiliationField;

        private ServiceGestion.ReponseInfoEntrepriseCategorieEmploi[] CategoriesEmploisField;

        private System.DateTime DateCreationField;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NomEntreprise
        {
            get
            {
                return this.NomEntrepriseField;
            }
            set
            {
                this.NomEntrepriseField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
        public string CodeCourtier
        {
            get
            {
                return this.CodeCourtierField;
            }
            set
            {
                this.CodeCourtierField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
        public bool CompatibleModuleAffiliation
        {
            get
            {
                return this.CompatibleModuleAffiliationField;
            }
            set
            {
                this.CompatibleModuleAffiliationField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 3)]
        public ServiceGestion.ReponseInfoEntrepriseCategorieEmploi[] CategoriesEmplois
        {
            get
            {
                return this.CategoriesEmploisField;
            }
            set
            {
                this.CategoriesEmploisField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 4)]
        public System.DateTime DateCreation
        {
            get
            {
                return this.DateCreationField;
            }
            set
            {
                this.DateCreationField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "ReponseLireAffiliation", Namespace = "http://www.april.fr/APE/Services/Gestion")]
    public partial class ReponseLireAffiliation : ServiceGestion.Reponse
    {

        private string IdentiteCreateurField;

        private string IdentifiantDADHField;

        private string IdentifiantEntrepriseField;

        private string TypeField;

        private string CanalField;

        private string CiviliteField;

        private string NomField;

        private string PrenomField;

        private System.DateTime DateDeNaissanceField;

        private int SalaireAnnuelField;

        private string CollegeField;

        private string EmailField;

        private System.DateTime DateEntreeEntrepriseField;

        private System.DateTime DateAffiliationField;

        private string IdentifiantProprietaireField;

        private string EtatField;

        private System.Nullable<int> IdentifiantProjetField;

        private string MarqueField;

        private string VersionFrameworkField;

        private System.Nullable<int> IdentifiantDemandeAffiliationField;

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        public string IdentiteCreateur
        {
            get
            {
                return this.IdentiteCreateurField;
            }
            set
            {
                this.IdentiteCreateurField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 1)]
        public string IdentifiantDADH
        {
            get
            {
                return this.IdentifiantDADHField;
            }
            set
            {
                this.IdentifiantDADHField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 2)]
        public string IdentifiantEntreprise
        {
            get
            {
                return this.IdentifiantEntrepriseField;
            }
            set
            {
                this.IdentifiantEntrepriseField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 3)]
        public string Type
        {
            get
            {
                return this.TypeField;
            }
            set
            {
                this.TypeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 4)]
        public string Canal
        {
            get
            {
                return this.CanalField;
            }
            set
            {
                this.CanalField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 5)]
        public string Civilite
        {
            get
            {
                return this.CiviliteField;
            }
            set
            {
                this.CiviliteField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 6)]
        public string Nom
        {
            get
            {
                return this.NomField;
            }
            set
            {
                this.NomField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 7)]
        public string Prenom
        {
            get
            {
                return this.PrenomField;
            }
            set
            {
                this.PrenomField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 8)]
        public System.DateTime DateDeNaissance
        {
            get
            {
                return this.DateDeNaissanceField;
            }
            set
            {
                this.DateDeNaissanceField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 9)]
        public int SalaireAnnuel
        {
            get
            {
                return this.SalaireAnnuelField;
            }
            set
            {
                this.SalaireAnnuelField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 10)]
        public string College
        {
            get
            {
                return this.CollegeField;
            }
            set
            {
                this.CollegeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 11)]
        public string Email
        {
            get
            {
                return this.EmailField;
            }
            set
            {
                this.EmailField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 12)]
        public System.DateTime DateEntreeEntreprise
        {
            get
            {
                return this.DateEntreeEntrepriseField;
            }
            set
            {
                this.DateEntreeEntrepriseField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 13)]
        public System.DateTime DateAffiliation
        {
            get
            {
                return this.DateAffiliationField;
            }
            set
            {
                this.DateAffiliationField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 14)]
        public string IdentifiantProprietaire
        {
            get
            {
                return this.IdentifiantProprietaireField;
            }
            set
            {
                this.IdentifiantProprietaireField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 15)]
        public string Etat
        {
            get
            {
                return this.EtatField;
            }
            set
            {
                this.EtatField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 16)]
        public System.Nullable<int> IdentifiantProjet
        {
            get
            {
                return this.IdentifiantProjetField;
            }
            set
            {
                this.IdentifiantProjetField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 17)]
        public string Marque
        {
            get
            {
                return this.MarqueField;
            }
            set
            {
                this.MarqueField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 18)]
        public string VersionFramework
        {
            get
            {
                return this.VersionFrameworkField;
            }
            set
            {
                this.VersionFrameworkField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 19)]
        public System.Nullable<int> IdentifiantDemandeAffiliation
        {
            get
            {
                return this.IdentifiantDemandeAffiliationField;
            }
            set
            {
                this.IdentifiantDemandeAffiliationField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "ReponseChargerAffilie", Namespace = "http://www.april.fr/APE/Services/Gestion")]
    public partial class ReponseChargerAffilie : ServiceGestion.Reponse
    {

        private ServiceGestion.Affiliation AffiliationField;

        private ServiceGestion.Assure[] ListeAssuresField;

        private ServiceGestion.ContratCollectif ContratCollectifField;

        private ServiceGestion.Entreprise EntrepriseField;

        private ServiceGestion.ContratIndividuel[] ListeContratsIndividuelsField;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public ServiceGestion.Affiliation Affiliation
        {
            get
            {
                return this.AffiliationField;
            }
            set
            {
                this.AffiliationField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public ServiceGestion.Assure[] ListeAssures
        {
            get
            {
                return this.ListeAssuresField;
            }
            set
            {
                this.ListeAssuresField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 2)]
        public ServiceGestion.ContratCollectif ContratCollectif
        {
            get
            {
                return this.ContratCollectifField;
            }
            set
            {
                this.ContratCollectifField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 3)]
        public ServiceGestion.Entreprise Entreprise
        {
            get
            {
                return this.EntrepriseField;
            }
            set
            {
                this.EntrepriseField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 4)]
        public ServiceGestion.ContratIndividuel[] ListeContratsIndividuels
        {
            get
            {
                return this.ListeContratsIndividuelsField;
            }
            set
            {
                this.ListeContratsIndividuelsField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Affiliation", Namespace = "http://www.april.fr/APE/Services/Gestion")]
    public partial class Affiliation : object
    {

        private decimal CapitalField;

        private string CauseSurprimeField;

        private string CodeCategorieAffiliationField;

        private string CodeFamilleAffiliationField;

        private string CodeQMField;

        private string CodeSecteurAffiliationField;

        private string CodeTypeAffiliationField;

        private string CommentaireField;

        private System.Nullable<System.DateTime> DateDernierStadeAffiliationField;

        private System.Nullable<System.DateTime> DateEffetAffiliationField;

        private System.Nullable<System.DateTime> DateFinEffetAffiliationField;

        private string DernierStadeAffiliationField;

        private System.Nullable<bool> ExistenceHistoriqueField;

        private string MotifDebutAffiliationField;

        private string MotifFinAffiliationField;

        private int NumEmploiField;

        private string NumEtablissementField;

        private int NumOrdreAffiliationField;

        private int NumOrdreContratField;

        private int NumParticipantField;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public decimal Capital
        {
            get
            {
                return this.CapitalField;
            }
            set
            {
                this.CapitalField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CauseSurprime
        {
            get
            {
                return this.CauseSurprimeField;
            }
            set
            {
                this.CauseSurprimeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeCategorieAffiliation
        {
            get
            {
                return this.CodeCategorieAffiliationField;
            }
            set
            {
                this.CodeCategorieAffiliationField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeFamilleAffiliation
        {
            get
            {
                return this.CodeFamilleAffiliationField;
            }
            set
            {
                this.CodeFamilleAffiliationField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeQM
        {
            get
            {
                return this.CodeQMField;
            }
            set
            {
                this.CodeQMField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeSecteurAffiliation
        {
            get
            {
                return this.CodeSecteurAffiliationField;
            }
            set
            {
                this.CodeSecteurAffiliationField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeTypeAffiliation
        {
            get
            {
                return this.CodeTypeAffiliationField;
            }
            set
            {
                this.CodeTypeAffiliationField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string Commentaire
        {
            get
            {
                return this.CommentaireField;
            }
            set
            {
                this.CommentaireField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<System.DateTime> DateDernierStadeAffiliation
        {
            get
            {
                return this.DateDernierStadeAffiliationField;
            }
            set
            {
                this.DateDernierStadeAffiliationField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<System.DateTime> DateEffetAffiliation
        {
            get
            {
                return this.DateEffetAffiliationField;
            }
            set
            {
                this.DateEffetAffiliationField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<System.DateTime> DateFinEffetAffiliation
        {
            get
            {
                return this.DateFinEffetAffiliationField;
            }
            set
            {
                this.DateFinEffetAffiliationField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string DernierStadeAffiliation
        {
            get
            {
                return this.DernierStadeAffiliationField;
            }
            set
            {
                this.DernierStadeAffiliationField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<bool> ExistenceHistorique
        {
            get
            {
                return this.ExistenceHistoriqueField;
            }
            set
            {
                this.ExistenceHistoriqueField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string MotifDebutAffiliation
        {
            get
            {
                return this.MotifDebutAffiliationField;
            }
            set
            {
                this.MotifDebutAffiliationField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string MotifFinAffiliation
        {
            get
            {
                return this.MotifFinAffiliationField;
            }
            set
            {
                this.MotifFinAffiliationField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int NumEmploi
        {
            get
            {
                return this.NumEmploiField;
            }
            set
            {
                this.NumEmploiField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string NumEtablissement
        {
            get
            {
                return this.NumEtablissementField;
            }
            set
            {
                this.NumEtablissementField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int NumOrdreAffiliation
        {
            get
            {
                return this.NumOrdreAffiliationField;
            }
            set
            {
                this.NumOrdreAffiliationField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int NumOrdreContrat
        {
            get
            {
                return this.NumOrdreContratField;
            }
            set
            {
                this.NumOrdreContratField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int NumParticipant
        {
            get
            {
                return this.NumParticipantField;
            }
            set
            {
                this.NumParticipantField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "ContratCollectif", Namespace = "http://www.april.fr/APE/Services/Gestion")]
    public partial class ContratCollectif : object
    {

        private int AgeMaxiDebutAffiliationField;

        private int AgeMaxiFinAffiliationField;

        private string CategorieAdhesionField;

        private string CategoriePersonneField;

        private string ClausierContratField;

        private string CodeDemandeEditionBACField;

        private string CodeFamillePDTField;

        private string CodeSecteurPDTField;

        private string CodeTypePDTField;

        private string CotisatAssociationContratField;

        private System.Nullable<System.DateTime> DateDebutContratField;

        private System.Nullable<System.DateTime> DateDernierEditionField;

        private System.Nullable<System.DateTime> DateEnregistrementStade1ContratField;

        private System.Nullable<System.DateTime> DateEnregistrementStade2ContratField;

        private System.Nullable<System.DateTime> DateEnregistrementStade3ContratField;

        private System.Nullable<System.DateTime> DateEnregistrementStade4ContratField;

        private System.Nullable<System.DateTime> DateEnvoiPremierBACField;

        private System.Nullable<System.DateTime> DateFinContratField;

        private System.Nullable<System.DateTime> DateStade1ContratField;

        private System.Nullable<System.DateTime> DateStade2ContratField;

        private System.Nullable<System.DateTime> DateStade3ContratField;

        private System.Nullable<System.DateTime> DateStade4ContratField;

        private int EffectifCategorieAdhesionField;

        private string ExistenceHistoContratField;

        private string ExistencePreavisField;

        private string IdentifiantDADHField;

        private string LibelleCategoriePersonneField;

        private string LibreServiceContratField;

        private ServiceGestion.ConditionAdhesion[] ListeConditionAdhesionField;

        private string MotifDebutContratField;

        private string MotifFinContratField;

        private int NbMoisCarrenceField;

        private int NumCorrExpComptPrescriptField;

        private string NumDeuxiemeApporteurField;

        private string NumEtablissementField;

        private int NumOrdreContratField;

        private string NumPremierApporteurField;

        private decimal PourcentageCommissionDeuxiemeApporteurField;

        private decimal PourcentageCommissionPremierApporteurField;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int AgeMaxiDebutAffiliation
        {
            get
            {
                return this.AgeMaxiDebutAffiliationField;
            }
            set
            {
                this.AgeMaxiDebutAffiliationField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int AgeMaxiFinAffiliation
        {
            get
            {
                return this.AgeMaxiFinAffiliationField;
            }
            set
            {
                this.AgeMaxiFinAffiliationField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CategorieAdhesion
        {
            get
            {
                return this.CategorieAdhesionField;
            }
            set
            {
                this.CategorieAdhesionField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CategoriePersonne
        {
            get
            {
                return this.CategoriePersonneField;
            }
            set
            {
                this.CategoriePersonneField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string ClausierContrat
        {
            get
            {
                return this.ClausierContratField;
            }
            set
            {
                this.ClausierContratField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeDemandeEditionBAC
        {
            get
            {
                return this.CodeDemandeEditionBACField;
            }
            set
            {
                this.CodeDemandeEditionBACField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeFamillePDT
        {
            get
            {
                return this.CodeFamillePDTField;
            }
            set
            {
                this.CodeFamillePDTField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeSecteurPDT
        {
            get
            {
                return this.CodeSecteurPDTField;
            }
            set
            {
                this.CodeSecteurPDTField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeTypePDT
        {
            get
            {
                return this.CodeTypePDTField;
            }
            set
            {
                this.CodeTypePDTField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CotisatAssociationContrat
        {
            get
            {
                return this.CotisatAssociationContratField;
            }
            set
            {
                this.CotisatAssociationContratField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<System.DateTime> DateDebutContrat
        {
            get
            {
                return this.DateDebutContratField;
            }
            set
            {
                this.DateDebutContratField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<System.DateTime> DateDernierEdition
        {
            get
            {
                return this.DateDernierEditionField;
            }
            set
            {
                this.DateDernierEditionField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<System.DateTime> DateEnregistrementStade1Contrat
        {
            get
            {
                return this.DateEnregistrementStade1ContratField;
            }
            set
            {
                this.DateEnregistrementStade1ContratField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<System.DateTime> DateEnregistrementStade2Contrat
        {
            get
            {
                return this.DateEnregistrementStade2ContratField;
            }
            set
            {
                this.DateEnregistrementStade2ContratField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<System.DateTime> DateEnregistrementStade3Contrat
        {
            get
            {
                return this.DateEnregistrementStade3ContratField;
            }
            set
            {
                this.DateEnregistrementStade3ContratField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<System.DateTime> DateEnregistrementStade4Contrat
        {
            get
            {
                return this.DateEnregistrementStade4ContratField;
            }
            set
            {
                this.DateEnregistrementStade4ContratField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<System.DateTime> DateEnvoiPremierBAC
        {
            get
            {
                return this.DateEnvoiPremierBACField;
            }
            set
            {
                this.DateEnvoiPremierBACField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<System.DateTime> DateFinContrat
        {
            get
            {
                return this.DateFinContratField;
            }
            set
            {
                this.DateFinContratField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<System.DateTime> DateStade1Contrat
        {
            get
            {
                return this.DateStade1ContratField;
            }
            set
            {
                this.DateStade1ContratField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<System.DateTime> DateStade2Contrat
        {
            get
            {
                return this.DateStade2ContratField;
            }
            set
            {
                this.DateStade2ContratField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<System.DateTime> DateStade3Contrat
        {
            get
            {
                return this.DateStade3ContratField;
            }
            set
            {
                this.DateStade3ContratField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<System.DateTime> DateStade4Contrat
        {
            get
            {
                return this.DateStade4ContratField;
            }
            set
            {
                this.DateStade4ContratField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int EffectifCategorieAdhesion
        {
            get
            {
                return this.EffectifCategorieAdhesionField;
            }
            set
            {
                this.EffectifCategorieAdhesionField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string ExistenceHistoContrat
        {
            get
            {
                return this.ExistenceHistoContratField;
            }
            set
            {
                this.ExistenceHistoContratField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string ExistencePreavis
        {
            get
            {
                return this.ExistencePreavisField;
            }
            set
            {
                this.ExistencePreavisField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string IdentifiantDADH
        {
            get
            {
                return this.IdentifiantDADHField;
            }
            set
            {
                this.IdentifiantDADHField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string LibelleCategoriePersonne
        {
            get
            {
                return this.LibelleCategoriePersonneField;
            }
            set
            {
                this.LibelleCategoriePersonneField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string LibreServiceContrat
        {
            get
            {
                return this.LibreServiceContratField;
            }
            set
            {
                this.LibreServiceContratField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public ServiceGestion.ConditionAdhesion[] ListeConditionAdhesion
        {
            get
            {
                return this.ListeConditionAdhesionField;
            }
            set
            {
                this.ListeConditionAdhesionField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string MotifDebutContrat
        {
            get
            {
                return this.MotifDebutContratField;
            }
            set
            {
                this.MotifDebutContratField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string MotifFinContrat
        {
            get
            {
                return this.MotifFinContratField;
            }
            set
            {
                this.MotifFinContratField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int NbMoisCarrence
        {
            get
            {
                return this.NbMoisCarrenceField;
            }
            set
            {
                this.NbMoisCarrenceField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int NumCorrExpComptPrescript
        {
            get
            {
                return this.NumCorrExpComptPrescriptField;
            }
            set
            {
                this.NumCorrExpComptPrescriptField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string NumDeuxiemeApporteur
        {
            get
            {
                return this.NumDeuxiemeApporteurField;
            }
            set
            {
                this.NumDeuxiemeApporteurField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string NumEtablissement
        {
            get
            {
                return this.NumEtablissementField;
            }
            set
            {
                this.NumEtablissementField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int NumOrdreContrat
        {
            get
            {
                return this.NumOrdreContratField;
            }
            set
            {
                this.NumOrdreContratField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string NumPremierApporteur
        {
            get
            {
                return this.NumPremierApporteurField;
            }
            set
            {
                this.NumPremierApporteurField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public decimal PourcentageCommissionDeuxiemeApporteur
        {
            get
            {
                return this.PourcentageCommissionDeuxiemeApporteurField;
            }
            set
            {
                this.PourcentageCommissionDeuxiemeApporteurField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public decimal PourcentageCommissionPremierApporteur
        {
            get
            {
                return this.PourcentageCommissionPremierApporteurField;
            }
            set
            {
                this.PourcentageCommissionPremierApporteurField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Entreprise", Namespace = "http://www.april.fr/APE/Services/Gestion")]
    public partial class Entreprise : object
    {

        private string APEField;

        private string AdherentImportantField;

        private string AncienNouveauSIRETField;

        private string ClefRIBField;

        private string CodeAPEField;

        private string CodeBanqueField;

        private string CodeCaisseCadreField;

        private string CodeCaisseNonCadreField;

        private string CodeCoField;

        private string CodeGuichetField;

        private string CodeJuridiqueField;

        private System.Nullable<System.DateTime> DateDebutField;

        private System.Nullable<System.DateTime> DateFinField;

        private string DomiciliationBancaireField;

        private string EnseigneEtablissementField;

        private System.Nullable<bool> ExistenceHistoriqueField;

        private string IndicateurField;

        private int JourDebutAct1Field;

        private int JourDebutAct2Field;

        private int JourFinAct1Field;

        private int JourFinAct2Field;

        private string LettreClefEtablissementField;

        private ServiceGestion.Adresse[] ListeAdressesField;

        private ServiceGestion.Contact[] ListeContactField;

        private int MoisDebutAct1Field;

        private int MoisDebutAct2Field;

        private int MoisFinAct1Field;

        private int MoisFinAct2Field;

        private string MotDirecteurEtablissement1Field;

        private string MotDirecteurEtablissement2Field;

        private string MotDirecteurEtablissement3Field;

        private string MotDirecteurEtablissement4Field;

        private string MotDirecteurEtablissement5Field;

        private string MotifDebutField;

        private string MotifFinField;

        private string NomTireField;

        private string NumCompteField;

        private int NumDestinataire1Field;

        private int NumDestinataire2Field;

        private int NumDestinataire3Field;

        private string NumEtablissementField;

        private int NumPersonneField;

        private string NumRegistreField;

        private string NumSIRETField;

        private string RaisonSocialeEtablissement1Field;

        private string RaisonSocialeEtablissement2Field;

        private string SigleEtablissementField;

        private string TypeDestinataireCourrierField;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string APE
        {
            get
            {
                return this.APEField;
            }
            set
            {
                this.APEField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string AdherentImportant
        {
            get
            {
                return this.AdherentImportantField;
            }
            set
            {
                this.AdherentImportantField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string AncienNouveauSIRET
        {
            get
            {
                return this.AncienNouveauSIRETField;
            }
            set
            {
                this.AncienNouveauSIRETField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string ClefRIB
        {
            get
            {
                return this.ClefRIBField;
            }
            set
            {
                this.ClefRIBField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeAPE
        {
            get
            {
                return this.CodeAPEField;
            }
            set
            {
                this.CodeAPEField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeBanque
        {
            get
            {
                return this.CodeBanqueField;
            }
            set
            {
                this.CodeBanqueField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeCaisseCadre
        {
            get
            {
                return this.CodeCaisseCadreField;
            }
            set
            {
                this.CodeCaisseCadreField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeCaisseNonCadre
        {
            get
            {
                return this.CodeCaisseNonCadreField;
            }
            set
            {
                this.CodeCaisseNonCadreField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeCo
        {
            get
            {
                return this.CodeCoField;
            }
            set
            {
                this.CodeCoField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeGuichet
        {
            get
            {
                return this.CodeGuichetField;
            }
            set
            {
                this.CodeGuichetField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeJuridique
        {
            get
            {
                return this.CodeJuridiqueField;
            }
            set
            {
                this.CodeJuridiqueField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<System.DateTime> DateDebut
        {
            get
            {
                return this.DateDebutField;
            }
            set
            {
                this.DateDebutField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<System.DateTime> DateFin
        {
            get
            {
                return this.DateFinField;
            }
            set
            {
                this.DateFinField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string DomiciliationBancaire
        {
            get
            {
                return this.DomiciliationBancaireField;
            }
            set
            {
                this.DomiciliationBancaireField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string EnseigneEtablissement
        {
            get
            {
                return this.EnseigneEtablissementField;
            }
            set
            {
                this.EnseigneEtablissementField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<bool> ExistenceHistorique
        {
            get
            {
                return this.ExistenceHistoriqueField;
            }
            set
            {
                this.ExistenceHistoriqueField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string Indicateur
        {
            get
            {
                return this.IndicateurField;
            }
            set
            {
                this.IndicateurField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int JourDebutAct1
        {
            get
            {
                return this.JourDebutAct1Field;
            }
            set
            {
                this.JourDebutAct1Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int JourDebutAct2
        {
            get
            {
                return this.JourDebutAct2Field;
            }
            set
            {
                this.JourDebutAct2Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int JourFinAct1
        {
            get
            {
                return this.JourFinAct1Field;
            }
            set
            {
                this.JourFinAct1Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int JourFinAct2
        {
            get
            {
                return this.JourFinAct2Field;
            }
            set
            {
                this.JourFinAct2Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string LettreClefEtablissement
        {
            get
            {
                return this.LettreClefEtablissementField;
            }
            set
            {
                this.LettreClefEtablissementField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public ServiceGestion.Adresse[] ListeAdresses
        {
            get
            {
                return this.ListeAdressesField;
            }
            set
            {
                this.ListeAdressesField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public ServiceGestion.Contact[] ListeContact
        {
            get
            {
                return this.ListeContactField;
            }
            set
            {
                this.ListeContactField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int MoisDebutAct1
        {
            get
            {
                return this.MoisDebutAct1Field;
            }
            set
            {
                this.MoisDebutAct1Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int MoisDebutAct2
        {
            get
            {
                return this.MoisDebutAct2Field;
            }
            set
            {
                this.MoisDebutAct2Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int MoisFinAct1
        {
            get
            {
                return this.MoisFinAct1Field;
            }
            set
            {
                this.MoisFinAct1Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int MoisFinAct2
        {
            get
            {
                return this.MoisFinAct2Field;
            }
            set
            {
                this.MoisFinAct2Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string MotDirecteurEtablissement1
        {
            get
            {
                return this.MotDirecteurEtablissement1Field;
            }
            set
            {
                this.MotDirecteurEtablissement1Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string MotDirecteurEtablissement2
        {
            get
            {
                return this.MotDirecteurEtablissement2Field;
            }
            set
            {
                this.MotDirecteurEtablissement2Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string MotDirecteurEtablissement3
        {
            get
            {
                return this.MotDirecteurEtablissement3Field;
            }
            set
            {
                this.MotDirecteurEtablissement3Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string MotDirecteurEtablissement4
        {
            get
            {
                return this.MotDirecteurEtablissement4Field;
            }
            set
            {
                this.MotDirecteurEtablissement4Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string MotDirecteurEtablissement5
        {
            get
            {
                return this.MotDirecteurEtablissement5Field;
            }
            set
            {
                this.MotDirecteurEtablissement5Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string MotifDebut
        {
            get
            {
                return this.MotifDebutField;
            }
            set
            {
                this.MotifDebutField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string MotifFin
        {
            get
            {
                return this.MotifFinField;
            }
            set
            {
                this.MotifFinField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string NomTire
        {
            get
            {
                return this.NomTireField;
            }
            set
            {
                this.NomTireField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string NumCompte
        {
            get
            {
                return this.NumCompteField;
            }
            set
            {
                this.NumCompteField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int NumDestinataire1
        {
            get
            {
                return this.NumDestinataire1Field;
            }
            set
            {
                this.NumDestinataire1Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int NumDestinataire2
        {
            get
            {
                return this.NumDestinataire2Field;
            }
            set
            {
                this.NumDestinataire2Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int NumDestinataire3
        {
            get
            {
                return this.NumDestinataire3Field;
            }
            set
            {
                this.NumDestinataire3Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string NumEtablissement
        {
            get
            {
                return this.NumEtablissementField;
            }
            set
            {
                this.NumEtablissementField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int NumPersonne
        {
            get
            {
                return this.NumPersonneField;
            }
            set
            {
                this.NumPersonneField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string NumRegistre
        {
            get
            {
                return this.NumRegistreField;
            }
            set
            {
                this.NumRegistreField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string NumSIRET
        {
            get
            {
                return this.NumSIRETField;
            }
            set
            {
                this.NumSIRETField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string RaisonSocialeEtablissement1
        {
            get
            {
                return this.RaisonSocialeEtablissement1Field;
            }
            set
            {
                this.RaisonSocialeEtablissement1Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string RaisonSocialeEtablissement2
        {
            get
            {
                return this.RaisonSocialeEtablissement2Field;
            }
            set
            {
                this.RaisonSocialeEtablissement2Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string SigleEtablissement
        {
            get
            {
                return this.SigleEtablissementField;
            }
            set
            {
                this.SigleEtablissementField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string TypeDestinataireCourrier
        {
            get
            {
                return this.TypeDestinataireCourrierField;
            }
            set
            {
                this.TypeDestinataireCourrierField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Assure", Namespace = "http://www.april.fr/APE/Services/Gestion")]
    public partial class Assure : object
    {

        private System.Nullable<System.DateTime> DateDebutCouvertureField;

        private System.Nullable<System.DateTime> DateFinCouvertureField;

        private System.Nullable<bool> ExistenceHistoriqueField;

        private ServiceGestion.Emploi[] ListeEmploiField;

        private string MotifFinCouvertureField;

        private int NumAffiliationField;

        private int NumAssureField;

        private string NumEtablissementField;

        private int NumOrdreContratField;

        private int NumOrdreCouvertureAssureField;

        private int NumParticipantAffiliationField;

        private int NumPersonneField;

        private ServiceGestion.Personne PersonneField;

        private string TypeAssureField;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<System.DateTime> DateDebutCouverture
        {
            get
            {
                return this.DateDebutCouvertureField;
            }
            set
            {
                this.DateDebutCouvertureField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<System.DateTime> DateFinCouverture
        {
            get
            {
                return this.DateFinCouvertureField;
            }
            set
            {
                this.DateFinCouvertureField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<bool> ExistenceHistorique
        {
            get
            {
                return this.ExistenceHistoriqueField;
            }
            set
            {
                this.ExistenceHistoriqueField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public ServiceGestion.Emploi[] ListeEmploi
        {
            get
            {
                return this.ListeEmploiField;
            }
            set
            {
                this.ListeEmploiField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string MotifFinCouverture
        {
            get
            {
                return this.MotifFinCouvertureField;
            }
            set
            {
                this.MotifFinCouvertureField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int NumAffiliation
        {
            get
            {
                return this.NumAffiliationField;
            }
            set
            {
                this.NumAffiliationField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int NumAssure
        {
            get
            {
                return this.NumAssureField;
            }
            set
            {
                this.NumAssureField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string NumEtablissement
        {
            get
            {
                return this.NumEtablissementField;
            }
            set
            {
                this.NumEtablissementField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int NumOrdreContrat
        {
            get
            {
                return this.NumOrdreContratField;
            }
            set
            {
                this.NumOrdreContratField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int NumOrdreCouvertureAssure
        {
            get
            {
                return this.NumOrdreCouvertureAssureField;
            }
            set
            {
                this.NumOrdreCouvertureAssureField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int NumParticipantAffiliation
        {
            get
            {
                return this.NumParticipantAffiliationField;
            }
            set
            {
                this.NumParticipantAffiliationField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int NumPersonne
        {
            get
            {
                return this.NumPersonneField;
            }
            set
            {
                this.NumPersonneField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public ServiceGestion.Personne Personne
        {
            get
            {
                return this.PersonneField;
            }
            set
            {
                this.PersonneField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string TypeAssure
        {
            get
            {
                return this.TypeAssureField;
            }
            set
            {
                this.TypeAssureField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "ContratIndividuel", Namespace = "http://www.april.fr/APE/Services/Gestion")]
    public partial class ContratIndividuel : object
    {

        private System.Nullable<int> AnneeTraitementCapital1Field;

        private System.Nullable<int> AnneeTraitementCapital2Field;

        private System.Nullable<decimal> CapitalBase1Field;

        private System.Nullable<decimal> CapitalBase1YField;

        private System.Nullable<decimal> CapitalBase2Field;

        private System.Nullable<decimal> CapitalBase2YField;

        private string CategorieProfessionnelleDebutField;

        private string CategorieProfessionnelleFinField;

        private string CodeAssietteField;

        private string CodeAvenantField;

        private string CodeCalculExo1Field;

        private string CodeCalculExo2Field;

        private string CodeCalculExo3Field;

        private string CodeCalculExo4Field;

        private string CodeCalculExo5Field;

        private string CodeCapital1Field;

        private string CodeCapital2Field;

        private string CodeExonerationField;

        private string CodeGarantie1Field;

        private string CodeGarantie10Field;

        private string CodeGarantie11Field;

        private string CodeGarantie12Field;

        private string CodeGarantie13Field;

        private string CodeGarantie14Field;

        private string CodeGarantie15Field;

        private string CodeGarantie2Field;

        private string CodeGarantie3Field;

        private string CodeGarantie4Field;

        private string CodeGarantie5Field;

        private string CodeGarantie6Field;

        private string CodeGarantie7Field;

        private string CodeGarantie8Field;

        private string CodeGarantie9Field;

        private string CodeGestionHistoriqueField;

        private string CodeIndexationSurPlafondField;

        private string CodeLieuField;

        private string CodeMajorationField;

        private string CodeNiveauFranchise1Field;

        private string CodeNiveauFranchise10Field;

        private string CodeNiveauFranchise11Field;

        private string CodeNiveauFranchise12Field;

        private string CodeNiveauFranchise13Field;

        private string CodeNiveauFranchise14Field;

        private string CodeNiveauFranchise15Field;

        private string CodeNiveauFranchise2Field;

        private string CodeNiveauFranchise3Field;

        private string CodeNiveauFranchise4Field;

        private string CodeNiveauFranchise5Field;

        private string CodeNiveauFranchise6Field;

        private string CodeNiveauFranchise7Field;

        private string CodeNiveauFranchise8Field;

        private string CodeNiveauFranchise9Field;

        private string CodeOperateurField;

        private string CodeProduitField;

        private System.Nullable<int> CodeTraitementForfaitField;

        private System.Nullable<System.DateTime> DateAppelAvenantField;

        private System.Nullable<System.DateTime> DateCreationField;

        private System.Nullable<System.DateTime> DateEffetField;

        private System.Nullable<System.DateTime> DateFinField;

        private string FamilleProduitField;

        private System.Nullable<int> FormuleRattachementPrestationField;

        private System.Nullable<bool> HorsCommissionField;

        private string LibelleReduitRisque1Field;

        private string LibelleReduitRisque2Field;

        private string LibelleReduitRisque3Field;

        private string LibelleReduitRisque4Field;

        private string LibelleReduitRisque5Field;

        private ServiceGestion.AssureContratIndividuel[] ListeAssureField;

        private string MotifFinField;

        private string MotifFinBisField;

        private System.Nullable<int> NbJourFranchiseAccidentField;

        private System.Nullable<int> NbJourFranchiseHopitalField;

        private System.Nullable<int> NbJourFranchiseMaladieField;

        private string NumAdherentField;

        private string NumAffaireField;

        private string NumAffaireExterneField;

        private string NumCorrespondantApporteur1Field;

        private string NumCorrespondantApporteur2Field;

        private System.Nullable<int> NumExpertComptableField;

        private int NumPersonneField;

        private System.Nullable<int> PrimeAnnuelleNetField;

        private System.Nullable<decimal> PrimeCotisationAnnuelleField;

        private System.Nullable<int> Risque1Field;

        private System.Nullable<int> Risque10Field;

        private System.Nullable<int> Risque11Field;

        private System.Nullable<int> Risque12Field;

        private System.Nullable<int> Risque13Field;

        private System.Nullable<int> Risque14Field;

        private System.Nullable<int> Risque15Field;

        private System.Nullable<int> Risque2Field;

        private System.Nullable<int> Risque3Field;

        private System.Nullable<int> Risque4Field;

        private System.Nullable<int> Risque5Field;

        private System.Nullable<int> Risque6Field;

        private System.Nullable<int> Risque7Field;

        private System.Nullable<int> Risque8Field;

        private System.Nullable<int> Risque9Field;

        private string SecteurGestionCreationAffaireField;

        private string SecteurGestionProduitField;

        private System.Nullable<decimal> TauxAppelRisqueAutrsMCField;

        private System.Nullable<decimal> TauxAppelRisqueMCField;

        private System.Nullable<decimal> TauxCapital1Field;

        private System.Nullable<decimal> TauxCapital2Field;

        private System.Nullable<decimal> TauxCommissionField;

        private System.Nullable<decimal> TauxExonerationCommercialField;

        private System.Nullable<decimal> TauxIndexationObsequesField;

        private System.Nullable<decimal> TauxPartage1Field;

        private System.Nullable<decimal> TauxPartage2Field;

        private System.Nullable<decimal> TauxSurprimRisqueCORRESField;

        private System.Nullable<decimal> TauxSurprimRisqueTLIR1Field;

        private System.Nullable<decimal> TauxSurprimRisqueTLIR2Field;

        private System.Nullable<decimal> TauxSurprimRisqueTLIR3Field;

        private System.Nullable<decimal> TauxSurprimRisqueTLIR4Field;

        private System.Nullable<decimal> TauxSurprimRisqueTLIR5Field;

        private string TypeProduitField;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<int> AnneeTraitementCapital1
        {
            get
            {
                return this.AnneeTraitementCapital1Field;
            }
            set
            {
                this.AnneeTraitementCapital1Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<int> AnneeTraitementCapital2
        {
            get
            {
                return this.AnneeTraitementCapital2Field;
            }
            set
            {
                this.AnneeTraitementCapital2Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<decimal> CapitalBase1
        {
            get
            {
                return this.CapitalBase1Field;
            }
            set
            {
                this.CapitalBase1Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<decimal> CapitalBase1Y
        {
            get
            {
                return this.CapitalBase1YField;
            }
            set
            {
                this.CapitalBase1YField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<decimal> CapitalBase2
        {
            get
            {
                return this.CapitalBase2Field;
            }
            set
            {
                this.CapitalBase2Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<decimal> CapitalBase2Y
        {
            get
            {
                return this.CapitalBase2YField;
            }
            set
            {
                this.CapitalBase2YField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CategorieProfessionnelleDebut
        {
            get
            {
                return this.CategorieProfessionnelleDebutField;
            }
            set
            {
                this.CategorieProfessionnelleDebutField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CategorieProfessionnelleFin
        {
            get
            {
                return this.CategorieProfessionnelleFinField;
            }
            set
            {
                this.CategorieProfessionnelleFinField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeAssiette
        {
            get
            {
                return this.CodeAssietteField;
            }
            set
            {
                this.CodeAssietteField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeAvenant
        {
            get
            {
                return this.CodeAvenantField;
            }
            set
            {
                this.CodeAvenantField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeCalculExo1
        {
            get
            {
                return this.CodeCalculExo1Field;
            }
            set
            {
                this.CodeCalculExo1Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeCalculExo2
        {
            get
            {
                return this.CodeCalculExo2Field;
            }
            set
            {
                this.CodeCalculExo2Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeCalculExo3
        {
            get
            {
                return this.CodeCalculExo3Field;
            }
            set
            {
                this.CodeCalculExo3Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeCalculExo4
        {
            get
            {
                return this.CodeCalculExo4Field;
            }
            set
            {
                this.CodeCalculExo4Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeCalculExo5
        {
            get
            {
                return this.CodeCalculExo5Field;
            }
            set
            {
                this.CodeCalculExo5Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeCapital1
        {
            get
            {
                return this.CodeCapital1Field;
            }
            set
            {
                this.CodeCapital1Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeCapital2
        {
            get
            {
                return this.CodeCapital2Field;
            }
            set
            {
                this.CodeCapital2Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeExoneration
        {
            get
            {
                return this.CodeExonerationField;
            }
            set
            {
                this.CodeExonerationField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeGarantie1
        {
            get
            {
                return this.CodeGarantie1Field;
            }
            set
            {
                this.CodeGarantie1Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeGarantie10
        {
            get
            {
                return this.CodeGarantie10Field;
            }
            set
            {
                this.CodeGarantie10Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeGarantie11
        {
            get
            {
                return this.CodeGarantie11Field;
            }
            set
            {
                this.CodeGarantie11Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeGarantie12
        {
            get
            {
                return this.CodeGarantie12Field;
            }
            set
            {
                this.CodeGarantie12Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeGarantie13
        {
            get
            {
                return this.CodeGarantie13Field;
            }
            set
            {
                this.CodeGarantie13Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeGarantie14
        {
            get
            {
                return this.CodeGarantie14Field;
            }
            set
            {
                this.CodeGarantie14Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeGarantie15
        {
            get
            {
                return this.CodeGarantie15Field;
            }
            set
            {
                this.CodeGarantie15Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeGarantie2
        {
            get
            {
                return this.CodeGarantie2Field;
            }
            set
            {
                this.CodeGarantie2Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeGarantie3
        {
            get
            {
                return this.CodeGarantie3Field;
            }
            set
            {
                this.CodeGarantie3Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeGarantie4
        {
            get
            {
                return this.CodeGarantie4Field;
            }
            set
            {
                this.CodeGarantie4Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeGarantie5
        {
            get
            {
                return this.CodeGarantie5Field;
            }
            set
            {
                this.CodeGarantie5Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeGarantie6
        {
            get
            {
                return this.CodeGarantie6Field;
            }
            set
            {
                this.CodeGarantie6Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeGarantie7
        {
            get
            {
                return this.CodeGarantie7Field;
            }
            set
            {
                this.CodeGarantie7Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeGarantie8
        {
            get
            {
                return this.CodeGarantie8Field;
            }
            set
            {
                this.CodeGarantie8Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeGarantie9
        {
            get
            {
                return this.CodeGarantie9Field;
            }
            set
            {
                this.CodeGarantie9Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeGestionHistorique
        {
            get
            {
                return this.CodeGestionHistoriqueField;
            }
            set
            {
                this.CodeGestionHistoriqueField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeIndexationSurPlafond
        {
            get
            {
                return this.CodeIndexationSurPlafondField;
            }
            set
            {
                this.CodeIndexationSurPlafondField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeLieu
        {
            get
            {
                return this.CodeLieuField;
            }
            set
            {
                this.CodeLieuField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeMajoration
        {
            get
            {
                return this.CodeMajorationField;
            }
            set
            {
                this.CodeMajorationField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeNiveauFranchise1
        {
            get
            {
                return this.CodeNiveauFranchise1Field;
            }
            set
            {
                this.CodeNiveauFranchise1Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeNiveauFranchise10
        {
            get
            {
                return this.CodeNiveauFranchise10Field;
            }
            set
            {
                this.CodeNiveauFranchise10Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeNiveauFranchise11
        {
            get
            {
                return this.CodeNiveauFranchise11Field;
            }
            set
            {
                this.CodeNiveauFranchise11Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeNiveauFranchise12
        {
            get
            {
                return this.CodeNiveauFranchise12Field;
            }
            set
            {
                this.CodeNiveauFranchise12Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeNiveauFranchise13
        {
            get
            {
                return this.CodeNiveauFranchise13Field;
            }
            set
            {
                this.CodeNiveauFranchise13Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeNiveauFranchise14
        {
            get
            {
                return this.CodeNiveauFranchise14Field;
            }
            set
            {
                this.CodeNiveauFranchise14Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeNiveauFranchise15
        {
            get
            {
                return this.CodeNiveauFranchise15Field;
            }
            set
            {
                this.CodeNiveauFranchise15Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeNiveauFranchise2
        {
            get
            {
                return this.CodeNiveauFranchise2Field;
            }
            set
            {
                this.CodeNiveauFranchise2Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeNiveauFranchise3
        {
            get
            {
                return this.CodeNiveauFranchise3Field;
            }
            set
            {
                this.CodeNiveauFranchise3Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeNiveauFranchise4
        {
            get
            {
                return this.CodeNiveauFranchise4Field;
            }
            set
            {
                this.CodeNiveauFranchise4Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeNiveauFranchise5
        {
            get
            {
                return this.CodeNiveauFranchise5Field;
            }
            set
            {
                this.CodeNiveauFranchise5Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeNiveauFranchise6
        {
            get
            {
                return this.CodeNiveauFranchise6Field;
            }
            set
            {
                this.CodeNiveauFranchise6Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeNiveauFranchise7
        {
            get
            {
                return this.CodeNiveauFranchise7Field;
            }
            set
            {
                this.CodeNiveauFranchise7Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeNiveauFranchise8
        {
            get
            {
                return this.CodeNiveauFranchise8Field;
            }
            set
            {
                this.CodeNiveauFranchise8Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeNiveauFranchise9
        {
            get
            {
                return this.CodeNiveauFranchise9Field;
            }
            set
            {
                this.CodeNiveauFranchise9Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeOperateur
        {
            get
            {
                return this.CodeOperateurField;
            }
            set
            {
                this.CodeOperateurField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeProduit
        {
            get
            {
                return this.CodeProduitField;
            }
            set
            {
                this.CodeProduitField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<int> CodeTraitementForfait
        {
            get
            {
                return this.CodeTraitementForfaitField;
            }
            set
            {
                this.CodeTraitementForfaitField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<System.DateTime> DateAppelAvenant
        {
            get
            {
                return this.DateAppelAvenantField;
            }
            set
            {
                this.DateAppelAvenantField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<System.DateTime> DateCreation
        {
            get
            {
                return this.DateCreationField;
            }
            set
            {
                this.DateCreationField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<System.DateTime> DateEffet
        {
            get
            {
                return this.DateEffetField;
            }
            set
            {
                this.DateEffetField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<System.DateTime> DateFin
        {
            get
            {
                return this.DateFinField;
            }
            set
            {
                this.DateFinField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string FamilleProduit
        {
            get
            {
                return this.FamilleProduitField;
            }
            set
            {
                this.FamilleProduitField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<int> FormuleRattachementPrestation
        {
            get
            {
                return this.FormuleRattachementPrestationField;
            }
            set
            {
                this.FormuleRattachementPrestationField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<bool> HorsCommission
        {
            get
            {
                return this.HorsCommissionField;
            }
            set
            {
                this.HorsCommissionField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string LibelleReduitRisque1
        {
            get
            {
                return this.LibelleReduitRisque1Field;
            }
            set
            {
                this.LibelleReduitRisque1Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string LibelleReduitRisque2
        {
            get
            {
                return this.LibelleReduitRisque2Field;
            }
            set
            {
                this.LibelleReduitRisque2Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string LibelleReduitRisque3
        {
            get
            {
                return this.LibelleReduitRisque3Field;
            }
            set
            {
                this.LibelleReduitRisque3Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string LibelleReduitRisque4
        {
            get
            {
                return this.LibelleReduitRisque4Field;
            }
            set
            {
                this.LibelleReduitRisque4Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string LibelleReduitRisque5
        {
            get
            {
                return this.LibelleReduitRisque5Field;
            }
            set
            {
                this.LibelleReduitRisque5Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public ServiceGestion.AssureContratIndividuel[] ListeAssure
        {
            get
            {
                return this.ListeAssureField;
            }
            set
            {
                this.ListeAssureField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string MotifFin
        {
            get
            {
                return this.MotifFinField;
            }
            set
            {
                this.MotifFinField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string MotifFinBis
        {
            get
            {
                return this.MotifFinBisField;
            }
            set
            {
                this.MotifFinBisField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<int> NbJourFranchiseAccident
        {
            get
            {
                return this.NbJourFranchiseAccidentField;
            }
            set
            {
                this.NbJourFranchiseAccidentField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<int> NbJourFranchiseHopital
        {
            get
            {
                return this.NbJourFranchiseHopitalField;
            }
            set
            {
                this.NbJourFranchiseHopitalField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<int> NbJourFranchiseMaladie
        {
            get
            {
                return this.NbJourFranchiseMaladieField;
            }
            set
            {
                this.NbJourFranchiseMaladieField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string NumAdherent
        {
            get
            {
                return this.NumAdherentField;
            }
            set
            {
                this.NumAdherentField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string NumAffaire
        {
            get
            {
                return this.NumAffaireField;
            }
            set
            {
                this.NumAffaireField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string NumAffaireExterne
        {
            get
            {
                return this.NumAffaireExterneField;
            }
            set
            {
                this.NumAffaireExterneField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string NumCorrespondantApporteur1
        {
            get
            {
                return this.NumCorrespondantApporteur1Field;
            }
            set
            {
                this.NumCorrespondantApporteur1Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string NumCorrespondantApporteur2
        {
            get
            {
                return this.NumCorrespondantApporteur2Field;
            }
            set
            {
                this.NumCorrespondantApporteur2Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<int> NumExpertComptable
        {
            get
            {
                return this.NumExpertComptableField;
            }
            set
            {
                this.NumExpertComptableField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int NumPersonne
        {
            get
            {
                return this.NumPersonneField;
            }
            set
            {
                this.NumPersonneField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<int> PrimeAnnuelleNet
        {
            get
            {
                return this.PrimeAnnuelleNetField;
            }
            set
            {
                this.PrimeAnnuelleNetField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<decimal> PrimeCotisationAnnuelle
        {
            get
            {
                return this.PrimeCotisationAnnuelleField;
            }
            set
            {
                this.PrimeCotisationAnnuelleField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<int> Risque1
        {
            get
            {
                return this.Risque1Field;
            }
            set
            {
                this.Risque1Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<int> Risque10
        {
            get
            {
                return this.Risque10Field;
            }
            set
            {
                this.Risque10Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<int> Risque11
        {
            get
            {
                return this.Risque11Field;
            }
            set
            {
                this.Risque11Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<int> Risque12
        {
            get
            {
                return this.Risque12Field;
            }
            set
            {
                this.Risque12Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<int> Risque13
        {
            get
            {
                return this.Risque13Field;
            }
            set
            {
                this.Risque13Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<int> Risque14
        {
            get
            {
                return this.Risque14Field;
            }
            set
            {
                this.Risque14Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<int> Risque15
        {
            get
            {
                return this.Risque15Field;
            }
            set
            {
                this.Risque15Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<int> Risque2
        {
            get
            {
                return this.Risque2Field;
            }
            set
            {
                this.Risque2Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<int> Risque3
        {
            get
            {
                return this.Risque3Field;
            }
            set
            {
                this.Risque3Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<int> Risque4
        {
            get
            {
                return this.Risque4Field;
            }
            set
            {
                this.Risque4Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<int> Risque5
        {
            get
            {
                return this.Risque5Field;
            }
            set
            {
                this.Risque5Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<int> Risque6
        {
            get
            {
                return this.Risque6Field;
            }
            set
            {
                this.Risque6Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<int> Risque7
        {
            get
            {
                return this.Risque7Field;
            }
            set
            {
                this.Risque7Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<int> Risque8
        {
            get
            {
                return this.Risque8Field;
            }
            set
            {
                this.Risque8Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<int> Risque9
        {
            get
            {
                return this.Risque9Field;
            }
            set
            {
                this.Risque9Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string SecteurGestionCreationAffaire
        {
            get
            {
                return this.SecteurGestionCreationAffaireField;
            }
            set
            {
                this.SecteurGestionCreationAffaireField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string SecteurGestionProduit
        {
            get
            {
                return this.SecteurGestionProduitField;
            }
            set
            {
                this.SecteurGestionProduitField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<decimal> TauxAppelRisqueAutrsMC
        {
            get
            {
                return this.TauxAppelRisqueAutrsMCField;
            }
            set
            {
                this.TauxAppelRisqueAutrsMCField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<decimal> TauxAppelRisqueMC
        {
            get
            {
                return this.TauxAppelRisqueMCField;
            }
            set
            {
                this.TauxAppelRisqueMCField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<decimal> TauxCapital1
        {
            get
            {
                return this.TauxCapital1Field;
            }
            set
            {
                this.TauxCapital1Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<decimal> TauxCapital2
        {
            get
            {
                return this.TauxCapital2Field;
            }
            set
            {
                this.TauxCapital2Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<decimal> TauxCommission
        {
            get
            {
                return this.TauxCommissionField;
            }
            set
            {
                this.TauxCommissionField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<decimal> TauxExonerationCommercial
        {
            get
            {
                return this.TauxExonerationCommercialField;
            }
            set
            {
                this.TauxExonerationCommercialField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<decimal> TauxIndexationObseques
        {
            get
            {
                return this.TauxIndexationObsequesField;
            }
            set
            {
                this.TauxIndexationObsequesField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<decimal> TauxPartage1
        {
            get
            {
                return this.TauxPartage1Field;
            }
            set
            {
                this.TauxPartage1Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<decimal> TauxPartage2
        {
            get
            {
                return this.TauxPartage2Field;
            }
            set
            {
                this.TauxPartage2Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<decimal> TauxSurprimRisqueCORRES
        {
            get
            {
                return this.TauxSurprimRisqueCORRESField;
            }
            set
            {
                this.TauxSurprimRisqueCORRESField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<decimal> TauxSurprimRisqueTLIR1
        {
            get
            {
                return this.TauxSurprimRisqueTLIR1Field;
            }
            set
            {
                this.TauxSurprimRisqueTLIR1Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<decimal> TauxSurprimRisqueTLIR2
        {
            get
            {
                return this.TauxSurprimRisqueTLIR2Field;
            }
            set
            {
                this.TauxSurprimRisqueTLIR2Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<decimal> TauxSurprimRisqueTLIR3
        {
            get
            {
                return this.TauxSurprimRisqueTLIR3Field;
            }
            set
            {
                this.TauxSurprimRisqueTLIR3Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<decimal> TauxSurprimRisqueTLIR4
        {
            get
            {
                return this.TauxSurprimRisqueTLIR4Field;
            }
            set
            {
                this.TauxSurprimRisqueTLIR4Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<decimal> TauxSurprimRisqueTLIR5
        {
            get
            {
                return this.TauxSurprimRisqueTLIR5Field;
            }
            set
            {
                this.TauxSurprimRisqueTLIR5Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string TypeProduit
        {
            get
            {
                return this.TypeProduitField;
            }
            set
            {
                this.TypeProduitField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Adresse", Namespace = "http://www.april.fr/APE/Services/Gestion")]
    public partial class Adresse : object
    {

        private string BatimentField;

        private string BureauPostalField;

        private string CodeInseeField;

        private string CodePaysField;

        private string CodePostalField;

        private string CodeProvenanceField;

        private string CodeTourneeFacteurField;

        private string CodeVoieField;

        private int IdPersonneField;

        private string Identifiant1Field;

        private string Identifiant2Field;

        private string LibellePaysField;

        private string LibelleVOieField;

        private string LieuDitField;

        private int NumOrdreAdresseField;

        private string NumVoieField;

        private string TypeVoieField;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string Batiment
        {
            get
            {
                return this.BatimentField;
            }
            set
            {
                this.BatimentField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string BureauPostal
        {
            get
            {
                return this.BureauPostalField;
            }
            set
            {
                this.BureauPostalField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeInsee
        {
            get
            {
                return this.CodeInseeField;
            }
            set
            {
                this.CodeInseeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodePays
        {
            get
            {
                return this.CodePaysField;
            }
            set
            {
                this.CodePaysField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodePostal
        {
            get
            {
                return this.CodePostalField;
            }
            set
            {
                this.CodePostalField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeProvenance
        {
            get
            {
                return this.CodeProvenanceField;
            }
            set
            {
                this.CodeProvenanceField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeTourneeFacteur
        {
            get
            {
                return this.CodeTourneeFacteurField;
            }
            set
            {
                this.CodeTourneeFacteurField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeVoie
        {
            get
            {
                return this.CodeVoieField;
            }
            set
            {
                this.CodeVoieField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int IdPersonne
        {
            get
            {
                return this.IdPersonneField;
            }
            set
            {
                this.IdPersonneField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string Identifiant1
        {
            get
            {
                return this.Identifiant1Field;
            }
            set
            {
                this.Identifiant1Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string Identifiant2
        {
            get
            {
                return this.Identifiant2Field;
            }
            set
            {
                this.Identifiant2Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string LibellePays
        {
            get
            {
                return this.LibellePaysField;
            }
            set
            {
                this.LibellePaysField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string LibelleVOie
        {
            get
            {
                return this.LibelleVOieField;
            }
            set
            {
                this.LibelleVOieField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string LieuDit
        {
            get
            {
                return this.LieuDitField;
            }
            set
            {
                this.LieuDitField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int NumOrdreAdresse
        {
            get
            {
                return this.NumOrdreAdresseField;
            }
            set
            {
                this.NumOrdreAdresseField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string NumVoie
        {
            get
            {
                return this.NumVoieField;
            }
            set
            {
                this.NumVoieField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string TypeVoie
        {
            get
            {
                return this.TypeVoieField;
            }
            set
            {
                this.TypeVoieField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Contact", Namespace = "http://www.april.fr/APE/Services/Gestion")]
    public partial class Contact : object
    {

        private string CommentaireField;

        private int IdPersonneField;

        private int NumeroOrdreContactField;

        private string TypeContactField;

        private string ValeurContactField;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string Commentaire
        {
            get
            {
                return this.CommentaireField;
            }
            set
            {
                this.CommentaireField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int IdPersonne
        {
            get
            {
                return this.IdPersonneField;
            }
            set
            {
                this.IdPersonneField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int NumeroOrdreContact
        {
            get
            {
                return this.NumeroOrdreContactField;
            }
            set
            {
                this.NumeroOrdreContactField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string TypeContact
        {
            get
            {
                return this.TypeContactField;
            }
            set
            {
                this.TypeContactField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string ValeurContact
        {
            get
            {
                return this.ValeurContactField;
            }
            set
            {
                this.ValeurContactField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "ConditionAdhesion", Namespace = "http://www.april.fr/APE/Services/Gestion")]
    public partial class ConditionAdhesion : object
    {

        private string CategorieField;

        private string CodeAssietteField;

        private string CodeAssureurField;

        private string CodeFamilleField;

        private string CodeProduitField;

        private string CodeSecteurField;

        private string CodeTarifField;

        private string CodeTypeField;

        private string CotisAssocField;

        private System.Nullable<System.DateTime> DateDebutField;

        private System.Nullable<System.DateTime> DateFinField;

        private System.Nullable<System.DateTime> DateFinImposeeField;

        private System.Nullable<bool> ExistenceHistoriqueField;

        private string ExoCotisField;

        private string GroupeAssureField;

        private string LibelleAssureurField;

        private string LibelleProduitField;

        private ServiceGestion.CritereTarification[] ListeCriteresTarificationsField;

        private ServiceGestion.Garantie[] ListeGarantiesField;

        private ServiceGestion.MajorationMinoration[] ListeMajorationsMinorationsField;

        private ServiceGestion.SousPeriodeConditionAdhesion[] ListeSousPeriodesConditionAdhesionField;

        private string MethodeTarificationField;

        private string MotifDebutField;

        private string MotifFinField;

        private int NbEnfantsPayantField;

        private string NomDocumentCGField;

        private string NumEtablissementField;

        private int NumOrdreConditionAdhesionField;

        private int NumOrdreContratField;

        private string NumeroConventionField;

        private int NumeroProjetUtiliseField;

        private string ReferenceCGField;

        private string SantePharmaTiersPayantCDField;

        private string SystemeGestionField;

        private string TypeProduitField;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string Categorie
        {
            get
            {
                return this.CategorieField;
            }
            set
            {
                this.CategorieField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeAssiette
        {
            get
            {
                return this.CodeAssietteField;
            }
            set
            {
                this.CodeAssietteField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeAssureur
        {
            get
            {
                return this.CodeAssureurField;
            }
            set
            {
                this.CodeAssureurField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeFamille
        {
            get
            {
                return this.CodeFamilleField;
            }
            set
            {
                this.CodeFamilleField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeProduit
        {
            get
            {
                return this.CodeProduitField;
            }
            set
            {
                this.CodeProduitField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeSecteur
        {
            get
            {
                return this.CodeSecteurField;
            }
            set
            {
                this.CodeSecteurField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeTarif
        {
            get
            {
                return this.CodeTarifField;
            }
            set
            {
                this.CodeTarifField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeType
        {
            get
            {
                return this.CodeTypeField;
            }
            set
            {
                this.CodeTypeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CotisAssoc
        {
            get
            {
                return this.CotisAssocField;
            }
            set
            {
                this.CotisAssocField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<System.DateTime> DateDebut
        {
            get
            {
                return this.DateDebutField;
            }
            set
            {
                this.DateDebutField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<System.DateTime> DateFin
        {
            get
            {
                return this.DateFinField;
            }
            set
            {
                this.DateFinField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<System.DateTime> DateFinImposee
        {
            get
            {
                return this.DateFinImposeeField;
            }
            set
            {
                this.DateFinImposeeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<bool> ExistenceHistorique
        {
            get
            {
                return this.ExistenceHistoriqueField;
            }
            set
            {
                this.ExistenceHistoriqueField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string ExoCotis
        {
            get
            {
                return this.ExoCotisField;
            }
            set
            {
                this.ExoCotisField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string GroupeAssure
        {
            get
            {
                return this.GroupeAssureField;
            }
            set
            {
                this.GroupeAssureField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string LibelleAssureur
        {
            get
            {
                return this.LibelleAssureurField;
            }
            set
            {
                this.LibelleAssureurField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string LibelleProduit
        {
            get
            {
                return this.LibelleProduitField;
            }
            set
            {
                this.LibelleProduitField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public ServiceGestion.CritereTarification[] ListeCriteresTarifications
        {
            get
            {
                return this.ListeCriteresTarificationsField;
            }
            set
            {
                this.ListeCriteresTarificationsField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public ServiceGestion.Garantie[] ListeGaranties
        {
            get
            {
                return this.ListeGarantiesField;
            }
            set
            {
                this.ListeGarantiesField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public ServiceGestion.MajorationMinoration[] ListeMajorationsMinorations
        {
            get
            {
                return this.ListeMajorationsMinorationsField;
            }
            set
            {
                this.ListeMajorationsMinorationsField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public ServiceGestion.SousPeriodeConditionAdhesion[] ListeSousPeriodesConditionAdhesion
        {
            get
            {
                return this.ListeSousPeriodesConditionAdhesionField;
            }
            set
            {
                this.ListeSousPeriodesConditionAdhesionField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string MethodeTarification
        {
            get
            {
                return this.MethodeTarificationField;
            }
            set
            {
                this.MethodeTarificationField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string MotifDebut
        {
            get
            {
                return this.MotifDebutField;
            }
            set
            {
                this.MotifDebutField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string MotifFin
        {
            get
            {
                return this.MotifFinField;
            }
            set
            {
                this.MotifFinField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int NbEnfantsPayant
        {
            get
            {
                return this.NbEnfantsPayantField;
            }
            set
            {
                this.NbEnfantsPayantField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string NomDocumentCG
        {
            get
            {
                return this.NomDocumentCGField;
            }
            set
            {
                this.NomDocumentCGField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string NumEtablissement
        {
            get
            {
                return this.NumEtablissementField;
            }
            set
            {
                this.NumEtablissementField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int NumOrdreConditionAdhesion
        {
            get
            {
                return this.NumOrdreConditionAdhesionField;
            }
            set
            {
                this.NumOrdreConditionAdhesionField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int NumOrdreContrat
        {
            get
            {
                return this.NumOrdreContratField;
            }
            set
            {
                this.NumOrdreContratField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string NumeroConvention
        {
            get
            {
                return this.NumeroConventionField;
            }
            set
            {
                this.NumeroConventionField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int NumeroProjetUtilise
        {
            get
            {
                return this.NumeroProjetUtiliseField;
            }
            set
            {
                this.NumeroProjetUtiliseField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string ReferenceCG
        {
            get
            {
                return this.ReferenceCGField;
            }
            set
            {
                this.ReferenceCGField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string SantePharmaTiersPayantCD
        {
            get
            {
                return this.SantePharmaTiersPayantCDField;
            }
            set
            {
                this.SantePharmaTiersPayantCDField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string SystemeGestion
        {
            get
            {
                return this.SystemeGestionField;
            }
            set
            {
                this.SystemeGestionField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string TypeProduit
        {
            get
            {
                return this.TypeProduitField;
            }
            set
            {
                this.TypeProduitField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "CritereTarification", Namespace = "http://www.april.fr/APE/Services/Gestion")]
    public partial class CritereTarification : object
    {

        private string CodeProduitField;

        private System.Nullable<System.DateTime> DateEffetRegimeField;

        private string NumAdherentField;

        private int NumConditionAdhesionField;

        private int NumContratCollectifField;

        private string SystemeGestionField;

        private string TypeCritereField;

        private string ValeurField;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeProduit
        {
            get
            {
                return this.CodeProduitField;
            }
            set
            {
                this.CodeProduitField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<System.DateTime> DateEffetRegime
        {
            get
            {
                return this.DateEffetRegimeField;
            }
            set
            {
                this.DateEffetRegimeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string NumAdherent
        {
            get
            {
                return this.NumAdherentField;
            }
            set
            {
                this.NumAdherentField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int NumConditionAdhesion
        {
            get
            {
                return this.NumConditionAdhesionField;
            }
            set
            {
                this.NumConditionAdhesionField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int NumContratCollectif
        {
            get
            {
                return this.NumContratCollectifField;
            }
            set
            {
                this.NumContratCollectifField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string SystemeGestion
        {
            get
            {
                return this.SystemeGestionField;
            }
            set
            {
                this.SystemeGestionField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string TypeCritere
        {
            get
            {
                return this.TypeCritereField;
            }
            set
            {
                this.TypeCritereField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string Valeur
        {
            get
            {
                return this.ValeurField;
            }
            set
            {
                this.ValeurField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Garantie", Namespace = "http://www.april.fr/APE/Services/Gestion")]
    public partial class Garantie : object
    {

        private string CodeFranchiseField;

        private string CodeGarantieField;

        private string CodeProduitField;

        private decimal CoefMultiplicateurField;

        private string GarantieRegroupementField;

        private int NiveauGarantieField;

        private string NumEtablissementField;

        private int NumOrdreConditionAdhesionField;

        private int NumOrdreContratField;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeFranchise
        {
            get
            {
                return this.CodeFranchiseField;
            }
            set
            {
                this.CodeFranchiseField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeGarantie
        {
            get
            {
                return this.CodeGarantieField;
            }
            set
            {
                this.CodeGarantieField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeProduit
        {
            get
            {
                return this.CodeProduitField;
            }
            set
            {
                this.CodeProduitField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public decimal CoefMultiplicateur
        {
            get
            {
                return this.CoefMultiplicateurField;
            }
            set
            {
                this.CoefMultiplicateurField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string GarantieRegroupement
        {
            get
            {
                return this.GarantieRegroupementField;
            }
            set
            {
                this.GarantieRegroupementField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int NiveauGarantie
        {
            get
            {
                return this.NiveauGarantieField;
            }
            set
            {
                this.NiveauGarantieField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string NumEtablissement
        {
            get
            {
                return this.NumEtablissementField;
            }
            set
            {
                this.NumEtablissementField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int NumOrdreConditionAdhesion
        {
            get
            {
                return this.NumOrdreConditionAdhesionField;
            }
            set
            {
                this.NumOrdreConditionAdhesionField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int NumOrdreContrat
        {
            get
            {
                return this.NumOrdreContratField;
            }
            set
            {
                this.NumOrdreContratField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "MajorationMinoration", Namespace = "http://www.april.fr/APE/Services/Gestion")]
    public partial class MajorationMinoration : object
    {

        private string CritereMajoMinoField;

        private System.Nullable<System.DateTime> DateDebutField;

        private System.Nullable<System.DateTime> DateFinField;

        private string NumEtablissementField;

        private int NumOrdreConditionAdhesionField;

        private int NumOrdreContratField;

        private string ValeurField;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CritereMajoMino
        {
            get
            {
                return this.CritereMajoMinoField;
            }
            set
            {
                this.CritereMajoMinoField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<System.DateTime> DateDebut
        {
            get
            {
                return this.DateDebutField;
            }
            set
            {
                this.DateDebutField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<System.DateTime> DateFin
        {
            get
            {
                return this.DateFinField;
            }
            set
            {
                this.DateFinField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string NumEtablissement
        {
            get
            {
                return this.NumEtablissementField;
            }
            set
            {
                this.NumEtablissementField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int NumOrdreConditionAdhesion
        {
            get
            {
                return this.NumOrdreConditionAdhesionField;
            }
            set
            {
                this.NumOrdreConditionAdhesionField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int NumOrdreContrat
        {
            get
            {
                return this.NumOrdreContratField;
            }
            set
            {
                this.NumOrdreContratField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string Valeur
        {
            get
            {
                return this.ValeurField;
            }
            set
            {
                this.ValeurField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "SousPeriodeConditionAdhesion", Namespace = "http://www.april.fr/APE/Services/Gestion")]
    public partial class SousPeriodeConditionAdhesion : object
    {

        private string CodeAssietteField;

        private string CodeProduitField;

        private string CodeTarifField;

        private System.Nullable<System.DateTime> DateDebutField;

        private System.Nullable<System.DateTime> DateFinField;

        private string MotifDebutField;

        private string MotifFinField;

        private string NumEtablissementField;

        private int NumOrdreConditionAdhesionField;

        private int NumOrdreContratField;

        private decimal TauxAppel1Field;

        private decimal TauxAppel2Field;

        private decimal TauxAppel3Field;

        private decimal TauxAppel4Field;

        private decimal TauxContrat1Field;

        private decimal TauxContrat2Field;

        private decimal TauxContrat3Field;

        private decimal TauxContrat4Field;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeAssiette
        {
            get
            {
                return this.CodeAssietteField;
            }
            set
            {
                this.CodeAssietteField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeProduit
        {
            get
            {
                return this.CodeProduitField;
            }
            set
            {
                this.CodeProduitField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeTarif
        {
            get
            {
                return this.CodeTarifField;
            }
            set
            {
                this.CodeTarifField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<System.DateTime> DateDebut
        {
            get
            {
                return this.DateDebutField;
            }
            set
            {
                this.DateDebutField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<System.DateTime> DateFin
        {
            get
            {
                return this.DateFinField;
            }
            set
            {
                this.DateFinField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string MotifDebut
        {
            get
            {
                return this.MotifDebutField;
            }
            set
            {
                this.MotifDebutField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string MotifFin
        {
            get
            {
                return this.MotifFinField;
            }
            set
            {
                this.MotifFinField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string NumEtablissement
        {
            get
            {
                return this.NumEtablissementField;
            }
            set
            {
                this.NumEtablissementField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int NumOrdreConditionAdhesion
        {
            get
            {
                return this.NumOrdreConditionAdhesionField;
            }
            set
            {
                this.NumOrdreConditionAdhesionField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int NumOrdreContrat
        {
            get
            {
                return this.NumOrdreContratField;
            }
            set
            {
                this.NumOrdreContratField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public decimal TauxAppel1
        {
            get
            {
                return this.TauxAppel1Field;
            }
            set
            {
                this.TauxAppel1Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public decimal TauxAppel2
        {
            get
            {
                return this.TauxAppel2Field;
            }
            set
            {
                this.TauxAppel2Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public decimal TauxAppel3
        {
            get
            {
                return this.TauxAppel3Field;
            }
            set
            {
                this.TauxAppel3Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public decimal TauxAppel4
        {
            get
            {
                return this.TauxAppel4Field;
            }
            set
            {
                this.TauxAppel4Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public decimal TauxContrat1
        {
            get
            {
                return this.TauxContrat1Field;
            }
            set
            {
                this.TauxContrat1Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public decimal TauxContrat2
        {
            get
            {
                return this.TauxContrat2Field;
            }
            set
            {
                this.TauxContrat2Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public decimal TauxContrat3
        {
            get
            {
                return this.TauxContrat3Field;
            }
            set
            {
                this.TauxContrat3Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public decimal TauxContrat4
        {
            get
            {
                return this.TauxContrat4Field;
            }
            set
            {
                this.TauxContrat4Field = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "EntrepriseAffiliation", Namespace = "http://www.april.fr/APE/Services/Gestion")]
    public partial class EntrepriseAffiliation : object
    {

        private string CodeCourtierField;

        private string IdentifiantDADHField;

        private string NumEtablissementField;

        private string RaisonSocialeEtablissementField;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeCourtier
        {
            get
            {
                return this.CodeCourtierField;
            }
            set
            {
                this.CodeCourtierField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string IdentifiantDADH
        {
            get
            {
                return this.IdentifiantDADHField;
            }
            set
            {
                this.IdentifiantDADHField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string NumEtablissement
        {
            get
            {
                return this.NumEtablissementField;
            }
            set
            {
                this.NumEtablissementField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string RaisonSocialeEtablissement
        {
            get
            {
                return this.RaisonSocialeEtablissementField;
            }
            set
            {
                this.RaisonSocialeEtablissementField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "TypeContratActif", Namespace = "http://www.april.fr/APE/Services/Gestion")]
    public partial class TypeContratActif : object
    {

        private string CollegeField;

        private string MarcheField;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string College
        {
            get
            {
                return this.CollegeField;
            }
            set
            {
                this.CollegeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string Marche
        {
            get
            {
                return this.MarcheField;
            }
            set
            {
                this.MarcheField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "GestionAffiliation", Namespace = "http://schemas.datacontract.org/2004/07/APE.Services.Gestion.Interfaces")]
    public partial class GestionAffiliation : object
    {

        private string CiviliteField;

        private string CollegeField;

        private System.DateTime DateAffiliationField;

        private System.Nullable<System.DateTime> DateEffetStade4Field;

        private string DenominationSocialeField;

        private string EtatField;

        private System.Nullable<int> IdentifiantDemandeAffiliationField;

        private string IdentifiantEntrepriseField;

        private System.Nullable<int> IdentifiantProjetField;

        private string IdentifiantProprietaireField;

        private string MarcheField;

        private string NomField;

        private string PrenomField;

        private string StatutField;

        private string StatutAffiliationField;

        private string TypeField;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Civilite
        {
            get
            {
                return this.CiviliteField;
            }
            set
            {
                this.CiviliteField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string College
        {
            get
            {
                return this.CollegeField;
            }
            set
            {
                this.CollegeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateAffiliation
        {
            get
            {
                return this.DateAffiliationField;
            }
            set
            {
                this.DateAffiliationField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> DateEffetStade4
        {
            get
            {
                return this.DateEffetStade4Field;
            }
            set
            {
                this.DateEffetStade4Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DenominationSociale
        {
            get
            {
                return this.DenominationSocialeField;
            }
            set
            {
                this.DenominationSocialeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Etat
        {
            get
            {
                return this.EtatField;
            }
            set
            {
                this.EtatField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> IdentifiantDemandeAffiliation
        {
            get
            {
                return this.IdentifiantDemandeAffiliationField;
            }
            set
            {
                this.IdentifiantDemandeAffiliationField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdentifiantEntreprise
        {
            get
            {
                return this.IdentifiantEntrepriseField;
            }
            set
            {
                this.IdentifiantEntrepriseField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> IdentifiantProjet
        {
            get
            {
                return this.IdentifiantProjetField;
            }
            set
            {
                this.IdentifiantProjetField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdentifiantProprietaire
        {
            get
            {
                return this.IdentifiantProprietaireField;
            }
            set
            {
                this.IdentifiantProprietaireField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Marche
        {
            get
            {
                return this.MarcheField;
            }
            set
            {
                this.MarcheField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nom
        {
            get
            {
                return this.NomField;
            }
            set
            {
                this.NomField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Prenom
        {
            get
            {
                return this.PrenomField;
            }
            set
            {
                this.PrenomField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Statut
        {
            get
            {
                return this.StatutField;
            }
            set
            {
                this.StatutField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StatutAffiliation
        {
            get
            {
                return this.StatutAffiliationField;
            }
            set
            {
                this.StatutAffiliationField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Type
        {
            get
            {
                return this.TypeField;
            }
            set
            {
                this.TypeField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "ReponseInfoEntreprise.CategorieEmploi", Namespace = "http://schemas.datacontract.org/2004/07/APE.Services.Gestion.Interfaces")]
    public partial class ReponseInfoEntrepriseCategorieEmploi : object
    {

        private string CodeCategorieEmploiField;

        private System.DateTime DateAffiliationMaximumField;

        private System.DateTime DateAffiliationMinimumField;

        private string LibelleCategorieEmploiField;

        private bool SalaireObligatoireField;

        private System.Collections.Generic.KeyValuePair<string, string>[] TypeAffiliationsField;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodeCategorieEmploi
        {
            get
            {
                return this.CodeCategorieEmploiField;
            }
            set
            {
                this.CodeCategorieEmploiField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateAffiliationMaximum
        {
            get
            {
                return this.DateAffiliationMaximumField;
            }
            set
            {
                this.DateAffiliationMaximumField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateAffiliationMinimum
        {
            get
            {
                return this.DateAffiliationMinimumField;
            }
            set
            {
                this.DateAffiliationMinimumField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LibelleCategorieEmploi
        {
            get
            {
                return this.LibelleCategorieEmploiField;
            }
            set
            {
                this.LibelleCategorieEmploiField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool SalaireObligatoire
        {
            get
            {
                return this.SalaireObligatoireField;
            }
            set
            {
                this.SalaireObligatoireField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.KeyValuePair<string, string>[] TypeAffiliations
        {
            get
            {
                return this.TypeAffiliationsField;
            }
            set
            {
                this.TypeAffiliationsField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Personne", Namespace = "http://www.april.fr/APE/Services/Gestion")]
    public partial class Personne : object
    {

        private string CategorieProfessionnelleField;

        private string CentreCaisseSecuriteSocialeField;

        private string CiviliteField;

        private string ClefCaisseSecuriteSocialeField;

        private string CodeCaisseSecuriteSocialeField;

        private string CodeCentreSecuriteSocialeField;

        private string CodeClefSecuriteSocialeField;

        private string CodeProfessionField;

        private System.Nullable<System.DateTime> DateDecesField;

        private System.Nullable<System.DateTime> DateNaissanceField;

        private string DateNaissanceSecuriteSocialeField;

        private int DepartementNaissanceField;

        private string EmailField;

        private string LibeleProfessionField;

        private string LieuNaissanceField;

        private ServiceGestion.Adresse[] ListeAdressesField;

        private ServiceGestion.Contact[] ListeContactField;

        private string NationnaliteField;

        private string NomField;

        private string NomDField;

        private string NomJeuneFilleField;

        private string NomJeuneFilleDField;

        private string NomUsuelField;

        private string NomUsuelDField;

        private int NombreEnfantField;

        private int NumPersonneField;

        private string NumSecuriteSocialeField;

        private string PrenomField;

        private string PrenomDField;

        private int RangNaissanceField;

        private string SituationFamilialeField;

        private int TypeRegimeObligatoireField;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CategorieProfessionnelle
        {
            get
            {
                return this.CategorieProfessionnelleField;
            }
            set
            {
                this.CategorieProfessionnelleField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CentreCaisseSecuriteSociale
        {
            get
            {
                return this.CentreCaisseSecuriteSocialeField;
            }
            set
            {
                this.CentreCaisseSecuriteSocialeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string Civilite
        {
            get
            {
                return this.CiviliteField;
            }
            set
            {
                this.CiviliteField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string ClefCaisseSecuriteSociale
        {
            get
            {
                return this.ClefCaisseSecuriteSocialeField;
            }
            set
            {
                this.ClefCaisseSecuriteSocialeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeCaisseSecuriteSociale
        {
            get
            {
                return this.CodeCaisseSecuriteSocialeField;
            }
            set
            {
                this.CodeCaisseSecuriteSocialeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeCentreSecuriteSociale
        {
            get
            {
                return this.CodeCentreSecuriteSocialeField;
            }
            set
            {
                this.CodeCentreSecuriteSocialeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeClefSecuriteSociale
        {
            get
            {
                return this.CodeClefSecuriteSocialeField;
            }
            set
            {
                this.CodeClefSecuriteSocialeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeProfession
        {
            get
            {
                return this.CodeProfessionField;
            }
            set
            {
                this.CodeProfessionField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<System.DateTime> DateDeces
        {
            get
            {
                return this.DateDecesField;
            }
            set
            {
                this.DateDecesField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<System.DateTime> DateNaissance
        {
            get
            {
                return this.DateNaissanceField;
            }
            set
            {
                this.DateNaissanceField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string DateNaissanceSecuriteSociale
        {
            get
            {
                return this.DateNaissanceSecuriteSocialeField;
            }
            set
            {
                this.DateNaissanceSecuriteSocialeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int DepartementNaissance
        {
            get
            {
                return this.DepartementNaissanceField;
            }
            set
            {
                this.DepartementNaissanceField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string Email
        {
            get
            {
                return this.EmailField;
            }
            set
            {
                this.EmailField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string LibeleProfession
        {
            get
            {
                return this.LibeleProfessionField;
            }
            set
            {
                this.LibeleProfessionField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string LieuNaissance
        {
            get
            {
                return this.LieuNaissanceField;
            }
            set
            {
                this.LieuNaissanceField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public ServiceGestion.Adresse[] ListeAdresses
        {
            get
            {
                return this.ListeAdressesField;
            }
            set
            {
                this.ListeAdressesField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public ServiceGestion.Contact[] ListeContact
        {
            get
            {
                return this.ListeContactField;
            }
            set
            {
                this.ListeContactField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string Nationnalite
        {
            get
            {
                return this.NationnaliteField;
            }
            set
            {
                this.NationnaliteField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string Nom
        {
            get
            {
                return this.NomField;
            }
            set
            {
                this.NomField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string NomD
        {
            get
            {
                return this.NomDField;
            }
            set
            {
                this.NomDField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string NomJeuneFille
        {
            get
            {
                return this.NomJeuneFilleField;
            }
            set
            {
                this.NomJeuneFilleField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string NomJeuneFilleD
        {
            get
            {
                return this.NomJeuneFilleDField;
            }
            set
            {
                this.NomJeuneFilleDField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string NomUsuel
        {
            get
            {
                return this.NomUsuelField;
            }
            set
            {
                this.NomUsuelField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string NomUsuelD
        {
            get
            {
                return this.NomUsuelDField;
            }
            set
            {
                this.NomUsuelDField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int NombreEnfant
        {
            get
            {
                return this.NombreEnfantField;
            }
            set
            {
                this.NombreEnfantField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int NumPersonne
        {
            get
            {
                return this.NumPersonneField;
            }
            set
            {
                this.NumPersonneField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string NumSecuriteSociale
        {
            get
            {
                return this.NumSecuriteSocialeField;
            }
            set
            {
                this.NumSecuriteSocialeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string Prenom
        {
            get
            {
                return this.PrenomField;
            }
            set
            {
                this.PrenomField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string PrenomD
        {
            get
            {
                return this.PrenomDField;
            }
            set
            {
                this.PrenomDField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int RangNaissance
        {
            get
            {
                return this.RangNaissanceField;
            }
            set
            {
                this.RangNaissanceField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string SituationFamiliale
        {
            get
            {
                return this.SituationFamilialeField;
            }
            set
            {
                this.SituationFamilialeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int TypeRegimeObligatoire
        {
            get
            {
                return this.TypeRegimeObligatoireField;
            }
            set
            {
                this.TypeRegimeObligatoireField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Emploi", Namespace = "http://www.april.fr/APE/Services/Gestion")]
    public partial class Emploi : object
    {

        private System.Nullable<System.DateTime> DateDebutField;

        private System.Nullable<System.DateTime> DateFinField;

        private string EmploiMemberField;

        private int JourDebutPeriode1Field;

        private int JourDebutPeriode2Field;

        private int JourFinPeriode1Field;

        private int JourFinPeriode2Field;

        private ServiceGestion.CategorieEmploi[] ListeCategoriesEmploisField;

        private int MoisDebutPeriode1Field;

        private int MoisDebutPeriode2Field;

        private int MoisFinPeriode1Field;

        private int MoisFinPeriode2Field;

        private string NumEtablissementField;

        private int NumExerciceField;

        private int NumOrdreEmploiField;

        private int NumPersonneField;

        private System.Nullable<bool> PreavisEmploiField;

        private decimal SalaireAnnuelField;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<System.DateTime> DateDebut
        {
            get
            {
                return this.DateDebutField;
            }
            set
            {
                this.DateDebutField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<System.DateTime> DateFin
        {
            get
            {
                return this.DateFinField;
            }
            set
            {
                this.DateFinField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Name = "Emploi", EmitDefaultValue = false)]
        public string EmploiMember
        {
            get
            {
                return this.EmploiMemberField;
            }
            set
            {
                this.EmploiMemberField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int JourDebutPeriode1
        {
            get
            {
                return this.JourDebutPeriode1Field;
            }
            set
            {
                this.JourDebutPeriode1Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int JourDebutPeriode2
        {
            get
            {
                return this.JourDebutPeriode2Field;
            }
            set
            {
                this.JourDebutPeriode2Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int JourFinPeriode1
        {
            get
            {
                return this.JourFinPeriode1Field;
            }
            set
            {
                this.JourFinPeriode1Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int JourFinPeriode2
        {
            get
            {
                return this.JourFinPeriode2Field;
            }
            set
            {
                this.JourFinPeriode2Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public ServiceGestion.CategorieEmploi[] ListeCategoriesEmplois
        {
            get
            {
                return this.ListeCategoriesEmploisField;
            }
            set
            {
                this.ListeCategoriesEmploisField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int MoisDebutPeriode1
        {
            get
            {
                return this.MoisDebutPeriode1Field;
            }
            set
            {
                this.MoisDebutPeriode1Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int MoisDebutPeriode2
        {
            get
            {
                return this.MoisDebutPeriode2Field;
            }
            set
            {
                this.MoisDebutPeriode2Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int MoisFinPeriode1
        {
            get
            {
                return this.MoisFinPeriode1Field;
            }
            set
            {
                this.MoisFinPeriode1Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int MoisFinPeriode2
        {
            get
            {
                return this.MoisFinPeriode2Field;
            }
            set
            {
                this.MoisFinPeriode2Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string NumEtablissement
        {
            get
            {
                return this.NumEtablissementField;
            }
            set
            {
                this.NumEtablissementField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int NumExercice
        {
            get
            {
                return this.NumExerciceField;
            }
            set
            {
                this.NumExerciceField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int NumOrdreEmploi
        {
            get
            {
                return this.NumOrdreEmploiField;
            }
            set
            {
                this.NumOrdreEmploiField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int NumPersonne
        {
            get
            {
                return this.NumPersonneField;
            }
            set
            {
                this.NumPersonneField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<bool> PreavisEmploi
        {
            get
            {
                return this.PreavisEmploiField;
            }
            set
            {
                this.PreavisEmploiField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public decimal SalaireAnnuel
        {
            get
            {
                return this.SalaireAnnuelField;
            }
            set
            {
                this.SalaireAnnuelField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "CategorieEmploi", Namespace = "http://www.april.fr/APE/Services/Gestion")]
    public partial class CategorieEmploi : object
    {

        private string CodeCategoriePersonneField;

        private string CodeFonctionField;

        private System.Nullable<System.DateTime> DateDebutField;

        private System.Nullable<System.DateTime> DateFinField;

        private string NumEtablissementField;

        private int NumOrdreEmploiField;

        private int NumPersonneField;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeCategoriePersonne
        {
            get
            {
                return this.CodeCategoriePersonneField;
            }
            set
            {
                this.CodeCategoriePersonneField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeFonction
        {
            get
            {
                return this.CodeFonctionField;
            }
            set
            {
                this.CodeFonctionField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<System.DateTime> DateDebut
        {
            get
            {
                return this.DateDebutField;
            }
            set
            {
                this.DateDebutField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<System.DateTime> DateFin
        {
            get
            {
                return this.DateFinField;
            }
            set
            {
                this.DateFinField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string NumEtablissement
        {
            get
            {
                return this.NumEtablissementField;
            }
            set
            {
                this.NumEtablissementField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int NumOrdreEmploi
        {
            get
            {
                return this.NumOrdreEmploiField;
            }
            set
            {
                this.NumOrdreEmploiField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int NumPersonne
        {
            get
            {
                return this.NumPersonneField;
            }
            set
            {
                this.NumPersonneField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "AssureContratIndividuel", Namespace = "http://www.april.fr/APE/Services/Gestion")]
    public partial class AssureContratIndividuel : object
    {

        private string CentreCaisseSecuField;

        private string ClefCaisseSecuField;

        private string CodeCaisseSecuField;

        private string CodeGestionHistoriqueField;

        private string CodeOperateurField;

        private string CodeParticipationField;

        private string CodePrestationSpecialeField;

        private string CodeProduitField;

        private string CodeRegimeObligatoireField;

        private string CodeValiditeEnregistrementField;

        private System.DateTime DateEffetFamilleField;

        private System.Nullable<System.DateTime> DateFinFamilleField;

        private System.DateTime DateNaissanceField;

        private string LibelleDenominationField;

        private string LibelleStage1Field;

        private string LibelleStage2Field;

        private string LieuGestionField;

        private string MotifFinField;

        private string MotifFinBisField;

        private System.Nullable<int> NbMoisStageField;

        private string NomField;

        private string NumAdherentField;

        private int NumPersonneField;

        private string NumSecuField;

        private string PrenomField;

        private string QualiteStageField;

        private int RangField;

        private System.Nullable<decimal> TauxExonerationAutreMutuelleField;

        private System.Nullable<decimal> TauxSurprimeRisqueMCField;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CentreCaisseSecu
        {
            get
            {
                return this.CentreCaisseSecuField;
            }
            set
            {
                this.CentreCaisseSecuField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string ClefCaisseSecu
        {
            get
            {
                return this.ClefCaisseSecuField;
            }
            set
            {
                this.ClefCaisseSecuField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeCaisseSecu
        {
            get
            {
                return this.CodeCaisseSecuField;
            }
            set
            {
                this.CodeCaisseSecuField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeGestionHistorique
        {
            get
            {
                return this.CodeGestionHistoriqueField;
            }
            set
            {
                this.CodeGestionHistoriqueField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeOperateur
        {
            get
            {
                return this.CodeOperateurField;
            }
            set
            {
                this.CodeOperateurField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeParticipation
        {
            get
            {
                return this.CodeParticipationField;
            }
            set
            {
                this.CodeParticipationField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodePrestationSpeciale
        {
            get
            {
                return this.CodePrestationSpecialeField;
            }
            set
            {
                this.CodePrestationSpecialeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeProduit
        {
            get
            {
                return this.CodeProduitField;
            }
            set
            {
                this.CodeProduitField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeRegimeObligatoire
        {
            get
            {
                return this.CodeRegimeObligatoireField;
            }
            set
            {
                this.CodeRegimeObligatoireField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string CodeValiditeEnregistrement
        {
            get
            {
                return this.CodeValiditeEnregistrementField;
            }
            set
            {
                this.CodeValiditeEnregistrementField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.DateTime DateEffetFamille
        {
            get
            {
                return this.DateEffetFamilleField;
            }
            set
            {
                this.DateEffetFamilleField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<System.DateTime> DateFinFamille
        {
            get
            {
                return this.DateFinFamilleField;
            }
            set
            {
                this.DateFinFamilleField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.DateTime DateNaissance
        {
            get
            {
                return this.DateNaissanceField;
            }
            set
            {
                this.DateNaissanceField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string LibelleDenomination
        {
            get
            {
                return this.LibelleDenominationField;
            }
            set
            {
                this.LibelleDenominationField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string LibelleStage1
        {
            get
            {
                return this.LibelleStage1Field;
            }
            set
            {
                this.LibelleStage1Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string LibelleStage2
        {
            get
            {
                return this.LibelleStage2Field;
            }
            set
            {
                this.LibelleStage2Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string LieuGestion
        {
            get
            {
                return this.LieuGestionField;
            }
            set
            {
                this.LieuGestionField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string MotifFin
        {
            get
            {
                return this.MotifFinField;
            }
            set
            {
                this.MotifFinField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string MotifFinBis
        {
            get
            {
                return this.MotifFinBisField;
            }
            set
            {
                this.MotifFinBisField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<int> NbMoisStage
        {
            get
            {
                return this.NbMoisStageField;
            }
            set
            {
                this.NbMoisStageField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string Nom
        {
            get
            {
                return this.NomField;
            }
            set
            {
                this.NomField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string NumAdherent
        {
            get
            {
                return this.NumAdherentField;
            }
            set
            {
                this.NumAdherentField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int NumPersonne
        {
            get
            {
                return this.NumPersonneField;
            }
            set
            {
                this.NumPersonneField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string NumSecu
        {
            get
            {
                return this.NumSecuField;
            }
            set
            {
                this.NumSecuField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string Prenom
        {
            get
            {
                return this.PrenomField;
            }
            set
            {
                this.PrenomField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string QualiteStage
        {
            get
            {
                return this.QualiteStageField;
            }
            set
            {
                this.QualiteStageField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int Rang
        {
            get
            {
                return this.RangField;
            }
            set
            {
                this.RangField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<decimal> TauxExonerationAutreMutuelle
        {
            get
            {
                return this.TauxExonerationAutreMutuelleField;
            }
            set
            {
                this.TauxExonerationAutreMutuelleField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Nullable<decimal> TauxSurprimeRisqueMC
        {
            get
            {
                return this.TauxSurprimeRisqueMCField;
            }
            set
            {
                this.TauxSurprimeRisqueMCField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.april.fr/APE/Services/Gestion", ConfigurationName = "ServiceGestion.IGestion")]
    public interface IGestion
    {

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.april.fr/APE/Services/Gestion/IGestion/ChargerAffilie", ReplyAction = "http://www.april.fr/APE/Services/Gestion/IGestion/ChargerAffilieResponse")]
        System.Threading.Tasks.Task<ServiceGestion.ReponseChargerAffilie> ChargerAffilieAsync(ServiceGestion.DemandeChargerAffilie aobj_DemandeChargerAffilie);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.april.fr/APE/Services/Gestion/IGestion/ChargerEntreprise", ReplyAction = "http://www.april.fr/APE/Services/Gestion/IGestion/ChargerEntrepriseResponse")]
        System.Threading.Tasks.Task<ServiceGestion.ReponseChargerEntreprise> ChargerEntrepriseAsync(ServiceGestion.DemandeChargerEntreprise aobj_DemandeChargerEntreprise);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.april.fr/APE/Services/Gestion/IGestion/RechercherEntreprises", ReplyAction = "http://www.april.fr/APE/Services/Gestion/IGestion/RechercherEntreprisesResponse")]
        System.Threading.Tasks.Task<ServiceGestion.ReponseRechercherEntreprises> RechercherEntreprisesAsync(ServiceGestion.DemandeRechercherEntreprises aobj_DemandeRechercherEntreprises);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.april.fr/APE/Services/Gestion/IGestion/RechercherEntreprisesPourAffili" +
            "ation", ReplyAction = "http://www.april.fr/APE/Services/Gestion/IGestion/RechercherEntreprisesPourAffili" +
            "ationResponse")]
        System.Threading.Tasks.Task<ServiceGestion.ReponseRechercherEntreprisesAffiliation> RechercherEntreprisesPourAffiliationAsync(ServiceGestion.DemandeRechercherEntreprises aobj_DemandeRechercherEntreprises);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.april.fr/APE/Services/Gestion/IGestion/ListerTypeContratsActifsEntrepr" +
            "ise", ReplyAction = "http://www.april.fr/APE/Services/Gestion/IGestion/ListerTypeContratsActifsEntrepr" +
            "iseResponse")]
        System.Threading.Tasks.Task<ServiceGestion.ReponseTypeContratsActifsEntreprise> ListerTypeContratsActifsEntrepriseAsync(ServiceGestion.DemandeTypeContratsActifsEntreprise aobj_DemandeTypeContratsActifsEntreprise);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.april.fr/APE/Services/Gestion/IGestion/ObtenirBIA", ReplyAction = "http://www.april.fr/APE/Services/Gestion/IGestion/ObtenirBIAResponse")]
        System.Threading.Tasks.Task<ServiceGestion.ReponseObtenirBIA> ObtenirBIAAsync(ServiceGestion.DemandeObtenirBIA aobj_DemandeObtenirBIA);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.april.fr/APE/Services/Gestion/IGestion/ObtenirDocumentsAffiliation", ReplyAction = "http://www.april.fr/APE/Services/Gestion/IGestion/ObtenirDocumentsAffiliationResp" +
            "onse")]
        System.Threading.Tasks.Task<ServiceGestion.ReponseObtenirDocumentsAffiliation> ObtenirDocumentsAffiliationAsync(ServiceGestion.DemandeObtenirDocumentStatiqueAffiliation aobj_DemandeObtenirCG);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.april.fr/APE/Services/Gestion/IGestion/EnvoyerBIA", ReplyAction = "http://www.april.fr/APE/Services/Gestion/IGestion/EnvoyerBIAResponse")]
        System.Threading.Tasks.Task<ServiceGestion.ReponseBase> EnvoyerBIAAsync(ServiceGestion.DemandeEnvoyerBIA aobj_DemandeEnvoyerBIA);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.april.fr/APE/Services/Gestion/IGestion/ProduitTechniqueSupporteParPlat" +
            "eformeDistribution", ReplyAction = "http://www.april.fr/APE/Services/Gestion/IGestion/ProduitTechniqueSupporteParPlat" +
            "eformeDistributionResponse")]
        System.Threading.Tasks.Task<ServiceGestion.ReponseProduitTechniqueSupporte> ProduitTechniqueSupporteParPlateformeDistributionAsync(ServiceGestion.DemandeProduitTechniqueSupporte aobj_DemanderProduitTechniqueSupporte);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.april.fr/APE/Services/Gestion/IGestion/DecoderCollege", ReplyAction = "http://www.april.fr/APE/Services/Gestion/IGestion/DecoderCollegeResponse")]
        System.Threading.Tasks.Task<string> DecoderCollegeAsync(string astr_CategoriePersonne);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.april.fr/APE/Services/Gestion/IGestion/ListerAffiliations", ReplyAction = "http://www.april.fr/APE/Services/Gestion/IGestion/ListerAffiliationsResponse")]
        System.Threading.Tasks.Task<ServiceGestion.ReponseListerAffiliations> ListerAffiliationsAsync(ServiceGestion.DemandeListerAffiliations aobj_DemandeListerAffiliations);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.april.fr/APE/Services/Gestion/IGestion/CreerDemandeAffiliation", ReplyAction = "http://www.april.fr/APE/Services/Gestion/IGestion/CreerDemandeAffiliationResponse" +
            "")]
        System.Threading.Tasks.Task<ServiceGestion.ReponseCreationAffiliation> CreerDemandeAffiliationAsync(ServiceGestion.DemandeCreationAffiliation aobj_DemandeCreationAffiliation);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.april.fr/APE/Services/Gestion/IGestion/AnnulerDemandeAffiliation", ReplyAction = "http://www.april.fr/APE/Services/Gestion/IGestion/AnnulerDemandeAffiliationRespon" +
            "se")]
        System.Threading.Tasks.Task<ServiceGestion.ReponseBase> AnnulerDemandeAffiliationAsync(ServiceGestion.DemandeChangerEtatAffiliation astr_IdentifiantDADH);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.april.fr/APE/Services/Gestion/IGestion/InfoEntreprisePourAffiliation", ReplyAction = "http://www.april.fr/APE/Services/Gestion/IGestion/InfoEntreprisePourAffiliationRe" +
            "sponse")]
        System.Threading.Tasks.Task<ServiceGestion.ReponseInfoEntreprise> InfoEntreprisePourAffiliationAsync(ServiceGestion.DemandeInfoEntreprise aobj_DemandeInfoEntreprise);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.april.fr/APE/Services/Gestion/IGestion/DispenserDemandeAffiliation", ReplyAction = "http://www.april.fr/APE/Services/Gestion/IGestion/DispenserDemandeAffiliationResp" +
            "onse")]
        System.Threading.Tasks.Task<ServiceGestion.ReponseBase> DispenserDemandeAffiliationAsync(ServiceGestion.DemandeChangerEtatAffiliation aobj_IdentifiantDADH);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.april.fr/APE/Services/Gestion/IGestion/ModifierTypeDemandeAffiliation", ReplyAction = "http://www.april.fr/APE/Services/Gestion/IGestion/ModifierTypeDemandeAffiliationR" +
            "esponse")]
        System.Threading.Tasks.Task<ServiceGestion.ReponseBase> ModifierTypeDemandeAffiliationAsync(ServiceGestion.DemandeModifierTypeDemandeAffiliation aobj_Demande);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.april.fr/APE/Services/Gestion/IGestion/RenvoyerMailAffiliationDigital", ReplyAction = "http://www.april.fr/APE/Services/Gestion/IGestion/RenvoyerMailAffiliationDigitalR" +
            "esponse")]
        System.Threading.Tasks.Task<ServiceGestion.ReponseBase> RenvoyerMailAffiliationDigitalAsync(ServiceGestion.DemandeIdentifiantDemandeAffiliation aobj_DemandeRenvoyerMailAffiliationDigital);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.april.fr/APE/Services/Gestion/IGestion/LireAffiliation", ReplyAction = "http://www.april.fr/APE/Services/Gestion/IGestion/LireAffiliationResponse")]
        System.Threading.Tasks.Task<ServiceGestion.ReponseLireAffiliation> LireAffiliationAsync(ServiceGestion.DemandeIdentifiantDemandeAffiliation aobj_Demande);
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface IGestionChannel : ServiceGestion.IGestion, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class GestionClient : System.ServiceModel.ClientBase<ServiceGestion.IGestion>, ServiceGestion.IGestion
    {

        /// <summary>
        /// Implémentez cette méthode partielle pour configurer le point de terminaison de service.
        /// </summary>
        /// <param name="serviceEndpoint">Point de terminaison à configurer</param>
        /// <param name="clientCredentials">Informations d'identification du client</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);

        public GestionClient() :
                base(GestionClient.GetDefaultBinding(), GestionClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IGestion.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        public GestionClient(EndpointConfiguration endpointConfiguration) :
                base(GestionClient.GetBindingForEndpoint(endpointConfiguration), GestionClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        public GestionClient(EndpointConfiguration endpointConfiguration, string remoteAddress) :
                base(GestionClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        public GestionClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) :
                base(GestionClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        public GestionClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        public System.Threading.Tasks.Task<ServiceGestion.ReponseChargerAffilie> ChargerAffilieAsync(ServiceGestion.DemandeChargerAffilie aobj_DemandeChargerAffilie)
        {
            return base.Channel.ChargerAffilieAsync(aobj_DemandeChargerAffilie);
        }

        public System.Threading.Tasks.Task<ServiceGestion.ReponseChargerEntreprise> ChargerEntrepriseAsync(ServiceGestion.DemandeChargerEntreprise aobj_DemandeChargerEntreprise)
        {
            return base.Channel.ChargerEntrepriseAsync(aobj_DemandeChargerEntreprise);
        }

        public System.Threading.Tasks.Task<ServiceGestion.ReponseRechercherEntreprises> RechercherEntreprisesAsync(ServiceGestion.DemandeRechercherEntreprises aobj_DemandeRechercherEntreprises)
        {
            return base.Channel.RechercherEntreprisesAsync(aobj_DemandeRechercherEntreprises);
        }

        public System.Threading.Tasks.Task<ServiceGestion.ReponseRechercherEntreprisesAffiliation> RechercherEntreprisesPourAffiliationAsync(ServiceGestion.DemandeRechercherEntreprises aobj_DemandeRechercherEntreprises)
        {
            return base.Channel.RechercherEntreprisesPourAffiliationAsync(aobj_DemandeRechercherEntreprises);
        }

        public System.Threading.Tasks.Task<ServiceGestion.ReponseTypeContratsActifsEntreprise> ListerTypeContratsActifsEntrepriseAsync(ServiceGestion.DemandeTypeContratsActifsEntreprise aobj_DemandeTypeContratsActifsEntreprise)
        {
            return base.Channel.ListerTypeContratsActifsEntrepriseAsync(aobj_DemandeTypeContratsActifsEntreprise);
        }

        public System.Threading.Tasks.Task<ServiceGestion.ReponseObtenirBIA> ObtenirBIAAsync(ServiceGestion.DemandeObtenirBIA aobj_DemandeObtenirBIA)
        {
            return base.Channel.ObtenirBIAAsync(aobj_DemandeObtenirBIA);
        }

        public System.Threading.Tasks.Task<ServiceGestion.ReponseObtenirDocumentsAffiliation> ObtenirDocumentsAffiliationAsync(ServiceGestion.DemandeObtenirDocumentStatiqueAffiliation aobj_DemandeObtenirCG)
        {
            return base.Channel.ObtenirDocumentsAffiliationAsync(aobj_DemandeObtenirCG);
        }

        public System.Threading.Tasks.Task<ServiceGestion.ReponseBase> EnvoyerBIAAsync(ServiceGestion.DemandeEnvoyerBIA aobj_DemandeEnvoyerBIA)
        {
            return base.Channel.EnvoyerBIAAsync(aobj_DemandeEnvoyerBIA);
        }

        public System.Threading.Tasks.Task<ServiceGestion.ReponseProduitTechniqueSupporte> ProduitTechniqueSupporteParPlateformeDistributionAsync(ServiceGestion.DemandeProduitTechniqueSupporte aobj_DemanderProduitTechniqueSupporte)
        {
            return base.Channel.ProduitTechniqueSupporteParPlateformeDistributionAsync(aobj_DemanderProduitTechniqueSupporte);
        }

        public System.Threading.Tasks.Task<string> DecoderCollegeAsync(string astr_CategoriePersonne)
        {
            return base.Channel.DecoderCollegeAsync(astr_CategoriePersonne);
        }

        public System.Threading.Tasks.Task<ServiceGestion.ReponseListerAffiliations> ListerAffiliationsAsync(ServiceGestion.DemandeListerAffiliations aobj_DemandeListerAffiliations)
        {
            return base.Channel.ListerAffiliationsAsync(aobj_DemandeListerAffiliations);
        }

        public System.Threading.Tasks.Task<ServiceGestion.ReponseCreationAffiliation> CreerDemandeAffiliationAsync(ServiceGestion.DemandeCreationAffiliation aobj_DemandeCreationAffiliation)
        {
            return base.Channel.CreerDemandeAffiliationAsync(aobj_DemandeCreationAffiliation);
        }

        public System.Threading.Tasks.Task<ServiceGestion.ReponseBase> AnnulerDemandeAffiliationAsync(ServiceGestion.DemandeChangerEtatAffiliation astr_IdentifiantDADH)
        {
            return base.Channel.AnnulerDemandeAffiliationAsync(astr_IdentifiantDADH);
        }

        public System.Threading.Tasks.Task<ServiceGestion.ReponseInfoEntreprise> InfoEntreprisePourAffiliationAsync(ServiceGestion.DemandeInfoEntreprise aobj_DemandeInfoEntreprise)
        {
            return base.Channel.InfoEntreprisePourAffiliationAsync(aobj_DemandeInfoEntreprise);
        }

        public System.Threading.Tasks.Task<ServiceGestion.ReponseBase> DispenserDemandeAffiliationAsync(ServiceGestion.DemandeChangerEtatAffiliation aobj_IdentifiantDADH)
        {
            return base.Channel.DispenserDemandeAffiliationAsync(aobj_IdentifiantDADH);
        }

        public System.Threading.Tasks.Task<ServiceGestion.ReponseBase> ModifierTypeDemandeAffiliationAsync(ServiceGestion.DemandeModifierTypeDemandeAffiliation aobj_Demande)
        {
            return base.Channel.ModifierTypeDemandeAffiliationAsync(aobj_Demande);
        }

        public System.Threading.Tasks.Task<ServiceGestion.ReponseBase> RenvoyerMailAffiliationDigitalAsync(ServiceGestion.DemandeIdentifiantDemandeAffiliation aobj_DemandeRenvoyerMailAffiliationDigital)
        {
            return base.Channel.RenvoyerMailAffiliationDigitalAsync(aobj_DemandeRenvoyerMailAffiliationDigital);
        }

        public System.Threading.Tasks.Task<ServiceGestion.ReponseLireAffiliation> LireAffiliationAsync(ServiceGestion.DemandeIdentifiantDemandeAffiliation aobj_Demande)
        {
            return base.Channel.LireAffiliationAsync(aobj_Demande);
        }

        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }

        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }

        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IGestion))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Le point de terminaison nommé \'{0}\' est introuvable.", endpointConfiguration));
        }

        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IGestion))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:41005/APE/Services/Gestion");
            }
            throw new System.InvalidOperationException(string.Format("Le point de terminaison nommé \'{0}\' est introuvable.", endpointConfiguration));
        }

        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return GestionClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IGestion);
        }

        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return GestionClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IGestion);
        }

        public enum EndpointConfiguration
        {

            BasicHttpBinding_IGestion,
        }
    }
}
