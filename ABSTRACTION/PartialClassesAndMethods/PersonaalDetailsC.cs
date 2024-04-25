using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClassesAndMethods
{
    public partial class PersonaalDetails
    {
        public partial int CalculateAge(){
            TimeSpan span = DateTime.Now - DOB;
            int age = span.Days/365;
            return age;
        }
    }
}