public abstract class Duck
{
    protected IFlyBehavior flyBehavior;
    protected IMakeSoundBehavior makeSoundBehavior;

    public void MakeSound()
    {
        makeSoundBehavior.MakeSound();
    }

    public void Fly()
    {
        flyBehavior.Fly();
    }
}