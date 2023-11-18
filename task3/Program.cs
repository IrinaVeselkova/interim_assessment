/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/


// метод для считывания с консоли параметров
int ReadInt(string mesage)
{
    Console.WriteLine(mesage);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
// Функция Аккермана
int AckermannFunction(int n, int m)
{
    if (n == 0) return m + 1;
    if (m == 0) return AckermannFunction(n - 1, 1);
    else return AckermannFunction(n - 1, AckermannFunction(n, m - 1));
}
System.Console.WriteLine($"Вычисляем значение функции Аккермана");
int n = ReadInt("Введите параметр n (целое число): ");
int m = ReadInt("Введите параметр m (целое число): ");
if (n < 0 || m < 0) // проверка, что параметры неотрицательны
{
    System.Console.WriteLine("Параметры должны быть больше 0, попробуйте еще раз!");
}
else
{
    System.Console.Write($"Значение функции Аккермана: ");
    System.Console.WriteLine(AckermannFunction(n, m));
}

