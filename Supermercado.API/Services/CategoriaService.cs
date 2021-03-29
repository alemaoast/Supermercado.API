using System.Collections.Generic;
using System.Threading.Tasks;
using Supermercado.API.Domain.Models;
using Supermercado.API.Domain.Services;

namespace Supermercado.API.Services
{
    public class CategoriaService : ICategoriaService
    {
        public Task<IEnumerable<Categoria>> ListAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}