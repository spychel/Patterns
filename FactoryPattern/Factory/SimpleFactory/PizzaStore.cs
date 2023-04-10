internal class PizzaStore
{
    private readonly SimplePizzaFactory factory;

    public PizzaStore(SimplePizzaFactory factory)
    {
        this.factory = factory;
    }

    public Pizza orderPizza(PizzaType type)
    {
        Pizza pizza;
        pizza = factory.CreatePizza(type);
        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();
        return pizza;
    }
}