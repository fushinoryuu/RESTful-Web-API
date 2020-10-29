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
    }
}
