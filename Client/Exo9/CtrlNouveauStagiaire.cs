using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms; // ajout� manuellement


namespace Exo9
{
    /// <summary>
    /// controleur du cas d'utilisation : ajout de stagiaire � une section
    /// </summary>
    public class CtrlNouveauStagiaire
    {
        /// <summary>
        /// ref au form frmAjoutStagiaire
        /// </summary>
        private frmAjoutStagiaire leForm;

        /// <summary>
        /// ref au stagiaire saisi par ce form
        /// </summary>
        private MStagiaire leStagiaire;
        
        /// <summary>
        /// obtient la ref au stagiaire saisi par le form frmAjoutStagiaire
        /// </summary>
        public MStagiaire LeStagiaire
        {

            get
            {
                return this.leStagiaire;
            }
        }

        /// <summary>
        /// ref � la section du stagiaire trait�
        /// </summary>
        private MSection laSection;

        /// <summary>
        /// r�sultat du dialogue modal assur� par le form frmAjoutStagiaire
        /// </summary>
        private DialogResult resultat;

        /// <summary>
        /// obtient le r�sultat du dialogue modal assur� par le form frmAjoutStagiaire
        /// </summary>
        public DialogResult Resultat
        {
            get
            {
                return this.resultat;
            }
        }

        /// <summary>
        /// constructeur : instancie et personnalise le form et l'affiche en modal;
        /// r�cup�re ensuite le r�sultat du dialogue et la ref du stagiaire instanci�
        /// </summary>
        /// <param name="uneSection">la section du stagiaire � cr�er</param>
        public CtrlNouveauStagiaire(MSection uneSection)
        {
            this.laSection = uneSection;
            // instancier le form initial
            this.leForm = new frmAjoutStagiaire(this.laSection);
            this.leForm.Text += this.laSection.ToString();
            // variante avec plus de contr�le du from par le Contr�leur
            this.leForm.btnOK.Click += new EventHandler(this.btnOK_Click);
            // afficher le form
            this.leForm.ShowDialog();
            // en fin de dialogue modal r�cup�rer la ref du stagiaire sp�cialis� instanci� par le form
            this.leStagiaire = this.leForm.LeStagiaire;
        }

        /// <summary>
        /// bouton OK du form : demande au form de se contr�ler puis
        /// d'instancier un objet MStagiaire sp�cialis� 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            // controle vraissemblance des donn�es saisies sur le form
            if (this.leForm.Controle())
            {

                //  instancie l'objet MStagiaire sp�cialis�   
                if (this.leForm.Instancie())
                {
                    this.leForm.DialogResult = DialogResult.OK; // fermer le form si OK
                    // en fin de dialogue modal r�cup�rer le r�sultat de la saisie
                    this.resultat = this.leForm.DialogResult;
                }
                else // erreur d'instanciation objet stagiaire
                {
                    this.resultat = DialogResult.No; // erreur � remonter
                }
            }
        }


    }
}
