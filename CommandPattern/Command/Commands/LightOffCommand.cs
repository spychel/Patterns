using CommandPattern.Command.Devices;

namespace CommandPattern.Command.Commands;

internal class LightOffCommand : ICommand
{
    private readonly Light _light;

    public LightOffCommand(Light light)
    {
        this._light = light;
    }

    public void Execute()
    {
        _light.Off();
    }
}