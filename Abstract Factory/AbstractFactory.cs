public abstract class AbstractFactory
{
    // Каждая фабрика должна уметь создавать оба типа продуктов.
    public abstract ProductA CreateProductA();
    public abstract ProductB CreateProductB();
}