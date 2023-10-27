//Написать программу-калькулятор, вычисляющую выражения вида
        //a + b, a - b, a / b, a* b,
        //введенные из командной строки, и выводящую результат выполнения на
        //экран.
        //Пример вызова программы:
        //        program.exe 10 + 20
        //Пример вывода результата:
        //        10 + 20 = 30
        //В результате операции сложения чисел 10 и 20 получился ответ 30.

internal class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 3)
        {
            int result = 0;
            int num1 = int.Parse(args[0]);
            string operation = args[1];
            int num2 = int.Parse(args[2]);

            if (operation == "+")
            {
                result = num1 + num2;
            }
            if (operation == "-")
            {
                result = num1 - num2;
            }
            if (operation == "/")
            {
                result = num1 / num2;
                ;
            }
            if (operation == "*")
            {
                result = num1 * num2;
            }

            Console.WriteLine("Результат выполнения операции ("
                 + operation + ") = " + result);

        }
        else
            Console.WriteLine("Для использования программы введите:" +
                " число, знак, число через пробел (a (+-/*) b)");



    }
}