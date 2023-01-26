// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


// Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());

// int Summ(int number)

// {
// int count = 
// }


// int number = int.Parse(Console.ReadLine());
// int summ = 0;
//   while (number > 0)
//   {

// summ = summ + number % 10;
// number = number /10 ;

//    }  
// Console.WriteLine(summ);


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int summ = Summ(number);
Console.WriteLine(summ);


int Summ (int number)
{
    int counter = number;
    int summ = 0;
    int result = 0;
    for (int i = 0; i < counter; i++)
    {
     summ = number - number % 10;
        result = result + (number - summ);
        number = number / 10;
    }
    return result;
} 

