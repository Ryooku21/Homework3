// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int fiveDigitNum = Convert.ToInt32(Console.ReadLine());

void PalindromProof(int num)
{
    int firstDigit = num / 10000;
    int secondDigit = num / 1000 % 10;
    int lastDigit = num % 10;
    int preLastDigit = num / 10 % 10;
    if (firstDigit == lastDigit && secondDigit == preLastDigit)
    {
        Console.WriteLine("Введенное число является палиндромом");
    }
    else
    {
        Console.WriteLine("Введенное число не является палиндромом");
    }
}

if (fiveDigitNum > 99999 || fiveDigitNum <= 9999)
{
    Console.WriteLine("Введенное число не является пятизначным, введите корректное число.");
}
else
{
    PalindromProof(fiveDigitNum);
}