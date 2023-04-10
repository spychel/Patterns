namespace AbstractFactory;

class CheesePizza : Pizza
{
    PizzaIngredientFactory ingredientFactory;

    public CheesePizza(PizzaIngredientFactory ingredientFactory)
    {
        this.ingredientFactory = ingredientFactory;
    }

    public override void Prepare()
    {
        System.Console.WriteLine("Preparing " + Name);
        // dough = ingredientFactory.createDough();
        // sauce = ingredientFactory.createSauce();
        // cheese = ingredientFactory.createCheese();
    }
}
