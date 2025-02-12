using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralDesignPatterns.CommandDesignPattern.Undoable
{
    internal class Run
    {
        public Run() 
        {
            var history = new History();
            var document = new HtmlDocument();
            document.Content = "Hello World";
            var italicCommand = new ItalicCommand(document, history);
            italicCommand.Execute();
            Console.WriteLine(document.Content);
            var undoCommand = new UndoCommand(history);
            undoCommand.Execute();
            Console.WriteLine(document.Content);
            italicCommand.Execute();
            Console.WriteLine(document.Content);
            undoCommand.Execute();
            Console.WriteLine(document.Content);
        }
    }
}
