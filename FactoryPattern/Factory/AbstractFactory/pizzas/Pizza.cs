namespace AbstractFactory;

internal abstract class Pizza
{
    protected Cheese? cheese;
    protected Clams? clam;
    protected Dough? dough;
    protected Pepperoni? pepperoni;
    protected Sauce? sauce;
    protected Veggies[]? veggies;
    public string? Name { get; set; }

    public abstract void Prepare();

    private void Bake()
    {
        Console.WriteLine("Bake for 25 minutes at 350");
    }

    private void Cut()
    {
        Console.WriteLine("Cutting the pizza into diagonal slices");
    }

    private void Box()
    {
        Console.WriteLine("Place pizza in official PizzaStore box");
    }

    public string toString()
    {
        return Name;
    }
}