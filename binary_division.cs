using System;
using System.Linq;

public partial class Program
{
    public void division()
{
    Console.WriteLine("\n\t ДЕЛЕНИЕ ДВОИЧНЫХ ЧИСЕЛ");
    Console.WriteLine("Введите два числа из двоичной системы счисления: ");
    string dividend = Console.ReadLine();
    string divisor = Console.ReadLine();

    // Проверяем, что числа являются двоичными.
    if (!dividend.All(x => x == '0' || x == '1'))
    {
        throw new ArgumentException("Первое число должно быть двоичным");
    }
    if (!divisor.All(x => x == '0' || x == '1'))
    {
        throw new ArgumentException("Второе число должно быть двоичным");
    }

    // Проверяем, что делитель не равен 0.
    if (divisor == "0")
    {
        throw new ArgumentException("Делитель не должен быть равен 0");
    }

    // Убеждаемся, что делимое больше или равно делителю, иначе результатом будет 0.
    while (dividend.Length < divisor.Length)
    {
        dividend = "0" + dividend;
    }

    // Создаем результат деления.
    string result = "";
    string remainder = dividend;

    // Перебираем разряды делимого.
    for (int i = 0; i < dividend.Length; i++)
    {
        char currentDigit = remainder[i];
        result += (((currentDigit - '0') + 10 * int.Parse(remainder[i].ToString())) / (divisor[0] - '0')).ToString();
        remainder = (int.Parse(remainder) - int.Parse(result[i].ToString()) * int.Parse(divisor)).ToString();
        remainder = remainder.Substring(Math.Min(remainder.Length - 1, 1));
    }

    // Удаляем лишние нули из начала результата деления.
    result = result.TrimStart('0');

    // Если результат пуст, то это означает, что деление было нацело.
    if (result == "")
    {
        result = "0";
    }

    // Возвращаем результат деления.
    Console.WriteLine("Результат: " + result);
}

}
