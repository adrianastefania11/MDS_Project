﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Entities.CreateDTO
{
    public class CreateCookedWithDTO
    {
        public string Name { get; set; }
        public int IdRecipe { get; set; }
        public Recipe Recipe { get; set; }
        public Utensil Utensil { get; set; }
    }
}
