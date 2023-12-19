using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double Length
        {
            get => length;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"Length cannot be zero or negative.");
                }

                length = value;
            }
        }

        public double Width
        {
            get => width;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"Width cannot be zero or negative.");
                }

                width = value;
            }
        }
        public double Height
        {
            get => height;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"Height cannot be zero or negative.");
                }

                height = value;
            }
        }

        public double SurfaceArea()
        {
            //SA = 2lw+2lh+2hw
            return 2 * (Length * Width) + 2 * (Length * Height) + 2 * (Height * Width);
        }

        public double LateralSurfaceArea()
        {
            //2h(l + w)
            return 2 * Height*(Length + Width);
        }

        public double Volume()
        {
            return Height * Length * Width;
        }
    }
}
