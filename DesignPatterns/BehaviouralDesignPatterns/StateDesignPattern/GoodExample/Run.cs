using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralDesignPatterns.StateDesignPattern.GoodExample
{
    internal class Run
    {
        public Run()
        {
            Document document = new Document(UserRoles.Admin);

            Console.WriteLine(document.State);

            document.publish();

            Console.WriteLine(document.State);

            document.publish();

            Console.WriteLine(document.State);

            document.publish();

            Console.WriteLine(document.State);


        }
    }
}
