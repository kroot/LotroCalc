﻿using System.Collections.Generic;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Forester._4_Artisan;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Jeweler._4_Artisan;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.GatheringProfessions;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.Purchased;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Tailor._4_Artisan
{
    public class ImprovedDarkenedLeatherGuardGuild : ArtisanIngredients
    {
        public static string DisplayName = "Improved Darkened Leather Guard (Guild)";

        public ImprovedDarkenedLeatherGuardGuild(int count)
        {
            Name = DisplayName;
            QuantityRequested = count;
            QuantityProduced = 5;
            CraftingExperience = 8;
            SuperiorWorkbenchRequired = true;
            IsUserRecipe = true;
        }

        public override object Clone()
        {
            return new ImprovedDarkenedLeatherGuardGuild(QuantityRequested);
        }

        public override SortedDictionary<string, Ingredient> GetRecipeIngredients()
        {
            var recipe = new SortedDictionary<string, Ingredient>();
            Ingredient ing;
            string ingName;

            ingName = SmallArtisanPatternGuild.DisplayName;
            ing = (Ingredient)DictCraftedIngredients[ingName].Clone();
            ing.QuantityRequested = 1 * QuantityRequested;
            recipe.Add(ingName, ing);

            ingName = PieceOfPristineLeather.DisplayName;
            ing = (Ingredient)DictCraftedIngredients[ingName].Clone();
            ing.QuantityRequested = 3 * QuantityRequested;
            recipe.Add(ingName, ing);

            ingName = PolishedAdamant.DisplayName;
            ing = (Ingredient)DictCraftedIngredients[ingName].Clone();
            ing.QuantityRequested = 1 * QuantityRequested;
            recipe.Add(ingName, ing);

            return recipe;
        }
    }
}