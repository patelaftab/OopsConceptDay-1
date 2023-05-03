using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoopsConceptsDay1
{
    public class MethodOverriding
    {
        public virtual void Employye()
        {
            Console.WriteLine("Employee is Present For Working");
        }
    }
    public class Details:MethodOverriding
    {
        public override void Employye()
        {
            Console.WriteLine("EMployee Salary is 1000/Month");
        }
    }
}
