using EFCoreEmpRoupas.WEB.Interfaces;
using EFCoreEmpRoupas.WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreEmpRoupas.WEB.Repositorys
{
    public class RepositoryVW_RoupaEmprestimo : RepositoryBase<VW_RoupaEmprestimo>, IRepositoryVW_RoupaEmprestimo
    {
        public RepositoryVW_RoupaEmprestimo(bool SaveChanges = true) : base(SaveChanges)
        {
            //
        }
    }
}
