using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Services;
using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Services
{
    public class PrestationService : Service<Prestation>, IPrestationService
    {
        public PrestationService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IEnumerable<IGrouping<Intitule, Prestation>> GetPrestations(Client c)
        {
            return GetAll().
                Where(p => p.MyClient == c).
                GroupBy(p => p.MyPrestataire.MySpecialite.Intitule);
        }
    }
}
