using EFCoreEmpRoupas.WEB.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreEmpRoupas.WEB.Services
{
    public class RoupaService
    {
        public RepositoryRoupa oRepositoryRoupa { get; set; }

        public RoupaService()
        {
            oRepositoryRoupa = new RepositoryRoupa();
        }
    }
}