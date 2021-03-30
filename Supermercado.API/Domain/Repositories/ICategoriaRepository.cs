using System.Collections.Generic;
using System.Threading.Tasks;
using Supermercado.API.Domain.Models;

namespace Supermercado.API.Domain.Repositories
{
    public interface ICategoriaRepository
    {
         Task<IEnumerable<Categoria>> ListAsync();
         Task AddAsync(Categoria categoria);
         Task<Categoria> FindByIdAsync(int id);
         void Update(Categoria categoria);
         void Remove(Categoria categoria);
    }
}