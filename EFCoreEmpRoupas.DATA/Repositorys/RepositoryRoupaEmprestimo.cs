using EFCoreEmpRoupas.DATA.Models;
using EFCoreEmpRoupas.WEB.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreEmpRoupas.WEB.Repositorys
{
    public class RepositoryRoupaEmprestimo : RepositoryBase<RoupaEmprestimo>, IRepositoryRoupaEmprestimo
    {
        public RepositoryRoupaEmprestimo(bool SaveChanges = true) : base(SaveChanges)
        {
            //
        }
    }
}
