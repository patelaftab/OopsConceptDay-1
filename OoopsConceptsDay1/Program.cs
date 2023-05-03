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
                    "Enter 1: Object Class Concept\n" +
                    "Enter 2: Inheritance Concept\n" +
                    "Enter 3: Encapsulation Concept\n" +
                    "Enter 4: Abstraction Concept\n" +
                    "Enter 5: Method Overloading\n" +
                    "Enter 6: Method Overriding\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        ClassObject classObject = new ClassObject();
                        classObject.CreatingClass();
                        break;
                    case 2:
                        Finding concept = new Finding();
                        concept.AchivingInheritance("Aftab", "Bio");
                        concept.AchInheritance("Patel");
                        concept.Information("Pune");
                        break;
                    case 3:
                        Encapsulation encapsulation = new Encapsulation();
                        encapsulation.Name = "Aftab";
                        encapsulation.Address = "pune";
                        encapsulation.RollNumber = 23;
                        Console.WriteLine("Name is: " + encapsulation.Name + "Address is: " + encapsulation.Address + "Roll Number is: " + encapsulation.RollNumber);
                        break;
                    case 4:
                        Workers newemployees = new Workers();
                        newemployees.DisplayData();
                        newemployees.EmplloyeeData();
                        break;
                    case 5:
                        MethodOverloading methodOverloading = new MethodOverloading();
                        methodOverloading.Add(10, 20);
                        methodOverloading.Add("Aftab", "Patel");
                        break;
                    case 6:
                        Details methodOverriding = new Details();
                        methodOverriding.Employye();
                        methodOverriding=new MethodOverriding();
                        methodOverriding.Employye();
                        break;
                    default:
                        Console.WriteLine("Choose a Valid Option");
                        break;
                }
            }
        }
    }
}
