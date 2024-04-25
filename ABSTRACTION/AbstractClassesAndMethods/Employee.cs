using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractClassesAndMethods
{
    public abstract class Employee //Abstract class
    {
        //Abstract class - Partial abstarction
        //It has Field,Property,Method,constructor,destructor,indexes,events.
        //can have both abstract declarartion and normal definition.
        //can only used with an inherited class.
        //not support Multiple inheritance.
        //it cannot be static class.

        //Normal field
        protected string _name;

        //Abstract Property
        public abstract string Name { get; set; }
        //Normal Property
        public double Amount{get;set;}

        //Method
        public string Display(){  //Normal Method
            return _name;

        }
        public abstract double Salary(int dates); //Abstract Method - Only Declaration
        
    }
}