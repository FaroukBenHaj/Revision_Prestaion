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
    /**
     * Partie 2: 
     * Question 1 
     */
    public class PrestataireService : Service<Prestataire>, IPrestataireService
    {
        public PrestataireService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        /*
         * 1. retourner les 2 meilleurs prestataires de service bricolage.

         */
        public IList<Prestataire> GetPrestataires()
        {

            return GetAll().
                Where(p=> p.MySpecialite.Intitule == Intitule.Bricolage)
                .OrderByDescending(p=>p.Appreciation). //Trier par leur appreciations Order croissant 
                Take(2).
                ToList();
        }
        /*
         *  2. retourner la moyenne de tarif horaire d’une spécialité dont le code est passé en 
         *  paramètre
         * */
        public double TarifMoyen(int code)
        {
            return GetMany(s => s.MySpecialite.Code == code).Select(s => s.TarifHoraire).Average();
        }
    }
}
