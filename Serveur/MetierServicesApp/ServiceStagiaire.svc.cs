using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Exo9;

namespace MetierServicesApp
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "ServiceStagiaire" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez ServiceStagiaire.svc ou ServiceStagiaire.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class ServiceStagiaire : IServiceStagiaire
    {
        //public string GetData(int value)
        //{
        //    return string.Format("You entered: {0}", value);
        //}
        public string AddStagiaire(MStagiaire newStagiaire, MSection laSection)
        {
            string retour = "";
            try
            {
                MStagiaireDAOEFStatic.InsereStagiaire(newStagiaire, laSection);
            }
            catch (Exception ex)
            {
                retour = "Erreur d'insertion du stagiaire : " + ex.Message;
            }
            return retour;
        }

            public bool DeleteStagiaire(int laCleStagiaire)
        {
            try
            {
                MStagiaireDAOEFStatic.SupprimeStagiaire(laCleStagiaire);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public MSection GetSection(string codeSection)
        {
            return MSectionDAOEFStatic.RestitueSection(codeSection);
        }

        public IList<MStagiaire> GetStagiairesSection(string codeSection)
        {
            MSection laSection = MSectionDAOEFStatic.RestitueSection(codeSection);
            // chargement et instanciation des données Stagiaires de cette section depuis la BDD
            MStagiaireDAOEFStatic.InstancieStagiairesSection(laSection);
            return laSection.StagiairesToList();
        }

        public string UpdateStagiaire(MStagiaire leStagiaire)
        {
            string retour = "";
            try
            {
                MStagiaireDAOEFStatic.ModifieStagiaire(leStagiaire);
            }
            catch (Exception ex)
            {
                retour = "Erreur de modification du stagiaire : " + ex.Message;
            }
            return retour;
        }
    }
}
