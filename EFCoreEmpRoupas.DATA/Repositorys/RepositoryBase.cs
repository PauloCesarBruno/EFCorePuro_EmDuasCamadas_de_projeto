using EFCoreEmpRoupa.DATA.Interfaces;
using EFCoreEmpRoupas.DATA.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreEmpRoupas.WEB.Repositorys
{
    public class RepositoryBase<T> : IRepositoryBase<T>, IDisposable where T : class
    {
        // Configurar o Contexto
        protected DataRoupaContext _Contexto;
        // Variavel de persistencia de banco de dados
        public bool _SaveChanges = true;

        // CONSTRUTOR PARA O REPOSITORIO BASE
        public RepositoryBase(bool saveChanges = true)
        {
            _SaveChanges = saveChanges;
            _Contexto = new DataRoupaContext();
        }


        //==========================================================================


        public List<T> SelecionarTodos()
        {
            return _Contexto.Set<T>().ToList();
        }

        public T SelecionarPk(params object[] variavel)
        {
            return _Contexto.Set<T>().Find(variavel);
        }

        public T Incluir(T objeto)
        {
            _Contexto.Set<T>().Add(objeto);
            if (_SaveChanges)
            {
                _Contexto.SaveChanges();
            }
            return objeto;
        }

        public T Alterar(T objeto)
        {
            _Contexto.Entry(objeto).State = EntityState.Modified;

            if (_SaveChanges)
            {
                _Contexto.SaveChanges();
            }
            return objeto;
        }

        public void Excluir(T objeto)
        {
            _Contexto.Set<T>().Remove(objeto);
            if (_SaveChanges)
            {
                _Contexto.SaveChanges();
            }
        }

        public void Excluir(params object[] variavel)
        {
            var obj = SelecionarPk(variavel);
            Excluir(obj);
        }

        public void SaveChanges()
        {
            _Contexto.SaveChanges();
        }

        public void Dispose()
        {
            _Contexto.Dispose();
        }
    }
}
