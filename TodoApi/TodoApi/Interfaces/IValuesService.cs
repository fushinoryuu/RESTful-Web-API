namespace TodoApi.Interfaces
{
    public interface IValuesService
    {
        string GetValueByIndex(int index);

        string[] GetAllValues();
    }
}
