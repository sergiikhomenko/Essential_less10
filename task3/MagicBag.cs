namespace task3;
/*
 * Створіть проект Console Application, де реалізуйте типізований клас "Чарівний мішок".
 * Чарівність полягає в тому, що подарунок сам з'являється у мішку та залежить від того,
 * хто намагається відкрити мішок. Причому подарунок для однієї істоти може з'явитись
 * лише 1 раз на день. Використовуйте обмеження типу - інтерфейс із властивістю, що
 * зберігає тип істоти, яка намагається отримати подарунок із мішка.
 */


public class MagicBag <T>  where T: ICreate
{
    private T _being;
    private DateTime _date;

    public MagicBag(T being)
    {
        _being = being;
        _date = DateTime.Now;
        CreateGift(_being, _date);
    }

    public MagicBag(T being, DateTime date)
    {
        _being = being;
        _date = date;
        CreateGift(_being,_date);
    }

    private void CreateGift(T being, DateTime dateTime)
    {
        if (dateTime != DateTime.Now)
        {
            switch (being)
            {
              case Elf: 
                      Console.WriteLine("Gift for Elf Blue: Wolve's Heavy");
                   break;
              case Draft: Console.WriteLine("Gift for Draft: Draconic Leather Set");
                  break;
            }
        }
        else
        {
            Console.WriteLine("Ви вже отримали свою нагороду на сьогодні");
        }
    }
}