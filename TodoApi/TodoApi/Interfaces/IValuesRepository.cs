namespace TodoApi.Interfaces
{
    public interface IValuesRepository
    {
        string GetValueById(int id);

        string[] GetAllValues();
    }
}
