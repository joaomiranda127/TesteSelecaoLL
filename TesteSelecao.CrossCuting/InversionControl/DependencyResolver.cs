using Microsoft.Extensions.DependencyInjection;
using TesteSelecao.CrossCuting.Assemblies;

namespace TesteSelecao.CrossCuting.InversionControl
{
    public static class DependencyResolver
    {
        public static void AddResolverDependencies(this IServiceCollection services)
        {
            RegisterApplications(services);
        }

        private static void RegisterApplications(IServiceCollection services)
        {
            var applicationInterfaces = AssemblyReflection.GetApplicationInterfaces();
            var applicationClasses = AssemblyReflection.GetApplicationClasses();

            foreach (var @interface in applicationInterfaces)
            {
                var type = AssemblyReflection.FindType(@interface, applicationClasses);

                if (type != null)
                    services.AddScoped(@interface, type);
            }
        }
    }
}
