using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Reflection.Emit;

namespace DemoDynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            AssemblyName assemblyName = new AssemblyName();
            assemblyName.Name = "DemoAssembly";
            assemblyName.Version = new Version("1.0.0.0");

            AppDomain appDomain = AppDomain.CurrentDomain;
            AssemblyBuilder assemblyBuilder = appDomain.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.ReflectionOnly);

            ModuleBuilder moduleBuilder = assemblyBuilder.DefineDynamicModule("CodeModule", "DemoAssembly.dll");

            TypeBuilder typeBuilder = moduleBuilder.DefineType("Animal", TypeAttributes.Public);

            Type type = typeBuilder.CreateType();
            Console.WriteLine(type.FullName);

            foreach (MemberInfo memberInfo in type.GetMembers())
            {
                Console.WriteLine(memberInfo.Name);
                Console.WriteLine(memberInfo.MemberType);
            }

            Console.ReadKey();
        }
    }
}
