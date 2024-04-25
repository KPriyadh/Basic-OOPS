using System;
namespace ByType;
class Program{
    public static void Main(string[] args)
    {
        //Add Method to add Integer
        int result = Add(1,2);
        double result2 = Add(1,3);
        string result1 = Add("ds","sd");
    }
    public static int Add(int A, int B){
        return A+B;
    }
     public static double Add(double A, double B){
        return A+B;
    }

    public static string Add(string A, string B){
        return A+B;
    }
}