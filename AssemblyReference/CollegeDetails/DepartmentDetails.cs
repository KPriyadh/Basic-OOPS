using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CollegeDetails
{
    public class DepartmentDetails
    {
        /*
        a.	DepartmentID 
        b.	DepartmentName
        c.	NumberOfSeats
        */

        //Field
        //Static
        private static int s_departmentID = 101;

        //Property
        public string DepartmentID{get;} //Read only Property
        public string DepartmentName{get; set;}
        public int NumberOfSeats{get; set;}

        //Constructor

        public DepartmentDetails(string departmentID,string departmentName, int numberOfSeats){
            //Auto Incrementation
            s_departmentID++;
            DepartmentID="DID"+s_departmentID;

            DepartmentName=departmentName;
            NumberOfSeats=numberOfSeats;
        }


    }
}