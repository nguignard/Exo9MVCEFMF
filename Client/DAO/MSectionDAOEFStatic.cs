using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo9
{
    public static class MSectionDAOEFStatic
    {

        public static MSection RestitueSection(String unCodeSection)
        {
            // La section MSection à retourner
            MSection laSection;
            // Récupération d'un objet FormationService.MSection
            // en appelant la bonne méthode du service web
            // par le client du service dans DonneesDAO
            FormationService.MSection leStage = DonneesDAO.Client.GetSection(unCodeSection);
            // Mappage avec un objet MSection en utilisant sont constructeur
            laSection = new MSection(leStage.CodeSection, leStage.NomSection,
            leStage.DebutFormation, leStage.FinFormation);
            // Retourne un objet MSection
            return laSection;
        }
    }
}
