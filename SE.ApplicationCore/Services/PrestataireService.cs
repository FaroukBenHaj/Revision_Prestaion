using SE.ApplicationCore.Domain;
using SE.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE.ApplicationCore.Services
{
    public class PrestataireService : Service<Prestataire>, IPrestataireService
    {
        public PrestataireService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
        public double Gain()
        {
            double tarifMoinsCher = GetAll().OrderBy(p => p.TarifHoraire).First().TarifHoraire;
            var query = GetAll().OrderBy(p => p.TarifHoraire).First().Prestations;
            double nbre = 0;
            foreach (var item in query)
            {
                if (item.HeureDebut.Year == DateTime.Now.Year)
                {
                    nbre = nbre + item.NbrHeures;
                }

            }
            return nbre * tarifMoinsCher;
        }
        
        public IEnumerable<Prestataire> Top3Prestataires()
        {
            return GetAll().
            Where(p => p.Specialite.Intitule == Intitule.Bricolage).
            OrderBy(p => p.Appreciation).
            Take(3);
        }
    }
}