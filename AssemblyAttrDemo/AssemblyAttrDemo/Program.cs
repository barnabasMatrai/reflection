using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace AssemblyAttrDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type type = typeof(AssemblyDescriptionAttribute);
            object[] objects = assembly.GetCustomAttributes(type, false);

            if (objects.Length > 0)
            {
                AssemblyDescriptionAttribute description = (AssemblyDescriptionAttribute) objects[0];

                Console.WriteLine(description.Description);
                Console.ReadKey();
            }
        }
    }
}
