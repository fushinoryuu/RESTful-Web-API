using TodoApi.Interfaces;

namespace TodoApi.Repositories
{
    public class ValuesRepository : IValuesRepository
    {
        private readonly IValuesRepository _valuesRepository;

        public ValuesRepository(IValuesRepository valuesRepository)
        {
            _valuesRepository = valuesRepository;
        }

        public string GetValueById(int id)
        {
            return _valuesRepository.GetValueById(id);
        }
    }
}
