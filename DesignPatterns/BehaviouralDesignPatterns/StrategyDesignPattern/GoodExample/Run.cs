
namespace DesignPatterns.BehaviouralDesignPatterns.StrategyDesignPattern.GoodExample
{
    internal class Run
    {
        private readonly string _fileName = "C:\\video-folder\\video1";
        public Run()
        {
            var videoStorage = new VideoStorage(new CompressorMP4(), new OverlayBlur());
            
            videoStorage.Store(_fileName);

            videoStorage.SetCompressor(new CompressorMOV());
            videoStorage.Store(_fileName);
        }
    }
}