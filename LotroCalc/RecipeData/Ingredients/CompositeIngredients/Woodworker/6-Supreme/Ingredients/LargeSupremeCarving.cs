﻿using System.Collections.Generic;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Forester._6_Supreme;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.GatheringProfessions;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.Purchased;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Woodworker._6_Supreme
{
    public class LargeSupremeCarving : SupremeIngredients
    {
        public static string DisplayName = "Large Supreme Carving (Guild)";

        public LargeSupremeCarving(int count)
        {
            Name = DisplayName;
            QuantityRequested = count;
            QuantityProduced = 1;
            CraftingExperience = 70;
            SuperiorWorkbenchRequired = true;
            IsUserRecipe = true;
        }

        public override object Clone()
        {
            return new LargeSupremeCarving(QuantityRequested);
        }

        public override SortedDictionary<string, Ingredient> GetRecipeIngredients()
        {
            var recipe = new SortedDictionary<string, Ingredient>();
            Ingredient ing;
            string ingName;

            ingName = PlankofTreatedMallorn.DisplayName;
            ing = (Ingredient)DictCraftedIngredients[ingName].Clone();
            ing.QuantityRequested = 7 * QuantityRequested;
            recipe.Add(ingName, ing);

            ingName = PlankofTreatedIlex.DisplayName;
            ing = (Ingredient)DictCraftedIngredients[ingName].Clone();
            ing.QuantityRequested = 5 * QuantityRequested;
            recipe.Add(ingName, ing);

            return recipe;
        }
    }
}