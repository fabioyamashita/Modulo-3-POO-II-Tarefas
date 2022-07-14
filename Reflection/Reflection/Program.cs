using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DisplayPublicProperties();
            CreateInstance("Fabio Yamashita", "Let's Code University", 26517);
        }

        public static void DisplayPublicProperties()
        {
            var assembly = Assembly.GetExecutingAssembly().GetTypes();

            foreach (var type in assembly)
            {
                if (type.IsAssignableTo(typeof(Student)))
                {
                    Console.WriteLine($"Public Properties of class {type.Name}:");

                    foreach (var property in type.GetProperties())
                        Console.WriteLine("  " + property.Name);
                }
            }
        }

        public static void CreateInstance(string name, string university, int rollNumber)
        {
            var type = Assembly.GetExecutingAssembly().GetType("Reflection.Student");

            var instance = (Student)Activator.CreateInstance(type);

            instance.Name = name;
            instance.University = university;
            instance.RollNumber = rollNumber;

            instance.DisplayInfo();
        }
    }
}
