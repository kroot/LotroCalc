﻿using System.Collections.Generic;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.GatheringProfessions;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.Purchased;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Metalsmith._2_Journeyman
{
    public class CraftedShoulderGuards : JourneymanIngredients
    {
        public static string DisplayName = "Crafted Shoulder Guards";

        public CraftedShoulderGuards(int count)
        {
            Name = DisplayName;
            QuantityRequested = count;
            QuantityProduced = 1;
            CraftingExperience = 8;
            ForgeRequired = true;
            IsUserRecipe = true;
        }

        public override object Clone()
        {
            return new CraftedShoulderGuards(QuantityRequested);
        }

        public override SortedDictionary<string, Ingredient> GetRecipeIngredients()
        {
            var recipe = new SortedDictionary<string, Ingredient>();
            Ingredient ing;
            string ingName;

            ingName = IronChainLink.DisplayName;
            ing = (Ingredient)DictCraftedIngredients[ingName].Clone();
            ing.QuantityRequested = 1 * QuantityRequested;
            recipe.Add(ingName, ing);

            ingName = IronBand.DisplayName;
            ing = (Ingredient)DictCraftedIngredients[ingName].Clone();
            ing.QuantityRequested = 1 * QuantityRequested;
            recipe.Add(ingName, ing);

            return recipe;
        }
    }
}