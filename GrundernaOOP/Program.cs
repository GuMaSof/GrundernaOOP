using System.Security.Cryptography.X509Certificates;

namespace GrundernaOOP
{
    internal class Program
    {
        //Main metod där vi skapar ett objekt av den andra klassen och anropar metoden.
        static void Main(string[] args)
        {
            //First object of Circle class.
            Circle firstArea = new Circle();
            //Here GetArea calculates the first parameter into area.
            Console.WriteLine(firstArea.GetArea(5)); //Radie-parameter är 5.

            Circle secondArea = new Circle();
            //Here GetArea computes the second parameter.
            Console.WriteLine(secondArea.GetArea(6)); //Radie-parameter är 6.

            //Räknar omkrets av sfären.
            Sphere sphere = new Sphere();
            Console.WriteLine(sphere.GetOmkrets(7));//Diameter är 7.

            TriangleClass triangle = new TriangleClass();
            Console.WriteLine(triangle.GetArea(7, 4));//Base är 7 och höjd är 4. Area ska räkna utifrån detta som att det vore en rät triangel med dessa mått.
        }
    }
}