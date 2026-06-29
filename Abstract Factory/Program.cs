using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // Создаём массив разных фабрик (работаем через абстрактный интерфейс).
        AbstractFactory[] factories = { new FactoryOne(), new FactoryTwo() };

        // Перебираем фабрики и запрашиваем у каждой создание полного семейства продуктов.
        foreach (AbstractFactory factory in factories)
        {
            ProductA productA = factory.CreateProductA();
            ProductB productB = factory.CreateProductB();

            Console.WriteLine(productA.GetName());
            Console.WriteLine(productB.GetName());
            Console.WriteLine(); // Разделитель между семействами
        }

        Console.ReadKey();
    }
}