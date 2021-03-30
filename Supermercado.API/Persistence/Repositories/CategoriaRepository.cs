using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Supermercado.API.Domain.Models;
using Supermercado.API.Domain.Repositories;
using Supermercado.API.Persistence.Contexts;

namespace Supermercado.API.Persistence.Repositories
{
    public class CategoriaRepository : BaseRepository, ICategoriaRepository
    {
        public CategoriaRepository(AppDbContext context) : base(context)
        { }

        public async Task AddAsync(Categoria categoria)
        {
            await _context.Categorias.AddAsync(categoria);
        }

        public async Task<Categoria> FindByIdAsync(int id)
        {
            return await _context.Categorias.FindAsync(id);
        }

        public async Task<IEnumerable<Categoria>> ListAsync()
        {
            return await _context.Categorias.ToListAsync();
        }

        public void Remove(Categoria categoria)
        {
            _context.Categorias.Remove(categoria);
        }

        public void Update(Categoria categoria)
        {
            _context.Categorias.Update(categoria);
        }
    }
}