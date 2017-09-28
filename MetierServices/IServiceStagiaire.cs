using Exo9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MetierServices
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IServiceStagiaire" à la fois dans le code et le fichier de configuration.

        [ServiceContract]
        public interface IServiceStagiaire
        {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            [OperationContract]
        [WebGet(UriTemplate = "section/{codeSection}")]

        string GetData(int value);


            [OperationContract]
        [WebGet(UriTemplate = "stagiaires/{codeSection}")]

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
        [WebInvoke(Method = "POST", UriTemplate = "stagiaires/", RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        string AddStagiaire(MStagiaire newStagiaire, MSection laSection);


            /// <summary>
            /// Update un stagiaire
            /// </summary>
            /// <param name="leStagiaire"></param>
            /// <returns>Retourne une string vide en cas de succès ou une string contenant le message         d'erreur en cas d'échec</returns>
            [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "stagiaires/")]

        string UpdateStagiaire(MStagiaire leStagiaire);

            /// <summary>
            /// 
            /// </summary>
            /// <param name="laClefStagiaire"></param>
            /// <returns>return true si le stagiaire est bien supprimé</returns>
            [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "stagiaires/{laClefStagiaire}")]
        bool DeleteStagiaire(string laClefStagiaire);




            // TODO: ajoutez vos opérations de service ici
        }


    







    
}
