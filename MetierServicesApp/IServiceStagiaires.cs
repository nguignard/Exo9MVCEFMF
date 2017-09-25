using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Exo9;

//using classesMetier;

namespace MetierServicesApp
{
     [ServiceContract]
    public interface IServiceStagiaires
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        MSection GetSection(string codeCollection);

        [OperationContract]
        IList<MStagiaire> GetStagiairesSection(string codeSection);

        /// <summary>
        /// 
        /// </summary>
        /// <param name=""></param>
        /// <param name=""></param>
        /// <returns>Retourne une string vide en cas de succès ou une string contenant le message d'erreur en cas d'échec</returns>
        [OperationContract]
                string AddStagiaire(MStagiaire newStagiaire, MSection laSection);


        /// <summary>
        /// Update un stagiaire
        /// </summary>
        /// <param name="leStagiaire"></param>
        /// <returns>Retourne une string vide en cas de succès ou une string contenant le message         d'erreur en cas d'échec</returns>
        [OperationContract]
        string UpdateStagiaire(MStagiaire leStagiaire);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="laClefStagiaire"></param>
        /// <returns>return true si le stagiaire est bien supprimé</returns>
        [OperationContract]
        bool DeleteStagiaire(Int32 laClefStagiaire);




        // TODO: ajoutez vos opérations de service ici
    }


    // Utilisez un contrat de données comme indiqué dans l'exemple ci-après pour ajouter les types composites aux opérations de service.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
