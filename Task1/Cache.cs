namespace Task1;

public class Cache<T>
{
    List<T> values = new List<T>();
    public void AddCache(T value){
        values.Add(value);
    }
    public List<T> GetCache(){
        return values;
    }
    public void RemoveCache(T value){
        values.Remove(value);;
    }
}
