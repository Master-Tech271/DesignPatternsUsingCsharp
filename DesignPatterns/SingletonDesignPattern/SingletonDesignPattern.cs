using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SingletonDesignPattern
{
    public class SingletonDesignPattern
    {
        public SingletonDesignPattern() { Init(); }

        public void Init()
        {
            //SingletonClass instance = new SingletonClass();
            Parallel.Invoke(
                () => {
                    SingletonClass instance2 = SingletonClass.GetInstance();
                },
                () => {
                    SingletonClass instance3 = SingletonClass.GetInstance();
                }
                );
            //that's why we need to create singleton class with sealed keyword so that it inaccessible for inherit
            //SingletonClass instance4 = new SingletonClass.DerivedSingletonClass();

            //check count
            int instanceCount = SingletonClass.GetInstanceCounter();
            Console.WriteLine($"SingletonClass instance count is : '{instanceCount}'");
        }
    }
}
