using Lamar;
using TodoApi.Interfaces;
using TodoApi.Repositories;
using TodoApi.Services;

namespace TodoApi.Utils
{
    public class Registry : ServiceRegistry
    {
        public Registry()
        {
            For<IValuesRepository>().Use<ValuesRepository>();
            For<IValuesService>().Use<ValuesService>();
        }
    }
}
