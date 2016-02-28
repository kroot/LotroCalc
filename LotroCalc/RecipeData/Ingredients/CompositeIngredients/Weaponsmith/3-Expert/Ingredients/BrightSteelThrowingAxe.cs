﻿using System.Collections.Generic;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.GatheringProfessions;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.Purchased;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Weaponsmith._3_Expert
{
    public class BrightSteelThrowingAxe : ExpertIngredients
    {
        public static string DisplayName = "Bright Steel Throwing Axe";

        public BrightSteelThrowingAxe(int count)
        {
            Name = DisplayName;
            QuantityRequested = count;
            QuantityProduced = 4;
            CraftingExperience = 6;
            ForgeRequired = true;
            IsUserRecipe = true;
        }

        public override object Clone()
        {
            return new BrightSteelThrowingAxe(QuantityRequested);
        }

        public override SortedDictionary<string, Ingredient> GetRecipeIngredients()
        {
            var recipe = new SortedDictionary<string, Ingredient>();
            Ingredient ing;
            string ingName;

            ingName = BrightSteelBlade.DisplayName;
            ing = (Ingredient)DictCraftedIngredients[ingName].Clone();
            ing.QuantityRequested = 1 * QuantityRequested;
            recipe.Add(ingName, ing);

            return recipe;
        }
    }
}


