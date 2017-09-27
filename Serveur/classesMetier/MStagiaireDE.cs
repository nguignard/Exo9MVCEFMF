using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace Exo9
{
    /// <summary>
    /// stagiaire sp�cialis� statut Demandeur d'emploi
    /// </summary>
    [DataContract]
    public class MStagiaireDE : MStagiaire
    {
        /// <summary>
        /// constructeur par d�faut  ==> proscrit...
        /// (appelle le constructeur classe de base)
        /// </summary>
        //public MStagiaireDE()
        //    : base()
        //{
        //    this.RemuAfpa = false;
        //}


        /// <summary>
        /// constructeur d'initialisation
        /// (appelle le constructeur d'initialisation de la classe de base)
        /// </summary>
        /// <param name="unNumosia">num�ro OSIA</param>
        /// <param name="unNom">Nom</param>
        /// <param name="unPrenom">Pr�nom</param>
        /// <param name="uneRue">Adresse</param>
        /// <param name="uneVille">Ville</param>
        /// <param name="UnCodePostal">Code Postal</param>
        /// <param name="unRemuAfpa">R�munaration par l'Afpa</param>
        public MStagiaireDE(Int32 unNumosia, String unNom, String unPrenom, String uneRue, String uneVille, String UnCodePostal,
            Boolean unRemuAfpa)
            : base( unNumosia,  unNom,  unPrenom,  uneRue,  uneVille,  UnCodePostal)
        {
            this.RemuAfpa = unRemuAfpa;
        }

        /// <summary>
        /// R�muneration par l'Afpa
        /// </summary>
        private Boolean remuAfpa;

        /// <summary>
        /// obtient ou d�finit R�muneration par l'Afpa
        /// </summary>
        [DataMember]
        public Boolean RemuAfpa
        {
            get
            {
                return this.remuAfpa;
            }
            set
            {
                this.remuAfpa = value;
            }
        }

    }
}
