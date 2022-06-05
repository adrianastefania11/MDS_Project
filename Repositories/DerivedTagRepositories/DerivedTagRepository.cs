﻿using Microsoft.EntityFrameworkCore;
using RecipesApp.Data;
using RecipesApp.Entities;
using RecipesApp.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Repositories.DerivedTagRepositories
{
    public class DerivedTagRepository : GenericRepository<DerivedTag>, IDerivedTagRepository
    {
        public DerivedTagRepository(AppDbContext context) : base(context) { }
        public async Task<List<DerivedTag>> GetAllDerivedTag()
        {
            return await _context.DerivedTags.ToListAsync();
        }

        public async Task<DerivedTag> GetDerivedTagById(int idRecipe)
        {
            return await _context.DerivedTags.Where(a => a.IdDerivedRecipe.Equals(idRecipe)).FirstOrDefaultAsync();
        }
    }
}
