namespace task3;
/*
 * Створіть проект Console Application, де реалізуйте типізований клас "Чарівний мішок".
 * Чарівність полягає в тому, що подарунок сам з'являється у мішку та залежить від того,
 * хто намагається відкрити мішок. Причому подарунок для однієї істоти може з'явитись
 * лише 1 раз на день. Використовуйте обмеження типу - інтерфейс із властивістю, що
 * зберігає тип істоти, яка намагається отримати подарунок із мішка.
 */
class Program
{
    static void Main(string[] args)
    {
        DateTime dateTimeForDarkElf;
        Elf darkElf = new Elf();
        Elf elf = new Elf();
        Draft draft = new Draft();
        
        Console.WriteLine("Enter date for get gift for Dark Elf");
        DateTime.TryParse(Console.ReadLine(), out dateTimeForDarkElf);

        MagicBag<Elf> magicBag = new MagicBag<Elf>(elf);
        MagicBag<Draft> magicBag1 = new MagicBag<Draft>(draft);
        MagicBag<Elf> magicBag2 = new MagicBag<Elf>(darkElf, dateTimeForDarkElf);
       
    }
}