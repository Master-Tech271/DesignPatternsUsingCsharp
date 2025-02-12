using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralDesignPatterns.CommandDesignPattern.Undoable
{
    internal class UndoCommand : ICommand
    {
        private readonly History _history;

        public UndoCommand(History history)
        {
            _history = history;
        }

        public void Execute()
        {
            if(_history.Size() > 0)
            {
                var command = _history.Pop();
                command.Unexecute();
            }
        }
    }
}
