using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = {
            new Mammal("Лев", 5, "Саванна", "Мясо", "Короткая шерсть", 110),
            new Bird("Орел", 3, "Горы", "Рыба", 2.1, "На скалах"),
            new Reptile("Питон", 8, "Джунгли", "Мелкие животные", "Чешуя", 28.5),
            new Fish("Акула", 10, "Океан", "Рыба", "Плакоидная", 200)
        };

            foreach (var animal in animals)
            {
                Console.WriteLine($"Вид: {animal.Species}");
                Console.WriteLine($"Возраст: {animal.Age} лет");
                Console.WriteLine($"Среда обитания: {animal.Habitat}");
                Console.WriteLine($"Рацион: {animal.Diet}");

                if (animal is Mammal mammal)
                {
                    Console.WriteLine($"Тип меха: {mammal.FurType}");
                    Console.WriteLine($"Продолжительность беременности: {mammal.GestationPeriod} дней");
                }
                else if (animal is Bird bird)
                {
                    Console.WriteLine($"Размах крыльев: {bird.Wingspan} метров");
                    Console.WriteLine($"Тип гнездования: {bird.NestingType}");
                }
                else if (animal is Reptile reptile)
                {
                    Console.WriteLine($"Тип кожи: {reptile.SkinType}");
                    Console.WriteLine($"Предпочтительная температура: {reptile.PreferredTemperature}°C");
                }
                else if (animal is Fish fish)
                {
                    Console.WriteLine($"Тип чешуи: {fish.ScaleType}");
                    Console.WriteLine($"Предпочтительная глубина: {fish.PreferredDepth} метров");
                }

                Console.WriteLine();
            }
        }
    }
}
