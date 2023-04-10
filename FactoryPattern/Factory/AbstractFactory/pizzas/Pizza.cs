namespace AbstractFactory
{
    abstract class Pizza
    {
        public String? Name { get; set; }
        protected Dough? dough;
        protected Sauce? sauce;
        protected Veggies[]? veggies;
        protected Cheese? cheese;
        protected Pepperoni? pepperoni;
        protected Clams? clam;

        public abstract void Prepare();

        void Bake()
        {
            System.Console.WriteLine("Bake for 25 minutes at 350");
        }

        void Cut()
        {
            System.Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        void Box()
        {
            System.Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public String toString()
        {
            return Name;
        }
    }
}
