Console.Write("Введите значения массива через пробел: ");
string[] array = Console.ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);


// -----------------поиск нужного элемента-----------------
string[] array2 = new string[array.Length];
void ResultArray(string[] array, string[] array2)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= 3)
    {
      array2[count] = array[i];
      count++;
    }
  }
}
ResultArray(array, array2);

// -----------------Вывод массива-----------------
void PrintArray(string[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"{array[i]} ");
  }
  Console.WriteLine();
}
PrintArray(array2);