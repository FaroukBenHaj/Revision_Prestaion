using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE.ApplicationCore.Domain
{
    public enum Intitule { Bricolage, Jardinage, Menage, }
    
    public class Specialite
    {
        [Key]
        public int Code { get; set; }

        public Intitule Intitule { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        
        public virtual ICollection<Prestataire> Prestataires { get; set; }
    }
}
