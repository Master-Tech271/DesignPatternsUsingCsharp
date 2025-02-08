using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralDesignPatterns.ObserverDesignPattern.GoodExample
{
    internal class LineChartObserver : IObserver
    {
        private readonly DataSource _dataSource;

        public LineChartObserver(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public void Update()
        {
            Console.WriteLine($"Line Chart, total length is : {_dataSource.GetValues().Count()}");
        }
    }
}
