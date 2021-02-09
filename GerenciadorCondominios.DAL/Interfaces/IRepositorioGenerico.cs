using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorCondominios.DAL.Interfaces
{
    public interface IRepositorioGenerico<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> PegarTodos();
        Task<TEntity> PegarPeloId(int id);
        Task<TEntity> PegarPeloId(string id);
        Task Inserir(TEntity entity);
        Task Atualizar(TEntity entity);
        Task Exluir(TEntity entity);
        Task Exluir(int id);
        Task Exluir(string id);
    }
}
