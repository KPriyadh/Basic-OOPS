using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevel
{
    public class EmployeeDetails:StudentDetails
    {
        private static int s_employeeID = 1000;
        public string EmployeeID {get;}
        public string Designation{get;set;}

        public EmployeeDetails(string userID,string name,string fatherName,Gender gender,long phoneNumber,string studentID, int standard, string yearOfjoining,string designation):base(userID,name,fatherName,gender,phoneNumber,studentID,standard,yearOfjoining){
            
            s_employeeID++;
            
           
            EmployeeID="EID"+s_employeeID;
            Designation=designation;
        }
    }
}