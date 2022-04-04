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
        private bool Proceed = false;
        public int CurrentFrame { get; private set; } = 0;
        public int TotalFrames { get; private set; } = 0;

        public EventHandler? RenderingComplete;
        public EventHandler? RenderingNewFrame;

        public SKVideoMaker(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public void Cancel()
        {
            Proceed = false;
        }

        public async Task RenderAsync(int frameCount)
        {
            var frames = CreateFrames(frameCount);
            var videoFramesSource = new RawVideoPipeSource(frames) { FrameRate = 30 };
            Proceed = true;
            await FFMpegArguments
               .FromPipeInput(videoFramesSource)
               .OutputToFile("output.webm", overwrite: true, options => options.WithVideoCodec("libvpx-vp9"))
               .ProcessAsynchronously();
            Proceed = false;
        }

        private IEnumerable<IVideoFrame> CreateFrames(int count)
        {
            TotalFrames = count;

            Model.Field field = new();
            field.Reset(100, Width, Height);

            for (int i = 0; i < count; i++)
            {
                if (!Proceed)
                    break;

                CurrentFrame = i + 1;
                RenderingNewFrame?.Invoke(this, EventArgs.Empty);
                using SKBitmap bmp = new(Width, Height);
                using SKCanvas canvas = new(bmp);
                field.Advance(1, Width, Height);
                field.Draw(canvas);
                using SKBitmapFrame frame = new(bmp);
                yield return frame;
            }

            RenderingComplete?.Invoke(this, EventArgs.Empty);
        }
    }
}
