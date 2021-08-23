using System;

namespace MyCalculator
{
    class Program
    {
        static void Main()
        {
            // интересным моментом здесь является не сам калькулятор а
            // возможность создавать словарь фунций,
            // возможность вызывать эти функции по ключу
            // избегая изменения метода, избегая очередных if

            var calc = new Calculator();
            calc.DefineOperation("%", (x, y) => x % y);

            var addition = calc.PerformOperation("+", 3.0, 2.0);
            var subtraction = calc.PerformOperation("-", 3.0, 2.0);
            var multiplication = calc.PerformOperation("*", 3.0, 2.0);
            var division = calc.PerformOperation("/", 3.0, 2.0);
            var remainder = calc.PerformOperation("%", 3.0, 2.0);

            Console.WriteLine($"3 + 2 = {addition}");
            Console.WriteLine($"3 - 2 = {subtraction}");
            Console.WriteLine($"3 * 2 = {multiplication}");
            Console.WriteLine($"3 / 2 = {division}");
            Console.WriteLine($"3 % 2 = {remainder}");

            Console.ReadLine();
        }
    }
}