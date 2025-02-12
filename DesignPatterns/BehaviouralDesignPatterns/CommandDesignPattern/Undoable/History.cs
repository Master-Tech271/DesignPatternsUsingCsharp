using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralDesignPatterns.CommandDesignPattern.Undoable
{
    internal class History
    {
        private readonly Stack<IUndoableCommand> _commands = new Stack<IUndoableCommand>();
        public void Push(IUndoableCommand command)
        {
            _commands.Push(command);
        }
        public IUndoableCommand Pop()
        {
            return _commands.Pop();
        }
        public int Size()
        {
            return _commands.Count;
        }
    }
}
