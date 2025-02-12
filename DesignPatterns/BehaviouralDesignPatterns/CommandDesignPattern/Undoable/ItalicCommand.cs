using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralDesignPatterns.CommandDesignPattern.Undoable
{
    internal class ItalicCommand : IUndoableCommand
    {
        private readonly HtmlDocument _document;
        private readonly History _history;
        private string _prevContent = string.Empty;

        public ItalicCommand(HtmlDocument document, History history)
        {
            _document = document;
            _history = history;
        }

        public void Execute()
        {
            _prevContent = _document.Content;
            _document.MakeItalic();
            _history.Push(this);
        }

        public void Unexecute()
        {
            _document.Content = _prevContent;
        }
    }
}
