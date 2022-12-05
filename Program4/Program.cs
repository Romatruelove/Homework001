Console.WriteLine("Введите первое целое число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число");
int num3 = Convert.ToInt32(Console.ReadLine());

    if(num1 > num2 && num1 > num3)
    {
        Console.WriteLine($"{num1} максимальное число");
    }
    else if(num2 > num1 && num2 > num3)
    {
        Console.WriteLine($"{num2} максимальное число");
    }
    else if(num3 > num1 && num3 > num2)
    {
        Console.WriteLine($"{num3} максимальное число");
    }