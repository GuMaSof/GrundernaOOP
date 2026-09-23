using System.Security.Cryptography.X509Certificates;

namespace GrundernaOOP
{
    public class Sphere
    {
        private int _diameter;

        public int _Diameter
        {
            get { return _diameter; }
            set { _diameter = value; }
        }

        public double omkrets;

        public double GetOmkrets(int diameter)
        {
            omkrets = diameter * Math.PI;
            return omkrets;
        }
    }
    public class Circle
    {
        private int _radius;
        //Konstruktorn
        public int _Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        public double area;
        
        public double GetArea(int radie)
        {
            area = radie * radie * Math.PI;
            return area;
        }
    }
    internal class Program
    {
        //Main metod där vi skapar ett objekt av den andra klassen och anropar metoden.
        static void Main(string[] args)
        {
            //First object of Circle class.
            Circle firstArea = new Circle();
            //Here GetArea calculates the first parameter into area.
            Console.WriteLine(firstArea.GetArea(5));

            Circle secondArea = new Circle();
            //Here GetArea computes the second parameter.
            Console.WriteLine(secondArea.GetArea(6));

            //Räknar omkrets av sfären.
            Sphere sphere = new Sphere();
            Console.WriteLine(sphere.GetOmkrets(7));
        }
    }
}