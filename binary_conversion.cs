using System;

public partial class Program
{
          public void binary_conversion()
        {
            Console.WriteLine("Введите число из десятичной системы счисления: ");
            int num = int.Parse(Console.ReadLine());
            string binary_num = "";

            // Сохраняем оригинальное число для шестнадцатеричного преобразования
            int originalNum = num; 
            
            while (num > 0)
            {
                 int remainder_binary = num % 2;
                 binary_num = remainder_binary + binary_num;
                 num = num / 2;
             }
            
             // Восстанавливаем оригинальное число для шестнадцатеричного преобразования
            num = originalNum;
            
            
            // Hexadecimal to decimal conversion
            
            string hexadecimalNum = "";
            
            while (num > 0)
        {
            int remainder_hex = num % 16;
            
            if (remainder_hex < 10)
            {
                hexadecimalNum = remainder_hex + hexadecimalNum;
            }
            else
            {
                char hexDigit = (char)('A' + (remainder_hex - 10));
                hexadecimalNum = hexDigit + hexadecimalNum;
            }
            num = num / 16;
        }

        Console.WriteLine("Двоичное представление: " + binary_num);
        Console.WriteLine("Шестнадцатеричное представление: " + hexadecimalNum);
        
            
        }
}