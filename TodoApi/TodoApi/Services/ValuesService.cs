using System;
using System.Linq;
using TodoApi.Interfaces;

namespace TodoApi.Services
{
    public class ValuesService : IValuesService
    {
        private readonly IValuesRepository _valuesRepository;

        public ValuesService(IValuesRepository valuesRepository)
        {
            _valuesRepository = valuesRepository;
        }

        public string GetValueByIndex(int index)
        {
            return _valuesRepository.GetValueByIndex(index);
        }

        public string[] GetValuesByFilter(string filter)
        {
            var list = _valuesRepository.GetAllValues();

            return list.Where(x => x.Equals(filter)).ToArray();
        }

        public string[] GetAllValues()
        {
            return _valuesRepository.GetAllValues();
        }
    }
}
