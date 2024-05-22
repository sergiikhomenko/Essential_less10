namespace task2;
/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
 * Створіть клас MyList. Реалізуйте у найпростішому наближенні можливість
 * використання його екземпляра аналогічно екземпляру класу List.
 * Мінімально необхідний інтерфейс взаємодії з екземпляром повинен
 * включати метод додавання елемента, індексатор для отримання значення
 * елемента за вказаним індексом і властивість тільки для читання для
 * отримання загальної кількості елементів.
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