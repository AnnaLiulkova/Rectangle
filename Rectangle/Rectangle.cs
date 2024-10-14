using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    public class Rectangle
    {
        private double x1_;
        private double y1_;
        private double x2_;
        private double y2_;

        public void CheckingRectangleVertices(double x1, double y1, double x2, double y2)
        {
            if (x1 == x2 && y1 == y2)
            {
                throw new ArgumentException("Ці вершини однакові.");
            }
            if (x1 == x2 || y1 == y2)
            {
                throw new ArgumentException("Вершини знаходяться на одній осі.");
            }
        }

        public double X1 //властивості 
        {
            get { return x1_; }
            set { x1_ = value; }
        }
        public double Y1
        {
            get { return y1_; }
            set { y1_ = value; }
        }

        public double X2
        {
            get { return x2_; }
            set { x2_ = value; }
        }
        public double Y2
        {
            get { return y2_; }
            set { y2_ = value; }
        }
        public Rectangle(double x1, double y1, double x2, double y2) // конструктор
        {
            CheckingRectangleVertices(x1, y1, x2, y2);
            this.x1_ = x1;
            this.y1_ = y1;
            this.x2_ = x2;
            this.y2_ = y2;
        }

        public double this[int index]
        {
            get
            {
                if (index < 0 || index >= 2)
                {
                    throw new IndexOutOfRangeException("Індекс виходить за межі масиву сторін.");
                }
                else
                {
                    switch (index)
                    {
                        case 0:
                            return Math.Abs(x2_ - x1_); // Сторона a
                        case 1:
                            return Math.Abs(y2_ - y1_); // Сторона b
                        default:
                            throw new IndexOutOfRangeException();
                    }
                }

                //if (index < 0 || index >= 2)
                //{
                //    throw new IndexOutOfRangeException("Індекс виходить за межі масиву сторін.");
                //}
                //return index == 0 ? Math.Abs(x2_ - x1_) : Math.Abs(y2_ - y1_);
            }
        }

        public double Perimeter()
        {
            return 2 * (this[0] + this[1]);
        }

        public double Area()
        {
            return this[0] * this[1];
        }

        public void Display()
        {
            Console.WriteLine("Координати вершин прямокутника:");
            Console.WriteLine($"({x1_}, {y1_}), ({x2_}, {y2_})");
            Console.WriteLine($"Сторона a: {this[0]}");
            Console.WriteLine($"Сторона b: {this[1]}");
            Console.WriteLine($"Периметр: {Perimeter()}");
            Console.WriteLine($"Площа: {Area()}");
        }
    }
}