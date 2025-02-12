using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralDesignPatterns.CommandDesignPattern.GoodExample
{
    internal class DimCommand : ICommand
    {
        private readonly Light _light;
        public DimCommand(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.Dim();
        }
    }
}
