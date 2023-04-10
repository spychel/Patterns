namespace CommandPattern.Command.Devices;

internal class Stereo
{
    private readonly string _name;

    public Stereo(string name)
    {
        _name = name;
    }

    public void On()
    {
        Console.WriteLine(_name + " light is on");
    }

    public void Off()
    {
        Console.WriteLine(_name + " light is off");
    }

    public void SetCd()
    {
        Console.WriteLine(_name + " is set for Cd input");
    }

    public void SetDvd()
    {
        Console.WriteLine(_name + " is set for Dvd input");
    }

    public void SetRadio()
    {
        Console.WriteLine(_name + " is set for Radio input");
    }

    public void SetVolume(int volume)
    {
        Console.WriteLine(_name + " volume set to " + volume);
    }
}