using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedianSortProgram.Classes;

namespace MedianSortProgram.Service
{
    internal class ImageProcessor
    {
        public Pixel[,] MedianFilter(Pixel[,] input)
        {
            int width = input.GetLength(0);
            int height = input.GetLength(1);
            Pixel[,] output = new Pixel[width, height];

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    output[x, y] = GetMedianPixel(input, x, y, width, height);
                }
            }

            return output;
        }

        private Pixel GetMedianPixel(Pixel[,] input, int x, int y, int width, int height)
        {
            byte[] reds = new byte[9];
            byte[] greens = new byte[9];
            byte[] blues = new byte[9];
            int count = 0;

            for (int dx = -1; dx <= 1; dx++)
            {
                for (int dy = -1; dy <= 1; dy++)
                {
                    int nx = x + dx;
                    int ny = y + dy;

                    if (nx >= 0 && nx < width && ny >= 0 && ny < height)
                    {
                        reds[count] = input[nx, ny].Red;
                        greens[count] = input[nx, ny].Green;
                        blues[count] = input[nx, ny].Blue;
                        count++;
                    }
                }
            }

            Array.Sort(reds, 0, count);
            Array.Sort(greens, 0, count);
            Array.Sort(blues, 0, count);

            return new Pixel(reds[count / 2], greens[count / 2], blues[count / 2]);
        }
    }
}
