/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
*/
/*
int CutNumber (int num)
{
    int res = num % 100 /10;
    return res;
}
 int random = new Random().Next(100,1000);
 int newNumber = CutNumber(random);
 Console.WriteLine($"New version of {random} is {newNumber}");*/
/*Задача 15: Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот день выходным.*/
void DayW(int number)
{
    if (number > 0 && number < 8)
    {
        if (number == 6 || number == 7)
        {   
        Console.WriteLine($"Это {number} входной день:");   
        }
        else
        {       
        Console.WriteLine($"Это  {number} рабочий день");        
        }
    }
    else
    {
        Console.WriteLine("рабочий день");
    }
}
Console.Write("введи день: ");
int day = Convert.ToInt32(Console.ReadLine());
DayW(day);