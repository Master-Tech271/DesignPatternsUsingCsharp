namespace DesignPatterns.BehaviouralDesignPatterns.StrategyDesignPattern.GoodExample
{
    public class OverlayBlur : IOverlay
    {
        public void Execute(string fileName)
        {
            System.Console.WriteLine($"Overlaying blur on file: {fileName}");
        }
    }
}