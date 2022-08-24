// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

double[,] value = new double[2, 2];
double[] cross = new double[2];

void InputValues()
{
  for (int i = 0; i < value.GetLength(0); i++)
  {
    Console.Write($"Введите значение {i+1}-го уравнения (y = k * x + b):\n");
    for (int j = 0; j < value.GetLength(1); j++)
    {
      if(j==0) Console.Write($"Введите значение k: ");
      else Console.Write($"Введите значение b: ");
      value[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

double[] Decision(double[,] value)
{
  cross[0] = (value[1,1] - value[0,1]) / (value[0,0] - value[1,0]);
  cross[1] = cross[0] * value[0,0] + value[0,1];
  return cross;
}

void Output(double[,] value)
{
  if (value[0,0] == value[1,0] && value[0,1] == value[1,1]) 
  {
    Console.Write($"\n Прямые совпадают");
  }
  else if (value[0,0] == value[1,0] && value[0,1] != value[1,1]) 
  {
    Console.Write($"\n Прямые параллельны");
  }
  else 
  {
    Decision(value);
    Console.Write($"\n Точка пересечения: ({cross[0]}, {cross[1]})");
  }
}

InputValues();
Output(value);