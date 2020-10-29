namespace TodoApi.Interfaces
{
    public interface IValuesRepository
    {
        string GetValueByIndex(int id);

        string[] GetAllValues();
    }
}
