﻿using AM.ApplicationCore.Interfaces;
using Examen.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Interfaces
{
    public interface IPrestataireService:IService<Prestataire>
    {

        IList<Prestataire> GetPrestataires();
        public double TarifMoyen(int code); 
    }
}
