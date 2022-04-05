using SkiaSharp;
using System.Numerics;

namespace MystifySharp.Model;

// TODO: allow mutation
public struct PolyCorner
{
    public SKPoint Location { get; init; }
    public Vector2 Velocity { get; init; }

    public static float RandomPositiveVelocity(Random rand)
    {
        return (float)rand.NextDouble() * 15 + 2;
    }

    public static float RandomVelocity(Random rand)
    {
        float pos = RandomPositiveVelocity(rand);
        return (rand.NextDouble() > .5) ? pos : -pos;
    }

    public PolyCorner WithAdvancement(Random rand, float delta, float width, float height)
    {
        float x = Location.X + Velocity.X * delta;
        float y = Location.Y + Velocity.Y * delta;
        float xVel = Velocity.X;
        float yVel = Velocity.Y;

        float overLeft = -x;
        if (overLeft > 0)
        {
            //xVel = -xVel;
            xVel = RandomPositiveVelocity(rand);
            x += overLeft;
        }

        float overRight = x - width;
        if (overRight > 0)
        {
            //xVel = -xVel;
            xVel = -RandomPositiveVelocity(rand);
            x -= overRight;
        }

        if (y < 0)
        {
            //yVel = -yVel;
            yVel = RandomPositiveVelocity(rand);
            y -= y;
        }

        if (y > height)
        {
            //yVel = -yVel;
            yVel = -RandomPositiveVelocity(rand);
            y += height - y;
        }

        return new PolyCorner()
        {
            Location = new SKPoint(x, y),
            Velocity = new Vector2(xVel, yVel),
        };
    }
}
