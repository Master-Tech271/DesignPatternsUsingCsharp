namespace DesignPatterns.BehaviouralDesignPatterns.StrategyDesignPattern.GoodExample
{
    public class OverlayBlackAndWhite : IOverlay
    {
        public void Execute(string fileName)
        {
            System.Console.WriteLine($"Overlaying Black and White on file: {fileName}");
        }
    }
}