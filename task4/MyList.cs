namespace task4;
/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
 * Створіть метод, що розширює: public static T[ ] GetArray(this MyList list)
 * Застосуйте розширюючий метод до екземпляра типу MyList, розробленого в домашньому
 * завданні 2 для даного уроку. Виведіть на екран значення елементів масиву,
 * який повернув метод GetArray(), що розширює метод.
 */

public class MyList <T>
{
    private T[] _myLists;
    private int _index;

    public MyList(params T[] items)
    {
        _myLists = items;
        _index = items.Length;
    }
    
    public void AddToMyList(T item)
    {
        T[] newList = new T[_myLists.Length +1];
        Array.Copy(_myLists,newList,_myLists.Length);
        newList[newList.Length-1] = item;
        _myLists = newList;
        _index = _myLists.Length;
    }

    public T this[int index]
    {
        get
        {
            return _myLists[index];
        }
    }

    public int Lenght
    {
        get { return _index; }
    } 
    
}