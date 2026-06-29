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
//Паттерн Abstract Factory позволяет создавать целые семейства связанных объектов, не привязываясь к их конкретным классам. В моём коде AbstractFactory определяет методы для создания продуктов типа A и B. Конкретные фабрики FactoryOne и FactoryTwo создают свои семейства продуктов (ProductA1/ProductB1 и ProductA2/ProductB2). Клиентский код в Main работает с абстрактной фабрикой и не знает, какая именно фабрика и какие именно продукты создаются.
