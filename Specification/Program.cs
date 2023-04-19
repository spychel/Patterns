using static System.Console;

namespace Specification;

internal interface ISpecification<T>
{
    bool IsSatisfied(T t);
}

internal interface IFilter<T>
{
    IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
}

public enum Color
{
    Red, Green, Blue
}

public enum Size
{
    Small, Medium, Large
}

internal class Product
{
    public readonly string Name;
    public readonly Color Color;
    public readonly Size Size;

    public Product(string name, Color color, Size size)
    {
        Name = name;
        Color = color;
        Size = size;
    }
}

internal class ProductFilter : IFilter<Product>
{
    public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
    {
        return items.Where(spec.IsSatisfied);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var apple = new Product("Apple", Color.Green, Size.Small);
        var tree = new Product("Tree", Color.Green, Size.Large);
        var house = new Product("House", Color.Blue, Size.Large);

        Product[] products = {apple, tree, house};

        var pf = new ProductFilter();
        Console.WriteLine("Green products (new):");
        foreach (var p in pf.Filter(products, new ColorSpecification(Color.Green)))
            Console.WriteLine($" - {p.Name} is green");
        
        Console.WriteLine("Large products");
        foreach (var p in pf.Filter(products, new SizeSpecification(Size.Large)))
            Console.WriteLine($" - {p.Name} is large");
        
        WriteLine("Large blue items");
        foreach (var p in pf.Filter(products,
                     new AndSpecification<Product>(
                         new ISpecification<Product>[]
                         {
                             new ColorSpecification(Color.Blue), 
                             new SizeSpecification(Size.Large)
                         })
                 )
                )
        {
            WriteLine($" - {p.Name} is big and blue");
        }

    }
}

internal class ColorSpecification : ISpecification<Product>
{
    private readonly Color _color;

    public ColorSpecification(Color color)
    {
        _color = color;
    }
    public bool IsSatisfied(Product p)
    {
        return p.Color == _color;
    }
}

internal class SizeSpecification : ISpecification<Product>
{
    private readonly Size _size;

    public SizeSpecification(Size size)
    {
        _size = size;
    }
    public bool IsSatisfied(Product p)
    {
        return p.Size == _size;
    }
}

internal class AndSpecification<T> : ISpecification<T>
{
    private readonly IEnumerable<ISpecification<T>> _specs;

    public AndSpecification(IEnumerable<ISpecification<T>> specs)
    {
        _specs = specs;
    }
    public bool IsSatisfied(T t)
    {
        return _specs.All(spec => spec.IsSatisfied(t) != false);
    }
}



