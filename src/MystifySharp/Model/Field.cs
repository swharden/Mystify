using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MystifySharp.Model;

public class Field
{
    private readonly List<PolyWire> Wires = new();

    public float Width { get; private set; }
    public float Height { get; private set; }
    public SKColor BackgroundColor = SKColors.Black;
    public float Speed = 1.0f;
    public int History { set { Wires.ForEach(x => x.MaxSnapshots = value); } }
    public double ColorChangeSpeed { set { Wires.ForEach(x => x.ColorChangeSpeed = value); } }
    public bool AntiAlias { set { Wires.ForEach(x => x.AntiAlias = value); } }
    public bool Fade { set { Wires.ForEach(x => x.Fade = value); } }

    public Field(float width, float height, int wireCount = 2, int cornerCount = 4)
    {
        Resize(width, height);
        Random rand = new();
        for (int i = 0; i < wireCount; i++)
        {
            PolyWire wire = new(cornerCount, rand)
            {
                ColorChangeSpeed = (.5 + .2 * rand.NextDouble()) * 1,
                MaxSnapshots = 7,
                Hue = (double)i / wireCount,
            };
            wire.RandomizeCorners(width, height);
            Wires.Add(wire);
        }
    }

    public void Resize(float width, float height, bool reset = false)
    {
        Width = width;
        Height = height;
        if (reset)
        {
            foreach (PolyWire wire in Wires)
            {
                wire.RandomizeCorners(width, height);
            }
        }
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
