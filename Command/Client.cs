using System;

namespace Command
{
    public class Client
    {
        static void Main(string[] args)
        {
            RemoteControl remote = new RemoteControl();

            Light light = new Light();

            ICommand lightsOn = new LightOnCommand(light);
            ICommand lightsOff = new LightOffCommand(light);

            remote.SetCommand(lightsOn);
            remote.pressButton();

            remote.SetCommand(lightsOff);
            remote.pressButton();

        }
    }
}
