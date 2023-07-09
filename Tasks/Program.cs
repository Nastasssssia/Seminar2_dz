int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
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


    