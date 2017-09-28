using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Exo9;

namespace MetierServices
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class ServiceStagiaire : IServiceStagiaire
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }




        public MSection GetSection(string codeSection)
        {
            return MSectionDAOEFStatic.RestitueSection(codeSection);
        }


        /// <summary> 
        /// /// Permet de récupérer une liste de stagiaire d'une section donnée 
        /// /// </summary> 
        /// /// <param name="codeSection">le code de la section</param> 
        /// /// <returns>Collection IList de MStagiaire</returns> 
        public IList<MStagiaire> GetStagiairesSection(string codeSection)
        {
            MSection laSection = MSectionDAOEFStatic.RestitueSection(codeSection);
            // chargement et instanciation des données Stagiaires de cette section depuis la BDD
            MStagiaireDAOEFStatic.InstancieStagiairesSection(laSection);
            return laSection.StagiairesToList();
        }



        /// <summary> 
        /// /// Permet d'insérer un stagiaire 
        /// /// </summary> 
        /// /// <param name="newStagiaire">la ref au stagiaire à insérer</param> 
        /// /// <param name="laSection">la ref à la section concernée</param> 
        /// /// <returns>Retourne une string vide en cas de succès ou une string contenant le message d'erreur en cas d'échec</returns> 
        public string AddStagiaire(MStagiaire newStagiaire, MSection newSection)
        {
            string retour = "";

            try
            {
                MStagiaireDAOEFStatic.InsereStagiaire(newStagiaire, newSection);
            }
            catch (Exception ex)
            {
                retour = "Erreur d'insertion du stagiaire : " + ex.Message;
            }
            return retour;
        }


        /// <summary> 
        /// /// Permet de modifier un stagiaire 
        /// /// </summary> /// 
        /// <param name="leStagiaire">le ref du stagiaire à modifier</param> 
        /// /// <returns>Retourne une string vide en cas de succès ou une string contenant le message d'erreur en cas d'échec</returns> 

        public string UpdateStagiaire(MStagiaire leStagiaire)
        {
            string retour = "";

            try
            {
                MStagiaireDAOEFStatic.ModifieStagiaire(leStagiaire);
            }
            catch (Exception ex)
            {
                retour = "Erreur d'insertion du stagiaire : " + ex.Message;
            }

            return retour;
        }

        public bool DeleteStagiaire(string laClefStagiaire)
        {
            try
            {
                MStagiaireDAOEFStatic.SupprimeStagiaire(Int32.Parse(laClefStagiaire));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }







    }
}
