using EFCoreEmpRoupas.WEB.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreEmpRoupas.WEB.Services
{
    public class ClienteService
    {
        public RepositoryCliente  oRepositoryCliente { get; set; }

        public ClienteService()
        {
            oRepositoryCliente = new RepositoryCliente();
        }
    }
}
