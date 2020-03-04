using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;

namespace Interface
{
    public interface IIngredientRepo
    {
        bool InsertIngredient(Ingredient i);
        bool DeleteIngredient(Ingredient i);
        bool UpdateIngredient(Ingredient i);
        Ingredient GetIngredient(string invId);
        List<Ingredient> GetALLIngredient();
    }
}
