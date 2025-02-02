
namespace DesignPatterns.BehaviouralDesignPatterns.StrategyDesignPattern.GoodExample
{
    public class VideoStorage
    {
        private ICompressor _compressor;
        private IOverlay _overlay;

        public VideoStorage(ICompressor compressor, IOverlay overlay)
        {
            _compressor = compressor;
            _overlay = overlay;
        }

        public void SetCompressor(ICompressor compressor){
            _compressor = compressor;
        }

        public void SetOverlay(IOverlay overlay){
            _overlay = overlay;
        }

        public void Store(string fileName)
        {
            _compressor.Execute(fileName);
            _overlay.Execute(fileName);

            System.Console.WriteLine($"Saving file: {fileName}");
        }
    }
}