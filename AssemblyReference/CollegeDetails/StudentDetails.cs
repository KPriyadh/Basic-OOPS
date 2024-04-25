using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace CollegeDetails
{
    //Enum Declaration
    public enum Gender{Select, Male, Female, Transgender};
    public class StudentDetails
    {
        /*
        a.	StudentID – (AutoGeneration ID – SF3000)
        b.	StudentName
        c.	FatherName
        d.	DOB
        e.	Gender – Enum (Male, Female, Transgender)
        f.	Physics
        g.	Chemistry
        h.	Maths 
        */

        //Field
        //Static
        private static int s_studentID = 3000;

        //Property
        public string StudentID{get; } //Read Only Property
        public string StudentName{get; set;}
        public string FatherName{get; set;}
        public DateTime DOB{get;set;}
        public Gender Gender{get; set;}

        public int Physics{get; set;}
        public int Chemistry{get; set;}
        public int Maths{get;set;}

        //Constructor
        public StudentDetails(string studentName, string fatherName, DateTime dob,Gender gender, int physics,int chemistry, int maths){  
            //Auto Incrementation
            s_studentID++;

            StudentID = "SF"+s_studentID;
            StudentName = studentName;
            FatherName = fatherName;
            DOB = dob;
            Physics = physics;
            Chemistry = chemistry;
            Maths = maths;
            Gender = gender;
        }


        //Methods

        public double Average(){
            int total = (Physics+Chemistry+Maths);
            double average = (double)total/3;
            return average;
        }

        public bool CheckEligibility(double cutOff){
            if(Average() >= cutOff){
                return true;
            }else{
                return false;
            }

        }
        
    }
}