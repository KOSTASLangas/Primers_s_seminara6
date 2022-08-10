// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
Console.WriteLine("Введите длины сторон");

int[] array = new int[3];
for (int i = 0; i < 3; i++)
    array[i] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine( "Начальный массив: [" + string.Join (", ", array) + "]");   

if (array[0] < array[1] +  array [2] && array[1] < array[0] +  array [2] && array[2] < array[1] +  array [0])
Console.WriteLine("Треугольник может существовать");
else 
Console.WriteLine("Треугольник не может существовать");
