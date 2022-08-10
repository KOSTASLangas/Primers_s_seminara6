// Заполнение двумерного массива с последующим его выводом

int [,] array = new int [5,5];
for (int i = 0; i < array.GetLength(0); i++) // цикл с 4 по 9 строки отвечает за заполнение массива
{
    for (int j = 0; j < array.GetLength(1); j++)
        //array[i,j] = Convert.ToInt32(Console.ReadLine()); // ввод чисел для заполнения массива с клавиатуры
        array [i, j] = new Random().Next (1, 11);  // ввод чисел для заполнения рандомом
}

for (int i = 0; i < array.GetLength(0); i++) // цикл с 11 по 16 строки отвечает за вывод всего массива в виде таблицы
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + "\t  ");
        Console.WriteLine();
}

