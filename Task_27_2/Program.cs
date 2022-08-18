// на вход число и выдаёт сумму цифр в числе

void Sum(int N)   

{
    int sum = 0;
    while (N > 0)
    {
        sum = sum + N % 10;
        N = N / 10;
    }
    Console.WriteLine($"Сумма цифр числа равна {sum}");
} 
   
Sum(479658);
