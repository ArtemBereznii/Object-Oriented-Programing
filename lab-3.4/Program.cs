using System;
using System.Linq;

namespace Lab3_4
{
    class Program
    {
        // ------------------ ЗАВДАННЯ 1 ------------------

        // 1. Оголошуємо тип делегата з відповідним підписом 
        // ("Сортування одновимірного масиву цілих чисел за зростанням" )
        public delegate void SortDelegate(int[] array);

        // Метод для демонстрації
        public static void PrintArray(string title, int[] array)
        {
            Console.WriteLine($"{title}: [ {string.Join(", ", array)} ]");
        }

        public static void DemonstrateTask1()
        {
            Console.WriteLine("========= ЗАВДАННЯ 1: ДЕЛЕГАТИ ТА ЛЯМБДИ =========");
            int[] numbers = { 5, 1, 9, 3, 7, 2, 8 };
            PrintArray("Початковий масив", numbers);

            // 2. Використання Анонімного методу (для оцінки "добре") 
            SortDelegate anonymousSorter = delegate (int[] arr)
            {
                Array.Sort(arr);
            };
            anonymousSorter(numbers);
            PrintArray("Після анонімного методу", numbers);

            // Скидаємо масив
            numbers = new int[] { 5, 1, 9, 3, 7, 2, 8 };

            // 3. Використання Лямбда-виразу 
            SortDelegate lambdaSorter = (int[] arr) =>
            {
                Array.Sort(arr);
            };
            lambdaSorter(numbers);
            PrintArray("Після лямбда-виразу", numbers);
        }

        // ------------------ ЗАВДАННЯ 2 і 3 ------------------

        public static void DemonstrateTask2And3()
        {
            Console.WriteLine("\n\n========= ЗАВДАННЯ 2-3: ПОДІЇ =========");

            // 1. Створюємо компонент (видавця) 
            Car myCar = new Car("BMW", 10.0, 10.0); // 10л, 10 л/100км

            // 2. Створюємо підписника з обробником 
            Driver driver = new Driver("Олександр");

            // 3. Підписуємо обробник на подію 
            myCar.OutOfGas += driver.OnCarOutOfGas;

            // 4. Демонстрація
            myCar.Drive(50);  // Їдемо 50 км (треба 5л). Залишок: 5л. Подія не спрацює.
            myCar.Drive(70);  // Їдемо 70 км (треба 7л). Залишок: 0л. Подія спрацює!
            myCar.Refuel(20.0); // Заправляємось
            myCar.Drive(100); // Їдемо 100 км (треба 10л). Залишок: 10л.
        }

        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            DemonstrateTask1();
            DemonstrateTask2And3();
        }
    }
}