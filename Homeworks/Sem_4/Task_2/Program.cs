Console.Clear();

Console.WriteLine("Задача 27\nНапишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int i=0;
int sum = 0;
while(n>0) 
{
    i++;
    sum += n%10;
    n/=10;
}
Console.WriteLine($"Результат: {sum}");
