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
class Program
{
    static void Main(string[] args)
    {
        string[] items = new string[5];
        for (int i = 0; i < items.Length; i++)
         {
             items[i] = i.ToString();
         }
        MyList<string> itemsMyList = new MyList<string>(items);
        
        itemsMyList.AddToMyList("errree");
        Console.WriteLine($"Доданий елемент  {itemsMyList[5]}" );
        Console.WriteLine($"Загальна кількість елементів {itemsMyList.Lenght}");
    }
}