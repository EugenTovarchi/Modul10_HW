using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;
using System.Transactions;

namespace Modul10_HW;

internal class Program
{
    static void Main(string[] args)
    {
        Numbers attempt = new Numbers();
        while (true)
        {
            try
            {
                attempt.EnterNumbers();
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




