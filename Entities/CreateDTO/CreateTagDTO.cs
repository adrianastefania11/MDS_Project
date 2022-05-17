﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Entities.CreateDTO
{
    public class CreateTagDTO
    {
        public string Name { get; set; }
        public List<RecipeTag> RecipeTags { get; set; }
        public List<DerivedTag> DerivedTags { get; set; }


    }
}
