namespace Project.Interfaces;

public interface IBase<in T>
{
    void WriteOnScreen(T data);
}