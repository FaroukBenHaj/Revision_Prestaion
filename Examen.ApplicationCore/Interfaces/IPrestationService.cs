using AM.ApplicationCore.Interfaces;
using Examen.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Interfaces
{
    public  interface IPrestationService:IService<Prestation>
    {
        /** IGrouping<out TKey, out TElement> : IEnumerable<TElement>, IEnumerable
         * 
         *TKey est le type de la clé utilisée pour regrouper les elements  
         *TElement est le type des elements regroupé 
        */
        public IEnumerable<IGrouping<Intitule , Prestation>> GetPrestations(Client c);
    }
}
