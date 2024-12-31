using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    /**
     * Question 5.a
     * La classe  detenue coordonne
     * |-> On a deux methodes soit par les aanotations soit par la configuration de l'API
     * 1) Par les annotation :  [ Owned ] 
     * 2) Par l'api fluent : Creer un eclasse de config => builder.ownedOne(coordonne) 
     */

    [Owned] 

    public class Coordonnees
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Tel { get; set; }
        public string Adresse { get; set; }

    }
}
