using System;

public partial class Program
{

        
       public void decimal_conversion()
        {
            Console.WriteLine("Введите число в двоичной системе счисления: ");
            string binaryInput = Console.ReadLine();

            int decimalNum = 0;
            int power = 0;

            for (int i = binaryInput.Length - 1; i >= 0; i--)
            {
                if (binaryInput[i] == '1')
                {
                    decimalNum += (int)Math.Pow(2, power);
                }
                power++;
            }

            Console.WriteLine("Десятичное представление: " + decimalNum);
        }
}