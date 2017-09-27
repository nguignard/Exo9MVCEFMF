using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Exo9
{
    /// <summary>
    /// classe accès aux données - BDD : Formations, table : StagiairesSet
    /// </summary>
    public static class MStagiaireDAOEFStatic
    {
        
        /// <summary>
        /// instancie les objets MStagiaires spécialisés correspondants aux Entities du dbSet
        /// </summary>
        /// <param name="laSection">la ref de la section qui gère la collection de ces stagiaires</param>
        public static void InstancieStagiairesSection(MSection laSection)
        {
            // Récupération des stagiaires d'une section en appelant la bonne méthode du service
            // web
            // par le client du service dans DonneesDAO
            // Nous récupérons des objets MStagiaire du service soit des
            // FormationService.MStagiaire
            foreach (FormationService.MStagiaire item in
            DonneesDAO.Client.GetStagiairesSection(laSection.CodeSection))
            {
                // ref d'objet générique (pour la collection)
                MStagiaire leStagiaire;
                // instancie et renseigne par mappage l'objet MStagiaire spécialisé
                if (item is FormationService.MStagiaireCIF)
                {
                    // cas d'un CIF : objet MStagiaireCIF
                    leStagiaire = new MStagiaireCIF(item.NumOsia,
                    item.Nom.Trim(),
                    item.Prenom.Trim(),
                    item.Rue,
                    item.Ville.Trim(),
                    item.CodePostal,
                    ((FormationService.MStagiaireCIF)item).Fongecif,
                    ((FormationService.MStagiaireCIF)item).TypeCif.Trim()
                    );
                }
                else
                {
                    // cas d'un DE : objet MStagiaireDE
                    leStagiaire = new MStagiaireDE(item.NumOsia,
                    item.Nom.Trim(),
                    item.Prenom.Trim(),
                    item.Rue,
                    item.Ville.Trim(),
                    item.CodePostal.Trim(),
                    ((FormationService.MStagiaireDE)item).RemuAfpa
                    );
                }
                // affecter points et notes
                // on ne peut affecter directement Pointsnotes et NbreNotes
                // dans MStagiaire que si le demandeur est de ce type MStagiaireDAOEFStatic
                leStagiaire.SetPoints(Convert.ToDouble(item.PointsNotes), (int)item.NbreNotes,
                typeof(MStagiaireDAOEFStatic).ToString());
                // ajoute le Stagiaire à la collection de la section
                laSection.Ajouter(leStagiaire);
            }
        }

        /// <summary>
        /// insère un stagiaire dans la table Stagiaires de la BDD
        /// </summary>
        /// <param name="unStagiaire">objet MStagiaire correspondant</param>
        /// <param name="unCodeSection">identifiant de sa section</param>
        public static void InsereStagiaire(MStagiaire unStagiaire, MSection uneSection)
        {
            // Un objet MStagiaire du service
            FormationService.MStagiaire unServiceStagiaire = null;
            // recupérer la Section ServiceStagiaires.MSection
            FormationService.MSection laSection =
            DonneesDAO.Client.GetSection(uneSection.CodeSection);
            // instancie ServiceStagiaires.MStagiaire et le renseigne à partir du MStagiaire reçu
            if (unStagiaire is MStagiaireCIF)
            {
                unServiceStagiaire = new FormationService.MStagiaireCIF();
                unServiceStagiaire.NumOsia = unStagiaire.NumOsia;
                unServiceStagiaire.Nom = unStagiaire.Nom;
                unServiceStagiaire.Prenom = unStagiaire.Prenom;
                unServiceStagiaire.Rue = unStagiaire.Rue;
                unServiceStagiaire.Ville = unStagiaire.Ville;
                unServiceStagiaire.CodePostal = unStagiaire.CodePostal;
                unServiceStagiaire.NbreNotes = unStagiaire.NbreNotes;
                unServiceStagiaire.PointsNotes = unStagiaire.PointsNotes;
                ((FormationService.MStagiaireCIF)unServiceStagiaire).Fongecif =
                ((MStagiaireCIF)unStagiaire).Fongecif;
                ((FormationService.MStagiaireCIF)unServiceStagiaire).TypeCif =
                ((MStagiaireCIF)unStagiaire).TypeCif;
            }
            else
            {
                // cas d'un DE
                unServiceStagiaire = new FormationService.MStagiaireDE();
                unServiceStagiaire.NumOsia = unStagiaire.NumOsia;
                unServiceStagiaire.Nom = unStagiaire.Nom;
                unServiceStagiaire.Prenom = unStagiaire.Prenom;
                unServiceStagiaire.Rue = unStagiaire.Rue;
                unServiceStagiaire.Ville = unStagiaire.Ville;
                unServiceStagiaire.CodePostal = unStagiaire.CodePostal;
                unServiceStagiaire.NbreNotes = unStagiaire.NbreNotes;
                unServiceStagiaire.PointsNotes = unStagiaire.PointsNotes;
                ((FormationService.MStagiaireDE)unServiceStagiaire).RemuAfpa =
                ((MStagiaireDE)unStagiaire).RemuAfpa;
            }
            string retour = DonneesDAO.Client.AddStagiaire(unServiceStagiaire, laSection);
            if (retour != "")
            {
                throw new Exception(retour);
            }
        }

        /// <summary>
        /// modifie un stagiaire en BDD
        /// </summary>
        /// <param name="unStagiaire">la ref à l'objet Mstagiaire qui a subi des modifications</param>
        public static void ModifieStagiaire(MStagiaire unStagiaire)
        {
            // un FormationService.MStagiaire (objet MStagiaire du service)
            FormationService.MStagiaire unServiceStagiaire = null;
            // instancie un ServiceStagiaires.Mstagiaire et le renseigne à partir du MStagiaire
            // reçu
            if (unStagiaire is MStagiaireCIF)
            {
                unServiceStagiaire = new FormationService.MStagiaireCIF();
                unServiceStagiaire.NumOsia = unStagiaire.NumOsia;
                unServiceStagiaire.Nom = unStagiaire.Nom;
                unServiceStagiaire.Prenom = unStagiaire.Prenom;
                unServiceStagiaire.Rue = unStagiaire.Rue;
                unServiceStagiaire.Ville = unStagiaire.Ville;
                unServiceStagiaire.CodePostal = unStagiaire.CodePostal;
                unServiceStagiaire.NbreNotes = unStagiaire.NbreNotes;
                unServiceStagiaire.PointsNotes = unStagiaire.PointsNotes;
                ((FormationService.MStagiaireCIF)unServiceStagiaire).Fongecif =
                ((MStagiaireCIF)unStagiaire).Fongecif;
                ((FormationService.MStagiaireCIF)unServiceStagiaire).TypeCif =
                ((MStagiaireCIF)unStagiaire).TypeCif;
            }
            else
            {
                // cas d'un DE
                unServiceStagiaire = new FormationService.MStagiaireDE();
                unServiceStagiaire.NumOsia = unStagiaire.NumOsia;
                unServiceStagiaire.Nom = unStagiaire.Nom;
                unServiceStagiaire.Prenom = unStagiaire.Prenom;
                unServiceStagiaire.Rue = unStagiaire.Rue;
                unServiceStagiaire.Ville = unStagiaire.Ville;
                unServiceStagiaire.CodePostal = unStagiaire.CodePostal;
                unServiceStagiaire.NbreNotes = unStagiaire.NbreNotes;
                unServiceStagiaire.PointsNotes = unStagiaire.PointsNotes;
                ((FormationService.MStagiaireDE)unServiceStagiaire).RemuAfpa =
                ((MStagiaireDE)unStagiaire).RemuAfpa;
            }
            string retour = DonneesDAO.Client.UpdateStagiaire(unServiceStagiaire);
            if (retour != "")
            {
                throw new Exception(retour);
            }
        }

        /// <summary>
        /// supprime un stagiaire de la table Stagiaires de la BDD
        /// </summary>
        /// <param name="uneCleStagiaire">NumOSIA du stagiaire à supprimer</param>
        public static void SupprimeStagiaire(Int32 uneCleStagiaire)
        {
            // supprime le stagiaire via le service
            DonneesDAO.Client.DeleteStagiaire(uneCleStagiaire);
        }

        public static MStagiaire RestitueStagiaire()
        {
            return null; //TODO
        }
        
    }


}
