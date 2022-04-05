using SkiaSharp;

namespace MystifySharp.Model;

public struct PolyWireSnapshot
{
    public SKColor Color { get; init; }
    public SKPoint[] Points { get; init; }

    public void Draw(SKCanvas canvas)
    {
        SKPaint paint = new()
        {
            Color = Color,
            IsAntialias = true,
            StrokeWidth = 1,
            Style = SKPaintStyle.Stroke,
        };

        SKPath path = new();
        path.MoveTo(Points[0]);
        for (int i = 1; i < Points.Length; i++)
            path.LineTo(Points[i]);
        path.Close();

        canvas.DrawPath(path, paint);
    }
}
