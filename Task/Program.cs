// Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, флина которых меньше либо равна 3.
//////////////////////////////////////////////////////////////
// Ввод массива
Console.WriteLine("Введите элементы массива через пробел");
string? stroka = Console.ReadLine();
string[] array1 = stroka!.Split(' ');

// Метод преобразует массив в строку 
// с элементами длиной не > 3.
string Stroka(string[] arr)
{
  string? stroka1 = "";
  foreach (var value in arr)
  {
    if (value.Length <= 3)
    {
      stroka1 = stroka1 + value + " ";
    }
  }
  stroka1 = stroka1.Remove(stroka1.Length - 1);
  return stroka1;
}


string stroka2 = Stroka(array1);
string[] array2 = stroka2!.Split(' ');
Console.Write("[\"");
Console.Write(string.Join("\", \"", array2));
Console.Write("\"]");
Console.ReadKey();