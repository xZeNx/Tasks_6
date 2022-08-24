// Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.

Console.Write($"Введи число М: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] Numbers = new int[m];

void InputNumbers(int m)
{
for (int i = 0; i < m; i++)
  {
    Console.Write($"Введи {i+1} число: ");
    Numbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}

int Comparison(int[] massNumbers)
{
  int count = 0;
  for (int i = 0; i < massNumbers.Length; i++)
  {
    if(massNumbers[i] > 0 ) count += 1;
  }
  return count;
}

InputNumbers(m);

Console.WriteLine($"Чисел больше 0: {Comparison(Numbers)} ");
