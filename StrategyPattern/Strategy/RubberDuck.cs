public class RubberDuck : Duck
{
    public RubberDuck()
    {
        flyBehavior = new FlyWithWings();
        makeSoundBehavior = new Quack();
    }
}