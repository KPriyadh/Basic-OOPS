using System;
namespace OperatorOverLoading;
class Program{
    public static void Main(string[] args)
    {
       Box box1 = new Box(1.2,3.4,4.1);
       Box box2 = new Box(1.2,7.2,9.2);

       Console.WriteLine(box1.CalculateVolume());
       Console.WriteLine(box2.CalculateVolume());
       Box box3 = Box.Add(box1,box2);
       Box box4 = box1 +box2;
       int c = 1+2;
    }
}