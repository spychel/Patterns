namespace AbstractFactory;

internal class CheesePizza : Pizza
{
    private PizzaIngredientFactory ingredientFactory;

    public CheesePizza(PizzaIngredientFactory ingredientFactory)
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
