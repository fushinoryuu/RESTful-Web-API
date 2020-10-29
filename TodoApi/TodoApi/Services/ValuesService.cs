using TodoApi.Interfaces;

namespace TodoApi.Services
{
    public class ValuesService : IValuesService
    {
        public ValuesService()
        {
        }

        public string GetValueById(int id)
        {
            return "value";
        }

        public string[] GetAllValues()
        {
            return new[] { "value1", "value2" };
        }
    }
}
