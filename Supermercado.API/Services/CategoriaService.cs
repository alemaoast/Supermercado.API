using System.Collections.Generic;
using System.Threading.Tasks;
using Supermercado.API.Domain.Models;
using Supermercado.API.Domain.Repositories;
using Supermercado.API.Domain.Services;

namespace Supermercado.API.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;
        public CategoriaService(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public async Task<IEnumerable<Categoria>> ListAsync()
        {
            return await _categoriaRepository.ListAsync();
        }
    }
}