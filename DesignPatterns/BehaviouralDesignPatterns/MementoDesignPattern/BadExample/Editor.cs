using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralDesignPatterns.MementoDesignPattern.BadExample
{
/*
 * 
 * This class has the undo feature, we dont need to explicity tell to undo titile or content, it knows the prev states
 * But, this class violates the SRP - Single Responsibility Principle
 * 
 */
    internal class Editor
    {
        private string _title = string.Empty;
        private string _content = string.Empty;

        private List<EditorState> _prevStates = new List<EditorState>();

        public string Title
        {
            get { return _title; }
            set
            {
                savePrevStates();
                _title = value;
            }
        }

        public string Content
        {
            get { return _content; }
            set
            {
                savePrevStates();
                _content = value;
            }
        }

        private void savePrevStates()
        {
            _prevStates.Add(new EditorState { Title = _title, Content = _content });
        }

        public Editor(string title, string content)
        {
            Title = title;
            Content = content;
        }

        public void undo()
        {
            if (_prevStates.Count == 0) return;
            EditorState lastState = _prevStates.Last();
            Title = lastState.Title;
            Content = lastState.Content;

            _prevStates.Remove(lastState);
        }
    }
}
