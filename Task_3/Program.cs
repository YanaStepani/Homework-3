/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27;  5 -> 1, 8, 27, 64, 125
*/

// запрос данных у пользователя:
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

// выведение ответа пользователю:
for (int i = 1; i <= number; i++)
{
    Console.Write($"{Math.Pow(i, 3)} ");
}

// Не смогла решить с массивом. Почему-то у меня выходит ошибка в строке cubeNums[i - 1] = i * i * i;, 
// якобы i не является переменной, хотя ранее она задана. Не пщнимаю, в чем проблема.

/*
// определение метода
int[] GetCubeNumber(int number)
{
    int[] cubeNums = new int[number];

    for (int i = 1; i <= number; i++);
    {
        cubeNums[i - 1] = i * i * i;
    }
    return cubeNums; 
}

// запрос числа у пользователя:
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

// выведение ответа пользователю:
int [] result = GetCubeNumber(number);
    for (int i = 0; i < result.Length; i++)
    {
       Console.WriteLine(result[i]);
    }
*/
