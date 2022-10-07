/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
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
            Console.WriteLine($"Ошибка ввода! Введите пятизначное число, вы ввели: [{userLine}].");
        }
    }
    return result;
}

int checkUpNumber(int userNumber)
{
    int firstDigit = userNumber / 10000;
    int secondDigit = userNumber / 1000;
    secondDigit = secondDigit % 10;
    int thirdDigit = userNumber / 100;
    thirdDigit = thirdDigit % 100;
    thirdDigit = thirdDigit % 10;
    int forthDigit = userNumber % 100;
    forthDigit = forthDigit / 10;
    int fifthDigit = userNumber % 10;
    if (fifthDigit == fifthDigit && secondDigit == forthDigit)
    {
        Console.WriteLine($"{userNumber} -> Да");
    }
    else 
    {
        Console.WriteLine($"{userNumber} -> Нет");
    }
    return userNumber;
}

int userNumber = getNumberFromUser("Введите пятизначное число: ");
int result = checkUpNumber(userNumber);