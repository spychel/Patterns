using System.Text;
using CommandPattern.Command.Commands;

namespace CommandPattern.Command;

internal class RemoteControl
{
    private readonly ICommand[] _offCommands;
    private readonly ICommand[] _onCommands;

    public RemoteControl()
    {
        _onCommands = new ICommand[7];
        _offCommands = new ICommand[7];

        for (var i = 0; i < 7; i++)
        {
            _onCommands[i] = new NoCommand();
            _offCommands[i] = new NoCommand();
        }
    }

    public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
    {
        _onCommands[slot] = onCommand;
        _offCommands[slot] = offCommand;
    }

    public void OnButtonWasPressed(int slot)
    {
        _onCommands[slot].Execute();
    }

    public void OffButtonWasPressed(int slot)
    {
        _offCommands[slot].Execute();
    }

    public new string ToString()
    {
        var stringBuff = new StringBuilder();
        stringBuff.Append("\n------ Remote Control -------\n");
        for (var i = 0; i < _onCommands.Length; i++)
            stringBuff.Append(
                "[slot "
                + i
                + "] "
                + _onCommands[i].GetType().Name
                + " "
                + _offCommands[i].GetType().Name
                + "\n"
            );
        return stringBuff.ToString();
    }
}