using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface
{
    public interface ICalculate
    {
        //No Fields and Constructor
        //Property
        int number{get;set;} //Declaration Only
        //Method
        int Calculate(); //Method Declaration

        //Fully Abstraction - no Definition
    }
}