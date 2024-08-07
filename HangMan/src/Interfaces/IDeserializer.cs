namespace HangMan.src.Interfaces
{
    public interface IDeserializer<T>
    {
        T Deserialize(string data);
    }
}
