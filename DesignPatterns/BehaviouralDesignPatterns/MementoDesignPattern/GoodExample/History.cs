using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralDesignPatterns.MementoDesignPattern.GoodExample
{
    internal class History
    {
        private readonly Editor _editor;
        private readonly List<EditorState> _states;

        public History(Editor editor)
        {
            _editor = editor;
            _states = new List<EditorState>();
        }

        public void Backup()
        {
            _states.Add(_editor.CreateState());
        }

        public void Undo()
        {
            if (_states.Count == 0) return;

            EditorState state = _states.Last();
            _states.Remove(state);

            _editor.Restore(state);
        }

        public void States()
        {
            foreach (EditorState state in _states)
            {
                Console.WriteLine($"{state.GetName()}");
            }
        }
    }
}
