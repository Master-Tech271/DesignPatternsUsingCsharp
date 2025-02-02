namespace DesignPatterns.BehaviouralDesignPatterns.StrategyDesignPattern.GoodExample
{
    public class CompressorMOV : ICompressor
    {
        public void Execute(string fileName)
        {
            System.Console.WriteLine($"Compressing file by using MOV : {fileName}");
        }
    }
}