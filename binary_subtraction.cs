using System;
using System.Linq;


public partial class Program
{
    public void subtraction() {
        
        Console.WriteLine("\n\t ВЫЧИТАНИЕ ДВОИЧНЫХ ЧИСЕЛ");
        Console.WriteLine("Введите два числа из двоичной системы счисления: ");
        string first_input_num = Console.ReadLine();
        string second_input_num = Console.ReadLine();
        
        // Проверяем, что числа состоят только из цифр 0 и 1
        if (!first_input_num.All(x => x == '0' || x == '1')) {
            throw new ArgumentException("Первое число должно быть двоичным");
        }
        if (!second_input_num.All(x => x == '0' || x == '1')) {
            throw new ArgumentException("Второе число должно быть двоичным");
        }
        
      // Проверяем, что числа имеют одинаковое количество разрядов
      if (first_input_num.Length != second_input_num.Length) {
        throw new ArgumentException("Числа должны иметь одинаковое количество разрядов");
      }
    
         string result = "";
        char carry = '0';
        
      // Перебираем разряды чисел
      for (int i = first_input_num.Length - 1; i >= 0; i--) {
        
        char first_input_num_digit = first_input_num[i];
        char second_input_num_digit = second_input_num[i];
        char difference = (char)((first_input_num_digit - second_input_num_digit + carry - '0') % 2 + '0');
        carry = (char)((first_input_num_digit - second_input_num_digit + carry - '0') / 2 + '0');

        
        // Добавляем текущий разряд к результату, сдвигая его влево на один разряд
        result = difference + result;
        if (carry == 1) {
            result = '1' + result;
            carry = '0';
        }
      }
        Console.WriteLine("Разность: " + result);
    }
}