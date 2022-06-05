using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Entities.CreateDTO
{
    public class CreateDerivedTagDTO
    {
        public string NameTag { get; set; }
        public int IdDerivedRecipe { get; set; }
        public Tag Tag { get; set; }
        public DerivedRecipe DerivedRecipe { get; set; }
    }
}
