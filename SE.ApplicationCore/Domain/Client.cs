using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE.ApplicationCore.Domain
{
    public class Client
    {
        public int ClientId { get; set; }
       public Coordonnees Coordonnees { get; set; }
        //public string Nom { get; set; }
        //public string Prenom { get; set; }
        //public string Tel { get; set; }
        //public string Adresse { get; set; }
        public virtual ICollection<Prestation> Prestations { get; set; }
    }
}
