using SkiaSharp;

namespace MystifySharp;

public interface IFrameGenerator
{
    public SKBitmap Bitmap { get; }
    public SKVideoFrame GetNextFrame();
}
