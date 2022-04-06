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
        public readonly int FPS;
        public readonly int FrameCount;
        public int CurrentFrame { get; private set; }
        public string Status { get; private set; } = string.Empty;

        private bool Abort = false;
        public readonly IFrameGenerator Model;
        private readonly System.Diagnostics.Stopwatch Stopwatch = new();

        public SKVideoMaker(IFrameGenerator model, int frameCount, int fps)
        {
            Model = model;
            FrameCount = frameCount;
            FPS = fps;
        }

        public async Task RenderAsync_WebM(string filename)
        {
            if (!filename.EndsWith(".webm"))
                throw new ArgumentException(".webm extension required");

            await RenderAsync(filename, "libvpx-vp9");
        }

        public async Task RenderAsync_X264(string filename)
        {
            if (!filename.EndsWith(".mp4"))
                throw new ArgumentException(".mp4 extension required");

            await RenderAsync(filename, "libx264");
        }

        public async Task RenderAsync_MP4(string filename)
        {
            if (!filename.EndsWith(".mp4"))
                throw new ArgumentException(".mp4 extension required");

            await RenderAsync(filename, "mpeg4");
        }

        private async Task RenderAsync(string filename, string codec)
        {
            Stopwatch.Restart();
            Abort = false;
            Status = $"starting renderer";
            System.Diagnostics.Debug.WriteLine(Status);
            var videoFramesSource = new RawVideoPipeSource(CreateFrames()) { FrameRate = FPS };
            await FFMpegArguments
               .FromPipeInput(videoFramesSource)
               .OutputToFile(filename, overwrite: true, options => options
                   .WithVideoCodec(codec))
               .ProcessAsynchronously();
            Status = $"render completed in {Stopwatch.Elapsed}";
        }

        public void Cancel() => Abort = true;

        private IEnumerable<IVideoFrame> CreateFrames()
        {
            DateTime LastFrameTime = DateTime.Now;
            List<double> FrameRenderTimes = new();

            for (int i = 0; i < FrameCount; i++)
            {
                if (Abort)
                    break;

                if (i > 0)
                {
                    TimeSpan frameTime = DateTime.Now - LastFrameTime;
                    FrameRenderTimes.Add(frameTime.TotalSeconds);
                    while (FrameRenderTimes.Count > 10)
                        FrameRenderTimes.RemoveAt(0);
                    double meanFrameTime = FrameRenderTimes.Sum() / FrameRenderTimes.Count;
                    double meanFps = 1.0 / meanFrameTime;
                    Status = $"Rendering {i + 1:N0} of {FrameCount:N0} ({meanFps:N3} fps)";
                    LastFrameTime = DateTime.Now;
                }

                CurrentFrame = i + 1;

                yield return Model.GetNextFrame();
            }

            Status = Abort ? "rendering cancelled" : "rendering complete";
        }
    }
}
