Console.WriteLine("Введите Ваше имя: ");
string userName = Console.ReadLine();

if (userName.ToLower() == "маша")
{
    Console.Write("Здравствуй, " + userName);
}
else
{
    Console.Write("Привет, " + userName);
}
