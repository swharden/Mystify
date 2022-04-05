using FFMpegCore.Pipes;

namespace MystifySharp;

internal class FrameBytes : IVideoFrame
{
    public int Width { get; private set; }
    public int Height { get; private set; }
    public string Format => "bgra";
    private readonly byte[] Bytes;

    public FrameBytes(byte[] bytes) =>
        Bytes = bytes;

    public void Serialize(Stream stream) =>
        stream.Write(Bytes);

    public async Task SerializeAsync(Stream stream, CancellationToken token) =>
        await stream.WriteAsync(Bytes, token).ConfigureAwait(false);
}