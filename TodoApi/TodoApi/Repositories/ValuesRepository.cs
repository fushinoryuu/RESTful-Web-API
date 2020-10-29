using TodoApi.Interfaces;

namespace TodoApi.Repositories
{
    public class ValuesRepository : IValuesRepository
    {
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
