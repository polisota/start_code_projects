Console.Clear();

Console.WriteLine("Задание№2.\nНапишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");

Console.Write("Введите число: ");
long n = Convert.ToInt64(Console.ReadLine());

int i=0;
long nNew = n;
while(nNew>0) 
{
    i++;
    nNew/=10;
}

if (n<99)
    Console.Write("Третьей цифры нет");
else
{
    for (int count = 0; count < i-3; count ++)    
        n = (n - n % 10)/10;    
    Console.WriteLine(n % 10);    
}