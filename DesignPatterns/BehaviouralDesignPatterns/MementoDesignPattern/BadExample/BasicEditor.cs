using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralDesignPatterns.MementoDesignPattern.BadExample
{
    /*
     * 
     * This class has the problem, they don't know the prev states when we do undo, like we need to undo title or content.
     * so we need to explicity call the method to undo title or content.    
     * 
     */
    internal class BasicEditor
    {
        private string _title = string.Empty;
        private string _content = string.Empty;

        private List<string> _prevTitles = new List<string>();
        private List<string> _prevContents = new List<string>();

        public string Title 
        { 
            get { return _title; } 
            set 
            {
                _prevTitles.Add(_title);
                _title = value; 
            } 
        }

        public string Content
        {
            get { return _content; }
            set 
            {
                _prevContents.Add(_content); 
                _content = value; 
            }
        }

        public BasicEditor(string title, string content)
        { 
            Title = title;
            Content = content;
        }

        public void UndoTitle()
        {
            if (_prevTitles.Count == 0) return;
            string lastTitle = _prevTitles.Last();
            Title = lastTitle;
            _prevTitles.Remove(lastTitle);
        }

        public void UndoContents()
        {
            if (_prevContents.Count == 0) return;
            string lastContent = _prevContents.Last();
            Content = lastContent;
            _prevContents.Remove(lastContent);
        }


    }
}
