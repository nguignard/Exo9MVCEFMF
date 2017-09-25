using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;



namespace Exo9
{
    /// <summary>
    /// controleur du cas d'utilisation visualiser/modifier un stagiaire
    /// </summary>
    public class CtrlVisuModifStagiaire
    {

        /// <summary>
        /// ref au form frmVisuStagiaire
        /// </summary>
        private frmVisuStagiaire leForm;

        /// <summary>
        /// ref au stagiaire saisi par ce form
        /// </summary>
        private MStagiaire leStagiaire;


        /// <summary>
        /// constructeur : instancie et personnalise le form et l'affiche en modal;
        /// </summary>
        public CtrlVisuModifStagiaire(MStagiaire unStagiaire)
        {
            // m�mo ref au stagiaire � modifier
            this.leStagiaire = unStagiaire;
            // instancier le form initial
            this.leForm = new frmVisuStagiaire(this.leStagiaire);
            this.leForm.Text = this.leStagiaire.ToString();
            // impl�menter l'�v�nement bouton Saisir Note
            this.leForm.btnSaisirNote.Click += new EventHandler(btnSaisirNote_Click);
            // impl�menter l'�v�nement bouton Valider
            this.leForm.btnValider.Click += new EventHandler(btnValider_Click);
            // afficher le form
            this.leForm.ShowDialog();
        }

        /// <summary>
        /// appelle le service de mise � jour par le form de l'objet stagiaire actuellement affich�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void btnValider_Click(object sender, EventArgs e)
        {
            this.leForm.Valider();
        }

        /// <summary>
        /// instancier un form de saisie de note 
        /// et mettre � jour le stagiaqire si validation de la saisie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaisirNote_Click(object sender, EventArgs e)
        {
            // form secondaire de saisie de note
            // (appel� par ce m�me contr�leur car ce form de saisie de note 
            // fait toujours partie de ce m�me dialogue de misu/modif de stagiaire
            // donc du m�me cas d'utilisation
            frmSaisieNote leFormNote = new frmSaisieNote(this.leStagiaire);
            if (leFormNote.ShowDialog() == DialogResult.OK)
            {
                // appel m�thode prise en compte note
                this.leStagiaire.RecevoirNote(leFormNote.LaNote);
                // rafra�chit le form
                this.leForm.AfficheMoyenne(this.leStagiaire);
            }
        }



    }
}

