using System.Security.Cryptography.X509Certificates;

namespace GrundernaOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //First object of Circle class.
            Circle firstArea = new Circle();

            //Here GetArea calculates the first parameter into area.
            Console.WriteLine(firstArea.GetArea(5)); //Radie-parameter is 5.

            Circle secondArea = new Circle();

            //Here GetArea computes the second parameter.
            Console.WriteLine(secondArea.GetArea(6)); //Radius-parameter is 6.

            //Calculates circumference.
            Sphere sphere = new Sphere();
            Console.WriteLine(sphere.GetCircumference(7));//Diameter is 7.

            TriangleClass triangle = new TriangleClass();
            Console.WriteLine(triangle.GetArea(7, 4));//Base is 7 och height is 4.
        }
    }
}