﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace DynamicCodeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.Web.dll";
            Assembly assembly = Assembly.LoadFrom(path);
            Type type = assembly.GetType("System.Web.HttpUtility");

            MethodInfo encode = type.GetMethod("HtmlEncode", new Type[] { typeof(string) });
            MethodInfo decode = type.GetMethod("HtmlDecode", new Type[] { typeof(string) });

            string originalString = "This is Sally & Jack's Anniversary <sic>";
            Console.WriteLine(originalString);

            string encoded = (string)encode.Invoke(null, new object[] { originalString });

            Console.WriteLine(encoded);

            string decoded = (string)decode.Invoke(null, new object[] { encoded });

            Console.WriteLine(decoded);
            Console.ReadKey();
        }
    }
}
