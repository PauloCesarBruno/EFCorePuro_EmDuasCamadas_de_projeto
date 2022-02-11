using EFCoreEmpRoupas.WEB.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreEmpRoupas.WEB.Services
{
    public class RoupaEmprestimoService
    {
        public RepositoryVW_RoupaEmprestimo oRepositoryVW_RoupaEmprestimo { get; set;  }

        public RoupaEmprestimoService()
        {
            oRepositoryVW_RoupaEmprestimo = new RepositoryVW_RoupaEmprestimo();
        }
    }
}
