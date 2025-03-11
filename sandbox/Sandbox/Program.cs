// using System;
// using System.Formats.Asn1;

// class Program
// {   
//     public static int Addnumbers(int n, int m)
//     {
//         return n + m;
//     }
//     static void Main(string[] args)
//     {

//         Circle myCircle = new Circle(10);
//         myCircle.displayCircleArea();
//         // Circle myCircle2 = new Circle(20);
//         // myCircle2.displayCircleArea();
//         Cylinder myCylinder = new Cylinder(10, myCircle);
//         double volume = myCylinder.GetVolume();
//         Console.WriteLine($"The cylinder volume is: {volume}");

//         // for(int i = 0; i < 31; i++)
//         // {
//         //     myCircle.SetRadius(i);
//         //     double circleArea = myCircle.GetArea();
//         //     Console.WriteLine($"{i}: Circle area is: {circleArea}");
//         // }
//     }
    
// }
using System;
using System.Threading.Tasks;
class Program
{
   public static async Task Main()
   {
        Console.WriteLine("Starting Task 1...");
        var task1 = Jump();
        await Task.WhenAll(task1);
        Console.WriteLine("Both tasks completed.");
   }
   private static async Task Jump()
   {   
        Console.WriteLine("1");
        await Task.Delay(0900);
        Console.WriteLine("2");
        await Task.Delay(0900);
        Console.WriteLine("3");

   }
}
