﻿using System.Collections.Generic;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.GatheringProfessions;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.Purchased;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Scholar._4_Artisan
{
    public class RefinedCelebrantOintment : ArtisanIngredients
    {
        public static string DisplayName = "Refined Celebrant Ointment (Guild)";

        public RefinedCelebrantOintment(int count)
        {
            Name = DisplayName;
            QuantityRequested = count;
            QuantityProduced = 25;
            CraftingExperience = 12;
            SuperiorStudyRequired = true;
            IsUserRecipe = true;
        }

        public override object Clone()
        {
            return new RefinedCelebrantOintment(QuantityRequested);
        }

        public override SortedDictionary<string, Ingredient> GetRecipeIngredients()
        {
            var recipe = new SortedDictionary<string, Ingredient>();
            Ingredient ing;
            string ingName;

            ingName = ScholarIngredients.RelicOfLothlorien;
            ing = (Ingredient)DictSimpleIngredients[ingName].Clone();
            ing.QuantityRequested = 10 * QuantityRequested;
            recipe.Add(ingName, ing);

            ingName = SupplierIngredients.GlassPhial;
            ing = (Ingredient)DictSimpleIngredients[ingName].Clone();
            ing.QuantityRequested = 10 * QuantityRequested;
            recipe.Add(ingName, ing);

            ingName = MediumArtisanScroll.DisplayName;
            ing = (Ingredient)DictCraftedIngredients[ingName].Clone();
            ing.QuantityRequested = 1 * QuantityRequested;
            recipe.Add(ingName, ing);

            ingName = SupplierIngredients.VialOfRefinedCelebrantWater;
            ing = (Ingredient)DictSimpleIngredients[ingName].Clone();
            ing.QuantityRequested = 10 * QuantityRequested;
            recipe.Add(ingName, ing);

            return recipe;
        }
    }
}



