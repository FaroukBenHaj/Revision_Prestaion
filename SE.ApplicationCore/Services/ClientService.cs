using SE.ApplicationCore.Domain;
using SE.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE.ApplicationCore.Services
{
    public class ClientService : Service<Client>,IClientService
    {
        public ClientService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
