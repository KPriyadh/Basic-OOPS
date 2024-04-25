using System;
namespace Inside;
using Outside;
class Program{
    public static void Main(string[] args)
    {
        First obj = new First();
        Console.WriteLine(obj.PrivateOut);
        Console.WriteLine(obj.PublicNumber);
        Second obj1 = new Second();
       
        Console.WriteLine(obj1.ProtectedInternal);
        Console.WriteLine(obj1.ProtectedInternalOut);  
        
              

    }
}
