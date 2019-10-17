using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module2_4
{
    abstract class Figure
    {
        public abstract string Area();
        public abstract string Perimeter();
        public abstract string ShapeName();

        public void ShowInfo()
        {
            Console.WriteLine(
                $"Фигура: {ShapeName()}\n" +
                $"Площадь: {Area()}\n" +
                $"Периметр: {Perimeter()}"
                );
            Console.WriteLine();
        }
    }

    class Triangle : Figure
    {
        double sideA, sideB, sideC;   // Стороны треугольника

        // Конструктор
        public Triangle(double triangleSideA, double triangleSideB, double triangleSideC)
        {
            SideA = triangleSideA;
            SideB = triangleSideB;
            SideC = triangleSideC;
        }

        // Свойство, проверяем значение на отрицательность.
        // Если значение отрицательное меняем его на аналогичное положительное.
        public double SideA
        {
            get { return sideA; }
            set { sideA = value < 0 ? -value : value; }
        }

        public double SideB
        {
            get { return sideB; }
            set { sideB = value < 0 ? -value : value; }
        }

        public double SideC
        {
            get { return sideC; }
            set { sideC = value < 0 ? -value : value; }
        }

        // Метод для вычисления площади треугольника
        public override string Area()
        {
            double semPer = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(semPer * (semPer - sideA) * (semPer - sideB) * (semPer - sideC)).ToString();
        }

        // Метод для вычисления периметра треугольника
        public override string Perimeter()
        {
            return (sideA + sideB + sideC).ToString();
        }

        // Метод возвращающий наименование фигуры
        public override string ShapeName()
        {
            return "Треугольник";
        }
    }

    class Circle : Figure
    {
        public const double PI = 3.14159265358979;
        double rad;   // Радиус круга

        // Конструктор
        public Circle(double circleRad)
        {
            rad = circleRad;
        }

        // Свойство, проверяем значение на отрицательность.
        public double Rad
        {
            get { return rad; }
            set { rad = value < 0 ? -value : value; }
        }

        // Метод для вычисления площади круга
        public override string Area()
        {
            return (PI * rad * rad).ToString();
        }

        // Метод для вычисления периметра круга
        public override string Perimeter()
        {
            return (PI * rad * 2).ToString();
        }

        // Метод возвращающий наименование фигуры
        public override string ShapeName()
        {
            return "Круг";
        }
    }

    class Rectangle : Figure
    {
        double width;   // Ширина прямоугольника
        double height;   // Высота прямоугольника

        // Конструктор
        public Rectangle(double rectangleWidth, double rectangleHeight)
        {
            Width = rectangleWidth;
            Height = rectangleHeight;
        }

        // Свойство, проверяем значение на отрицательность.
        public double Width
        {
            get { return width; }
            set { width = value < 0 ? -value : value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value < 0 ? -value : value; }
        }

        // Метод для вычисления площади прямоугольника
        public override string Area()
        {
            return (width * height).ToString();
        }

        // Метод для вычисления периметра прямоугольника
        public override string Perimeter()
        {
            return (width * 2 + height * 2).ToString();
        }

        // Метод возвращающий наименование фигуры
        public override string ShapeName()
        {
            return "Прямоугольник";
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Выберите фигуру и нажмите ссответствующую клавишу: треугольник (1), четырехугольник (2), круг (3)");
            const double PI = 3.14159265358979;
            String f = Console.ReadLine();
            switch (f)
            {
                case "1":
                Console.WriteLine("Выберите, нажав соотв. клавишу, считать площать (1) или периметр (2)");
                string v1 = Console.ReadLine();
                    switch (v1)
                    {
                        case "1":
                            Console.WriteLine("Введите длину первой стороны треугольника: ");
                            double a1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите длину второй стороны треугольника: ");
                            double b1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите длину третьей стороны треугольника: ");
                            double c1 = Convert.ToDouble(Console.ReadLine());
                            double Per1 = (a1 + b1 + c1) / 2;
                            string s1 = Math.Sqrt(Per1 * (Per1 - a1) * (Per1 - b1) * (Per1 - c1)).ToString();
                            Console.WriteLine("Площадь треугольника равна " + s1);
                            Console.WriteLine("А вот возможные параметры других фигур:");
                            Figure figure2 = new Circle(a1);
                            figure2.ShowInfo();
                            Figure figure3 = new Rectangle(a1, b1);
                            figure3.ShowInfo();
                            Console.WriteLine("*При условии, что радиус круга равен первой стороне треугольника, а стороны прямоугольника равны первым двум сторонам треугольника.");
                            break;
                        case "2":
                            Console.WriteLine("Введите длину первой стороны треугольника: ");
                            double a2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите длину второй стороны треугольника: ");
                            double b2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите длину третьей стороны треугольника: ");
                            double c2 = Convert.ToDouble(Console.ReadLine());
                            string s2 = (a2 + b2 +c2).ToString();
                            Console.WriteLine("Периметр треугольника равен " + s2);
                            Console.WriteLine("А вот возможные параметры других фигур:");
                            Figure figure4 = new Circle(5);
                            figure4.ShowInfo();
                            Figure figure5 = new Rectangle(5, 6);
                            figure5.ShowInfo();
                            Console.WriteLine("*При условии, что радиус круга равен первой стороне треугольника, а стороны прямоугольника равны первым двум сторонам треугольника.");
                            break;
                    }
                    break;
                 case "2":
                 Console.WriteLine("Выберите, нажав соотв. клавишу, считать площать (1) или периметр (2)");
                 string v2 = Console.ReadLine();
                    switch (v2)
                    {
                        case "1":
                            Console.WriteLine("Введите длину первой стороны прямоугольника: ");
                            double a1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите длину второй стороны прямоугольника: ");
                            double b1 = Convert.ToDouble(Console.ReadLine());
                            string s1 = (a1 * b1).ToString();
                            Console.WriteLine("Площадь четырехугольника равна " + s1);
                            Console.WriteLine("А вот возможные параметры других фигур:");
                            Figure figure2 = new Circle(a1);
                            figure2.ShowInfo();
                            Figure figure3 = new Triangle(a1, a1, a1);
                            figure3.ShowInfo();
                            Console.WriteLine("*При условии, что радиус круга равен первой стороне прямоугольника, а стороны треугольника равны первой стороне прямоугольника.");
                        break;
                        case "2":
                            Console.WriteLine("Введите длину первой стороны прямоугольника: ");
                            double a2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите длину второй стороны прямоугольника: ");
                            double b2 = Convert.ToDouble(Console.ReadLine());
                            string s2 = ((a2 + b2) * 2).ToString();
                            Console.WriteLine("Периметр четырехугольника равен " + s2);
                            Console.WriteLine("А вот возможные параметры других фигур:");
                            Figure figure4 = new Circle(a2);
                            figure4.ShowInfo();
                            Figure figure5 = new Triangle(a2, a2, a2);
                            figure5.ShowInfo();
                            Console.WriteLine("*При условии, что радиус круга равен первой стороне прямоугольника, а стороны треугольника равны первой стороне прямоугольника.");
                        break;
                    }
                break;
                case "3":
                Console.WriteLine("Выберите, нажав соотв. клавишу, считать площать (1) или периметр (2)");
                string v3 = Console.ReadLine();
                    switch (v3)
                    {
                        case "1":
                            Console.WriteLine("Введите радиус окружности: ");
                            double a1 = Convert.ToDouble(Console.ReadLine());
                            string s1 = (PI * PI * a1).ToString();
                            Console.WriteLine("Площадь круга равна " + s1);
                            Console.WriteLine("А вот возможные параметры других фигур:");
                            Figure figure2 = new Rectangle(a1, a1);
                            figure2.ShowInfo();
                            Figure figure3 = new Triangle(a1, a1, a1);
                            figure3.ShowInfo();
                            Console.WriteLine("*При условии, строны трехугольника и черытехугольника равны радиусу круга.");
                        break;
                        case "2":
                            Console.WriteLine("Введите радиус окружности: ");
                            double a2 = Convert.ToDouble(Console.ReadLine());
                            string s2 = (2 * PI * a2).ToString();
                            Console.WriteLine("Периметр круга равен " + s2);
                            Console.WriteLine("А вот возможные параметры других фигур:");
                            Figure figure4 = new Rectangle(a2, a2);
                            figure4.ShowInfo();
                            Figure figure5 = new Triangle(a2, a2, a2);
                            figure5.ShowInfo();
                            Console.WriteLine("*При условии, строны трехугольника и черытехугольника равны радиусу круга.");
                        break;
                    }
                break;
        }
        Console.WriteLine("Ну все, хорош уже.");
        Console.ReadKey();
        }
    }
}
