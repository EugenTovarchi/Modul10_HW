using System.Numerics;

namespace Modul10_Task2_HW;

class Program
{
    static ILogger Logger { get; set; }
    static void Main(string[] args)
    {
        ILogger Logger = new Logger();
        Numbers userNumbers = new Numbers(Logger);

        while (true)
        {
            try
            {
                userNumbers.EnterNumbers();
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка: Введено слишком большое или маленькое число. Попробуйте ещё раз.");
            }
            catch (FormatException)
            {
                Console.WriteLine($"Введено не коректное значение. Введите цифры!");
            }
        }
    }
}



