using CommandPattern.Command.Devices;

namespace CommandPattern.Command.Commands;

internal class StereoOnWithCdCommand : ICommand
{
    private readonly Stereo _stereo;

    public StereoOnWithCdCommand(Stereo stereo)
    {
        this._stereo = stereo;
    }
    public void Execute()
    {
        _stereo.On();
        _stereo.SetCd();
        _stereo.SetVolume(11);
    }
}