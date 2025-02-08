using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralDesignPatterns.ObserverDesignPattern.GoodExample
{
    internal class BarChartObserver : IObserver
    {
        private readonly DataSource _dataSource;

        public BarChartObserver(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        private void Display(int total)
        {
            Console.WriteLine($"Bar Chart: {total}");
        }

        public void Update()
        {
            int total = _dataSource.GetValues().Sum();
            Display(total);
        }
    }
}
