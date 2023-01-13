// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB < 1)
{
    Console.WriteLine("число B введено не корректно (изучить определение 'натуральные числа')!");
}

else
{
    int methodExponent = MethodExponent(numberA, numberB);
    Console.Write($"Number {numberA} to the power {numberB} = {methodExponent}");


    int MethodExponent(int numA, int numB)
    {
        int result = 1;
        for (int i = 1; i <= numB; i++)
        {
            result = result * numA;
        }
        return result;
    }
}