/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.

3, 5 -> 243

2, 4 -> 16 */

int ReadData(string line)
{
    Console.WriteLine(line);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int FindResultNumber(int num1, int num2)
{
    int resultN = 1;
    for (int i = 1; i <= num2; i++)
    {
        resultN = resultN * num1;
    }
    return resultN;
}

int numberA = ReadData("Введите число А: ");
int numberB = ReadData("Введите число B: ");

int result = FindResultNumber(numberA, numberB);
if (numberB >= 1)
    Console.WriteLine($"Число A возведенное в натуральную степень числа B равно: {result}.");
else
    Console.WriteLine("Вы ввели некоректные данные");