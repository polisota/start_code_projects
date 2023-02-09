Console.Clear();

Console.WriteLine("Задание№3.\nНапишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

switch(n)
{
    case 1:
        Console.WriteLine("Понедельник, к сожалению, это будний день.");
        break;
    case 2:
        Console.WriteLine("Вторник, к сожалению, это будний день.");
        break;
    case 3:
        Console.WriteLine("Cреда, к сожалению, это будний день.");
        break;
    case 4:
        Console.WriteLine("Четверг, к сожалению, это будний день.");
        break;
    case 5:
        Console.WriteLine("Пятница, к сожалению, это будний день, но мы уже близки.");
        break;
    case 6:
        Console.WriteLine("Суббота! Ура, выходные!");
        break;
    case 7:
        Console.WriteLine("Воскресенье! Завтра понедельник...");
        break;
    default:
        Console.Write("Ошибка!\nВведите число от 1 до 7!");
        break;

}