namespace DesignPatterns.BehaviouralDesignPatterns.IterationDesignPattern.GoodExample
{
    internal interface IIterator<T>
    {
        bool HasNext();
        void Next();
        T Current();
    }
}