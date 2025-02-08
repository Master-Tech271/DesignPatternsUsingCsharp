using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralDesignPatterns.ObserverDesignPattern.GoodExample
{
    internal class DataSource
    {
        private List<int> _data;

        public DataSource(List<int> data)
        {
            _data = data;
        }

        public List<int> GetValues()
        {
            return _data;
        }

        public void SetValues(List<int> data)
        {
            _data = data;
        }

    }
}
