/*Задача 64: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8"*/

//метод, который принимает на ввод с консоли значение
int ReadInt(string mesage)
{
    Console.WriteLine(mesage);
    int result = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(Console.ReadLine()))); //чтобы не было ошибки, если введено дробное число
    return result;
}
//рекурсивный метод, который находит в ряду чисед натуральные чётные числа
void PrintNaturalEvenNumbers(int firstNumber, int secondNumber)
{

    if (secondNumber < firstNumber)//условие выхода
    {
        return;
    }
    if (firstNumber <= 0) //условие, если пользователь ввел значение меньше 0 или 0 (0 - не натуральное)
    {
        firstNumber = 1;
    }
    if (secondNumber % 2 != 0) // проверяем на четность
    {
        secondNumber--; //делаем число ближайшим меньшим четным
    }
    PrintNaturalEvenNumbers(firstNumber, secondNumber - 2);// рекусия
    System.Console.Write($"{secondNumber}\t"); //вывод значений функции
}
System.Console.WriteLine($"Ищем все натуральные чётные числа между числом M и N");
int firstNumber = ReadInt("Введите первое число M: ");
int secondNumber = ReadInt("Введите второе число N: ");
if (secondNumber < firstNumber) // улсловие, если пользователь ввел сначала большее число, потом меньшее
{
    int temp = firstNumber;
    firstNumber = secondNumber;
    secondNumber = temp;
}
if (secondNumber == firstNumber && secondNumber % 2 != 0 || secondNumber < 0) // проверяем, если числа равны и нечетны, то выводим сообщение
{
    System.Console.WriteLine($"В промежутке между данными числами нет натуральных четных чисел");
}
else
{
    System.Console.WriteLine($"Натуральные четные числа в указанных пределах:");
    System.Console.WriteLine();
    PrintNaturalEvenNumbers(firstNumber, secondNumber);
}


