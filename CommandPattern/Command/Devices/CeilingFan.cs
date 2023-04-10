namespace CommandPattern.Command.Devices;

internal class CeilingFan
{
    private readonly string _name;
    private string _speed;

    public CeilingFan(string name)
    {
        _name = name;
        _speed = "zero";
    }

    public void High()
    {
        _speed = "high";
        Console.WriteLine(_name + "ceiling fan is on high");
    }

    public void Medium()
    {
        _speed = "medium";
        Console.WriteLine(_name + "ceiling fan is on medium");
    }

    public void Low()
    {
        _speed = "low";
        Console.WriteLine(_name + "ceiling fan is on low");
    }

    public void Off()
    {
        _speed = "zero";
        Console.WriteLine(_name + "ceiling fan is off");
    }

    public string GetSpeed()
    {
        return _speed;
    }
}