namespace DesignPatterns.BehaviouralDesignPatterns.StrategyDesignPattern.GoodExample
{
    public class CompressorMP4 : ICompressor
    {
        public void Execute(string fileName)
        {
            System.Console.WriteLine($"Compressing file by using MP4: {fileName}");
        }
    }
}