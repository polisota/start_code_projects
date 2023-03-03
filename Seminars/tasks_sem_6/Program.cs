Console.Clear();
//Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
  array[i] = new Random().Next(1, 11); // [1, 10]
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
for(int i = 0; i < array.Length / 2; i++)
{
  int temp = array[i];
  array[i] = array[array.Length - 1 - i];
  array[array.Length - 1 - i] = temp;
}
Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");

//Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами
//такой длины. Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
Console.Write("Введите длину первой стороны: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину второй стороны: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину третьей стороны: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a + b > c && b + c > a && a + c > b)
    Console.WriteLine("yes");
else
    Console.WriteLine("no");


//Задача 42: Напишите программу, которая будет преобразовывать
//десятичное число в двоичное.

/*Console.Write("Введите десятичное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int newNumber = number;
int j = 0;
while (newNumber != 0)
{
    newNumber /= 2;
    j++;
}

int[] arr = new int[j];

for(int i = 0; i < arr.Length; i++)
{
    arr[i] = number%2;
    number /= 2;
}

for(int i = 0; i < arr.Length / 2; i++)
{
  int temp = arr[i];
  arr[i] = arr[arr.Length - 1 - i];
  arr[arr.Length - 1 - i] = temp;
}
Console.WriteLine($"Конечный массив: [{string.Join(", ", arr)}]");*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string result = String.Empty;
while (number != 0)
{
  result = Convert.ToString(number % 2) + result;
  number = number / 2;
}
Console.WriteLine(result);


//Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
int f1 = 0;
int f2 = 1;
int fx = 0;
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

while (num > 0)
{
  Console.Write($"{f1} ");
  fx = f1 + f2;
  f1 = f2;
  f2 = fx;
  num--;
}
// 0 1 1 2 3 5 8 

//Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
Console.WriteLine("Введите кол-во элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] ar = new int[n];
for (int i = 0; i < ar.Length; i++)
  ar[i] = new Random().Next(1, 11);
int[] arCopy = new int[ar.Length];
for (int i = 0; i < arCopy.Length; i++)
  arCopy[i] = ar[i];
Console.WriteLine($"Mассив: [{string.Join(", ", ar)}]");
Console.WriteLine($"Копия массива: [{string.Join(", ", arCopy)}]");
arCopy[5] = 8;
Console.WriteLine($"Измененная копия: [{string.Join(", ", arCopy)}]");