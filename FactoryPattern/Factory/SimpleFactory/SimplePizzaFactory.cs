internal class SimplePizzaFactory
{
    public Pizza CreatePizza(PizzaType type)
    {
        Pizza pizza = null;

        if (type == PizzaType.CHEESE)
            pizza = new CheesePizza();
        else if (type == PizzaType.PEPPERONI)
            pizza = new PepperoniPizza();
        else if (type == PizzaType.CLAM)
            pizza = new ClamPizza();
        else if (type == PizzaType.VEGGIE) pizza = new VeggiePizza();

        return pizza;
    }
}