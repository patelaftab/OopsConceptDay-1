using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoopsConceptsDay1
{
    public class MethodOverloading
    {
        //method overloading is class with same method with differnet parameters
        public void Add(int numberone , int numbertwo)
        {
            int numberthird=numberone+numbertwo;
            Console.WriteLine("Addition of Two Numbers Are: "+numberthird);
        }
        public void Add(string firstname, string lastname)
        {
            string fullname=firstname+lastname;
            Console.WriteLine("My Full Name :"+fullname);
        }
       
    }
}
