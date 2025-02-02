using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralDesignPatterns.StateDesignPattern.GoodExample
{
    internal class PublishState : IState
    {
        private readonly Document _document;

        public PublishState(Document document)
        {
            _document = document;
        }

        public void publish()
        {
            //do nothing
        }
    }
}
