using System.Security.Cryptography.X509Certificates;

namespace GrundernaOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //First object of Circle class.
            Circle firstArea = new Circle(5);

            //Here GetArea calculates the first parameter into area.
            Console.WriteLine(firstArea.GetArea()); //Radie-parameter is 5.

            Circle secondArea = new Circle(6);

            //Here GetArea computes the second parameter.
            Console.WriteLine(secondArea.GetArea()); //Radius-parameter is 6.

            //Calculates circumference.
            Sphere sphere = new Sphere(7);//Diameter is 7.
            Console.WriteLine(sphere.GetCircumference());

            //Base is 7 and height is 4.
            TriangleClass triangle = new TriangleClass(7, 4);
            Console.WriteLine(triangle.GetArea());
        }
    }
}