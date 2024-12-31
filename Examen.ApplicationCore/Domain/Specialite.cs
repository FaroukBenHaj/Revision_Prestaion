using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public enum Intitule { Bricolage, Jardinage, Menage }

    public class Specialite
    {
        /*
         * Configuration d'un clé primaire
         * |-> Les classes qui ne sont pas des clé primaires par defauts
         * NomDeLaClasseId / Id  ==> Un clé primaire par defauts 
         * Alors que IdNom n'est pas un clé primaire par defaut 
         * |-> Dans ce cas on met l'annotation [ Key ]
         * 
         */
        [Key] 
        public int Code { get; set; }
        public string  Description { get; set; }
        public Intitule Intitule { get; set; }

        //Une Relation ManyToOne 
        public virtual ICollection<Prestataire>  Prestataires {get; set;}j

    }
}
