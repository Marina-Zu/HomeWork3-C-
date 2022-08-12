// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение
    string readValue = Console.ReadLine(); // Считывает с консоли строку
    int result = int.Parse(readValue); // Преобразует строку в целое число
    return result; // Возвращает результат функции
}

int N = Prompt("Введите пятизначное число > ");
void Palindrome(int N)
{
    if (N > 10000 && N < 100000)
    {
        int number1 = N / 10000;
        int number5 = N % 10;
        if (number1 == number5)
        {
            int number2 = N / 1000 % 10;
            int number4 = N / 10 % 10;
            if (number2 == number4)
            {
                System.Console.WriteLine("Да");
            }
            else
                System.Console.WriteLine("Нет");
        }
        else
            System.Console.WriteLine("Нет");
    }
    else
    {
        System.Console.WriteLine("Это не пятизначное число");

    }
}

Palindrome(N);