using SkiaSharp;
using System.Numerics;

namespace MystifySharp.Model
{
    public class PolyWire
    {
        public readonly PolyCorner[] Corners;
        public readonly List<PolyWireSnapshot> Snapshots = new();
        public int MaxSnapshots = 5;
        public double Hue;
        public double ColorChangeSpeed = .001f;
        public bool AntiAlias = true;
        public bool Fade = false;
        public readonly Random Rand;

        public PolyWire(int cornerCount, Random rand)
        {
            Rand = rand;
            Corners = Enumerable
                .Range(0, cornerCount)
                .Select(x => new PolyCorner())
                .ToArray();
        }

        public void RandomizeCorners(float width, float height)
        {
            for (int i = 0; i < Corners.Length; i++)
            {
                SKPoint location = new(
                    x: (float)Rand.NextDouble() * width,
                    y: (float)Rand.NextDouble() * height);

                Vector2 velocity = new(
                    x: PolyCorner.RandomVelocity(Rand),
                    y: PolyCorner.RandomVelocity(Rand));

                Corners[i] = new PolyCorner()
                {
                    Location = location,
                    Velocity = velocity
                };
            }
        }

        public void Advance(float delta, float width, float height)
        {
            for (int i = 0; i < Corners.Length; i++)
                Corners[i] = Corners[i].WithAdvancement(Rand, delta, width, height);

            Hue += ColorChangeSpeed / 1000.0;

            PolyWireSnapshot snapshot = new()
            {
                Points = Corners.Select(x => x.Location).ToArray(),
                Color = RainbowColor(Hue),
            };

            Snapshots.Add(snapshot);
            while (Snapshots.Count > MaxSnapshots)
                Snapshots.RemoveAt(0);
        }

        public void Draw(SKCanvas canvas)
        {
            for (int i = 0; i < Snapshots.Count; i++)
            {
                float frac = (float)(i + 1) / Snapshots.Count;
                byte alpha = (byte)(frac * 255);
                Snapshots[i].Draw(canvas, AntiAlias, alpha);
            }
        }

        public static SKColor RainbowColor(double h)
        {
            h %= 1;
            double s = 1;
            double l = .5;
            double v;
            double r, g, b;

            r = l;
            g = l;
            b = l;
            v = (l <= 0.5)
                ? (l * (1.0 + s))
                : (l + s - l * s);

            if (v > 0)
            {
                double m;
                double sv;
                int sextant;
                double fract, vsf, mid1, mid2;

                m = l + l - v;
                sv = (v - m) / v;
                h *= 6.0;
                sextant = (int)h;
                fract = h - sextant;
                vsf = v * sv * fract;
                mid1 = m + vsf;
                mid2 = v - vsf;
                switch (sextant)
                {
                    case 0:
                        r = v;
                        g = mid1;
                        b = m;
                        break;
                    case 1:
                        r = mid2;
                        g = v;
                        b = m;
                        break;
                    case 2:
                        r = m;
                        g = v;
                        b = mid1;
                        break;
                    case 3:
                        r = m;
                        g = mid2;
                        b = v;
                        break;
                    case 4:
                        r = mid1;
                        g = m;
                        b = v;
                        break;
                    case 5:
                        r = v;
                        g = m;
                        b = mid2;
                        break;
                }
            }

            return new SKColor(
                red: Convert.ToByte(r * 255.0f),
                green: Convert.ToByte(g * 255.0f),
                blue: Convert.ToByte(b * 255.0f));
        }
    }
}
