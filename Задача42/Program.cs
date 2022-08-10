// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
int n = Convert.ToInt32(Console.ReadLine());
string end = "";
while (n > 0 )
{
    int x =  n % 2;
    end = Convert.ToString(x) + end; // положение "+end" регулирует положение цифры при выводе (начало/конец)
    n /= 2;
}
Console.WriteLine(end);


