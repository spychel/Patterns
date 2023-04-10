using CommandPattern.Command.Commands;
using CommandPattern.Command.Devices;

namespace CommandPattern.Command;

internal class RemoteLoader
{
    public static void Start()
    {
        var remoteControl = new RemoteControl();
        var livingRoomLight = new Light("Living Room");
        var kitchenLight = new Light("Kitchen");
        var ceilingFan = new CeilingFan("Living Room");
        var stereo = new Stereo("Living Room");

        var livingRoomLightOn =
            new LightOnCommand(livingRoomLight);
        var livingRoomLightOff =
            new LightOffCommand(livingRoomLight);
        var kitchenLightOn =
            new LightOnCommand(kitchenLight);
        var kitchenLightOff =
            new LightOffCommand(kitchenLight);
        
        var ceilingFanOn =
            new CeilingFanOnCommand(ceilingFan);
        var ceilingFanOff =
            new CeilingFanOffCommand(ceilingFan);
        var stereoOnWithCd =
            new StereoOnWithCdCommand(stereo);
        var stereoOff =
            new StereoOffCommand(stereo);
        
        remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
        remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
        remoteControl.SetCommand(2, ceilingFanOn, ceilingFanOff);
        remoteControl.SetCommand(3, stereoOnWithCd, stereoOff);

        Console.WriteLine(remoteControl.ToString());
        
        remoteControl.OnButtonWasPressed(0);
        remoteControl.OffButtonWasPressed(0);
        remoteControl.OnButtonWasPressed(1);
        remoteControl.OffButtonWasPressed(1);
        remoteControl.OnButtonWasPressed(2);
        remoteControl.OffButtonWasPressed(2);
        remoteControl.OnButtonWasPressed(3);
        remoteControl.OffButtonWasPressed(3);
        
    }
}