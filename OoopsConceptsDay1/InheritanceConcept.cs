using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoopsConceptsDay1
{
    public class InheritanceConcept
    {
        public void AchivingInheritance(string name, string subject)
        { 
            Console.WriteLine(" My First Name"+name);
            Console.WriteLine("Fav Subject :" + subject);
        }
    }
   public class Achiving:InheritanceConcept
    {
        public void AchInheritance(string lastname)
        {
            Console.WriteLine(" My Last Name: "+lastname);
        }
    }
    //Multilevel Inheritance
    public class Finding:Achiving
    {
        public void Information(string city)
        {
            Console.WriteLine("I Am From :"+city);
        }
    }
}
