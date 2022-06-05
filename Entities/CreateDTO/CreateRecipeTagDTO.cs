﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Entities.CreateDTO
{
    public class CreateRecipeTagDTO
    {
        public string NameTag { get; set; }
        public int IdRecipe { get; set; }
        public Recipe Recipe { get; set; }
        public Tag Tag { get; set; }
    }
}