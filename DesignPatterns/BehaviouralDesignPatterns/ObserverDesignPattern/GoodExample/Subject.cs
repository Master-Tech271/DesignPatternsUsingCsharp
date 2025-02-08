using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralDesignPatterns.ObserverDesignPattern.GoodExample
{
    internal class Subject
    {
        private readonly List<IObserver> _observers;

        public Subject(List<IObserver> observers)
        {
            _observers = observers;
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }
    }
}
