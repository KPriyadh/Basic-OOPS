using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;
using Hierarchial;

namespace Single_Inheritance
{
    public class CustomerDetails:PersonalDetails
    {
        private static int s_customerID =1000;
        public string CustomerID{get;}
        public int Balance{get;set;}

        public CustomerDetails(string name,string fatherName,Gender gender,long phoneNumber,string customerID, int balance):base(name,fatherName,gender, phoneNumber){
            s_customerID++;
            

            CustomerID="CID"+s_customerID;
            Balance =balance;
        }
        
    }
}