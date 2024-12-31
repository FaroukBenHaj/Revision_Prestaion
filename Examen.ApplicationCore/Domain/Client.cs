using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    //On doit remplacer tjrs Internal par public 
    public class Client
    {
        public string Adresse { get; set; }
        
        public int ClientId { get; set; }
        public string  Nom { get; set; }
        public string  Prenom { get; set; }
        public  string Tel { get; set; }
        public virtual ICollection<Prestation> Prestations { get; set; }

    }
}
