using task4;

namespace task4;

public static class MyListExtensions
{
    public static T[] GetArray <T>(this MyList <T> list)
    {
        T[] arrey = new T[list.Lenght];
        for (int i = 0; i < list.Lenght; i++)
        {
            arrey[i] = list[i];
        }
        return arrey;
    }
}