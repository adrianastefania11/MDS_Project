﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Entities.DTOs
{
    public class RecpieTagDTO
    {
        public string NameTag { get; set; }
        public int IdRecipe { get; set; }
        public  Recipe Recipe { get; set; }
        public  Tag Tag { get; set; }

        public RecpieTagDTO(RecpieTagDTO rt)
        {
            this.NameTag = rt.NameTag;
            this.Tag = rt.Tag;
            this.IdRecipe = rt.IdRecipe;
            this.Recipe = rt.Recipe;
        }
    }
}
