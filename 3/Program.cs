//  Напишите программу, которая задаёт массив из некоторого количества элементов и
// выводит их на экран с помощью функций. (можно спрашивать количество вводимых элементов и вводить все значения с клавиатуры)

Console.Write("Введите колличество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] Mac()
{
    int[] a = new int[n];
    for (int i = 0; i < n; i++)
    {
        a[i] = Convert.ToInt32(Console.ReadLine());
    }
    return a;
}
void Print(int[] a)
{
    for (int i = 0; i < n; i++)
    {
        Console.Write($"{a[i]} ");
    }
}
int[] array = Mac();
Print(array);
