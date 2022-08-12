// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение
    string readValue = Console.ReadLine(); // Считывает с консоли строку
    int result = int.Parse(readValue); // Преобразует строку в целое число
    return result; // Возвращает результат функции
}

int N = Prompt("Введите N > ");
int num = 1;
void CubeN(int num)
{
    while (num <= N)
    {
        int result = 0;
        result = num * num * num;
        System.Console.WriteLine(result);
        num++;
    }
}
CubeN(num);
