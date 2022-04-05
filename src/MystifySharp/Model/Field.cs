using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MystifySharp.Model;

internal class Field
{
    private readonly List<PolyWire> Wires = new();

    public float Width { get; private set; }
    public float Height { get; private set; }
    public SKColor BackgroundColor = SKColors.Black;
    public float Speed = 1.0f;

    public Field(float width, float height, int wireCount = 2)
    {
        Resize(width, height);
        Random rand = new();
        for (int i = 0; i < wireCount; i++)
        {
            PolyWire wire = new(4, rand);
            wire.ColorChangeSpeed = .5 + .2 * rand.NextDouble();
            wire.Hue = 255f / wireCount * i;
            wire.RandomizeCorners(width, height);
            Wires.Add(wire);
        }
    }

    private static SKColor[] RandomRainbowColors(Random rand, int count)
    {
        float spacing = 255 / count;
        float offset = (float)rand.NextDouble() * spacing;
        return Enumerable
            .Range(0, count)
            .Select(i => SKColor.FromHsv(offset + spacing * i, 255, 255))
            .ToArray();
    }

    public void Resize(float width, float height)
    {
        Width = width;
        Height = height;
    }

    public void Advance()
    {
        Wires.ForEach(x => x.Advance(Speed, Width, Height));
    }

    public void Draw(SKCanvas canvas)
    {
        canvas.Clear(BackgroundColor);
        Wires.ForEach(x => x.Draw(canvas));
    }
}
