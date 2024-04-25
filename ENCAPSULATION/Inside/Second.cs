using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Outside;
namespace Inside
{
    public class Second:First
    {
        protected int ProtectedNumberOut{get{return ProtectedNumber;}set{ProtectedNumber=value;}}
        protected internal int ProtectedInternal = 40;
        
        
    }
}