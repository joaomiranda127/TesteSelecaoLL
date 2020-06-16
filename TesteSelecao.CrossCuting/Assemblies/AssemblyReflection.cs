using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace TesteSelecao.CrossCuting.Assemblies
{
    public class AssemblyReflection
    {
        public static IEnumerable<Type> GetApplicationInterfaces()
        {
            return Assembly.Load("TesteSelecao.Application").GetTypes().Where(
                type => type.IsInterface
                && type.Namespace != null
                && type.Namespace.StartsWith("TesteSelecao.Application.Interfaces"));
        }

        public static IEnumerable<Type> GetApplicationClasses()
        {
            return Assembly.Load("TesteSelecao.Application").GetTypes().Where(
                type => type.IsClass
                && !type.IsAbstract
                && type.GetCustomAttribute<CompilerGeneratedAttribute>() == null);
        }

        public static Type FindType(Type @interface, IEnumerable<Type> types)
        {
            foreach (var type in types)
            {
                if (type.GetInterfaces().Contains(@interface))
                {
                    return type;
                }
            }

            return null;
        }
    }
}
