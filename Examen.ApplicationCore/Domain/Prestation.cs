using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Prestation
    {
        public DateTime HeureDebut { get; set; }
        public int  NbrHeure { get; set; }

        public virtual int  ClientFK { get; set; }

        public virtual int PrestataireFK { get; set; }

        public virtual  Client MyClient { get; set; }
        public virtual  Prestataire MyPrestataire { get; set; }
  
    }
}
