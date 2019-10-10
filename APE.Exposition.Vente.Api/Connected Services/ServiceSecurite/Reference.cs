//------------------------------------------------------------------------------
// <généré automatiquement>
//     Ce code a été généré par un outil.
//     //
//     Les changements apportés à ce fichier peuvent provoquer un comportement incorrect et seront perdus si
//     le code est regénéré.
// </généré automatiquement>
//------------------------------------------------------------------------------

namespace ServiceSecurite
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Demande", Namespace = "http://www.april.fr/APE/Services/Securite")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceSecurite.DemandeContexte))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceSecurite.DemandeSubstitution))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceSecurite.DemandeValiderMotPasse2))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceSecurite.DemandeVueCumule))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceSecurite.DemandeSousCode))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceSecurite.DemandeInfosApporteur))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceSecurite.DemandeObtenirJetonEspaceEntreprises))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceSecurite.DemandeCrypterJeton))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceSecurite.DemandeDecrypterJeton))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceSecurite.DemandeCrypterJetonRSA))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceSecurite.DemandeDecrypterJetonRSA))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceSecurite.DemandeCreerContexteODV))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceSecurite.DemandeObtenirContexteODV))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceSecurite.DemandeAuthentifier))]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "DemandeContexte", Namespace = "http://www.april.fr/APE/Services/Securite")]
    public partial class DemandeContexte : ServiceSecurite.Demande
    {

        private string JetonAEPField;

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        public string JetonAEP
        {
            get
            {
                return this.JetonAEPField;
            }
            set
            {
                this.JetonAEPField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "DemandeSubstitution", Namespace = "http://www.april.fr/APE/Services/Securite")]
    public partial class DemandeSubstitution : ServiceSecurite.Demande
    {

        private string JetonAEPField;

        private string UtilisateurField;

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        public string JetonAEP
        {
            get
            {
                return this.JetonAEPField;
            }
            set
            {
                this.JetonAEPField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        public string Utilisateur
        {
            get
            {
                return this.UtilisateurField;
            }
            set
            {
                this.UtilisateurField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "DemandeValiderMotPasse2", Namespace = "http://www.april.fr/APE/Services/Securite")]
    public partial class DemandeValiderMotPasse2 : ServiceSecurite.Demande
    {

        private string JetonAEPField;

        private bool ActifField;

        private string MotDePasse2Field;

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        public string JetonAEP
        {
            get
            {
                return this.JetonAEPField;
            }
            set
            {
                this.JetonAEPField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 1)]
        public bool Actif
        {
            get
            {
                return this.ActifField;
            }
            set
            {
                this.ActifField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 2)]
        public string MotDePasse2
        {
            get
            {
                return this.MotDePasse2Field;
            }
            set
            {
                this.MotDePasse2Field = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "DemandeVueCumule", Namespace = "http://www.april.fr/APE/Services/Securite")]
    public partial class DemandeVueCumule : ServiceSecurite.Demande
    {

        private string JetonAEPField;

        private bool ActifField;

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        public string JetonAEP
        {
            get
            {
                return this.JetonAEPField;
            }
            set
            {
                this.JetonAEPField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 1)]
        public bool Actif
        {
            get
            {
                return this.ActifField;
            }
            set
            {
                this.ActifField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "DemandeSousCode", Namespace = "http://www.april.fr/APE/Services/Securite")]
    public partial class DemandeSousCode : ServiceSecurite.Demande
    {

        private string JetonAEPField;

        private string UtilisateurField;

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        public string JetonAEP
        {
            get
            {
                return this.JetonAEPField;
            }
            set
            {
                this.JetonAEPField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        public string Utilisateur
        {
            get
            {
                return this.UtilisateurField;
            }
            set
            {
                this.UtilisateurField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "DemandeInfosApporteur", Namespace = "http://www.april.fr/APE/Services/Securite")]
    public partial class DemandeInfosApporteur : ServiceSecurite.Demande
    {

        private string JetonAEPField;

        private string UtilisateurField;

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        public string JetonAEP
        {
            get
            {
                return this.JetonAEPField;
            }
            set
            {
                this.JetonAEPField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        public string Utilisateur
        {
            get
            {
                return this.UtilisateurField;
            }
            set
            {
                this.UtilisateurField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "DemandeObtenirJetonEspaceEntreprises", Namespace = "http://www.april.fr/APE/Services/Securite")]
    public partial class DemandeObtenirJetonEspaceEntreprises : ServiceSecurite.Demande
    {

        private string JetonAEPField;

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        public string JetonAEP
        {
            get
            {
                return this.JetonAEPField;
            }
            set
            {
                this.JetonAEPField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "DemandeCrypterJeton", Namespace = "http://www.april.fr/APE/Services/Securite")]
    public partial class DemandeCrypterJeton : ServiceSecurite.Demande
    {

        private int DureeValiditeField;

        private System.Collections.Generic.KeyValuePair<string, string>[] ListeParametresField;

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        public int DureeValidite
        {
            get
            {
                return this.DureeValiditeField;
            }
            set
            {
                this.DureeValiditeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        public System.Collections.Generic.KeyValuePair<string, string>[] ListeParametres
        {
            get
            {
                return this.ListeParametresField;
            }
            set
            {
                this.ListeParametresField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "DemandeDecrypterJeton", Namespace = "http://www.april.fr/APE/Services/Securite")]
    public partial class DemandeDecrypterJeton : ServiceSecurite.Demande
    {

        private string JetonField;

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        public string Jeton
        {
            get
            {
                return this.JetonField;
            }
            set
            {
                this.JetonField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "DemandeCrypterJetonRSA", Namespace = "http://www.april.fr/APE/Services/Securite")]
    public partial class DemandeCrypterJetonRSA : ServiceSecurite.Demande
    {

        private string CanalField;

        private string ValeurField;

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
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

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "DemandeDecrypterJetonRSA", Namespace = "http://www.april.fr/APE/Services/Securite")]
    public partial class DemandeDecrypterJetonRSA : ServiceSecurite.Demande
    {

        private string JetonField;

        private string CanalField;

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        public string Jeton
        {
            get
            {
                return this.JetonField;
            }
            set
            {
                this.JetonField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 1)]
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
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "DemandeCreerContexteODV", Namespace = "http://www.april.fr/APE/Services/Securite")]
    public partial class DemandeCreerContexteODV : ServiceSecurite.Demande
    {

        private string TokenTypeField;

        private string CanalField;

        private string IdentiteConnecteeField;

        private string IdentiteActiveField;

        private string IdentitePresenteeField;

        private string IdentifiantDADHField;

        private string IdentifiantEntrepriseField;

        private string IdentifiantParticipantField;

        private int IdentifiantProjetField;

        private string PortefeuilleField;

        private System.DateTime DateCreationField;

        private System.DateTime DateFinValiditeField;

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        public string TokenType
        {
            get
            {
                return this.TokenTypeField;
            }
            set
            {
                this.TokenTypeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 1)]
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

        [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
        public string IdentiteConnectee
        {
            get
            {
                return this.IdentiteConnecteeField;
            }
            set
            {
                this.IdentiteConnecteeField = value;
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
        public string IdentitePresentee
        {
            get
            {
                return this.IdentitePresenteeField;
            }
            set
            {
                this.IdentitePresenteeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 5)]
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

        [System.Runtime.Serialization.DataMemberAttribute(Order = 6)]
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

        [System.Runtime.Serialization.DataMemberAttribute(Order = 7)]
        public string IdentifiantParticipant
        {
            get
            {
                return this.IdentifiantParticipantField;
            }
            set
            {
                this.IdentifiantParticipantField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 8)]
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

        [System.Runtime.Serialization.DataMemberAttribute(Order = 9)]
        public string Portefeuille
        {
            get
            {
                return this.PortefeuilleField;
            }
            set
            {
                this.PortefeuilleField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 10)]
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

        [System.Runtime.Serialization.DataMemberAttribute(Order = 11)]
        public System.DateTime DateFinValidite
        {
            get
            {
                return this.DateFinValiditeField;
            }
            set
            {
                this.DateFinValiditeField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "DemandeObtenirContexteODV", Namespace = "http://www.april.fr/APE/Services/Securite")]
    public partial class DemandeObtenirContexteODV : ServiceSecurite.Demande
    {

        private string TokenField;

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        public string Token
        {
            get
            {
                return this.TokenField;
            }
            set
            {
                this.TokenField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "DemandeAuthentifier", Namespace = "http://www.april.fr/APE/Services/Securite")]
    public partial class DemandeAuthentifier : ServiceSecurite.Demande
    {

        private string CodeMarqueField;

        private string JetonSSOField;

        private string UtilisateurField;

        private string MotDePasseField;

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        public string CodeMarque
        {
            get
            {
                return this.CodeMarqueField;
            }
            set
            {
                this.CodeMarqueField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        public string JetonSSO
        {
            get
            {
                return this.JetonSSOField;
            }
            set
            {
                this.JetonSSOField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        public string Utilisateur
        {
            get
            {
                return this.UtilisateurField;
            }
            set
            {
                this.UtilisateurField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 3)]
        public string MotDePasse
        {
            get
            {
                return this.MotDePasseField;
            }
            set
            {
                this.MotDePasseField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Reponse", Namespace = "http://www.april.fr/APE/Services/Securite")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceSecurite.ReponseObtenirContexte))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceSecurite.ReponseContexte))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceSecurite.ReponseSousCode))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceSecurite.ReponseInfosApporteur))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceSecurite.ReponseObtenirJetonEspaceEntreprises))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceSecurite.ReponseCrypterJeton))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceSecurite.ReponseDecrypterJeton))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceSecurite.ReponseDecrypterJetonRSA))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceSecurite.ReponseCreerContexteODV))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceSecurite.ReponseAuthentifier))]
    public partial class Reponse : object
    {

        private string StatutTechniqueField;

        private string MessageTechniqueField;

        private string StatutMetierField;

        private string MessageMetierField;

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
        public string MessageMetier
        {
            get
            {
                return this.MessageMetierField;
            }
            set
            {
                this.MessageMetierField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "ReponseObtenirContexte", Namespace = "http://www.april.fr/APE/Services/Securite")]
    public partial class ReponseObtenirContexte : ServiceSecurite.Reponse
    {

        private string TokenTypeField;

        private string CanalField;

        private string IdentiteConnecteeField;

        private string IdentiteActiveField;

        private string IdentitePresenteeField;

        private string IdentifiantDADHField;

        private string IdentifiantEntrepriseField;

        private string IdentifiantParticipantField;

        private int IdentifiantProjetField;

        private string PortefeuilleField;

        private System.DateTime DateCreationField;

        private System.DateTime DateFinValiditeField;

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        public string TokenType
        {
            get
            {
                return this.TokenTypeField;
            }
            set
            {
                this.TokenTypeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 1)]
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

        [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
        public string IdentiteConnectee
        {
            get
            {
                return this.IdentiteConnecteeField;
            }
            set
            {
                this.IdentiteConnecteeField = value;
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
        public string IdentitePresentee
        {
            get
            {
                return this.IdentitePresenteeField;
            }
            set
            {
                this.IdentitePresenteeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 5)]
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

        [System.Runtime.Serialization.DataMemberAttribute(Order = 6)]
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

        [System.Runtime.Serialization.DataMemberAttribute(Order = 7)]
        public string IdentifiantParticipant
        {
            get
            {
                return this.IdentifiantParticipantField;
            }
            set
            {
                this.IdentifiantParticipantField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 8)]
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

        [System.Runtime.Serialization.DataMemberAttribute(Order = 9)]
        public string Portefeuille
        {
            get
            {
                return this.PortefeuilleField;
            }
            set
            {
                this.PortefeuilleField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 10)]
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

        [System.Runtime.Serialization.DataMemberAttribute(Order = 11)]
        public System.DateTime DateFinValidite
        {
            get
            {
                return this.DateFinValiditeField;
            }
            set
            {
                this.DateFinValiditeField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "ReponseContexte", Namespace = "http://schemas.datacontract.org/2004/07/APE.Services.Securite.Interfaces")]
    public partial class ReponseContexte : ServiceSecurite.Reponse
    {

        private ServiceSecurite.Contexte ContexteField;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public ServiceSecurite.Contexte Contexte
        {
            get
            {
                return this.ContexteField;
            }
            set
            {
                this.ContexteField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "ReponseSousCode", Namespace = "http://schemas.datacontract.org/2004/07/APE.Services.Securite.Interfaces")]
    public partial class ReponseSousCode : ServiceSecurite.Reponse
    {

        private ServiceSecurite.SousCode[] ListeSousCodeField;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public ServiceSecurite.SousCode[] ListeSousCode
        {
            get
            {
                return this.ListeSousCodeField;
            }
            set
            {
                this.ListeSousCodeField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "ReponseInfosApporteur", Namespace = "http://schemas.datacontract.org/2004/07/APE.Services.Securite.Interfaces")]
    public partial class ReponseInfosApporteur : ServiceSecurite.Reponse
    {

        private ServiceSecurite.InfoApporteur InfosApporteurField;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public ServiceSecurite.InfoApporteur InfosApporteur
        {
            get
            {
                return this.InfosApporteurField;
            }
            set
            {
                this.InfosApporteurField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "ReponseObtenirJetonEspaceEntreprises", Namespace = "http://schemas.datacontract.org/2004/07/APE.Services.Securite.Interfaces")]
    public partial class ReponseObtenirJetonEspaceEntreprises : ServiceSecurite.Reponse
    {

        private string JetonEspaceEntreprisesField;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string JetonEspaceEntreprises
        {
            get
            {
                return this.JetonEspaceEntreprisesField;
            }
            set
            {
                this.JetonEspaceEntreprisesField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "ReponseCrypterJeton", Namespace = "http://schemas.datacontract.org/2004/07/APE.Services.Securite.Interfaces")]
    public partial class ReponseCrypterJeton : ServiceSecurite.Reponse
    {

        private string JetonField;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string Jeton
        {
            get
            {
                return this.JetonField;
            }
            set
            {
                this.JetonField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "ReponseDecrypterJeton", Namespace = "http://schemas.datacontract.org/2004/07/APE.Services.Securite.Interfaces")]
    public partial class ReponseDecrypterJeton : ServiceSecurite.Reponse
    {

        private int DureeValiditeField;

        private System.Collections.Generic.KeyValuePair<string, string>[] ListeParametresField;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public int DureeValidite
        {
            get
            {
                return this.DureeValiditeField;
            }
            set
            {
                this.DureeValiditeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public System.Collections.Generic.KeyValuePair<string, string>[] ListeParametres
        {
            get
            {
                return this.ListeParametresField;
            }
            set
            {
                this.ListeParametresField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "ReponseDecrypterJetonRSA", Namespace = "http://schemas.datacontract.org/2004/07/APE.Services.Securite.Interfaces")]
    public partial class ReponseDecrypterJetonRSA : ServiceSecurite.Reponse
    {

        private string ValeurField;

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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "ReponseCreerContexteODV", Namespace = "http://schemas.datacontract.org/2004/07/APE.Services.Securite.Interfaces")]
    public partial class ReponseCreerContexteODV : ServiceSecurite.Reponse
    {

        private string TokenField;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string Token
        {
            get
            {
                return this.TokenField;
            }
            set
            {
                this.TokenField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "ReponseAuthentifier", Namespace = "http://schemas.datacontract.org/2004/07/APE.Services.Securite.Interfaces")]
    public partial class ReponseAuthentifier : ServiceSecurite.Reponse
    {

        private string JetonAEPField;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string JetonAEP
        {
            get
            {
                return this.JetonAEPField;
            }
            set
            {
                this.JetonAEPField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Contexte", Namespace = "http://schemas.datacontract.org/2004/07/APE.Services.Securite.Interfaces")]
    public partial class Contexte : object
    {

        private string JetonAEPField;

        private System.DateTime DateValiditeJetonAEPField;

        private System.DateTime DateValiditeContexteField;

        private string LoginField;

        private string TypeUtilisateurField;

        private string CodeSubstitueField;

        private string SousCodeSubstitueField;

        private bool EstEnVueCumuleeField;

        private bool MotPasse2ValideField;

        private string NiveauAutorisationField;

        private string ReseauField;

        private ServiceSecurite.Strate StrateField;

        private ServiceSecurite.Qualification QualificationField;

        private bool DroitDeVendreField;

        private string CodeMarqueField;

        private string IdentiteConnecteeField;

        private string IdentiteActiveField;

        private System.DateTime DateDeconnexionField;

        private string JetonSSOField;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string JetonAEP
        {
            get
            {
                return this.JetonAEPField;
            }
            set
            {
                this.JetonAEPField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
        public System.DateTime DateValiditeJetonAEP
        {
            get
            {
                return this.DateValiditeJetonAEPField;
            }
            set
            {
                this.DateValiditeJetonAEPField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
        public System.DateTime DateValiditeContexte
        {
            get
            {
                return this.DateValiditeContexteField;
            }
            set
            {
                this.DateValiditeContexteField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 3)]
        public string Login
        {
            get
            {
                return this.LoginField;
            }
            set
            {
                this.LoginField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 4)]
        public string TypeUtilisateur
        {
            get
            {
                return this.TypeUtilisateurField;
            }
            set
            {
                this.TypeUtilisateurField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 5)]
        public string CodeSubstitue
        {
            get
            {
                return this.CodeSubstitueField;
            }
            set
            {
                this.CodeSubstitueField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 6)]
        public string SousCodeSubstitue
        {
            get
            {
                return this.SousCodeSubstitueField;
            }
            set
            {
                this.SousCodeSubstitueField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 7)]
        public bool EstEnVueCumulee
        {
            get
            {
                return this.EstEnVueCumuleeField;
            }
            set
            {
                this.EstEnVueCumuleeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 8)]
        public bool MotPasse2Valide
        {
            get
            {
                return this.MotPasse2ValideField;
            }
            set
            {
                this.MotPasse2ValideField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 9)]
        public string NiveauAutorisation
        {
            get
            {
                return this.NiveauAutorisationField;
            }
            set
            {
                this.NiveauAutorisationField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 10)]
        public string Reseau
        {
            get
            {
                return this.ReseauField;
            }
            set
            {
                this.ReseauField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 11)]
        public ServiceSecurite.Strate Strate
        {
            get
            {
                return this.StrateField;
            }
            set
            {
                this.StrateField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 12)]
        public ServiceSecurite.Qualification Qualification
        {
            get
            {
                return this.QualificationField;
            }
            set
            {
                this.QualificationField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 13)]
        public bool DroitDeVendre
        {
            get
            {
                return this.DroitDeVendreField;
            }
            set
            {
                this.DroitDeVendreField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 14)]
        public string CodeMarque
        {
            get
            {
                return this.CodeMarqueField;
            }
            set
            {
                this.CodeMarqueField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 15)]
        public string IdentiteConnectee
        {
            get
            {
                return this.IdentiteConnecteeField;
            }
            set
            {
                this.IdentiteConnecteeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(Order = 16)]
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

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 17)]
        public System.DateTime DateDeconnexion
        {
            get
            {
                return this.DateDeconnexionField;
            }
            set
            {
                this.DateDeconnexionField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 18)]
        public string JetonSSO
        {
            get
            {
                return this.JetonSSOField;
            }
            set
            {
                this.JetonSSOField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Strate", Namespace = "http://schemas.datacontract.org/2004/07/APE.Services.Securite.Interfaces")]
    public partial class Strate : object
    {

        private string CodeField;

        private string LibelleField;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string Code
        {
            get
            {
                return this.CodeField;
            }
            set
            {
                this.CodeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string Libelle
        {
            get
            {
                return this.LibelleField;
            }
            set
            {
                this.LibelleField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Qualification", Namespace = "http://www.april.fr/APE/Services/Securite")]
    public partial class Qualification : object
    {

        private string CodeField;

        private string LibelleField;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string Code
        {
            get
            {
                return this.CodeField;
            }
            set
            {
                this.CodeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string Libelle
        {
            get
            {
                return this.LibelleField;
            }
            set
            {
                this.LibelleField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "SousCode", Namespace = "http://schemas.datacontract.org/2004/07/APE.Services.Securite.Interfaces")]
    public partial class SousCode : object
    {

        private string CodeField;

        private string LibelleField;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string Code
        {
            get
            {
                return this.CodeField;
            }
            set
            {
                this.CodeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string Libelle
        {
            get
            {
                return this.LibelleField;
            }
            set
            {
                this.LibelleField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "InfoApporteur", Namespace = "http://www.april.fr/APE/Services/Securite")]
    public partial class InfoApporteur : object
    {

        private string CodeCoField;

        private string LibelleCabinetField;

        private string MotPasse2Field;

        private string EmailField;

        private string AbonnementListeDiffusionField;

        private string NiveauAccesField;

        private string TypeField;

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
        public string LibelleCabinet
        {
            get
            {
                return this.LibelleCabinetField;
            }
            set
            {
                this.LibelleCabinetField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string MotPasse2
        {
            get
            {
                return this.MotPasse2Field;
            }
            set
            {
                this.MotPasse2Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 3)]
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

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 4)]
        public string AbonnementListeDiffusion
        {
            get
            {
                return this.AbonnementListeDiffusionField;
            }
            set
            {
                this.AbonnementListeDiffusionField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 5)]
        public string NiveauAcces
        {
            get
            {
                return this.NiveauAccesField;
            }
            set
            {
                this.NiveauAccesField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 6)]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.april.fr/APE/Services/Securite", ConfigurationName = "ServiceSecurite.ISecurite")]
    public interface ISecurite
    {

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.april.fr/APE/Services/Securite/ISecurite/Authentifier", ReplyAction = "http://www.april.fr/APE/Services/Securite/ISecurite/AuthentifierResponse")]
        System.Threading.Tasks.Task<ServiceSecurite.ReponseAuthentifier> AuthentifierAsync(ServiceSecurite.DemandeAuthentifier aobj_Demande);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.april.fr/APE/Services/Securite/ISecurite/ObtenirContexte", ReplyAction = "http://www.april.fr/APE/Services/Securite/ISecurite/ObtenirContexteResponse")]
        System.Threading.Tasks.Task<ServiceSecurite.ReponseContexte> ObtenirContexteAsync(ServiceSecurite.DemandeContexte aobj_Demande);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.april.fr/APE/Services/Securite/ISecurite/SubstituerProfil", ReplyAction = "http://www.april.fr/APE/Services/Securite/ISecurite/SubstituerProfilResponse")]
        System.Threading.Tasks.Task<ServiceSecurite.ReponseContexte> SubstituerProfilAsync(ServiceSecurite.DemandeSubstitution aobj_Demande);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.april.fr/APE/Services/Securite/ISecurite/SubstituerSousCode", ReplyAction = "http://www.april.fr/APE/Services/Securite/ISecurite/SubstituerSousCodeResponse")]
        System.Threading.Tasks.Task<ServiceSecurite.ReponseContexte> SubstituerSousCodeAsync(ServiceSecurite.DemandeSubstitution aobj_Demande);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.april.fr/APE/Services/Securite/ISecurite/ReinitialiserProfil", ReplyAction = "http://www.april.fr/APE/Services/Securite/ISecurite/ReinitialiserProfilResponse")]
        System.Threading.Tasks.Task<ServiceSecurite.ReponseContexte> ReinitialiserProfilAsync(ServiceSecurite.DemandeContexte aobj_Demande);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.april.fr/APE/Services/Securite/ISecurite/ValiderMotPasse2", ReplyAction = "http://www.april.fr/APE/Services/Securite/ISecurite/ValiderMotPasse2Response")]
        System.Threading.Tasks.Task<ServiceSecurite.ReponseContexte> ValiderMotPasse2Async(ServiceSecurite.DemandeValiderMotPasse2 aobj_Demande);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.april.fr/APE/Services/Securite/ISecurite/CumulerPortefeuille", ReplyAction = "http://www.april.fr/APE/Services/Securite/ISecurite/CumulerPortefeuilleResponse")]
        System.Threading.Tasks.Task<ServiceSecurite.ReponseContexte> CumulerPortefeuilleAsync(ServiceSecurite.DemandeVueCumule aobj_Demande);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.april.fr/APE/Services/Securite/ISecurite/ObtenirSousCode", ReplyAction = "http://www.april.fr/APE/Services/Securite/ISecurite/ObtenirSousCodeResponse")]
        System.Threading.Tasks.Task<ServiceSecurite.ReponseSousCode> ObtenirSousCodeAsync(ServiceSecurite.DemandeSousCode aobj_Demande);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.april.fr/APE/Services/Securite/ISecurite/LireInfosApporteurs", ReplyAction = "http://www.april.fr/APE/Services/Securite/ISecurite/LireInfosApporteursResponse")]
        System.Threading.Tasks.Task<ServiceSecurite.ReponseInfosApporteur> LireInfosApporteursAsync(ServiceSecurite.DemandeInfosApporteur aobj_Demande);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.april.fr/APE/Services/Securite/ISecurite/Deconnexion", ReplyAction = "http://www.april.fr/APE/Services/Securite/ISecurite/DeconnexionResponse")]
        System.Threading.Tasks.Task<ServiceSecurite.Reponse> DeconnexionAsync(ServiceSecurite.DemandeContexte aobj_Demande);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.april.fr/APE/Services/Securite/ISecurite/ObtenirJetonEspaceEntreprises" +
            "", ReplyAction = "http://www.april.fr/APE/Services/Securite/ISecurite/ObtenirJetonEspaceEntreprises" +
            "Response")]
        System.Threading.Tasks.Task<ServiceSecurite.ReponseObtenirJetonEspaceEntreprises> ObtenirJetonEspaceEntreprisesAsync(ServiceSecurite.DemandeObtenirJetonEspaceEntreprises aobj_Demande);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.april.fr/APE/Services/Securite/ISecurite/CrypterJeton", ReplyAction = "http://www.april.fr/APE/Services/Securite/ISecurite/CrypterJetonResponse")]
        System.Threading.Tasks.Task<ServiceSecurite.ReponseCrypterJeton> CrypterJetonAsync(ServiceSecurite.DemandeCrypterJeton aobj_Demande);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.april.fr/APE/Services/Securite/ISecurite/DecrypterJeton", ReplyAction = "http://www.april.fr/APE/Services/Securite/ISecurite/DecrypterJetonResponse")]
        System.Threading.Tasks.Task<ServiceSecurite.ReponseDecrypterJeton> DecrypterJetonAsync(ServiceSecurite.DemandeDecrypterJeton aobj_Demande);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.april.fr/APE/Services/Securite/ISecurite/CrypterJetonRSA", ReplyAction = "http://www.april.fr/APE/Services/Securite/ISecurite/CrypterJetonRSAResponse")]
        System.Threading.Tasks.Task<ServiceSecurite.ReponseCrypterJeton> CrypterJetonRSAAsync(ServiceSecurite.DemandeCrypterJetonRSA aobj_Demande);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.april.fr/APE/Services/Securite/ISecurite/DecrypterJetonRSA", ReplyAction = "http://www.april.fr/APE/Services/Securite/ISecurite/DecrypterJetonRSAResponse")]
        System.Threading.Tasks.Task<ServiceSecurite.ReponseDecrypterJetonRSA> DecrypterJetonRSAAsync(ServiceSecurite.DemandeDecrypterJetonRSA aobj_Demande);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.april.fr/APE/Services/Securite/ISecurite/CreerContexteODV", ReplyAction = "http://www.april.fr/APE/Services/Securite/ISecurite/CreerContexteODVResponse")]
        System.Threading.Tasks.Task<ServiceSecurite.ReponseCreerContexteODV> CreerContexteODVAsync(ServiceSecurite.DemandeCreerContexteODV aobj_Demande);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.april.fr/APE/Services/Securite/ISecurite/ObtenirContexteODV", ReplyAction = "http://www.april.fr/APE/Services/Securite/ISecurite/ObtenirContexteODVResponse")]
        System.Threading.Tasks.Task<ServiceSecurite.ReponseObtenirContexte> ObtenirContexteODVAsync(ServiceSecurite.DemandeObtenirContexteODV aobj_Demande);
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public interface ISecuriteChannel : ServiceSecurite.ISecurite, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public partial class SecuriteClient : System.ServiceModel.ClientBase<ServiceSecurite.ISecurite>, ServiceSecurite.ISecurite
    {

        /// <summary>
        /// Implémentez cette méthode partielle pour configurer le point de terminaison de service.
        /// </summary>
        /// <param name="serviceEndpoint">Point de terminaison à configurer</param>
        /// <param name="clientCredentials">Informations d'identification du client</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);

        public SecuriteClient(EndpointConfiguration endpointConfiguration) :
                base(SecuriteClient.GetBindingForEndpoint(endpointConfiguration), SecuriteClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        public SecuriteClient(EndpointConfiguration endpointConfiguration, string remoteAddress) :
                base(SecuriteClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        public SecuriteClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) :
                base(SecuriteClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        public SecuriteClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        public System.Threading.Tasks.Task<ServiceSecurite.ReponseAuthentifier> AuthentifierAsync(ServiceSecurite.DemandeAuthentifier aobj_Demande)
        {
            return base.Channel.AuthentifierAsync(aobj_Demande);
        }

        public System.Threading.Tasks.Task<ServiceSecurite.ReponseContexte> ObtenirContexteAsync(ServiceSecurite.DemandeContexte aobj_Demande)
        {
            return base.Channel.ObtenirContexteAsync(aobj_Demande);
        }

        public System.Threading.Tasks.Task<ServiceSecurite.ReponseContexte> SubstituerProfilAsync(ServiceSecurite.DemandeSubstitution aobj_Demande)
        {
            return base.Channel.SubstituerProfilAsync(aobj_Demande);
        }

        public System.Threading.Tasks.Task<ServiceSecurite.ReponseContexte> SubstituerSousCodeAsync(ServiceSecurite.DemandeSubstitution aobj_Demande)
        {
            return base.Channel.SubstituerSousCodeAsync(aobj_Demande);
        }

        public System.Threading.Tasks.Task<ServiceSecurite.ReponseContexte> ReinitialiserProfilAsync(ServiceSecurite.DemandeContexte aobj_Demande)
        {
            return base.Channel.ReinitialiserProfilAsync(aobj_Demande);
        }

        public System.Threading.Tasks.Task<ServiceSecurite.ReponseContexte> ValiderMotPasse2Async(ServiceSecurite.DemandeValiderMotPasse2 aobj_Demande)
        {
            return base.Channel.ValiderMotPasse2Async(aobj_Demande);
        }

        public System.Threading.Tasks.Task<ServiceSecurite.ReponseContexte> CumulerPortefeuilleAsync(ServiceSecurite.DemandeVueCumule aobj_Demande)
        {
            return base.Channel.CumulerPortefeuilleAsync(aobj_Demande);
        }

        public System.Threading.Tasks.Task<ServiceSecurite.ReponseSousCode> ObtenirSousCodeAsync(ServiceSecurite.DemandeSousCode aobj_Demande)
        {
            return base.Channel.ObtenirSousCodeAsync(aobj_Demande);
        }

        public System.Threading.Tasks.Task<ServiceSecurite.ReponseInfosApporteur> LireInfosApporteursAsync(ServiceSecurite.DemandeInfosApporteur aobj_Demande)
        {
            return base.Channel.LireInfosApporteursAsync(aobj_Demande);
        }

        public System.Threading.Tasks.Task<ServiceSecurite.Reponse> DeconnexionAsync(ServiceSecurite.DemandeContexte aobj_Demande)
        {
            return base.Channel.DeconnexionAsync(aobj_Demande);
        }

        public System.Threading.Tasks.Task<ServiceSecurite.ReponseObtenirJetonEspaceEntreprises> ObtenirJetonEspaceEntreprisesAsync(ServiceSecurite.DemandeObtenirJetonEspaceEntreprises aobj_Demande)
        {
            return base.Channel.ObtenirJetonEspaceEntreprisesAsync(aobj_Demande);
        }

        public System.Threading.Tasks.Task<ServiceSecurite.ReponseCrypterJeton> CrypterJetonAsync(ServiceSecurite.DemandeCrypterJeton aobj_Demande)
        {
            return base.Channel.CrypterJetonAsync(aobj_Demande);
        }

        public System.Threading.Tasks.Task<ServiceSecurite.ReponseDecrypterJeton> DecrypterJetonAsync(ServiceSecurite.DemandeDecrypterJeton aobj_Demande)
        {
            return base.Channel.DecrypterJetonAsync(aobj_Demande);
        }

        public System.Threading.Tasks.Task<ServiceSecurite.ReponseCrypterJeton> CrypterJetonRSAAsync(ServiceSecurite.DemandeCrypterJetonRSA aobj_Demande)
        {
            return base.Channel.CrypterJetonRSAAsync(aobj_Demande);
        }

        public System.Threading.Tasks.Task<ServiceSecurite.ReponseDecrypterJetonRSA> DecrypterJetonRSAAsync(ServiceSecurite.DemandeDecrypterJetonRSA aobj_Demande)
        {
            return base.Channel.DecrypterJetonRSAAsync(aobj_Demande);
        }

        public System.Threading.Tasks.Task<ServiceSecurite.ReponseCreerContexteODV> CreerContexteODVAsync(ServiceSecurite.DemandeCreerContexteODV aobj_Demande)
        {
            return base.Channel.CreerContexteODVAsync(aobj_Demande);
        }

        public System.Threading.Tasks.Task<ServiceSecurite.ReponseObtenirContexte> ObtenirContexteODVAsync(ServiceSecurite.DemandeObtenirContexteODV aobj_Demande)
        {
            return base.Channel.ObtenirContexteODVAsync(aobj_Demande);
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ISecurite))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ISecurite1))
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ISecurite))
            {
                return new System.ServiceModel.EndpointAddress("http://p00025882.april.interne.fr:41000/APE/Services/Securite/ServiceSecurite");
            }
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ISecurite1))
            {
                return new System.ServiceModel.EndpointAddress("http://p00025882.april.interne.fr:41000/APE/Services/Securite/ServiceSecurite");
            }
            throw new System.InvalidOperationException(string.Format("Le point de terminaison nommé \'{0}\' est introuvable.", endpointConfiguration));
        }

        public enum EndpointConfiguration
        {

            BasicHttpBinding_ISecurite,

            BasicHttpBinding_ISecurite1,
        }
    }
}
