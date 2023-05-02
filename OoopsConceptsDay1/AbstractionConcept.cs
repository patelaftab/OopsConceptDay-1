using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoopsConceptsDay1
{
    abstract class Employee
    {
        public abstract void DisplayData();
        public void EmplloyeeData()
        {
            Console.WriteLine("There Are 200 EMployees");
        }
    }
    class Workers:Employee
    {
        public override void DisplayData() 
        {
            Console.WriteLine("There are New 100 Vacancies And Data HAs To Be Shared");
        }
    }
}
