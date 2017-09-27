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
            MSection laSection;
            FormationService.MSection leStage = DonneesDAO.Client.GetSection(unCodeSection);
            laSection = new MSection(leStage.CodeSection, leStage.NomSection, leStage.DebutFormation, leStage.FinFormation);
            return laSection;
        }
    }
}
