Console.Clear();

//Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
Console.Write("Введите число: ");
double n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Результат: {(1 + n) / 2 * n}");

//Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int i=0;
while(a>0) 
{
    i++;
    a/=10;
}
Console.WriteLine($"Результат: {i}");

//Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
Console.Write("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());
int res = 1;
for (int j = 1; j<=b; j++)
{
    res *= j;

}
Console.WriteLine($"Результат: {res}");

//Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
int[] array = new int[8];
for (int m = 0; m < array.Length; m++)
    array[m] = new Random().Next(0, 2); 
Console.WriteLine($"Результат: [{string.Join(", ", array)}]");