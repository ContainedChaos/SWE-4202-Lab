using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_9__Shapes_
{
    public interface Shapes
    {
        string WhoAmI();
    }

    public class TwoDimensional : Shapes
    {
        public virtual double area(double sideORradius)
        {
            return 1;
        }

        public virtual double area(double length, double breadth)
        {
            return 2;
        }

        public virtual double area(double side1, double side2, double side3)
        {
            return 3;
        }

        public virtual double perimeter(double sideORradius)
        {
            return 4;
        }

        public virtual double perimeter(double length, double breadth)
        {
            return 5;
        }

        public virtual double perimeter(double side1, double side2, double side3)
        {
            return 6;
        }
        public string WhoAmI()
        {
            return "";
        }
    }

    public class ThreeDimensional : Shapes
    {
        public virtual double area(double sideORradius)
        {
            return -1;
        }

        public virtual double area(double radius, double height)
        {
            return -2;
        }

        public virtual double volume(double sideORradius)
        {
            return -3;
        }

        public virtual double volume(double radius, double height)
        {
            return -4;
        }
        public string WhoAmI()
        {
            return "";
        }
    }

    public class Circle : TwoDimensional
    {
        public double radius;

        public Circle (double radius)
        {
            this.radius = radius;
        }

        public override double area(double radius)
        {
            return 3.1416 * radius * radius;
        }

        public override double perimeter(double radius)
        {
            return 2 * 3.1416 * radius;
        }

        public string WhoAmI()
        {
            return "I am a Circle and I am a 2D shape.";
        }
    }

    public class Square : TwoDimensional
    {
        public double side;

        public Square (double side)
        {
            this.side = side;
        }

        public override double area(double side)
        {
            return side * side;
        }

        public override double perimeter(double side)
        {
            return 4 * side;
        }

        public string WhoAmI()
        {
            return "I am a Square and I am a 2D shape.";
        }
    }

    public class Rectangle : TwoDimensional
    {
        public double length;
        public double breadth;

        public Rectangle (double length, double breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }

        public override double area(double length, double breadth)
        {
            return length * breadth;
        }

        public override double perimeter(double length, double breadth)
        {
            return 2 * (length + breadth);
        }

        public string WhoAmI()
        {
            return "I am a Rectangle and I am a 2D shape.";
        }
    }

    public class Triangle : TwoDimensional
    {
        public double side1, side2, side3;

        public Triangle (double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public override double area(double side1, double side2, double side3)
        {
            double s;
            s = (side1 + side2 + side3) / 2;
            return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        }

        public override double perimeter(double side1, double side2, double side3)
        {
            return side1 + side2 + side3;
        }

        public string WhoAmI()
        {
            return "I am a Triangle and I am a 2D shape.";
        }
    }

    public class Cube : ThreeDimensional
    {
        public double side;

        public Cube (double side)
        {
            this.side = side;
        }

        public override double area(double side)
        {
            return 6 * side * side;
        }

        public override double volume(double side)
        {
            return side * side * side;
        }

        public string WhoAmI()
        {
            return "I am a Cube and I am a 3D shape.";
        }
    }

    public class Sphere : ThreeDimensional
    {
        public double radius;

        public Sphere (double radius)
        {
            this.radius = radius;
        }

        public override double area(double radius)
        {
            return 4 * 3.1416 * radius * radius;
        }

        public override double volume(double radius)
        {
            return 1.333 * 3.1416 * radius * radius * radius;
        }

        public string WhoAmI()
        {
            return "I am a Sphere and I am a 3D shape.";
        }
    }

    public class Cylinder : ThreeDimensional
    {
        public double radius, height;

        public Cylinder (double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }

        public override double area(double radius, double height)
        {
            return (2 * 3.1416 * radius * (radius + height));
        }

        public override double volume(double radius, double height)
        {
            return 3.1416 * radius * radius * height;
        }

        public string WhoAmI()
        {
            return "I am a Cylinder and I am a 3D shape.";
        }
    }

    public class Cone : ThreeDimensional
    {
        public double radius, height;

        public Cone (double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }

        public override double area(double radius, double height)
        {
            return (3.1416 * radius * radius) + (3.1416 * radius * Math.Sqrt(radius * radius + height * height));
        }

        public override double volume(double radius, double height)
        {
            return 0.333 * 3.1416 * radius * radius * height;
        }

        public string WhoAmI()
        {
            return "I am a Cone and I am a 3D shape.";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Circle

            Console.WriteLine("Enter radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Circle dummy = new Circle (radius);

            Console.WriteLine("\nArea: " + dummy.area(radius));
            Console.WriteLine("Perimeter: " + dummy.perimeter(radius) + "\n");
            Console.WriteLine((dummy.WhoAmI()) + "\n ----------------------");

            //Square

            Console.WriteLine("Enter side of the square: ");
            double side = Convert.ToDouble(Console.ReadLine());

            Square dummy_sq = new Square(side);

            Console.WriteLine("\nArea: " + dummy_sq.area(side));
            Console.WriteLine("Perimeter: " + dummy_sq.perimeter(side) + "\n");
            Console.WriteLine((dummy_sq.WhoAmI()) + "\n ----------------------");

            //Rectangle

            Console.WriteLine("Enter length and breadth of the rectangle: ");
            double length = Convert.ToDouble(Console.ReadLine());
            double breadth = Convert.ToDouble(Console.ReadLine());

            Rectangle dummy_rec = new Rectangle(length, breadth);

            Console.WriteLine("\nArea: " + dummy_rec.area(length, breadth));
            Console.WriteLine("Perimeter: " + dummy_rec.perimeter(length, breadth) + "\n");
            Console.WriteLine((dummy_rec.WhoAmI()) + "\n ----------------------");

            //Triangle

            Console.WriteLine("Enter sides of the triangle: ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            double side2 = Convert.ToDouble(Console.ReadLine());
            double side3 = Convert.ToDouble(Console.ReadLine());

            Triangle dummy_tri = new Triangle(side1, side2, side3);

            Console.WriteLine("\nArea: " + dummy_tri.area(side1, side2, side3));
            Console.WriteLine("Perimeter: " + dummy_tri.perimeter(side1, side2, side3) + "\n");
            Console.WriteLine((dummy_tri.WhoAmI()) + "\n ----------------------");

            //Cube

            Console.WriteLine("Enter side of the cube: ");
            double cube_side = Convert.ToDouble(Console.ReadLine());

            Cube dummy_cube = new Cube(cube_side);

            Console.WriteLine("\nArea: " + dummy_cube.area(cube_side));
            Console.WriteLine("Volume: " + dummy_cube.volume(cube_side) + "\n");
            Console.WriteLine((dummy_cube.WhoAmI()) + "\n ----------------------");

            //Cylinder

            Console.WriteLine("Enter radius and height of the cylinder: ");
            double cyl_radius = Convert.ToDouble(Console.ReadLine());
            double cyl_height = Convert.ToDouble(Console.ReadLine());

            Cylinder dummy_cyl = new Cylinder(cyl_radius, cyl_height);

            Console.WriteLine("\nArea: " + dummy_cyl.area(cyl_radius, cyl_height));
            Console.WriteLine("Volume: " + dummy_cyl.volume(cyl_radius, cyl_height) + "\n");
            Console.WriteLine((dummy_cyl.WhoAmI()) + "\n ----------------------");

            //Sphere

            Console.WriteLine("Enter radius of the sphere: ");
            double sp_radius = Convert.ToDouble(Console.ReadLine());

            Sphere dummy_sp = new Sphere(sp_radius);

            Console.WriteLine("\nArea: " + dummy_sp.area(sp_radius));
            Console.WriteLine("Volume: " + dummy_sp.volume(sp_radius) + "\n");
            Console.WriteLine((dummy_sp.WhoAmI()) + "\n ----------------------");

            //Cone

            Console.WriteLine("Enter radius and height of the cone: ");
            double cone_r = Convert.ToDouble(Console.ReadLine());
            double cone_h = Convert.ToDouble(Console.ReadLine());

            Cone dummy_cone = new Cone(cone_r, cone_h);

            Console.WriteLine("\nArea: " + dummy_cone.area(cone_r, cone_h));
            Console.WriteLine("Volume: " + dummy_cone.volume(cone_r, cone_h) + "\n");
            Console.WriteLine((dummy_cone.WhoAmI()) + "\n ----------------------");
            Console.ReadKey();
        }
    }
}
