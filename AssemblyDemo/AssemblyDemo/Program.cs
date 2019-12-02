using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace AssemblyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.LoadFrom(@"C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.dll");
            ShowAssembly(assembly);

            Assembly assembly1 = Assembly.GetExecutingAssembly();
            ShowAssembly(assembly1);

        }

        static void ShowAssembly(Assembly assembly)
        {
            Console.WriteLine(assembly.FullName);
            Console.WriteLine(assembly.GlobalAssemblyCache);
            Console.WriteLine(assembly.Location);
            Console.WriteLine(assembly.ImageRuntimeVersion);
            
            foreach (Module module in assembly.Modules)
            {
                Console.WriteLine(module.Name);
            }

            Console.ReadKey();
        }
    }
}
