﻿using System.Collections.Generic;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.GatheringProfessions;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.Purchased;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Tailor._3_Expert
{
    public class ElvenTravellersLeggings : ExpertIngredients
    {
        public static string DisplayName = "Elven Traveller's Leggings";

        public ElvenTravellersLeggings(int count)
        {
            Name = DisplayName;
            QuantityRequested = count;
            QuantityProduced = 1;
            CraftingExperience = 10;
            WorkbenchRequired = true;
            IsUserRecipe = true;
        }

        public override object Clone()
        {
            return new ElvenTravellersLeggings(QuantityRequested);
        }

        public override SortedDictionary<string, Ingredient> GetRecipeIngredients()
        {
            var recipe = new SortedDictionary<string, Ingredient>();
            Ingredient ing;
            string ingName;

            ingName = SupplierIngredients.BoltOfCottonCloth;
            ing = (Ingredient)DictSimpleIngredients[ingName].Clone();
            ing.QuantityRequested = 1 * QuantityRequested;
            recipe.Add(ingName, ing);

            ingName = SturdyLeatherGuard.DisplayName;
            ing = (Ingredient)DictCraftedIngredients[ingName].Clone();
            ing.QuantityRequested = 1 * QuantityRequested;
            recipe.Add(ingName, ing);

            ingName = SturdyLeatherBinding.DisplayName;
            ing = (Ingredient)DictCraftedIngredients[ingName].Clone();
            ing.QuantityRequested = 1 * QuantityRequested;
            recipe.Add(ingName, ing);

            return recipe;
        }
    }
}