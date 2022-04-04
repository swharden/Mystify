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
    public class SKVideoMaker : IDisposable
    {
        private bool Proceed = false;
        public int CurrentFrame { get; private set; } = 0;
        public int TotalFrames { get; private set; } = 0;

        public EventHandler? RenderingComplete;
        public EventHandler? RenderingNewFrame;

        public readonly SKBitmap Bmp;
        public readonly SKCanvas Canvas;

        public SKVideoMaker(int width, int height)
        {
            Bmp = new(width, height);
            Canvas = new(Bmp);
        }

        public void Dispose()
        {
            Canvas.Dispose();
            Bmp.Dispose();
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
            field.Reset(100, Bmp.Width, Bmp.Height);

            using SKFont timeCodeFont = new(SKTypeface.FromFamilyName("consolas"), size: 32);
            using SKPaint timeCodePaint = new(timeCodeFont) { Color = SKColors.Yellow, TextAlign = SKTextAlign.Left, IsAntialias = true };

            for (int i = 0; i < count; i++)
            {
                if (!Proceed)
                    break;

                CurrentFrame = i + 1;
                RenderingNewFrame?.Invoke(this, EventArgs.Empty);
                field.Advance(1, Bmp.Width, Bmp.Height);
                field.Draw(Canvas);
                Canvas.DrawText($"Frame {i:N0}", 10, 35, timeCodePaint);
                yield return new SKBitmapFrame(Bmp);
            }

            RenderingComplete?.Invoke(this, EventArgs.Empty);
        }
    }
}
