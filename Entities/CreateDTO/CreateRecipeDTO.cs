using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Entities.CreateDTO
{
    public class CreateRecipeDTO
    {


        public string Name { get; set; }
        public string RecipeFinal { get; set; }
        public DateTime CreationDate { get; set; }
        public int IdUser { get; set; }
        public User User { get; set; }
        public int Rating { get; set; }
        public List<PullRecipe> PullRecipes { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Question> Questions { get; set; }
        public List<DerivedRecipe> DerivedRecipes { get; set; }
        public List<MadeWith> MadeWiths { get; set; }
        public List<CookedWith> CookedWiths { get; set; }
        public List<RecipeTag> RecipeTags { get; set; }
        public List<RecipeLibrary> RecipeLibraries { get; set; }

    }
}
