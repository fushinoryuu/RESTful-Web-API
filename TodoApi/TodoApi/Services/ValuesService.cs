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

        public string[] GetAllValues()
        {
            return _valuesRepository.GetAllValues();
        }
    }
}
