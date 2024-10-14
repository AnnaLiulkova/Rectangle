using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть координати першої вершини (x1, y1)");
            (double x1, double y1) = InputCoordinates();

            Console.WriteLine("Введіть координати другої вершини (x2, y2):");
            (double x2, double y2) = InputCoordinates();

            Rectangle rect = new Rectangle(x1, y1, x2, y2);

            rect.Display();
        }

        static (double, double) InputCoordinates()
        {
            try
            {
                string input = Console.ReadLine();
                string[] parts = input.Trim('(', ')').Split(',');

                if (parts.Length != 2)
                {
                    throw new ArgumentException("Невірний формат введення. Введіть координати у форматі (x, y).");
                }

                //double x = Convert.ToDouble(parts[0].Trim());
                //double y = Convert.ToDouble(parts[1].Trim());
                double x = Convert.ToDouble(parts[0].Trim(), CultureInfo.InvariantCulture);
                double y = Convert.ToDouble(parts[1].Trim(), CultureInfo.InvariantCulture);

                return (x, y);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Сталася помилка: " + e.Message);
                Environment.Exit(1); // завершення програми
                return (0, 0);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Сталася помилка: " + e.Message);
                Environment.Exit(1);
                return (0, 0);
            }
        }
    }
}