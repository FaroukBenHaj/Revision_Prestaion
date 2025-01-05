using SE.ApplicationCore.Domain;
using SE.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SE.ApplicationCore.Services
{
    public class PrestationService : Service<Prestation>, IPrestationService
    {
        public PrestationService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        
        public double TarifMoyen(int code)
        {
            return GetMany(s=>s.Prestataire.Specialite.Code == code).Select(s => s.Prestataire.TarifHoraire).Average();
        }
        public IEnumerable<IGrouping<Intitule, Prestation>> GroupedBySpeciality(Client c)
        {
            return GetAll().Where(p => p.Client == c).GroupBy(p => p.Prestataire.Specialite.Intitule);

        }
        
    }
}
