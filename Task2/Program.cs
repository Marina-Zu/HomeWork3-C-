// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

int Prompt(string message)
{
    System.Console.Write(message);           // Вывести сообщение
    string readValue = Console.ReadLine();   // Считывает с консоли строку
    int result = int.Parse(readValue);       // Преобразует строку в целое число
    return result;                           // Возвращает результат функции
}

int Ax = Prompt("Введите координту точки A по оси х > ");
int Ay = Prompt("Введите координту точки A по оси y > ");
int Az = Prompt("Введите координту точки A по оси z > ");
int Bx = Prompt("Введите координту точки B по оси х > ");
int By = Prompt("Введите координту точки B по оси y > ");
int Bz = Prompt("Введите координту точки B по оси z > ");

double Length(int x, int y, int z)
{
    double result = Math.Sqrt((Ax - Bx) * (Ax - Bx) + (Ay - By) * (Ay - By) + (Az - Bz) * (Az - Bz));
    System.Console.WriteLine(result);
    return result;
}
Length(Ax, Ay, Az);