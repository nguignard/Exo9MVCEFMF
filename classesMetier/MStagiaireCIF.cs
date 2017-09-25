using System;
using System.Collections.Generic;
using System.Text;

namespace Exo9
{
    /// <summary>
    /// stagiaire sp�cialis� statut CIF
    /// </summary>
    public class MStagiaireCIF : MStagiaire
    {
        /// <summary>
        /// constructeur par d�faut ==> proscrit...
        /// (appelle le constructeur classe de base)
        /// </summary>
        //public MStagiaireCIF(): base()
        //{
        //    this.Fongecif = "";
        //    this.TypeCif = "";
        //}

        /// <summary>
        /// constructeur d'initialisation
        /// (appelle le constructeur d'initialisation de la classe de base)
        /// </summary>
        /// <param name="unNumosia">num�ro OSIA</param>
        /// <param name="unNom">Nom</param>
        /// <param name="unPrenom">Pr�nom</param>
        /// <param name="uneRue">Adresse'</param>
        /// <param name="uneVille">Ville</param>
        /// <param name="UnCodePostal">Code Postal</param>
        /// <param name="unFongecif">Nom fongecif</param>
        /// <param name="unTypeCIF">type de CIF</param>
        public MStagiaireCIF(Int32 unNumosia, String unNom, String unPrenom, String uneRue, String uneVille, String UnCodePostal,
            String unFongecif, String unTypeCIF)
            : base(unNumosia,  unNom,  unPrenom,  uneRue,  uneVille,  UnCodePostal)
        {
            this.Fongecif = unFongecif;
            this.TypeCif = unTypeCIF;
        }
        /// <summary>
        /// nom Fongecif
        /// </summary>
        private String fongecif;

        /// <summary>
        /// obtient ou d�finit nom Fongecif
        /// </summary>
        public String Fongecif
        {
            get
            {
                return this.fongecif;
            }
            set
            {
                this.fongecif = value;
            }
        }

        /// <summary>
        /// type CIF (CDD, CDI, TT)
        /// </summary>
        private String typeCif;

        /// <summary>
        /// obtient ou d�finit type CIF (CDD, CDI, TT)
        /// </summary>
        public String TypeCif
        {
            get
            {
                return this.typeCif;
            }
            set
            {
                if (value == "CDI" || value == "CDD" || value == "TT")
                {
                    this.typeCif = value;
                }
                else
                {
                    throw new Exception("Erreur de type CIF");
                }
            }
        }
    }
}
