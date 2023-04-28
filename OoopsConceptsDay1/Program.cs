using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoopsConceptsDay1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Day-1 Oops Concepts");
            Console.WriteLine("================================");
            bool flag = true;
            while (true)
            {
                Console.WriteLine("\nChoose a option From Below \n" +
                    "Enter 1: Object Class Concept\n"
                    );
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        ClassObject classObject = new ClassObject();
                        classObject.CreatingClass();
                        break;
                    default:
                        Console.WriteLine("Choose a Valid Option");
                        break;
                }
            }
        }
    }
}
