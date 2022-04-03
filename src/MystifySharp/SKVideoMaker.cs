using FFMpegCore;
using FFMpegCore.Pipes;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MystifySharp
{
    public class SKVideoMaker
    {
        readonly int Width;
        readonly int Height;
        public int CurrentFrame { get; private set; } = 0;
        public int TotalFrames { get; private set; } = 0;

        public EventHandler? RenderingComplete;
        public EventHandler? RenderingNewFrame;

        public SKVideoMaker(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public async Task RenderAsync(int frameCount)
        {
            var frames = CreateFrames(frameCount, width: 400, height: 300);
            var videoFramesSource = new RawVideoPipeSource(frames) { FrameRate = 30 };
            await FFMpegArguments
               .FromPipeInput(videoFramesSource)
               .OutputToFile("output.webm", overwrite: true, options => options.WithVideoCodec("libvpx-vp9"))
               .ProcessAsynchronously();
        }

        private IEnumerable<IVideoFrame> CreateFrames(int count, int width, int height)
        {
            TotalFrames = count;

            Model.Field field = new();
            field.Reset(100, width, height);

            for (int i = 0; i < count; i++)
            {
                CurrentFrame = i + 1;
                RenderingNewFrame?.Invoke(this, EventArgs.Empty);
                using SKBitmap bmp = new(width, height);
                using SKCanvas canvas = new(bmp);
                field.Advance(1, width, height);
                field.Draw(canvas);
                using SKBitmapFrame frame = new(bmp);
                yield return frame;
            }

            RenderingComplete?.Invoke(this, EventArgs.Empty);
        }
    }
}
