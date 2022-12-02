
// Переменные
string[] array;
int count;
string userString;
string[] arrayTemp;

// Функция ввода строк с клавиатуры и заполнение ими массива
string[] EnterString()
{
  // Цикл ввода строк
  Console.WriteLine("Вводите строки. Пустая строка означает конец ввода.");
  count = 0;
  array = new string[count];
  do
  {
    userString = Console.ReadLine();
    // Проверка на пусту строку
    if (userString != "")
    {
      count++; // если не пустая, добавляем в массив
      arrayTemp = new string[count];
      for (int i = 0; i < arrayTemp.Length - 1; i++)
      {
        arrayTemp[i] = array[i];
      }
      arrayTemp[count - 1] = userString;
      array = arrayTemp;
    }
  } while (userString != "");

  return array;
}

EnterString();
for (int i = 0; i < array.Length; i++)
{
  Console.WriteLine(i + " " + array[i]);
}
// Функция проверки массива по условию длины строк

string[] ChangeArray(string[] array, int stringLength)
{
  for (int i = 0; i < array.Length; i++)
  {
    
  }
}