
namespace DesignPatterns.BehaviouralDesignPatterns.IterationDesignPattern.GoodExample
{
    internal class Run
    {
        public Run()
        {
            ShoppingList shoppingList = new ShoppingList();
            shoppingList.Push("Apple");
            shoppingList.Push("Bread");
            shoppingList.Push("Milk");

            IIterator<string> iterator = shoppingList.GetIterator();
            while (iterator.HasNext())
            {
                System.Console.WriteLine(iterator.Current());
                iterator.Next();
            }
        }
    }
}