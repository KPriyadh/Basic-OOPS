using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CollegeDetails
{

    public enum AdmissionStatus{Select, Admitted, Cancelled};
    public class AdmissionDetails
    {

        /*
        a.	AdmissionID – (Auto Increment ID - AID1001)
        b.	StudentID
        c.	DepartmentID
        d.	AdmissionDate
        e.	AdmissionStatus – Enum- (Select, Admitted, Cancelled)
       */

       //Field
       //Static
       private static int s_admissionID=1001;

       //Property

       public string AdmissionID{get;} //Read only Property

       public string StudentID{get; set;}
       public string DepartmentID{get; set;}
       public DateTime AdmissionDate{get; set;}
       public AdmissionStatus AdmissionStatus{get; set;}

       //Constructor

       public AdmissionDetails(string studentID,string departmentID, DateTime admissionDate, AdmissionStatus admissionStatus){
        //Auto Incrementation
        s_admissionID++;

        AdmissionID = "AID"+s_admissionID;
        DepartmentID = departmentID;
        StudentID = studentID;
        AdmissionDate=admissionDate;
        AdmissionStatus=admissionStatus;
       }


    }
}