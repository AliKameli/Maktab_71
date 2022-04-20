public interface IRepository<T>
{
    List<T> GetAll();
    T? Get(string sSID);
    string Add(T person);
    string Delete(T person);
    void DeleteAll();
    void SaveFile();
    void LoadFile();
}