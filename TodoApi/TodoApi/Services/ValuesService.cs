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

        public string GetValueById(int id)
        {
            return _valuesRepository.GetValueById(id);
        }

        public string[] GetAllValues()
        {
            return _valuesRepository.GetAllValues();
        }
    }
}
