using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Entities.DTOs
{
    public class DerivedTagDTO
    {
        public string NameTag { get; set; }
        public int IdDerivedRecipe { get; set; }
        public  Tag Tag { get; set; }
        public  DerivedRecipe DerivedRecipe { get; set; }

        public DerivedTagDTO(DerivedTagDTO dt)
        {
            this.NameTag = dt.NameTag;
            this.Tag = dt.Tag;
            this.IdDerivedRecipe = dt.IdDerivedRecipe;
            this.DerivedRecipe = dt.DerivedRecipe;
        }
    }
}
