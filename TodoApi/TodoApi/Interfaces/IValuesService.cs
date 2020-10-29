namespace TodoApi.Interfaces
{
    public interface IValuesService
    {
        string GetValueById(int id);

        string[] GetAllValues();
    }
}
