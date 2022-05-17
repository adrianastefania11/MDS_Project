using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Entities.CreateDTO
{
    public class CreateLibraryDTO
    {
        public int IdRecipe { get; set; }
        public int IdUser { get; set; }
        public User User { get; set; }
        public List<RecipeLibrary> RecipeLibraries { get; set; }

    }
}
