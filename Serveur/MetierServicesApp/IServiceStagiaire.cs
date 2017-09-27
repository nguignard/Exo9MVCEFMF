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
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IServiceStagiaire" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IServiceStagiaire
    {

        //[OperationContract]
        //string GetData(int value);

        //[OperationContract]
        //CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: ajoutez vos opérations de service ici


        /// <summary>
        /// Permet de récupérer une section
        /// </summary>
        /// <param name="codeSection">le code de la section</param>
        /// <returns>MSection</returns>
        [OperationContract]
        MSection GetSection(string codeSection);
        /// <summary>
        /// Permet de récupérer une liste de stagiaire d'une section donnée
        /// </summary>
        /// <param name="codeSection"> le code de la section</param>
        /// <returns>IList de MStagiaire</returns>
        [OperationContract]
        IList<MStagiaire> GetStagiairesSection(string codeSection);
        /// <summary>
        /// Permet d'insérer un stagiaire
        /// </summary>
        /// <param name="newStagiaire">la ref au stagiqire à insérer</param>
        /// <param name="laSection">le ref à la section concernée</param>
        /// <returns>Retourne une string vide en cas de succès ou une string contenant le message
        /// d'erreur en cas d'échec</returns>
        [OperationContract]
        string AddStagiaire(MStagiaire newStagiaire, MSection laSection);
        /// <summary>
        /// Permet de modifier un stagiaire
        /// </summary>
        /// <param name="leStagiaire">la ref au stagiqire à modifier</param>
        /// <returns>Retourne une string vide en cas de succès ou une string contenant le message
        /// d'erreur en cas d'échec</returns>
        [OperationContract]
        string UpdateStagiaire(MStagiaire leStagiaire);
        /// Permet de supprimer un stagiaire
        /// </summary>
        /// <param name="laCleStagiaire">le numosia du stagiaire à supprimer</param>
        /// <returns> retourne true si le stagiaire est bien supprimé, false si ce n'est pas le
        /// cas</returns>
        [OperationContract]
    bool DeleteStagiaire(Int32 laCleStagiaire);
    }
}
