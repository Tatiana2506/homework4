﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine($"\nЗадача 25. Возведено числа A в натуральную степень B");

Возведение в степень (целое число A, целое число B) {
  результат = 1;
  for(int i=1; i <= numberB; i++){
    результат = результат * числоА;
  }
    // int result = Math.Pow(numberA, numberB);
    вернуть результат;
}

  Console.Write("Введите число A: ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число B: ");
  int numberB = Convert.ToInt32(Console.ReadLine());

  int возведение в степень = Возведение в степень (число A, число B);
  Console.WriteLine("Ответ: " + возведение в степень);


// Задача 27: Напишите программу, которая принимает вход на число и выдает сумму, включающую сумму.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.WriteLine($"\nЗадача 27. Выдает сумму с учетом");
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

  intSumNumber(int numberN){
    
    int counter = Convert.ToString(numberN).Length;
    заранее = 0;
    результат = 0;

    for (int i = 0; i < counter; i++){
      заранее = числоN - числоN % 10;
      результат = результат + (числоN - продвижение);
      числоN = числоN/10;
    }
   вернуть результат;
  }

int суммаЧисло = СуммаЧисло(числоN);
Console.WriteLine("Сумма цифр с учетом: " + sumNumber);

// Задача 29: Напишите программу, которая задает массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine($"\nЗадача 29. Ряд чисел преобразуется в массив");
Console.Write("Введите ряд чисел, разделенных запятой : ");
нить? seriesOfNumbers = Console.ReadLine();

СерияЧисел = СерияЧисел + ","; // дополнительная запятая для определения конца строки

// функция удаления пробелов из строки
строка RemovingSpaces (серия строк){
  строка seriesNew = "";
  for (int i = 0; i < series.Length; i++)
  {
    если (серия [i] != ' ')
    {
      серияНовая += серия[i];
    }
  }
  обратная серияНовая;
}

// функция проверки правильности ввода
void СcheckNumber2 (целая серия){

      если (серии == '0'||серии == '1'||серии == '2'
      ||серия == '3'||серия == '4'||серия == '5'||серия == '6'
      ||серия == '7'||серия == '8'||серия == '9'||серия == ','
      ||серия == '-')
      {
      }
        еще {
          Console.WriteLine($"Ошибка ввода символа. Вводи цифр.");

      }
}

// функция создания и заполнения массива из строки
int[] ArrayOfNumbers(string seriesNew){

  int[] arrayOfNumbers = новый int[1]; // инициализация массива из 1 элемента

  интервал j =0;

  for (int i = 0; i < seriesNew.Length; i++){
    строка seriesNew1 = "";

    в то время как (seriesNew[i] != ',' && i < seriesNew.Length){
      серияНовая1 += серияНовая[i];
      СcheckNumber2(seriesNew[i]);
      я++;
    }
    arrayOfNumbers[j] = Convert.ToInt32(seriesNew1); // заполняет массивы из значений строк
    если (i < seriesNew.Length-1){
      arrayOfNumbers = arrayOfNumbers.Concat(new int[] {0}).ToArray(); // создает новый нулевой элемент в конце массива
    }
    j++;
  }
  вернуть массив чисел;
}

// функция воспроизведения массива на печать
недействительным PrintArry (int [] колл) {
  int count = кол.Длина;
  внутренний индекс = 0;
  Консоль.Записать("[");
  в то время как (индекс < количество) {
    Console.Write(колл[индекс]);
    индекс++;
    если (индекс <количество){
      Консоль.Написать(", ");
    }
  }
  Console.Write("]");
}


строка seriesNew = удаление пробелов (серии чисел);

int[] МассивЧисел = МассивЧисел(новая серия);

PrintArry (массивЧисел);
