using EFCoreEmpRoupas.WEB.Repositorys;

namespace EFCoreEmpRoupas.DATA.Services
{
    public class RoupaEmprestimoClienteService
    {
        public RepositoryVW_RoupaEmprestimo oReposytoriVW_RoupaEmprestimo { get; set; }
        public RepositoryRoupa oRepositoryRoupa { get; set; }
        public RepositoryCliente oRepositoryCliente { get; set; }
        public RepositoryRoupaEmprestimo oRepositoryRoupaEmprestimo { get; set; }

        public RoupaEmprestimoClienteService()
        {
            oReposytoriVW_RoupaEmprestimo = new RepositoryVW_RoupaEmprestimo();
            oRepositoryRoupa = new RepositoryRoupa();
            oRepositoryCliente = new RepositoryCliente();
            oRepositoryRoupaEmprestimo = new RepositoryRoupaEmprestimo();
        }
    }
}
