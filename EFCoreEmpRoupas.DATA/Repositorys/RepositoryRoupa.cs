using EFCoreEmpRoupas.DATA;
using EFCoreEmpRoupas.WEB.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreEmpRoupas.WEB.Repositorys
{
    public class RepositoryRoupa : RepositoryBase<Roupa>, IRepositoryRoupa
    {
        public RepositoryRoupa(bool SaveChanges = true) : base(SaveChanges)
        {
            //
        }
    }
}
