// для решения всех задач
int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

// для решения второй задачи
int Figure3(int number)
{
    while(number > 999)
    {
        number = number / 10;
    }
    return number % 10;
}

// для решения второй задачи
bool NoNumber(int number)
{
    if(number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
        return false;
    }
    return true;
}

// для решения третьей задачи
bool Weekend(int weekday)
{
    if(weekday > 5)
    {
        return true;
    }
    return false;
}
   
// для решения третьей задачи

bool NoDay(int number)
{
    if(number > 0 && number <=7)
    {
        return true;
    }
    Console.WriteLine("Это не день недели");
    return false;
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
    //Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 1-1 вариант решения 
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
    
    //2 способ решения задачи 2 с использованием методов

    int number = Input("Введите число:");
    if(NoNumber(number))
    {
        Console.WriteLine(Figure3(number));
    }

    
}

void Task3var1()
{
    //Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. 1-Й вариант решения

    int day = Input("Введите день недели используя цифру от 1 до 7:");
    if(day >=1 && day <= 7)
    {
        if(day ==6 || day == 7)
        {
            Console.WriteLine("Заданный день является выходным");
        }
        else
        {
            Console.WriteLine("Заданный день является будним");
        }
    }
    else
    {
        Console.WriteLine("Это не день недели");
    }
}

void Task3var2()
{
   // Второй способ решения задачи 3 с использованием методов
   int day = Input("Введите день недели используя цифры от 1 до 7:");
   if(NoDay(day))
   {
    if(Weekend(day))
   {
        Console.WriteLine("Заданный день недели является выходным");
   }
   else
   {
        Console.WriteLine("Заданный день недели является будним");
   }
   }
   
}

void Task4dop()
{
// Написать программу, которая определяет, является ли треугольник со сторонами a, b, c равнобедренным.
    int a = Input("Введите длину стороны а треугольника a,b,c:");
    int b = Input("Введите длину стороны b треугольника a,b,c:");
    int c = Input("Введите длину стороны c треугольника a,b,c:");
    if(a==c|| b==c||a==b)
    {
        Console.WriteLine($"Треугольника сто сторонами {a} {b} {c} - является равнобедренным");
    }
    else
    {
        Console.WriteLine($"Треугольника сто сторонами {a} {b} {c} - не является равнобедренным");
    }
    
}

void Task5dop()
{
    // На вход подаются год, номер месяца и день рождения человека, Определить возраст человека на момент 1 июля 2022 года.
    int birthyear = Input("Введите год рождения:");
    int birthmonth = Input("Введите месяц рождения:");
    int birthday = Input("Введите день рождения:");

    int realyear = Input("Введите год целевой даты:");
    int realmonth = Input("Введите месяц целевой даты:");
    int realday = Input("Введите день целевой даты:");
    
    int age = realyear - birthyear;
    if(realmonth < birthmonth || (realmonth == birthmonth && realday < birthday))
    {
        age--;
    }
    Console.WriteLine($"Ваш возраст на {realday}.{realmonth}.{realyear}:{age} года (лет)");


}

