using SE.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE.ApplicationCore.Interfaces
{
    public interface IPrestationService : IService<Prestation>
    {
        public double TarifMoyen(int code);
        public IEnumerable<IGrouping<Intitule, Prestation>> GroupedBySpeciality(Client c);
    }
}
