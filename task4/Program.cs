namespace task4;
/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
 * Створіть метод, що розширює: public static T[ ] GetArray(this MyList list)
 * Застосуйте розширюючий метод до екземпляра типу MyList, розробленого в домашньому
 * завданні 2 для даного уроку. Виведіть на екран значення елементів масиву,
 * який повернув метод GetArray(), що розширює метод.
 */
class Program
{
    static void Main(string[] args)
    {
        int[] ar = new[] { 1, 2, 3 };
        MyList<int> myList = new MyList<int>(ar);
        
        myList.AddToMyList(5);

        int[] array = myList.GetArray();
        foreach (var arr in myList.GetArray())
        {
            Console.WriteLine(arr);
        }

    }
    
}