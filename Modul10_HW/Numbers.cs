using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul10_HW
{
    class Numbers : ISum
    {
        double firstNumber = 0;
        double secondNumber = 0;
        double result = 0;
        public void SumNumbers(double firstNumber, double secondNumber)
        {
            result = firstNumber + secondNumber;
            Console.WriteLine(result);
        }

        public void EnterNumbers()
        {
            Console.WriteLine();
            Console.WriteLine("Введите число 1:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Введите число 2: ");
            string input2 = Console.ReadLine();

            if ((!double.TryParse(input1, out double firstNumber) || !double.TryParse(input2, out double secondNumber)))
            {
                throw new Exception();
            }
            SumNumbers(firstNumber, secondNumber);
        }
    }
}
