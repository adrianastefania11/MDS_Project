﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Entities
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RecipeFinal { get; set; }
        public DateTime CreationDate { get; set; }
        public int IdUser { get; set; }
        public virtual User User { get; set; }
        public ICollection<PullRecipe> PullRecipes { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Question> Questions { get; set; }
        public ICollection<DerivedRecipe> DerivedRecipes { get; set; }
        public virtual ICollection<MadeWith> MadeWiths { get; set; }
        public virtual ICollection<CookedWith> CookedWiths { get; set; }
        public virtual ICollection<RecipeTag> RecipeTags { get; set; }
        public virtual ICollection<RecipeLibrary> RecipeLibraries { get; set; }

    }
}
