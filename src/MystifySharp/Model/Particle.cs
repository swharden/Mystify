﻿using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MystifySharp.Model
{
    public class Particle
    {
        public float X;
        public float Y;
        public float VelocityX;
        public float VelocityY;
        public float Radius;
        public SKColor Color;

        public void Advance(float timeDelta, float width, float height)
        {
            X += VelocityX * timeDelta;
            Y += VelocityY * timeDelta;

            float overLeft = Radius - X;
            if (overLeft > 0)
            {
                VelocityX = -VelocityX;
                X += overLeft;
            }

            float overRight = X + Radius - width;
            if (overRight > 0)
            {
                VelocityX = -VelocityX;
                X -= overRight;
            }

            float overTop = Radius - Y;
            if (overTop > 0)
            {
                VelocityY = -VelocityY;
                Y += overTop;
            }

            float overBottom = Y + Radius - height;
            if (overBottom > 0)
            {
                VelocityY = -VelocityY;
                Y -= overBottom;
            }
        }
    }
}
