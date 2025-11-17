using Restaurant.BLL.Interfaces;
using Restaurant.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant.DAL.Repositories
{
    public class IngredientRepository : FileRepositoryBase<Ingredient>, IIngredientRepository
    {
        // Вказуємо конкретний файл для збереження
        public IngredientRepository() : base("ingredients.json") { }

        // Реалізація унікального методу пошуку
        public IEnumerable<Ingredient> Search(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                return GetAll();
            }

            return _entities.Where(i => i.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase));
        }
    }
}