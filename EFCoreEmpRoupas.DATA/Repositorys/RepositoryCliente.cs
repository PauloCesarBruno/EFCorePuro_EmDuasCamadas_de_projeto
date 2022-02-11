using EFCoreEmpRoupa.DATA.Interfaces;
using EFCoreEmpRoupas.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreEmpRoupas.WEB.Repositorys
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {
        public RepositoryCliente(bool SaveChanges = true) : base (SaveChanges)
        {
            //
        }
    }
}
