/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N
 с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

//метод, который принимает на ввод с консоли значение
double ReadInt(string mesage)
{
    Console.WriteLine(mesage);
    double result = Convert.ToDouble(Console.ReadLine()); //чтобы не было ошибки, если введено дробное число
    return result;
}
//рекурсивный метод, который находит cумму натуральных чисел в промежутке
int SumNaturalNumbers(int firstNumber, int secondNumber)
{
    if (firstNumber <= 0) //условие, если пользователь ввел значение меньше 0 или 0 (0 - не натуральное)
    {
        firstNumber = 1;
    }
    if (secondNumber < firstNumber || secondNumber <= 0 && firstNumber <= 0)//условие выхода
    {
        return 0;
    }
    return SumNaturalNumbers(firstNumber, secondNumber - 1) + secondNumber;//рекурсия
}
System.Console.WriteLine($"Ищем сумму натуральных чисел между M и N");
double firstNumber = ReadInt("Введите первое число M: ");
double secondNumber = ReadInt("Введите второе число N: ");
if (secondNumber < firstNumber) // уcловие, если пользователь ввел сначала большее число, потом меньшее
{
    double temp = firstNumber;
    firstNumber = secondNumber;
    secondNumber = temp;
}
else
{
    System.Console.Write($"Сумма натуральных чисел в указанных пределах: ");
    System.Console.WriteLine(SumNaturalNumbers(Convert.ToInt32(Math.Ceiling(firstNumber)), Convert.ToInt32(Math.Round(secondNumber))));//меньшее число округляем в большую сторону, а более в меньшую
}
