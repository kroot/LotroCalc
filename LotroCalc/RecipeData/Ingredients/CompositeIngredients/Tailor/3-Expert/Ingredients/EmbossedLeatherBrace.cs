﻿using System.Collections.Generic;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Forester._3_Expert;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Jeweler._3_Expert;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.GatheringProfessions;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.Purchased;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Tailor._3_Expert
{
    public class EmbossedLeatherBrace : ExpertIngredients
    {
        public static string DisplayName = "Embossed Leather Brace";

        public EmbossedLeatherBrace(int count)
        {
            Name = DisplayName;
            QuantityRequested = count;
            QuantityProduced = 1;
            CraftingExperience = 6;
            WorkbenchRequired = true;
            IsUserRecipe = false;
        }

        public override object Clone()
        {
            return new EmbossedLeatherBrace(QuantityRequested);
        }

        public override SortedDictionary<string, Ingredient> GetRecipeIngredients()
        {
            var recipe = new SortedDictionary<string, Ingredient>();
            Ingredient ing;
            string ingName;

            ingName = PieceOfSturdyLeather.DisplayName;
            ing = (Ingredient)DictCraftedIngredients[ingName].Clone();
            ing.QuantityRequested = 3 * QuantityRequested;
            recipe.Add(ingName, ing);

            ingName = PolishedRuby.DisplayName;
            ing = (Ingredient)DictCraftedIngredients[ingName].Clone();
            ing.QuantityRequested = 1 * QuantityRequested;
            recipe.Add(ingName, ing);

            return recipe;
        }
    }
}
