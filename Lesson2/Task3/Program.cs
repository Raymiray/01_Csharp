int n = 10;
int[] array = { 2, 5, 3, 6, 39, 10, 4, 6, 59, 41 };
int i = 0;

while (i < n) //while (i < array.Lenght)
{
    if (array[i] % 2 == 0)
    {
        Console.Write($"{array[i]} ");
    }
    i = i + 1;
}