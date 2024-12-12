using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul10_Task2_HW
{
    internal class Numbers : ISum
    {
        double firstNumber = 0;
        double secondNumber = 0;
        double result = 0;

        public ILogger _logger { get; }

        public Numbers(ILogger logger)
        {
            _logger = logger;
        }

        public void SumNumbers(double firstNumber, double secondNumber)
        {
            result = firstNumber + secondNumber;
            _logger.Event($"Сумма ваших чисел: {result}");
        }
        /// <summary>
        /// Пользователь вводит цифры, метод проверяет входящие данные и при необходимости выводит ошибку обновляя цикл
        /// </summary>
        public void EnterNumbers()
        {
            _logger.Event("Введите число 1:");
            string input1 = Console.ReadLine();
            _logger.Event("Введите число 2: ");
            string input2 = Console.ReadLine();

            if ((!double.TryParse(input1, out double firstNumber) || !double.TryParse(input2, out double secondNumber)))
            {
                _logger.Error("Ошибка при вводе чисел!");
                return;
            }
            SumNumbers(firstNumber, secondNumber);
        }
    }
}
