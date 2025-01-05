using SE.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE.ApplicationCore.Interfaces
{
    public interface IPrestataireService:IService<Prestataire>
    {
        public double Gain();
        public IEnumerable<Prestataire> Top3Prestataires();
    }
}
