/*
Console.WriteLine("Введите первое число");
int Num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int Num2 = int.Parse(Console.ReadLine());

if(Num1 > Num2)
{
    Console.WriteLine("Первое число больше второго");
}
else if(Num1 < Num2)
{
    Console.WriteLine("Второе число больше первого");
}
*/




/*
Console.WriteLine("Введите первое число");
int Num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int Num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третее число");
int Num3 = int.Parse(Console.ReadLine());
int Nummax;

Nummax = 0;
if (Num2 > Num1){
    Nummax = Num2;
}
if (Num3 > Num2){
    Nummax = Num3;
}
if (Num1 > Num3){
    Nummax = Num1;
}

Console.WriteLine ($"Наибольшим числом является {Nummax}");
*/

/*
Console.WriteLine("Введите число");
int Num1 = int.Parse(Console.ReadLine());

if (Num1 % 2==1){
    Console.WriteLine("Число нечетное");
}
else{
    Console.WriteLine("Число четное");
}*/

Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());
int count = 1;

while (count <= N);
{
    Console.WriteLine(count);
    count = count + 1;
}