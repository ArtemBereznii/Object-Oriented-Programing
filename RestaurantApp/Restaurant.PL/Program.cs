using Restaurant.BLL.Interfaces;
using Restaurant.BLL.Services;
using Restaurant.DAL.Repositories;
using Restaurant.PL;
using System;

// Цей простір імен має відповідати назві вашого PL проекту
namespace Restaurant.PL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Restaurant Management System";

            // --- "Композиційний корінь" (Composition Root) ---
            // Тут ми вручну виконуємо "Inversion of Control".
            // PL створює об'єкти DAL і передає їх в BLL.

            // 1. Створення репозиторіїв (DAL)
            // Вони будуть спілкуватися з JSON файлами
            IIngredientRepository ingredientRepo = new IngredientRepository();
            IDishRepository dishRepo = new DishRepository();
            IOrderRepository orderRepo = new OrderRepository();

            // 2. Створення сервісів (BLL), "впорскуючи" залежності (repositories)

            // IngredientService потребує DishRepository для перевірки видалення
            IngredientService ingredientService = new IngredientService(ingredientRepo, dishRepo);

            // DishService потребує IngredientRepository для перевірки додавання інгредієнта
            DishService dishService = new DishService(dishRepo, ingredientRepo);

            // OrderService потребує DishRepository для отримання цін на страви
            OrderService orderService = new OrderService(orderRepo, dishRepo);

            // 3. Створення та запуск головного меню (PL)
            // Передаємо сервіси у меню, щоб воно могло їх викликати
            MainMenu menu = new MainMenu(ingredientService, dishService, orderService);

            // Запуск головного циклу програми
            menu.Run();
        }
    }
}