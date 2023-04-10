namespace AbstractFactory;

internal class ClamPizza : Pizza
{
    private PizzaIngredientFactory ingredientFactory;

    public ClamPizza(PizzaIngredientFactory ingredientFactory)
    {
        this.ingredientFactory = ingredientFactory;
    }

    public override void Prepare()
    {
        Console.WriteLine("Preparing " + Name);
        // dough = ingredientFactory.createDough();
        // sauce = ingredientFactory.createSauce();
        // cheese = ingredientFactory.createCheese();
    }
}
