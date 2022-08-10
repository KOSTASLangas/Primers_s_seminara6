// Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)

Console.WriteLine("Введите количество элементов");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
    array [i] = new Random().Next(100, 1000);
Console.WriteLine( "Начальный массив: [" + string.Join (", ", array) + "]");
for (int i = 0; i < n / 2; i++)
{
    int x = array[i];
    array [i] = array [n - i - 1];
    array [n - i - 1] = x; 
}
Console.WriteLine( "Начальный массив: [" + string.Join (", ", array) + "]");