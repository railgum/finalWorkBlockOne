
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
    // Проверка на пустую строку
    if (userString != "")
    {
      // если не пустая, добавляем в массив

      // выделяем память во временном массиве на 1 больше
      count++;
      arrayTemp = new string[count];

      // копируем массив во временный
      for (int i = 0; i < arrayTemp.Length - 1; i++)
      {
        arrayTemp[i] = array[i];
      }

      // добавляем последнний ввод во временный массив
      arrayTemp[count - 1] = userString;

      // приравниваем временный массив основному
      array = arrayTemp;
    }
  } while (userString != "");

  return array;
}

EnterString(); // заполняем массив

// создаем новый массив по условию
string[] changeArray = array.Where(str => str.Length <= 3).ToArray();

// выводим массив и массив, удовлетворяющий условию
Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", changeArray)}]");
