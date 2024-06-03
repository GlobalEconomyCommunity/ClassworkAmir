using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class Program
    {
        static void Main()
        {
            try
            {
                CreditCard myCard = new CreditCard("1234567890123456", "John Doe", 123, new DateTime(2023, 12, 31));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
    }
}

class CreditCard
{
    private string cardNumber;
    private string fullName;
    private int cvc;
    private DateTime expiryDate;

    public CreditCard(string cardNumber, string fullName, int cvc, DateTime expiryDate)
    {
        if (string.IsNullOrEmpty(cardNumber) || cardNumber.Length != 16)
            throw new ArgumentException("Invalid card number");

        if (string.IsNullOrEmpty(fullName))
            throw new ArgumentException("Invalid full name");

        if (cvc.ToString().Length != 3)
            throw new ArgumentException("Invalid CVC");

        if (expiryDate < DateTime.Today)
            throw new ArgumentException("Invalid expiry date");

        this.cardNumber = cardNumber;
        this.fullName = fullName;
        this.cvc = cvc;
        this.expiryDate = expiryDate;
    }


}


namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите математическое выражение (например, 3*2*1*4):");
            string input = Console.ReadLine();

            try
            {
                string[] tokens = input.Split('*');
                int result = Convert.ToInt32(tokens[0]);

                for (int i = 1; i < tokens.Length; i++)
                {
                    result *= Convert.ToInt32(tokens[i]);
                }

                Console.WriteLine("Результат выражения: " + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка ввода: " + ex.Message);
            }
        }
    }
}



class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку с цифрами от 0 до 9:");
        string input = Console.ReadLine();

        try
        {
            int number = Convert.ToInt32(input);

            if (number < int.MinValue || number > int.MaxValue)
            {
                throw new OverflowException("Число вышло за пределы диапазона типа int.");
            }

            Console.WriteLine("Преобразованное число: " + number);
        }
        catch (FormatException)
        {
            Console.WriteLine("Введенная строка не является числом.");
        }
        catch (OverflowException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
    class Binary
    {
        static void Main()
        {

            Console.WriteLine("Введите строку от 0 до 1 : ");
            string n = Console.ReadLine();
            try {
                int num = Converting(n); Console.WriteLine(n);
            }
            catch (FormatException)
            {
                Console.WriteLine("This is not number");
            }
            catch (OverflowException)
            {
                Console.WriteLine("выход за границы диапазона");
            }
        }
        static int Converting(string binry)
        {
            int num = Convert.ToInt32(binry, 2);
            return num;
        }
    }

