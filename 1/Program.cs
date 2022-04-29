//Напишите (функцию) цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int Stepen(int A)
{
    int B = 5;
    int C = 1;
    for (int i = 1; i <= B; i++)
    {
        C = C * A;  
    }
    return C;
}
Console.WriteLine($"A в степени B = {Stepen(5)}");

