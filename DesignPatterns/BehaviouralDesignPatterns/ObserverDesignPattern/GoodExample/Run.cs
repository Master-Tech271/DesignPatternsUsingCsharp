using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralDesignPatterns.ObserverDesignPattern.GoodExample
{
    internal class Run
    {
        public Run()
        {
            RunObserverDesignPattern();
        }

        private void RunObserverDesignPattern()
        {
            var dataSource = new DataSource(new List<int> { 1, 2, 3, 4, 5 });
            var lineChartObserver = new LineChartObserver(dataSource);
            var barChartObserver = new BarChartObserver(dataSource);
            var subject = new Subject(new List<IObserver> { lineChartObserver, barChartObserver });
            subject.Notify();

            dataSource.SetValues(new List<int> { 6, 7, 8, 10 });
            subject.Notify();
        }
    }
}
