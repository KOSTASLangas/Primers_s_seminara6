// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
int[] array = new int[5];
for (int i = 0; i < 5; i++)
    array[i] = new Random().Next(0, 101);

int[] array1 = new int[array.Length];
for (int i = 0; i < array1.Length; i++)
{
    int x = array[i];
    array1[i] = x;
}
array1[0] = -10;
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine("[" + string.Join(", ", array1) + "]");