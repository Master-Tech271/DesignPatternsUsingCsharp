using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralDesignPatterns.StateDesignPattern.GoodExample
{
    internal class ModerationState : IState
    {
        private Document _document;

        public ModerationState(Document document)
        {
            _document = document;
        }

        public void publish()
        {
            if(_document.CurrentUserRole == UserRoles.Admin)
            {
                _document.State = new PublishState(_document);
            }
        }
    }
}
