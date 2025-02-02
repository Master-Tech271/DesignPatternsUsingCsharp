
namespace DesignPatterns.BehaviouralDesignPatterns.IterationDesignPattern.GoodExample
{
    internal class ShoppingList
    {
        private readonly List<string> _list;

        public ShoppingList()
        {
            _list = new List<string>();
        }

        public void Push(string item)
        {
            _list.Add(item);
        }

        public void Pop(string item)
        {
            _list.Remove(item);
        }

        public IIterator<string> GetIterator()
        {
            return new ShoppingListIterator(this);
        }

        private class ShoppingListIterator : IIterator<string>
        {
            private readonly ShoppingList _shoppingList;
            private int _index = 0;

            public ShoppingListIterator(ShoppingList shoppingList)
            {
                _shoppingList = shoppingList;
            }

            public string Current()
            {
                return _shoppingList._list[_index];
            }

            public bool HasNext()
            {
                return _index < _shoppingList._list.Count;
            }

            public void Next()
            {
                _index++;
            }
        }
    }
}