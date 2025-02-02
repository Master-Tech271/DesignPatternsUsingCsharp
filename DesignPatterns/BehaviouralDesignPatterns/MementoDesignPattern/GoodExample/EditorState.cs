using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralDesignPatterns.MementoDesignPattern.GoodExample
{
    //Memento
    internal class EditorState
    {
        private readonly string _title = string.Empty;
        private readonly string _content = string.Empty;

        //State Meta Data
        private readonly DateTime _stateCreatedAt;

        public EditorState(string title, string content)
        {
            _title = title;
            _content = content;

            _stateCreatedAt = DateTime.Now;
        }

        public string GetTitle()
        {
            return _title;
        }

        public string GetContent()
        {
            return _content;
        }

        public string GetName()
        {
            return $"{_stateCreatedAt} / {_title} / {_content}";
        }

    }
}
