using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralDesignPatterns.CommandDesignPattern.Undoable
{
    internal class HtmlDocument
    {
        public string Content { get; set; } = string.Empty;

        public void MakeItalic()
        {
            Content = "<i>" + Content + "</i>";
        }
    }
}
