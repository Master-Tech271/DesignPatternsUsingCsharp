using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SingletonDesignPattern
{
    public sealed class SingletonClass
    {
        private static int _instanceCounter = 0;
        private static Lazy<SingletonClass> _lazyInstance = new Lazy<SingletonClass>(() => new SingletonClass());

        private SingletonClass()
        {
            _instanceCounter++;
        }

        //beneficial to avoid multi threading issue
        public static SingletonClass GetInstance()
        {
            return _lazyInstance.Value;
        }

        //to demonstrate how many times instance are created, if it always has a "1" value that means it follow the singleton principle.
        public static int GetInstanceCounter()
        {
            return _instanceCounter;
        }

        public void PerformSomeOperation()
        {
            Console.WriteLine("Perform Some Operation method is called by an instance.");
        }

        /*
        //to avoid the below situation, we make the singleton class as a sealed class to avoid the inheritance
        public class DerivedSingletonClass : SingletonClass
        {
            public DerivedSingletonClass()
            {
                
            }
        }

         */
    }
}
