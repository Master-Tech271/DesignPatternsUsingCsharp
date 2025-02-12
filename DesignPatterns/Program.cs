


using DesignPatterns.SingletonDesignPattern;

public class Program
{
    public static void Main(String[] args)
    {
        //SingletonDesignPattern();
        MementoBadExample();
    }

    private static void MementoBadExample()
    {
        //DesignPatterns.BehaviouralDesignPatterns.MementoDesignPattern.BadExample.Run run = new();
        //DesignPatterns.BehaviouralDesignPatterns.MementoDesignPattern.GoodExample.Run run2 = new();

        // DesignPatterns.BehaviouralDesignPatterns.StateDesignPattern.GoodExample.Run statePattern = new();
        // DesignPatterns.BehaviouralDesignPatterns.StrategyDesignPattern.GoodExample.Run strategyPattern = new();
        //DesignPatterns.BehaviouralDesignPatterns.IterationDesignPattern.GoodExample.Run iteratorPattern = new();
        //DesignPatterns.BehaviouralDesignPatterns.ObserverDesignPattern.GoodExample.Run observerDesignPattern = new();
        //DesignPatterns.BehaviouralDesignPatterns.CommandDesignPattern.GoodExample.Run remoteControl = new();
        DesignPatterns.BehaviouralDesignPatterns.CommandDesignPattern.Undoable.Run undoable = new();
    }

    private static void SingletonDesignPattern()
    {
        Console.WriteLine("Welcome to Design Patterns Examples.\n\n");

        Console.WriteLine("Singleton Desing Pattern -:");
        SingletonDesignPattern singletonDesignPattern = new SingletonDesignPattern();
    }
}