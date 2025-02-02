using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralDesignPatterns.StateDesignPattern.GoodExample
{
    internal class Document
    {
        public IState State;

        public UserRoles CurrentUserRole { get; private set; }

        public Document(UserRoles userRole)
        {
            State = new DraftState(this);
            CurrentUserRole = userRole;
        }

        public void publish()
        {
            State.publish();
        }

    }
}
