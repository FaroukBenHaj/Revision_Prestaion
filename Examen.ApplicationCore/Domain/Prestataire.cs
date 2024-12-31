using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Prestataire
    {
        /*
         * La propriété Appreciation, de la classe Prestataire, pour qu’elle soit un entier
         * compris entre 0 et 5 avec un message d’erreur lors de violation. 
         */

        [Range(0,5,ErrorMessage = "Entier compris entre 0 et 5 ! ")]
        public int Appreciation { get; set; }
        public int PrestataireId { get; set; }
        /*
         * la propriété NomPrestataire, de la classe Prestataire, pour qu’elle soit une
         * chaîne de caractères de longueur maximale 20.
         */
        [MaxLength(20)]
        public string PrestataireNom { get; set; }
        public string PrestatairePhoto { get; set; }
        public string PrestataireTel { get; set; }
        /*
         *  la propriété TarifHoraire, de la classe Prestataire, pour qu’elle soit une
         *  valeur monétaire. 
         */
        [DataType(DataType.Currency)]   
        public double  TarifHoraire { get; set; }
        /*
         * La configuration du clé etrangère 
         * On doit avoir le meme nom de la prop de navigation 
         * |-> Dans notre cas il est MySpecialite
         */
        [ForeignKey("MySpecialite")]
        public int SpecialiteFK { get; set; }

        /*
         * //Une Relation ManyToOne avec Lazy Loading (Virtual)
         * 
         * 2 eme methode pour la configuration du clé etrangère 
         * |->[ForeignKey("SpecialiteFK")]
         * |->public virtual Specialite MySpecialite  { get; set; }
         * 
         */
        public virtual Specialite MySpecialite  { get; set; }
        public virtual ICollection<Prestation> Prestations { get; set; }


    }
}
