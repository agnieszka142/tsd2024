using System;
using System.Collections.Generic;
using System.Linq;
using Cookbook.Models;

public class RecipeRepository
{
    private List<Recipe> _recipes;

    public RecipeRepository()
    {
        _recipes = new List<Recipe>
        {
            new Recipe
            {
                ID = 1,
                Name = "Spaghetti Carbonara",
                Time = TimeSpan.FromMinutes(30),
                Difficulty = "Medium",
                NumberOfLikes = 50,
                Ingredients = "Spaghetti", 
                Process = "1. Cook spaghetti according to package instructions. 2. In a separate pan, fry bacon until crispy. 3. In a bowl, whisk eggs, grated Parmesan cheese, and black pepper. 4. Combine cooked spaghetti with bacon and then mix in the egg mixture. 5. Serve immediately.",
                TipsAndTricks = "Make sure to mix the egg and cheese mixture quickly to avoid scrambling the eggs when mixing with the hot pasta."
            },
            new Recipe
            {
                ID = 2,
                Name = "Chicken Stir-Fry",
                Time = TimeSpan.FromMinutes(25),
                Difficulty = "Easy",
                NumberOfLikes = 35,
                Ingredients = "Mixed vegetables",
                Process = "1. Slice chicken breast into thin strips and marinate with soy sauce, minced garlic, and grated ginger. 2. Heat vegetable oil in a pan or wok. 3. Stir-fry marinated chicken until cooked through. 4. Add mixed vegetables and continue cooking until vegetables are tender. 5. Serve hot.",
                TipsAndTricks = "Cut the vegetables into similar sizes to ensure even cooking."
            },
            new Recipe
            {
                ID = 3,
                Name = "Chocolate Chip Cookies",
                Time = TimeSpan.FromMinutes(20),
                Difficulty = "Easy",
                NumberOfLikes = 65,
                Ingredients = "Brown sugar",
                Process = "1. Preheat oven to 350°F (175°C). 2. Cream together butter, sugar, and brown sugar. 3. Beat in egg and vanilla extract. 4. Combine flour, baking soda, and salt in a separate bowl, then gradually add to the wet ingredients. 5. Stir in chocolate chips. 6. Drop dough by rounded spoonfuls onto a greased baking sheet. 7. Bake for 10-12 minutes or until edges are golden brown. 8. Allow cookies to cool on the baking sheet for a few minutes before transferring to a wire rack to cool completely.",
                TipsAndTricks = "For softer cookies, slightly underbake them and let them cool on the baking sheet for longer."
            }
        };
    }

    public List<Recipe> GetAllRecipes()
    {
        return _recipes;
    }

    public Recipe GetRecipeByID(int id)
    {
        return _recipes.FirstOrDefault(r => r.ID == id);
    }

    public void AddRecipe(Recipe recipe)
    {
        recipe.ID = _recipes.Count + 1;
        _recipes.Add(recipe);
    }

    public void UpdateRecipe(Recipe updatedRecipe)
    {
        var existingRecipe = _recipes.FirstOrDefault(r => r.ID == updatedRecipe.ID);
        if (existingRecipe != null)
        {
            existingRecipe.Name = updatedRecipe.Name;
            existingRecipe.Time = updatedRecipe.Time;
            existingRecipe.Difficulty = updatedRecipe.Difficulty;
            existingRecipe.NumberOfLikes = updatedRecipe.NumberOfLikes;
            existingRecipe.Ingredients = updatedRecipe.Ingredients;
            existingRecipe.Process = updatedRecipe.Process;
            existingRecipe.TipsAndTricks = updatedRecipe.TipsAndTricks;
        }
    }


}
