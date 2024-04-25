using System;
using MultiLevel;
namespace MultiLevel;
class Program{
    public static void Main(string[] args)
    {
       PersonalDetails person = new PersonalDetails("priya","kesavan",Gender.Female,9840957406);
       Console.WriteLine($"Name: {person.Name}\nFather,s Name: {person.FatherName}\nGender: {person.Gender}\nPhone Number: {person.PhoneNumber}");
       StudentDetails student = new StudentDetails(person.UserID,person.Name,person.FatherName,person.Gender,person.PhoneNumber,"SID1001",1,"2003");
       EmployeeDetails employee = new EmployeeDetails(person.UserID,person.Name,person.FatherName,person.Gender,person.PhoneNumber,student.StudentID,student.Standard,student.YearOfJoining,"software Engineer");
       

    }
}