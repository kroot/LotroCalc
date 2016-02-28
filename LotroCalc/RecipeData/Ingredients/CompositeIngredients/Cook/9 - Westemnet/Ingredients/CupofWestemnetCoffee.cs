﻿
using System.Collections.Generic;
 using LotroCalc.RecipeData.Ingredients.SimpleIngredients;
 using LotroCalc.RecipeData.Ingredients.SimpleIngredients.GatheringProfessions;
 using LotroCalc.RecipeData.Ingredients.SimpleIngredients.Purchased;
 using LotroCalc.RecipeData.Ingredients.CompositeIngredients;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Cook._9_Westemnet
{
    public class CupofWestemnetCoffee : WestemnetIngredients
    {
        public static string DisplayName = "Cup of Westemnet Coffee";

        public CupofWestemnetCoffee(int count)
        {
            Name = DisplayName;
            QuantityRequested = count;
            QuantityProduced = 1;
            CraftingExperience = 8;
            IsUserRecipe = true;
        }

        public override object Clone()
        {
            return new CupofWestemnetCoffee(QuantityRequested);
        }

        public override SortedDictionary<string, Ingredient> GetRecipeIngredients()
        {
            var recipe = new SortedDictionary<string, Ingredient>();
            Ingredient ing;
            string ingName;

            ingName = BagofWestemnetCoffeeGrounds.DisplayName;
            ing = (Ingredient) DictCraftedIngredients[ingName].Clone();
            ing.QuantityRequested = 1*QuantityRequested;
            recipe.Add(ingName, ing);

            ingName = SupplierIngredients.BottleOfWater;
            ing = (Ingredient) DictSimpleIngredients[ingName].Clone();
            ing.QuantityRequested = 1*QuantityRequested;
            recipe.Add(ingName, ing);

            ingName = SupplierIngredients.LargeClayPot;
            ing = (Ingredient) DictSimpleIngredients[ingName].Clone();
            ing.QuantityRequested = 1*QuantityRequested;
            recipe.Add(ingName, ing);

            return recipe;
        }
    }
}