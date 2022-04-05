using FFMpegCore.Pipes;
using SkiaSharp;
namespace MystifySharp;

public class SKVideoFrame : IVideoFrame
{
    public int Width { get; private set; }
    public int Height { get; private set; }
    public string Format { get; private set; }

    public readonly byte[] Bytes;

    public SKVideoFrame(SKBitmap bmp)
    {
        if (bmp.ColorType != SKColorType.Bgra8888)
            throw new NotImplementedException("only 'bgra' color type is supported");
        Format = "bgra";
        Width = bmp.Width;
        Height = bmp.Height;
        Bytes = bmp.Bytes;
    }

    public void Serialize(Stream stream) => stream.Write(Bytes);

    public async Task SerializeAsync(Stream stream, CancellationToken token) =>
        await stream.WriteAsync(Bytes, token).ConfigureAwait(false);
}
