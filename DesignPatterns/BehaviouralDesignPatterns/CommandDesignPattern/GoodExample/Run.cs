using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralDesignPatterns.CommandDesignPattern.GoodExample
{
    internal class Run
    {
        public Run()
        {
            Light light = new Light();
            ICommand turnOnCommand = new TurnOnCommand(light);
            ICommand turnOffCommand = new TurnOffCommand(light);
            ICommand dimCommand = new DimCommand(light);
            RemoteControl remoteControl = new RemoteControl(turnOnCommand);
            remoteControl.PressButton();
            remoteControl.SetCommand(turnOffCommand);
            remoteControl.PressButton();
            remoteControl.SetCommand(dimCommand);
            remoteControl.PressButton();
        }
    }
}
