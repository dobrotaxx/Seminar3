/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int getNumberFromUser(string userInformation)
{
    int result = 0;
    while (result == 0)
    {
        Console.Write(userInformation);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if (result == 0 && userLine != "0")
        {
            Console.WriteLine($"Ошибка ввода! Ожидается числовое значение, вы ввели: [{userLine}].");
        }
        else // Чтобы можно было вводить значение равное 0
        {
            break;
        }
    }
    return result;
}

int[] tableOfSquarers(int userNumber)
{
    int[] result = new int[userNumber];
    for (int i = 1; i <= userNumber; i++)
    {
        result[i - 1] = (int)Math.Pow(i, 3);
    }
    return result;
}

int number = getNumberFromUser("Введите целое число N > 1: ");
int[] table = tableOfSquarers(number);

for (int i = 0; i < table.Length; i++)
{
    Console.Write(table[i] + " ");
}
