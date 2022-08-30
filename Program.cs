/*
Console.Write("Enter ur num: ");

int number = Convert.ToInt32(Console.ReadLine());

int quad = number * number;

Console.WriteLine("my quad of " + number + " is " + quad);

Console.WriteLine($"the quad of {number} is {quad}");
*/

/*
Console.Write("Enter ur 1st num: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter ur 2nd num: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad = num2 * num2;

if(num1 == quad)
{
    Console.WriteLine($" {num1} is a quad of {num2} ");
}
else
{
    Console.WriteLine($" {num1} is not a quad of {num2} ");
}
*/

/*
Console.Write("Enter ur num: ");
int num = Convert.ToInt32(Console.ReadLine());
int current = num * (-1);
while(current <= num)
{
    Console.Write(current + " ");
    current++;
}
*/
/*
int FindBiggerDigit(int number) //fucking METHod LOL
{
    int ed = number % 10;
    int dec = number / 10;

    int max;
    if(ed > dec) max = ed;
    else max = dec;

    return max;
}

int randNumber = new Random().Next(10, 100);
int biggerDigit = FindBiggerDigit(randNumber);

Console.WriteLine($" Bigger digit of {randNumber} is {biggerDigit} ");
*/

//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
/*
int Method(int num) // 135
{
    int ed = num % 10;
    int hun = num / 100;

    int result = hun * 10 + ed;
    return result;
}

int randNumber = new Random().Next(100, 1000);
int number = Method(randNumber);

Console.WriteLine($" answer is {number} ");
*/

//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
//Если второе число не кратно числу первому, то программа выводит остаток от деления.

/*
void TwoNumbers(int num1, int num2)
{
    if (num2 % num1 == 0)
    {
        Console.WriteLine($" {num2} multiple {num1} ");
    }
    else
    {
        if(num1 > num2)
        Console.WriteLine(" swap values ");
        else
        {
            int div;
            div = num2 % num1;
            Console.WriteLine($" remainder is {div} ");
        }
    }
}

Console.Write("Enter 1st value: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter 2nd value: ");
int n2 = Convert.ToInt32(Console.ReadLine());

TwoNumbers(n1, n2);
*/

//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// int FindQuadrant(double x, double y)
// {
//     if (x > 0 && y > 0) return 1;
//     if (x < 0 && y > 0) return 2;
//     if (x < 0 && y < 0) return 3;
//     if (x > 0 && y < 0) return 4;
//     return 0;
// }

// Console.Write(" Enter X coord ");
// double xA = Convert.ToDouble(Console.ReadLine());
// Console.Write(" Enter Y coord ");
// double yA = Convert.ToDouble(Console.ReadLine());

// int quadrant = FindQuadrant(xA, yA);
// Console.WriteLine("Num of quad is " + quadrant);

//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// void FindXY(int quad)
// {
//     if(quad == 1)
//         Console.WriteLine(" (x > 0 && y > 0) ");
//     if(quad == 2)
//         Console.WriteLine(" (x < 0 && y > 0) ");
//     if(quad == 3)
//         Console.WriteLine(" (x < 0 && y < 0) ");
//     if(quad == 4)
//         Console.WriteLine("  (x > 0 && y < 0) ");
//     if(quad < 1 || quad >  4)
//         Console.WriteLine("  Введены неверные значения ");
// }

// Console.Write(" Enter value ");
// int q1 = Convert.ToInt32(Console.ReadLine());

// FindXY(q1);

// //Напишите программу, которая принимает на вход число (n) и выдаёт квадраты чисел от 1 до n.

// void Method(int num) 
// {
//     int counter = 1;
//     while(counter <= num)
//     {
//         Console.Write(counter * counter + " ");
//         counter++;
//     }
// }

// Console.Write(" Enter value ");
// int num = Convert.ToInt32(Console.ReadLine());

// Method(num);

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве. Math.Sqrt()

// double FindDistance(double x1, double y1, double x2, double y2)
// {
//     return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
// }

// Console.WriteLine(" Enter 1 dot ");
// double xA = Convert.ToDouble(Console.ReadLine());
// double yA = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine(" Enter 2 dot ");
// double xB = Convert.ToDouble(Console.ReadLine());
// double yB = Convert.ToDouble(Console.ReadLine());

// double dist = FindDistance(xA, yA, xB, yB);
// Console.WriteLine($" dist is {dist} ");


// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

// int FindSum(int num)
// {
//     int sum = 0;
//     for (int current = 1; current < num; current++)
//     {
//         sum += current;
//     }
//     return sum;
// }

// Console.Write(" enter pisitive number ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($" sum of nums from 1 to {a}  is {FindSum(a)}");

// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// void Digits(int number)
// {
//     int size = 0;
//     while(number > 0)
//     {
//         number /= 10;
//         size++;
//     }
//     Console.WriteLine($" Entered number consist of {size} digits ");
// }

// Console.Write("Enter value: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Digits(num);


// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// int FindMult(int num)
// {
//     int mult = 1;
//     for (int current = 1; current <= num; current++)
//     {
//         mult *= current;
//     }
//     return mult;
// }

// Console.Write(" enter positive number ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($" fac of {a} is {FindMult(a)}");




// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.


// int[] MakeArray(int size)
// {
//     int[] array = new int [size];
//     return array;
// }

// void FillArray(int[] array)
// {
//     int lenth = array.Length;
//     int index = 0;
//     while (index < lenth)
//     {
//         array[index] = new Random().Next(0, 2);
//         index++;
//     }
// }

// int sizeArr = 8;

// int[] array = MakeArray(sizeArr);
// FillArray(array);
// for(int index = 0; index < array.Length; index++)
// {
//     Console.Write($"{array[index]}");
// }

// ============

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return newArray;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }

//     Console.WriteLine();
// }

// ShowArray(CreateRandomArray(25, 0, 9));