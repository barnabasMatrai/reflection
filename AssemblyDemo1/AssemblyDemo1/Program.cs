using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace AssemblyDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.ServiceProcess.dll";
            BindingFlags bindingFlags = BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance;

            Assembly assembly = Assembly.LoadFrom(path);
            Console.WriteLine(assembly.FullName);

            Type[] types = assembly.GetTypes();

            foreach (Type type in types)
            {
                Console.WriteLine(type.Name);
                MemberInfo[] members = type.GetMembers(bindingFlags);

                foreach (MemberInfo member in members)
                {
                    Console.WriteLine(member.MemberType);
                    Console.WriteLine(member.Name);
                }
            }

            Console.ReadKey();
        }
    }
}
