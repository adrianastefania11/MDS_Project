using Microsoft.EntityFrameworkCore;
using RecipesApp.Data;
using RecipesApp.Entities;
using RecipesApp.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Repositories.UtensilRepositories
{
    public class UtensilRepository : GenericRepository<Utensil>, IUtensilRepository
    {
        public UtensilRepository(AppDbContext context) : base(context) { }


        public async Task<List<Utensil>> GetAllUtensils()
        {
            return await _context.Utensils.ToListAsync();
        }

        public async Task<List<Utensil>> GetAllByName(string name)
        {
            return await _context.Utensils.Where(a => a.Name == name).ToListAsync(); ;

        }

        public async Task<Utensil> GetUtensilByName(string name)
        {
            return await _context.Utensils.Where(a => a.Name.Equals(name)).FirstOrDefaultAsync();
        }
    }
}
