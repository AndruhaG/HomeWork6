//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3


void Zadacha41()

{
Console.WriteLine();
Console.Write($"Какое количество чисел Вы хотели бы ввести?: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arrayNumbers = new int[size];

void InputNumbers()
{
    for (int n = 0; n < arrayNumbers.Length; n++)
    {
        Console.Write($"Введи {n+1} число: ");
        arrayNumbers[n] = Convert.ToInt32(Console.ReadLine());
    }
}


int CountPositiveNumbers(int[] arrayNumbers)
{
  int count = 0;
  for (int i = 0; i < arrayNumbers.Length; i++)
  {
    if(arrayNumbers[i] > 0 ) count ++; 
  }
  return count;
}

InputNumbers();

Console.WriteLine($"Введено чисел больше 0: {CountPositiveNumbers(arrayNumbers)} ");
}


//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


void Zadacha43()
{

Console.WriteLine();
Console.Write("Введите коэффициент k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите коэффициент b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите коэффициент k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите коэффициент b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

double x;
double y;

if (k1 != k2)
{
    x = (b2 - b1)/(k1 - k2);
    y = k1 * x + b1;
    Console.WriteLine();
    Console.WriteLine($"Точка пересечения прямых ({x}, {y})");
    Console.WriteLine();
}
else
{
    Console.WriteLine();
    Console.WriteLine("Прямые паралельны");
    Console.WriteLine();
}

}





//Zadacha41();
Zadacha43 ();


