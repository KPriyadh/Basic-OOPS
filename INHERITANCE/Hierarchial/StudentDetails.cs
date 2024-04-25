using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hierarchial
{
    public class StudentDetails:PersonalDetails
    {
        private static int s_studentID = 1000;

        public string StudentID{get;}
        public int Standard{get;set;}
        public string YearOfJoining{get;set;}


        public StudentDetails(string userID,string name,string fatherName,Gender gender,long phoneNumber,string studentID, int standard, string yearOfjoining):base(name,fatherName,gender,phoneNumber)
        {
            s_studentID++;

            StudentID="SID"+s_studentID;
            Standard=standard;
            YearOfJoining=yearOfjoining;
            Name = name;
        }
        
    }
}