// принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


void Power(int a, int b)
{
    int result =Convert.ToInt32(Math.Pow(a, b));
    Console.WriteLine($"Число {a} в степени {b} равняется {result}");
}
Power(5, 8);