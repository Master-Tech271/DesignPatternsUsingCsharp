using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralDesignPatterns.MementoDesignPattern.BadExample
{
    internal class Run
    {
        private readonly BasicEditor _basicEditor;
        private readonly Editor _editor;

        public Run() 
        {
            _basicEditor = new BasicEditor("Title", "Content");
            _editor = new Editor("Title", "Content");

            _initBasicEditor();

            _initEditor();
        }

        public void _initBasicEditor()
        {
            Console.WriteLine("Basic Editor Class: ");
            BasicEditorPrint();
            _basicEditor.UndoTitle();
            BasicEditorPrint();

            _basicEditor.UndoContents();
            BasicEditorPrint();
        }

        public void _initEditor()
        {
            Console.WriteLine("Editor Class with undo feature");
            EditorPrint();
            _editor.undo();
            EditorPrint();

            _editor.Title = "Hi, This is title";
            _editor.Title = "Hi, This is title, Hurray!";
            EditorPrint();
            
            _editor.undo();

            EditorPrint();

            _editor.undo();
            EditorPrint();
        }

        public void BasicEditorPrint()
        {
            Console.WriteLine($"Title : {_basicEditor.Title}");
            Console.WriteLine($"Content : {_basicEditor.Content}");
        }

        public void EditorPrint()
        {
            Console.WriteLine($"Title : {_editor.Title}");
            Console.WriteLine($"Content : {_editor.Content}");
        }
    }
}
