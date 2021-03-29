using System.Collections.Generic;
using System.Threading.Tasks;
using Supermercado.API.Domain.Models;

namespace Supermercado.API.Domain.Services
{
    public interface ICategoriaService
    {
         Task<IEnumerable<Categoria>> ListAsync();
    }
}