using System.Collections.Generic;
using System.Linq;
using TodoApi.Interfaces;

namespace TodoApi.Repositories
{
    public class ValuesRepository : IValuesRepository
    {
        private readonly IList<string> _valuesList;

        public ValuesRepository()
        {
            _valuesList = new List<string> { "something", "something else" };
        }

        public string GetValueByIndex(int id)
        {
            if (id < _valuesList.Count)
            {
                return _valuesList[id - 1];
            }

            return null;
        }

        public string[] GetAllValues()
        {
            return _valuesList.ToArray();
        }
    }
}
