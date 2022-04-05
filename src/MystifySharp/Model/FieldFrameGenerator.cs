using SkiaSharp;

namespace MystifySharp.Model;

public class FieldFrameGenerator : IFrameGenerator
{
    public SKBitmap Bitmap { get; private set; }
    private readonly Field Field;
    private readonly SKCanvas Canvas;

    public FieldFrameGenerator(int width, int height)
    {
        Field = new Field(width, height);
        Bitmap = new SKBitmap(width, height);
        Canvas = new SKCanvas(Bitmap);
    }

    public SKVideoFrame GetNextFrame()
    {
        Field.Advance();
        Field.Draw(Canvas);
        return new SKVideoFrame(Bitmap);
    }
}
