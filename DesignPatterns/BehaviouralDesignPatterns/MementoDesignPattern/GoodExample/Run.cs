using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralDesignPatterns.MementoDesignPattern.GoodExample
{
    internal class Run
    {
        private readonly Editor _editor;
        private readonly History _history;

        public Run()
        {
            _editor = new Editor();
            _history = new History(_editor);
            _history.Backup();
            Console.WriteLine("Welcome to the Editor Class that using 'Memento Design Pattern'\n");

            _editor.Title = "Title";
            _history.Backup();
            Print();
            
            _editor.Content = "Content";
            _history.Backup();
            Print();

            _editor.Title = "Title Updated";
            Print();

            _history.Undo();
            Print();

            _history.States();
            


        }

        public void Print()
        {
            Console.WriteLine($"Title: {_editor.Title}");
            Console.WriteLine($"Content: {_editor.Content}");
        }
    }
}
