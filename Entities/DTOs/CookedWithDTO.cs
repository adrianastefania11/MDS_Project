using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Entities.DTOs
{
    public class CookedWithDTO
    {
        public string Name { get; set; }
        public int IdRecipe { get; set; }
        public  Recipe Recipe { get; set; }
        public  Utensil Utensil { get; set; }

        public CookedWithDTO(CookedWith cooked)
        {
            this.Name = cooked.Name;
            this.Utensil = cooked.Utensil;
            this.IdRecipe = cooked.IdRecipe;
            this.Recipe = cooked.Recipe;
        }



    }
}
