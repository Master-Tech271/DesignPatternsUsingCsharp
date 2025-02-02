using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralDesignPatterns.StateDesignPattern.GoodExample
{
    internal class DraftState : IState
    {
        private Document _document;

        public DraftState(Document document)
        {
            _document = document;
        }

        public void publish()
        {
            _document.State = new ModerationState(_document);
        }
    }
}
