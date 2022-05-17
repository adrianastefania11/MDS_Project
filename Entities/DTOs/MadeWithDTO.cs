using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Entities.DTOs
{
    public class MadeWithDTO
    {
        public string Name { get; set; }
        public int IdRecipe { get; set; }
        public  Recipe Recipe { get; set; }
        public  Ingredient Ingredient { get; set; }

        public MadeWithDTO(MadeWithDTO made)
        {
            this.Name = made.Name;
            this.Ingredient = made.Ingredient;
            this.IdRecipe = made.IdRecipe;
            this.Recipe = made.Recipe;
        }
    }
}
