﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Entities.DTOs
{
    public class RecipeLibraryDTO
    {
        public int IdRecipe { get; set; }
        public int IdLibrary { get; set; }
        public  Recipe Recipe { get; set; }
        public  Library Library { get; set; }

        public RecipeLibraryDTO(RecipeLibraryDTO rl)
        {
            this.IdLibrary = rl.IdLibrary;
            this.Library = rl.Library;
            this.IdRecipe = rl.IdRecipe;
            this.Recipe = rl.Recipe;
        }
    }
}