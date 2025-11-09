using System;

namespace Lab3_4
{
    
    /// Клас-підписник, що містить метод-обробник події.
    public class Driver
    {
        public string Name { get; }

        public Driver(string name)
        {
            Name = name;
        }

        
        /// Метод-обробник, що реагує на подію.
        /// Його сигнатура відповідає стандарту .NET
        public void OnCarOutOfGas(object? sender, OutOfGasEventArgs e)
        {
            // Отримуємо інформацію про ініціатора події
            Car? car = sender as Car;
            if (car == null) return;

            Console.WriteLine($"--- СПОВІЩЕННЯ ВОДІЮ ({Name}) ---");
            Console.WriteLine($"Увага! Ваша машина {car.Model} заглухла.");
            Console.WriteLine($"Подія сталася о: {e.TimeOfEvent.ToShortTimeString()}");
            Console.WriteLine($"Для завершення поїздки не вистачило {e.FuelDeficit:F1} л палива.");
            Console.WriteLine("----------------------------------");
        }
    }
}