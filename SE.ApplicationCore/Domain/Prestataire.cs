using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE.ApplicationCore.Domain
{
    public class Prestataire
    {
        public int PrestataireId { get; set; }
        [MaxLength(20)]
        public string PrestataireNom { get; set; }
        public string PrestatairePhoto { get; set; }
        public string PrestataireTel { get; set; }

        [Range(0,5, ErrorMessage ="entre 0 et 5!")]
        public int Appreciation { get; set; }

        [DataType(DataType.Currency)]
        public double TarifHoraire { get; set; }
        [ForeignKey("Specialite")]
        public int SpecialiteFK { get; set; }
        public virtual Specialite Specialite { get; set; }
        public virtual ICollection<Prestation> Prestations { get; set; }
    }
}
