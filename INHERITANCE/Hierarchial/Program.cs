using System;
using Hierarchial;
using Single_Inheritance;

namespace Hierarchial;
class Program{
    public static void Main(string[] args)
    {
       PersonalDetails person = new PersonalDetails("priya","kesavan",Gender.Female,9840957406);
       Console.WriteLine($"Name: {person.Name}\nFather,s Name: {person.FatherName}\nGender: {person.Gender}\nPhone Number: {person.PhoneNumber}");
       StudentDetails student = new StudentDetails(person.UserID,person.Name,person.FatherName,person.Gender,person.PhoneNumber,"SID1001",1,"2003");
       CustomerDetails customer =new CustomerDetails(person.Name,person.FatherName,person.Gender,person.PhoneNumber,"CID1001",1000);
    }
}