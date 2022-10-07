/*
Задача 22: Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу квадратов чисел от 1 до N. 
5 -> 1, 4, 9, 16, 25. 
2 -> 1,4
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
    }
    return result;
}

int[] tableOfSquarers(int userNumber)
{
    int[] result = new int[userNumber];/*int[] result - создангие переменной хранящей массив
    new int[userNumber] - новый массив размерностью заданной пользователем
    */
    for (int i = 1; i <= userNumber; i++)
    {
        result[i - 1] = (int)Math.Pow(i, 2);/* (int) - преобразование в тип int. [i - 1]. Для того чтобы начать с 
        нуля*/
    }
    return result;
}

int number = getNumberFromUser("Введите целое число N > 1: ");
int[] table = tableOfSquarers(number);

for (int i = 0; i < table.Length; i++)/*table.Length - table - наименование переменно хранящей массив.
Lenght - длина массива. table.Length - длина массива "table"
*/
{
    Console.Write(table[i] + " ");// (table[i] + " ") - обращение к индексу массива (начиная с 0) + "пробел"
}
