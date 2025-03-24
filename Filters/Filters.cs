using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace Filters
{
    public abstract class Filters
    {
        protected abstract Color CalculateNewColor(Bitmap srcImage, int x, int y);


        public Bitmap ProcessImage(Bitmap srcImage, BackgroundWorker worker, int progressOffset, int progressScale)
        {
            Bitmap result = new Bitmap(srcImage.Width, srcImage.Height);
            for (int x = 0; x < srcImage.Width; x++)
            {
                int overallProgress = progressOffset + (int)(((double)x / srcImage.Width) * progressScale);
                worker.ReportProgress(overallProgress);
                if (worker.CancellationPending)
                    return null;
                for (int y = 0; y < srcImage.Height; y++)
                {
                    result.SetPixel(x, y, CalculateNewColor(srcImage, x, y));
                }
            }

            return result;
        }

        public int Clamp(int value, int min, int max)
        {
            if (value < min)
            {
                return min;
            }

            if (value > max)
            {
                return max;
            }

            return value;
        }
    }

    // Точечные
    public class InvertFilter : Filters
    {
        protected override Color CalculateNewColor(Bitmap srcImage, int x, int y)
        {
            Color srcCol = srcImage.GetPixel(x, y);
            Color resCol = Color.FromArgb(255 - srcCol.R, 255 - srcCol.G, 255 - srcCol.B);

            return resCol;
        }
    }

    public class GrayScaleFilter : Filters
    {
        protected override Color CalculateNewColor(Bitmap srcImage, int x, int y)
        {
            Color srcCol = srcImage.GetPixel(x, y);

            int intensity = (int)(0.299 * srcCol.R + 0.587 * srcCol.G + 0.114 * srcCol.B);

            Color resultColor = Color.FromArgb(intensity, intensity, intensity);

            return resultColor;
        }
    }

    public class SepiyaFilter : Filters
    {
        private const int K = 20;

        protected override Color CalculateNewColor(Bitmap srcImage, int x, int y)
        {
            Color srcCol = srcImage.GetPixel(x, y);
            int intensity = (int)(0.299 * srcCol.R + 0.587 * srcCol.G + 0.114 * srcCol.B);

            int r = Clamp(intensity + 2 * K, 0, 255);
            int g = Clamp(intensity + (int)(0.5 * K), 0, 255);
            int b = Clamp(intensity - K, 0, 255);

            Color newCol = Color.FromArgb(r, g, b);

            return newCol;
        }
    }

    public class BrightnessFilter : Filters
    {
        private const int K = 50;

        protected override Color CalculateNewColor(Bitmap srcImage, int x, int y)
        {
            Color sourceColor = srcImage.GetPixel(x, y);

            int r = Clamp(sourceColor.R + K, 0, 255);
            int g = Clamp(sourceColor.G + K, 0, 255);
            int b = Clamp(sourceColor.B + K, 0, 255);

            Color newCol = Color.FromArgb(r, g, b);

            return newCol;
        }
    }

    public class MedianFilter : Filters
    {
        private readonly int _windowSize;

        public MedianFilter(int windowSize = 3)
        {
            this._windowSize = windowSize;
        }

        protected override Color CalculateNewColor(Bitmap srcImage, int x, int y)
        {
            int radius = _windowSize / 2;
            List<int> rValues = new List<int>();
            List<int> gValues = new List<int>();
            List<int> bValues = new List<int>();

            for (int dx = -radius; dx <= radius; dx++)
            {
                for (int dy = -radius; dy <= radius; dy++)
                {
                    int px = Clamp(x + dx, 0, srcImage.Width - 1);
                    int py = Clamp(y + dy, 0, srcImage.Height - 1);
                    Color color = srcImage.GetPixel(px, py);
                    rValues.Add(color.R);
                    gValues.Add(color.G);
                    bValues.Add(color.B);
                }
            }

            rValues.Sort();
            gValues.Sort();
            bValues.Sort();
            int medianIndex = rValues.Count / 2;

            return Color.FromArgb(rValues[medianIndex], gValues[medianIndex], bValues[medianIndex]);
        }
    }

    public class MaxFilter : Filters
    {
        private readonly int _windowSize;

        public MaxFilter(int windowSize = 3)
        {
            this._windowSize = windowSize;
        }

        protected override Color CalculateNewColor(Bitmap srcImage, int x, int y)
        {
            int radius = _windowSize / 2;
            int maxR = 0, maxG = 0, maxB = 0;

            for (int dx = -radius; dx <= radius; dx++)
            {
                for (int dy = -radius; dy <= radius; dy++)
                {
                    int px = Clamp(x + dx, 0, srcImage.Width - 1);
                    int py = Clamp(y + dy, 0, srcImage.Height - 1);
                    Color color = srcImage.GetPixel(px, py);
                    maxR = Math.Max(maxR, color.R);
                    maxG = Math.Max(maxG, color.G);
                    maxB = Math.Max(maxB, color.B);
                }
            }

            return Color.FromArgb(maxR, maxG, maxB);
        }
    }

    // Матричные
    public abstract class MatrixFilter : Filters
    {
        protected float[,] Kernel;

        protected MatrixFilter()
        {
        }

        public MatrixFilter(float[,] kernel)
        {
            this.Kernel = kernel;
        }

        protected override Color CalculateNewColor(Bitmap srcImage, int x, int y)
        {
            int radiusX = Kernel.GetLength(0) / 2;
            int radiusY = Kernel.GetLength(1) / 2;

            float resultR = 0;
            float resultG = 0;
            float resultB = 0;

            for (int l = -radiusY; l <= radiusY; l++)
            {
                for (int k = -radiusX; k <= radiusX; k++)
                {
                    int idX = Clamp(x + k, 0, srcImage.Width - 1);
                    int idY = Clamp(y + l, 0, srcImage.Height - 1);

                    Color neighborColor = srcImage.GetPixel(idX, idY);

                    resultR += neighborColor.R * Kernel[k + radiusX, l + radiusY];
                    resultG += neighborColor.G * Kernel[k + radiusX, l + radiusY];
                    resultB += neighborColor.B * Kernel[k + radiusX, l + radiusY];
                }
            }

            return Color.FromArgb(
                Clamp((int)resultR, 0, 255),
                Clamp((int)resultG, 0, 255),
                Clamp((int)resultB, 0, 255)
            );
        }
    }

    public class BlurFilter : MatrixFilter
    {
        public BlurFilter()
        {
            int sizeX = 3;
            int sizeY = 3;

            Kernel = new float[sizeX, sizeY];

            for (int i = 0; i < sizeX; i++)
            {
                for (int j = 0; j < sizeY; j++)
                {
                    Kernel[i, j] = 1.0f / (sizeX * sizeY);
                }
            }
        }
    }

    public class GaussianFilter : MatrixFilter
    {
        private void CreateGaussianKernel(int radius, float sigma)
        {
            int size = 2 * radius + 1;

            Kernel = new float[size, size];

            float norm = 0;

            for (int i = -radius; i <= radius; i++)
            {
                for (int j = -radius; j <= radius; j++)
                {
                    Kernel[i + radius, j + radius] = (float)(Math.Exp(-(i * i + j * j) / (sigma * sigma)));
                    norm += Kernel[i + radius, j + radius];
                }
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Kernel[i, j] /= norm;
                }
            }
        }

        public GaussianFilter()
        {
            CreateGaussianKernel(3, 2);
        }
    }

    public class SharpnessFilter : MatrixFilter
    {
        public SharpnessFilter()
        {
            Kernel = new float[,]
            {
                { 0, -1, 0 },
                { -1, 5, -1 },
                { 0, -1, 0 }
            };
        }
    }

    public class EmbossFilter : MatrixFilter
    {
        public EmbossFilter() : base(new float[,]
        {
            { 0, 1, 0 },
            { 1, 0, -1 },
            { 0, -1, 0 }
        })
        {
        }

        protected override Color CalculateNewColor(Bitmap srcImage, int x, int y)
        {
            int radiusX = Kernel.GetLength(0) / 2;
            int radiusY = Kernel.GetLength(1) / 2;

            float result = 0f;

            for (int l = -radiusY; l <= radiusY; l++)
            {
                for (int k = -radiusX; k <= radiusX; k++)
                {
                    int idX = Clamp(x + k, 0, srcImage.Width - 1);
                    int idY = Clamp(y + l, 0, srcImage.Height - 1);

                    Color neighborColor = srcImage.GetPixel(idX, idY);

                    float intensity = 0.299f * neighborColor.R
                                      + 0.587f * neighborColor.G
                                      + 0.114f * neighborColor.B;

                    result += intensity * Kernel[k + radiusX, l + radiusY];
                }
            }

            result = (result + 255f) / 2f;

            int val = Clamp((int)result, 0, 255);

            return Color.FromArgb(val, val, val);
        }
    }

    class MotionBlurFilter : MatrixFilter
    {
        public MotionBlurFilter()
        {
            int size = 10;

            Kernel = new float[size, size];

            for (int i = 0; i < size; i++)
            {
                Kernel[i, i] = 1.0f / size;
            }
        }
    }

    class Sharpness2Filter : MatrixFilter
    {
        public Sharpness2Filter()
        {
            Kernel = new float[,]
            {
                { -1, -1, -1 },
                { -1, 9, -1 },
                { -1, -1, -1 }
            };
        }
    }

    public abstract class TwoKernelFilter : Filters
    {
        private readonly double[,] _kernelX;
        private readonly double[,] _kernelY;

        protected TwoKernelFilter(double[,] kernelX, double[,] kernelY)
        {
            this._kernelX = kernelX;
            this._kernelY = kernelY;
        }

        protected override Color CalculateNewColor(Bitmap srcImage, int x, int y)
        {
            int width = srcImage.Width;
            int height = srcImage.Height;

            int kernelWidth = _kernelX.GetLength(0);
            int kernelHeight = _kernelX.GetLength(1);
            int radiusX = kernelWidth / 2;
            int radiusY = kernelHeight / 2;

            double sumRx = 0, sumGx = 0, sumBx = 0;
            double sumRy = 0, sumGy = 0, sumBy = 0;

            for (int dx = -radiusX; dx <= radiusX; dx++)
            {
                for (int dy = -radiusY; dy <= radiusY; dy++)
                {
                    int idX = Clamp(x + dx, 0, width - 1);
                    int idY = Clamp(y + dy, 0, height - 1);

                    Color neighborColor = srcImage.GetPixel(idX, idY);

                    double factorX = _kernelX[dx + radiusX, dy + radiusY];
                    double factorY = _kernelY[dx + radiusX, dy + radiusY];

                    sumRx += neighborColor.R * factorX;
                    sumGx += neighborColor.G * factorX;
                    sumBx += neighborColor.B * factorX;

                    sumRy += neighborColor.R * factorY;
                    sumGy += neighborColor.G * factorY;
                    sumBy += neighborColor.B * factorY;
                }
            }

            int r = Clamp((int)Math.Sqrt(sumRx * sumRx + sumRy * sumRy), 0, 255);
            int g = Clamp((int)Math.Sqrt(sumGx * sumGx + sumGy * sumGy), 0, 255);
            int b = Clamp((int)Math.Sqrt(sumBx * sumBx + sumBy * sumBy), 0, 255);

            return Color.FromArgb(r, g, b);
        }
    }

    public class SobelFilter : TwoKernelFilter
    {
        public SobelFilter() : base(
            new double[,]
            {
                { -1, 0, 1 },
                { -2, 0, 2 },
                { -1, 0, 1 }
            },
            new double[,]
            {
                { -1, -2, -1 },
                { 0, 0, 0 },
                { 1, 2, 1 }
            })
        {
        }
    }

    public class SharraFilter : TwoKernelFilter
    {
        public SharraFilter() : base(
            new double[,]
            {
                { 3, 0, -3 },
                { 10, 0, -10 },
                { 3, 0, -3 }
            },
            new double[,]
            {
                { 3, 10, 3 },
                { 0, 0, 0 },
                { -3, -10, -3 }
            })
        {
        }
    }

    public class PruittaFilter : TwoKernelFilter
    {
        public PruittaFilter() : base(
            new double[,]
            {
                { -1, 0, 1 },
                { -1, 0, 1 },
                { -1, 0, 1 }
            },
            new double[,]
            {
                { -1, -1, -1 },
                { 0, 0, 0 },
                { 1, 1, 1 }
            })
        {
        }
    }

    // Движения
    public class MoveFilter : Filters
    {
        protected override Color CalculateNewColor(Bitmap srcImage, int x, int y)
        {
            if (x + 50 < srcImage.Width)
            {
                return srcImage.GetPixel(x + 50, y);
            }

            return Color.FromArgb(0, 0, 0);
        }
    }

    public class RotateFilter : Filters
    {
        private readonly double _phi;

        public RotateFilter(double angleInRadians)
        {
            _phi = angleInRadians;
        }

        protected override Color CalculateNewColor(Bitmap sourceImage, int x, int y)
        {
            int x0 = sourceImage.Width / 2;
            int y0 = sourceImage.Height / 2;

            double dx = x - x0;
            double dy = y - y0;

            int newX = (int)(dx * Math.Cos(_phi) - dy * Math.Sin(_phi)) + x0;
            int newY = (int)(dx * Math.Sin(_phi) + dy * Math.Cos(_phi)) + y0;

            if (newX >= 0 && newX < sourceImage.Width &&
                newY >= 0 && newY < sourceImage.Height)
            {
                return sourceImage.GetPixel(newX, newY);
            }

            return Color.FromArgb(0, 0, 0);
        }
    }

    public class Wave1Filter : Filters
    {
        protected override Color CalculateNewColor(Bitmap sourceImage, int x, int y)
        {
            int newX = x + (int)(20 * Math.Sin(2 * Math.PI * x / 60));
            int newY = y;

            newX = Clamp(newX, 0, sourceImage.Width - 1);
            newY = Clamp(newY, 0, sourceImage.Height - 1);

            return sourceImage.GetPixel(newX, newY);
        }
    }

    public class Wave2Filter : Filters
    {
        protected override Color CalculateNewColor(Bitmap sourceImage, int x, int y)
        {
            int newX = x + (int)(20 * Math.Sin(2 * Math.PI * y / 30));
            int newY = y;

            newX = Clamp(newX, 0, sourceImage.Width - 1);
            newY = Clamp(newY, 0, sourceImage.Height - 1);

            return sourceImage.GetPixel(newX, newY);
        }
    }

    public class GlassFilter : Filters
    {
        private readonly Random _rand = new Random();

        protected override Color CalculateNewColor(Bitmap sourceImage, int x, int y)
        {
            int newX = x + (int)((_rand.NextDouble() - 0.5) * 10);
            int newY = y + (int)((_rand.NextDouble() - 0.5) * 10);

            newX = Clamp(newX, 0, sourceImage.Width - 1);
            newY = Clamp(newY, 0, sourceImage.Height - 1);

            return sourceImage.GetPixel(newX, newY);
        }
    }
}