int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Figure3(int number)
{
    while(number > 999)
    {
        number = number / 10;
    }
    return number % 10;
}

bool NoNumber(int number)
{
    if(number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
        return false;
    }
    return true;
}

void Task1()
{
    //Написать программу,которая на вход принимает трехзначное число, а на выходе показывает вторую цифру этого числа.
    int number = Input ("Введите трехзначное число:");
    if(number < 100 | number >= 1000)
    {
        Console.WriteLine("Вы ввели не трехзначное число!!!Повторите попытку");
        return;
    }
    
    Console.WriteLine($"Введенное число:{number}");
    int number_s = number / 10 % 10;
    Console.WriteLine ($"Второй цифрой числа:{number} являтеся: {number_s} ");
}

void Task2var1()
{
    //Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
    int number = Input("Введите число:");
    int figureK = 0;
    int figureT = 0;
    if(number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else if(number > 999)
    {
        while(number > 999)
        {
        figureK = number / 10;
        figureT = figureK % 10;
        Console.WriteLine($"Третья цифра числа {number}:{figureT}");
        number = number /10;
        }
        
    }
    
    else 
        {
            figureT = number %10;
            Console.WriteLine($"Третья цифра числа {number}:{figureT}");
        }
     
}

void Task2var2()
{
    int number = Input("Введите число:");
    if(NoNumber(number))
    {
        Console.WriteLine(Figure3(number));
    }

    
}

Task2var2();