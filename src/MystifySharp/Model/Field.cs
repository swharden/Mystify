using SkiaSharp;

namespace MystifySharp.Model;

public class Field
{
    readonly List<Particle> Particles = new();

    public void Reset(int count, float width, float height)
    {
        Random rand = new();
        Particles.Clear();
        for (int i = 0; i < count; i++)
        {
            Particle p = new()
            {
                X = (float)rand.NextDouble() * width,
                Y = (float)rand.NextDouble() * height,
                VelocityX = (float)(rand.NextDouble() - .5) * 5 + 1,
                VelocityY = (float)(rand.NextDouble() - .5) * 5 + 1,
                Radius = (float)rand.NextDouble() * 10 + 3,
                Color = new SKColor(
                    red: (byte)rand.Next(255),
                    green: (byte)rand.Next(255),
                    blue: (byte)rand.Next(255),
                    alpha: 255),
            };

            Particles.Add(p);
        }
    }

    public void Advance(float timeDelta, int width, int height)
    {
        Particles.ForEach(x => x.Advance(timeDelta, width, height));
    }

    public void Draw(SKCanvas canvas)
    {
        canvas.Clear(SKColor.Parse("#003366"));

        using SKPaint paint = new()
        {
            Style = SKPaintStyle.Fill,
            IsAntialias = true,
        };

        foreach (Particle particle in Particles)
        {
            paint.Color = particle.Color;
            SKPoint pt = new(particle.X, particle.Y);
            canvas.DrawCircle(pt, particle.Radius, paint);
        }
    }
}
