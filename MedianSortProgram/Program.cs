using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedianSortProgram.Classes;
using MedianSortProgram.Service;

namespace MedianSortProgram
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Pixel[,] image = new Pixel[5, 5]
            {
            { new Pixel(10, 20, 30), new Pixel(40, 50, 60), new Pixel(70, 80, 90), new Pixel(100, 110, 120), new Pixel(130, 140, 150) },
            { new Pixel(15, 25, 35), new Pixel(45, 55, 65), new Pixel(75, 85, 95), new Pixel(105, 115, 125), new Pixel(135, 145, 155) },
            { new Pixel(20, 30, 40), new Pixel(50, 60, 70), new Pixel(80, 90, 100), new Pixel(110, 120, 130), new Pixel(140, 150, 160) },
            { new Pixel(25, 35, 45), new Pixel(55, 65, 75), new Pixel(85, 95, 105), new Pixel(115, 125, 135), new Pixel(145, 155, 165) },
            { new Pixel(30, 40, 50), new Pixel(60, 70, 80), new Pixel(90, 100, 110), new Pixel(120, 130, 140), new Pixel(150, 160, 170) }
            };

            ImageProcessor processor = new ImageProcessor();
            Pixel[,] filteredImage = processor.MedianFilter(image);

            Console.WriteLine("Отфильтрованное изображение:");
            for (int x = 0; x < filteredImage.GetLength(0); x++)
            {
                for (int y = 0; y < filteredImage.GetLength(1); y++)
                {
                    Console.Write($"({filteredImage[x, y].Red}, {filteredImage[x, y].Green}, {filteredImage[x, y].Blue}) ");
                }
                Console.WriteLine();
            }
        }
    }
}
