Console.Clear();

int n = Convert.ToInt32(Console.ReadLine());
int fitstMax = n;
int secondMax = 0;

while (n != 0)
{
  if (fitstMax < secondMax)
  {
    secondMax = fitstMax;
    fitstMax = secondMax;
  }

  if (n > fitstMax)
  {
    secondMax = fitstMax;
    fitstMax = n;
  }
  else if (n > secondMax)
  {
    secondMax = n;
  }

  n = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine(secondMax);