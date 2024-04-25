using System;
namespace Interface;
class Program{
    public static void Main(string[] args)
    {
        Square number = new Square(); //class variable as object
        number.number = 20;
        Console.WriteLine(number.Calculate());


        Circle number1 = new Circle();
        number1.number = 20;
        Console.WriteLine(number.Calculate());



    }
}