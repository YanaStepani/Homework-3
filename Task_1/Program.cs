//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет, 12821 -> да, 23432 -> да

// определение метода:
void PalindromNumber(string number)
{
  if (number.Length != 5)
  {
    Console.WriteLine($"Число {number} не является пятизначным!");
  }
  else if (number[0] == number[4] && number[1] == number[3])
  {
    Console.WriteLine($"Число {number} - палиндром.");
  }
  else 
  {
    Console.WriteLine($"Число {number} - не палиндром.");
  }
}

// запрос числа у пользователя и вывод результата:
Console.WriteLine("Введите пятизачное число: ");
string number = Console.ReadLine();

PalindromNumber(number); 
