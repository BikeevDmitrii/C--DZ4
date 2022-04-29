//Напишите функцию, которая принимает на вход число и выдаёт сумму цифр в числе.
int Summa(int a)
{
    int b = 0;
    while (a >= 10)
    {
       b = b + a%10;
       a = a/10;    
    }
    b = b + a;
    return b;
}
Console.WriteLine($"Сумма цифр в числе = {Summa(235479)}");
