using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Praktika_Nikitin
{
    class Programm
    {
        //static void Main(string[] args)
        //{
        ///Lesson 2

        //EX2
        //Console.WriteLine("Введите число");
        //int x = Int32.Parse(Console.ReadLine());
        //Console.WriteLine((x % 3 == 0 ? "Делится на 3" : "Не делится на 3"));
        //Console.ReadLine();

        //EX3
        //Console.WriteLine("Введите число");
        //int x = Int32.Parse(Console.ReadLine());
        //bool flag = x % 5 == 2 && x % 7 == 1;
        //Console.WriteLine((flag ? "Удовлетворяет условиям" : "Не удовлетворяет условиям"));
        //Console.ReadLine();

        //EX4
        //Console.WriteLine("Введите число");
        //int x = Int32.Parse(Console.ReadLine());
        //bool flag = x % 4 == 0 && x < 10;
        //Console.WriteLine((flag ? "Удовлетворяет условиям" : "Не удовлетворяет условиям"));
        //Console.ReadKey();

        //EX5
        //Console.WriteLine("Введите число");
        //int x = Int32.Parse(Console.ReadLine());
        //bool flag = 5 <= x && x <= 10;
        //Console.WriteLine((flag ? "Удовлетворяет условиям" : "Не удовлетворяет условиям"));
        //Console.ReadLine();

        //EX6
        //Console.WriteLine("Напишите число");
        //int x = Int32.Parse(Console.ReadLine()) / 1000;
        //Console.WriteLine(("Количество тысяч = " + x ));
        //Console.ReadLine();

        //EX7
        //Console.WriteLine("Напишите число");
        //int x = Int32.Parse(Console.ReadLine()) / 10;
        //int y = (x / 8) * 10 + x % 8;
        //Console.WriteLine(y);
        //Console.ReadLine();


        //EX8
        //Console.WriteLine("Введите число");
        //int x = Int32.Parse(Console.ReadLine());
        //int y = Convert.ToInt32(Convert.ToString(x, 2)) / 100;
        //Console.WriteLine(y);
        //Console.ReadLine();

        //EX9
        //Console.WriteLine("Введите число в двоичном виде");
        //int x = Int32.Parse(Console.ReadLine());
        //int y = x;
        //y = (y / 1000) * 1000 + 100 + y % 100;
        //Console.WriteLine(y);
        //Console.ReadLine();


        //EX10
        //Console.WriteLine("Введите число в двоичном виде");
        //int x = Int32.Parse(Console.ReadLine());
        //int y = x;
        //y = (y / 10000) * 10000 + y % 1000;
        //Console.WriteLine(y);
        //Console.ReadLine();

        //EX11
        //Console.WriteLine("Введите число в двоичном виде");
        //string a = Console.ReadLine();
        //int x = a.Length - 1;
        //x = Convert.ToInt32(Math.Pow(10, x));
        //int y = Int32.Parse(a);
        //int z = 1 - Convert.ToInt32(y % x) / (x / 10);
        //y = (y / x) * x + x / 10 + y % (x / 10);
        //Console.WriteLine(y);
        //Console.ReadLine();




        ///Lesson 3
        ///EX2
        //int number, numb1, numb2;
        //Console.WriteLine("Введите целое число");
        //number = Int32.Parse(Console.ReadLine());

        //numb1 = number / 7;
        //numb2 = number / 3;

        //Console.WriteLine($"Первое = {numb1} ");
        //Console.WriteLine($"Второе = {numb2} ");
        //Console.ReadLine();

        //EX3
        //int numb1, numb2;
        //Console.WriteLine("Введите первое целое число");
        //numb1 = Int32.Parse(Console.ReadLine());
        //Console.WriteLine("Введите второе целое число");
        //numb2 = Int32.Parse(Console.ReadLine());
        //if (numb1 > numb2) Console.WriteLine($"{numb1} > {numb2}");
        //else if (numb2 > numb1) Console.WriteLine($"{numb2} > {numb1}");
        //else if (numb1 == numb2) Console.WriteLine($"{numb1} = {numb2}");
        //Console.ReadLine();

        //EX4
        //int numb, summ = 0;
        //Console.WriteLine("Введите целое число");
        //numb = Int32.Parse(Console.ReadLine());

        //while (numb != 0)
        //{
        //    summ += numb;
        //    Console.WriteLine("Введите целое число");
        //    numb = Int32.Parse(Console.ReadLine());
        //}
        //Console.WriteLine($"Ваш номер {summ}");
        //Console.ReadLine();

        //EX5
        //int numb;
        //string txt = "";
        //Console.WriteLine("Введите число от 1 до 7");
        //numb = Int32.Parse(Console.ReadLine());

        //switch (numb)
        //{
        //    case 1:
        //        txt = "Понедельник";
        //        break;
        //    case 2:
        //        txt = "Вторник";
        //        break;
        //    case 3:
        //        txt = "Среда";
        //        break;
        //    case 4:
        //        txt = "Четверг";
        //        break;
        //    case 5:
        //        txt = "Пятница";
        //        break;
        //    case 6:
        //        txt = "Суббота";
        //        break;
        //    case 7:
        //        txt = "Воскресенье";
        //        break;
        //}
        //Console.WriteLine(txt, "день");
        //Console.ReadLine();

        //EX6
        //string txt = "";
        //Console.Write("Введите день недели:");
        //txt = Console.ReadLine();

        //if (txt == "Понедельник") Console.WriteLine("1");
        //else if (txt == "Вторник") Console.WriteLine("2");
        //else if (txt == "Среда") Console.WriteLine("3");
        //else if (txt == "Четверг") Console.WriteLine("4");
        //else if (txt == "Пятница") Console.WriteLine("5");
        //else if (txt == "Суббота") Console.WriteLine("6");
        //else if (txt == "Воскресенье") Console.WriteLine("7");
        //else Console.WriteLine("Такого дня нет");
        //Console.ReadLine();

        //EX7
        //int value, k = 1, sum = 0;
        //Console.WriteLine("Введите целое число");
        //value = Int32.Parse(Console.ReadLine());
        //do
        //{

        //    sum += k;

        //    k += 2;
        //} while (k <= value);
        //Console.WriteLine("Сумма целых чисел {0} = {1}", value, sum);
        //Console.ReadLine();


        //EX8
        //int value, k = 1, sum = 0;
        //Console.WriteLine("Введите числа");
        //value = Int32.Parse(Console.ReadLine());

        //for (; (k <= value); sum += k * k, k++) ;

        //Console.WriteLine("Сумма двоичных чисел целого числа {0} = {1}", value, sum);
        //Console.ReadLine();

        //EX9
        //int one = 1, two = 1, number, value;
        //Console.WriteLine("Введите значения чисел в Фибоначчи");
        //value = Int32.Parse(Console.ReadLine());
        //Console.WriteLine();
        //Console.Write(one + "," + two);
        //while (value > 0)
        //{
        //    number = one + two;
        //    one = two;
        //    two = number;
        //    value--;
        //    Console.Write("," + number);
        //}
        //Console.ReadLine();

        //EX10
        //int one, two, value1, value2;
        //try
        //{
        //    Console.WriteLine("Введите целое число");
        //    one = Int32.Parse(Console.ReadLine());
        //    Console.WriteLine("Введите второе целое число");
        //    two = Int32.Parse(Console.ReadLine());
        //    if (one < two)
        //    {
        //        value1 = one;
        //        value2 = two;
        //        Console.Write(value1);
        //    }
        //    else
        //    {
        //        value1 = two;
        //        value2 = one;
        //        Console.Write(value1);
        //    }
        //    while (value1 < value2)
        //    {
        //        value1++;
        //        Console.Write("," + value1);
        //    }
        //}
        //catch
        //{
        //    Console.WriteLine("Целое число неверно");
        //}
        //Console.ReadLine();

        //EX11
        //int a, result = 0, answer = 0;
        //try
        //{
        //    Console.WriteLine("Введите количество чисел в сумме");
        //    a = Int32.Parse(Console.ReadLine());
        //    for (int i = 0; i < a; i++)
        //    {
        //        if (i % 5 == 2)
        //        {
        //            result += 1;
        //            answer += result;
        //        }
        //    }
        //    Console.WriteLine($"Остаток 2 {answer}");
        //    for (int i = 0; i < a; i++)
        //    {
        //        if (i % 3 == 1)
        //        {
        //            result += 1;
        //            answer += result;
        //        }
        //    }
        //    Console.WriteLine($"Остаток 1 {answer}");
        //}
        //catch
        //{
        //    Console.WriteLine("Неверные данные");
        //}
        //Console.ReadLine();

        //Lesson 4

        //EX2
        //int[] nums = new int[12];
        //for (int k = 0; k < nums.Length; k++)
        //{
        //    nums[k] = 5 * k + 2;
        //    Console.Write("|" + nums[k] + "");

        //}
        //Console.WriteLine("|");
        //Console.ReadLine();

        ////EX3
        //int start = 1;
        //const int SIZE = 11;
        //int[] nums = new int[SIZE];
        //for (int i = 0; i < SIZE; i++)
        //{
        //    nums[i] = start;
        //    start <<= 1;
        //}
        //Console.WriteLine("Массив:");
        //for (int i = 0; i < SIZE; i++)
        //{
        //    Console.Write(nums[i] + " ");
        //}
        //Console.WriteLine("\nМассив в обратном порядке:");
        //for (int i = SIZE - 1; i >= 0; i--)
        //{
        //    Console.Write(nums[i] + " ");
        //}
        //Console.ReadLine();

        //EX4
        //int size = 10;
        //char value = 'a';
        //char[] array = new char[size];
        //for (int i = 0; i < array.Length; i++)
        //{
        //    array[i] = (char)value++;
        //    value++;
        //    Console.WriteLine("{0} = {1}", i, array[i]);
        //}
        //Console.WriteLine();
        //for (int j = size - 1; j >= 0; j--)
        //{
        //    Console.WriteLine("{0} = {1}", j, array[j]);
        //}
        //Console.ReadLine();



        //EX5
        //var voels = new char[] { 'A', 'E', 'I', 'O', 'Y', 'U' };
        //var a = Enumerable.Range('A', 'Z' - 'A' + 1).Select(x => (char)x).Except(voels).ToArray();
        //foreach (var c in a) Console.Write(c);
        //Console.ReadLine();

        //EX6
        //int value, min, k;
        //int[] array = new int[10];
        //Random rnd = new Random();
        //Console.WriteLine("Заполненный массив");
        //for (int i = 0; i < array.Length; i++)
        //{
        //    value = rnd.Next(0, 1000);
        //    array[i] = value;
        //    Console.WriteLine("{0} = {1}", i, array[i]);
        //}
        //Console.WriteLine();
        //min = array[0];
        //for (k = 0; k < array.Length; k++)
        //{
        //    if (array[k] <= min)
        //    {
        //        min = array[k];
        //    }
        //}
        //for (int j = 0; j < array.Length; j++)
        //{
        //    if (array[j] == min)
        //    {
        //        Console.WriteLine("Индекс минимального элемента = {0} Минимальное значение элемента = {1}",
        //            j, array[j]);
        //    }
        //}
        //Console.ReadLine();

        //EX7
        //int value, max = 0;
        //int[] array = new int[10];
        //Random rnd = new Random();
        //Console.WriteLine("Созданные значения массива");
        //Console.WriteLine();
        //for (int i = 0; i < array.Length; i++)
        //{
        //    value = rnd.Next(0, 1000);
        //    array[i] = value;
        //    Console.WriteLine("{0} = {1}", i, array[i]);
        //}
        //Console.WriteLine();
        //for (int k = 1; k < array.Length; k++)
        //{
        //    for (int j = 0; j < array.Length - k; j++)
        //    {
        //        if (array[j] < array[j + 1])
        //        {
        //            max = array[j + 1];
        //            array[j + 1] = array[j];
        //            array[j] = max;
        //        }
        //    }
        //}
        //Console.WriteLine();
        //Console.WriteLine("Массив после сортировки");
        //Console.WriteLine();
        //for (int a = 0; a < array.Length; a++)
        //{
        //    Console.WriteLine("{0} = {1}", a, array[a]);
        //}
        //Console.ReadLine();

        //EX8
        //char value;

        //Random rnd = new Random();

        //char[] array = new char[10];

        //Console.WriteLine("Созданный массив символов");
        //Console.WriteLine();
        //for (int i = 0; i < array.Length; i++)
        //{
        //    value = (char)rnd.Next(0, 200);
        //    array[i] = value;

        //    Console.WriteLine("{0} = {1}", i, array[i]);
        //}
        //Console.WriteLine();
        //Console.WriteLine("Массив в обратном порядке");
        //Console.WriteLine();

        //for (int k = 9; k >= 0; k--)
        //{
        //    Console.WriteLine("{0} = {1}", k, array[k]);
        //}
        //Console.ReadLine();

        //EX9
        //int sizeStroka = 3, sizeStolbec = 5, value;
        //int[,] array = new int[sizeStroka, sizeStolbec];
        //int[,] copyArray = new int[sizeStolbec, sizeStroka];
        //Random rnd = new Random();
        //for (int i = 0; i < array.GetLength(0); i++)
        //{
        //    for (int k = 0; k < array.GetLength(1); k++)
        //    {
        //        value = rnd.Next(0, 1000);
        //        array[i, k] = value;
        //        Console.Write(array[i, k] + "\t");
        //    }
        //    Console.WriteLine();
        //}
        //Console.WriteLine();
        //Console.WriteLine("После подмены");
        //Console.WriteLine();
        //for (int i = 0; i < copyArray.GetLength(0); i++)
        //{
        //    for (int j = 0; j < copyArray.GetLength(1); j++)
        //    {
        //        copyArray[i, j] = array[j, i];
        //        Console.Write(copyArray[i, j] + "\t");
        //    }
        //    Console.WriteLine();
        //}
        //Console.ReadLine();

        //EX10
        //int value, str, stolb;
        //int[,] array = new int[5, 5];
        //int[,] arrayTwo = new int[5, 5];
        //Random rnd = new Random();
        //for (int i = 0; i < array.GetLength(0); i++)
        //{
        //    for (int k = 0; k < array.GetLength(1); k++)
        //    {
        //        value = rnd.Next(0, 100);
        //        array[i, k] = value;
        //        Console.Write(array[i, k] + "\t");
        //    }
        //    Console.WriteLine();
        //}
        //str = rnd.Next(0, 5);
        //stolb = rnd.Next(0, 5);
        //Console.WriteLine();
        //Console.WriteLine("Row Index = {0} \nColumn Index = {1}", str, stolb);
        //Console.WriteLine();
        //for (int i = 0; i < arrayTwo.GetLength(0); i++)
        //{
        //    if (i != str)
        //    {
        //        for (int k = 0; k < arrayTwo.GetLength(1); k++)
        //        {
        //            if (k != stolb)
        //            {
        //                arrayTwo[i, k] = array[i, k];
        //                Console.Write(arrayTwo[i, k] + "\t");
        //            }
        //        }
        //        Console.WriteLine();
        //    }
        //}
        //Console.ReadLine();

        //Lesson 5 EX2
        //static void Main()
        //{
        //    Console.WriteLine("Двойной факториал числа");
        //    Console.WriteLine(Fact1(9));
        //    Console.ReadLine();
        //}
        //static int Fact2(int n)
        //{
        //    int result = 1;
        //    for (int i = n % 2 == 0 ? 2 : 1; i <= n; i += 2)
        //        result *= i;

        //    return result;

        //}
        //static int Fact1(int n)
        //{
        //    if (n == 1)
        //        return 1;
        //    else if (n == 0)
        //        return 0;
        //    else
        //    {
        //        if (n % 2 == 0)
        //        {
        //            if (n == 2)
        //                return n;

        //            return n * Fact1(n - 2);
        //        }
        //        else
        //        {
        //            if (n == 1)
        //                return n;

        //            return n * Fact1(n - 2);

        //        }
        //    }
        //}

        //Lesson 5 EX3
        //static void Main()
        //{
        //    Console.WriteLine("Сумма квадратов натуральных чисел");
        //    Console.WriteLine(sum(10));
        //    Console.ReadLine();

        //}
        //static int sum(int n)
        //{
        //    if (n <= 1)
        //        return n;
        //    else
        //        return sum(n - 1) + n * n;

        //    {
        //        int result = 0;
        //        for (int i = 1; i <= n; i++)
        //            result += Convert.ToInt32(Math.Pow(i, 2));
        //        return result;
        //    }
        //}

        //Lesson 5 EX4
        //static T[] Foo<T>(T[] array, int n) => array.Take(n).ToArray();

        //static void Main(string[] args)
        //{
        //    var arr1 = new int[] { 1, 2, 3 };
        //    var arr2 = new char[] { 'x', 'y', 'z' };
        //    var arr3 = Foo(arr1, 5);
        //    Console.WriteLine(string.Join(" ", arr3));
        //    var arr4 = Foo(arr2, 2);
        //    Console.WriteLine(string.Join(" ", arr4));
        //    Console.ReadLine();


        //Lesson5 EX5
        //static int[] mas(char[] symb, int lenght)
        //{
        //    int[] num = new int[lenght];
        //    for (int i = 0; i < lenght; i++)
        //    {
        //        num[i] = (int)symb[i];
        //    }
        //    return num;

        //}
        //static void Main(string[] args)
        //{

        //    char[] a = { 'a', 'b', 'c', 'd', 'e', 'f', 'g' };
        //    int[] b = mas(a, 3);

        //    Console.Write(a);

        //    Console.ReadLine();
        //}

        //Lesson5 EX6
        //static void Main(string[] args)
        //{
        //    int[] mass = new int[10];
        //    Random rnd = new Random();
        //    for (int i = 0; i < mass.Length; i++)
        //    {
        //        mass[i] = rnd.Next(1, 101);
        //    }
        //    Console.WriteLine(some(mass));
        //    Console.ReadLine();

        //}
        //static double some (int[] mass)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < mass.Length; i++)
        //    {
        //        sum += mass[i];
        //    }
        //    Console.WriteLine(sum);
        //    Console.WriteLine(mass.Length);
        //    Console.WriteLine(sum / mass.Length);
        //    return sum / mass.Length;
        //}


        //Lesson5 EX7
        //static int Max(int[,] arr, out int maxi, out int maxj)
        //{
        //    int max = arr[0, 0];
        //    maxi = 0; maxj = 0;
        //    for (int i = 0; i < arr.GetLength(0); i++)
        //    {
        //        for (int k = 0; k < arr.GetLength(1); k++)
        //        {
        //            if (max < arr[i, k])
        //                max = arr[i, k]; maxi = i; maxj = k;
        //        }
        //    }
        //    return max;
        //}
        //static void Main()
        //{
        //    int[,] A = { { 4, 5, 3 }, { 4, 2, 6 } };
        //    int imax, jmax;
        //    Console.WriteLine("Массив по умолчанию:");
        //    Console.Write(A);
        //    Console.WriteLine("Максимальный элемент массива:");
        //    Console.WriteLine(Max(A, out imax, out jmax));
        //    Console.WriteLine("Индекс элемента: [{0},{1}]", imax, jmax);
        //    Console.ReadLine();
        //}

        ////Lesson5 EX8
        //static void Main()
        //{
        //    char[] arr = { 'П', 'р', 'и', 'в', 'е', 'т','!' };
        //    Sort(arr);
        //    foreach (char ch in arr)
        //        Console.Write(ch + " ");

        //    Console.ReadLine();
        //}

        //static void Sort(char[] arr)
        //{
        //    for (int i = 0; i < arr.Length / 2; i++)
        //    {
        //        char temp = arr[i];
        //        arr[i] = arr[arr.Length - i - 1];
        //        arr[arr.Length - i - 1] = temp;
        //    }

        ////Lesson5 EX9
        //static void Main()
        //{
        //    object[] A = Foo('a', 'z');
        //    for (int i = 0; i < A.Length; i++)
        //        Console.WriteLine($" A[{i}]= {A[i]}");
        //    Console.ReadLine();
        //}
        //static object[] Foo(int a, int b)
        //{
        //    object[] nums;
        //    if (b < a)
        //    {
        //        int tmp = a;
        //        a = b;
        //        b = tmp;
        //    }
        //    if (a != b)
        //    {
        //        int length = 0;
        //        for (int i = a; i <= b; i++)
        //            length++;
        //        nums = new object[length];

        //        int t = a;
        //        for (int i = 0; i < length; i++)
        //        {
        //            nums[i] = t;
        //            t++;
        //        }
        //        return nums;
        //    }
        //    else
        //    {
        //        nums = new object[2];
        //        nums[0] = a;
        //        nums[1] = b;
        //        return nums;
        //    }
        //}
        //static object[] Foo(char a, char b)
        //{
        //    object[] nums;
        //    if (b < a)
        //    {
        //        char tmp = a;
        //        a = b;
        //        b = tmp;
        //    }
        //    if (a != b)
        //    {
        //        int length = 0;
        //        for (int i = a; i <= b; i++)
        //            length++;
        //        nums = new object[length];
        //        char t = a;
        //        for (int i = 0; i < length; i++)
        //        {
        //            nums[i] = t;
        //            t++;
        //        }
        //        return nums;
        //    }
        //    else
        //    {
        //        nums = new object[2];
        //        nums[0] = a;
        //        nums[1] = b;
        //        return nums;
        //    }
        //}

        //Lesson5 EX10
        //static int[] metod(params int[] p)
        //{
        //    int[] mas = new int[2] { p[0], p[0] };
        //    for (int i = 0; i < p.Length; i++)
        //    {
        //        if (p[i] > mas[0])
        //            mas[0] = p[i];
        //        if (p[i] < mas[0])
        //            mas[0] = p[i];

        //    }
        //    return mas;
        //}
        //static void Main(string[] args)
        //{
        //    var mas = metod(1, 2, 3, 6, 12, 34, 56, 90);
        //    Console.WriteLine($"{mas[0]} {mas[1]}");
        //    Console.ReadLine();

        //Lesson5 EX11
        //static void Main(string[] args)
        //{
        //    Somestring("Хочу", 'п', 'я', 'т', 'ё', 'р', 'к', 'у');
        //    Console.ReadLine();
        //}
        //static void Somestring(string text, params char[] a)
        //{
        //    string newText = String.Join("", a);
        //    Console.WriteLine(text + newText);
        //}


        //EX11 Lesson 4
        //static int get_n()
        //{
        //    Console.Write("N: ");
        //    int n = Int32.Parse(Console.ReadLine());

        //    if (n < 0)
        //        throw new Exception("wrong n");
        //    return n;
        //}

        //static void print(int[,] array, int n, int m, String name)
        //{
        //    Console.WriteLine(name + ": ");
        //    for (int i = 0; i < n; ++i)
        //    {
        //        for (int j = 0; j < m; ++j)
        //        {
        //            Console.Write(array[i, j] + " ");
        //        }
        //        Console.Write("\n");
        //    }
        //    Console.Write("\n");
        //}

        //static void Main()
        //{
        //    int n = get_n();
        //    int m = n;
        //    int[,] a = new int[n, m];
        //    int value = 1;
        //    for (int i = 0; i < n; ++i)
        //    {
        //        if (i % 2 == 0)
        //        {
        //            for (int j = 0; j < m; ++j)
        //            {
        //                a[i, j] = value;
        //                value++;
        //            }
        //        }
        //        else
        //        {
        //            for (int j = m - 1; j >= 0; --j)
        //            {
        //                a[i, j] = value;
        //                value++;
        //            }
        //        }
        //    }
        //    print(a, n, m, "A");
        //    Console.ReadLine();


        //Lesson6 EX2
        //class MainClass
        //{
        //    public static void Main(string[] args)
        //    {
        //        Exercise exe = new Exercise();
        //        exe.Set('F');
        //        exe.VozratKodSymvola();
        //        exe.ShowSymbolСode();
        //        Console.ReadLine();
        //    }
        //}
        //private char symbol;
        //public void Set(char symbol)
        //{
        //    this.symbol = symbol;
        //}
        //public int VozratKodSymvola()
        //{
        //    return symbol;
        //}
        //public void ShowSymbolСode()
        //{
        //    Console.Write("Поле объекта:" + symbol + " и код этого символа " + (int)symbol);
        //}

        //Lesson6 EX3
        //    private char symb1;
        //    private char symb2;
        //    public Main(char s1, char s2)
        //    {
        //        symb1 = s1;
        //        symb2 = s2;
        //    }

        //    public void Show()
        //    {
        //        for (char c = symb1; c <= symb2; c++)
        //            Console.Write("| {0} ", c);
        //        Console.WriteLine("|");
        //    }
        //}

        //class Program
        //{
        //    static void Main()
        //    {
        //        Main A = new Main('A', 'D');
        //        A.Show();
        //        Console.ReadLine();
        //    }
        //}

        //Lesson6 EX4
        //    static void Main(string[] args)
        //    {
        //        Class1 cls = new Class1();
        //        Class1 cls1 = new Class1(123456);
        //        Class1 cls2 = new Class1(7890, 122333);
        //    }
        //}
        //class Class1
        //{
        //    private int q;
        //    private int w;
        //    public Class1()
        //    {

        //    }
        //    public Class1(int x)
        //    {
        //        q = w = x;
        //        Console.WriteLine($"{x}");
        //    }
        //    public Class1(int a, int b)
        //    {
        //        q = a;
        //        w = b;
        //        Console.WriteLine($"{q},{w}");
        //        Console.ReadLine();
        //    }
        //}

        //Lesson6 EX5
        //    static void Main(string[] args)
        //    {
        //        MyClass koban = new MyClass(456, 'Q');
        //        koban.FieldConsole();
        //        MyClass koban2 = new MyClass(56.839);
        //        koban2.FieldConsole();
        //    }
        //    class MyClass
        //    {
        //        private int num;
        //        private char sym;
        //        public MyClass(double dor)
        //        {
        //            sym = Convert.ToChar(Convert.ToInt32(dor / 1));
        //            num = (int)(dor % 1 * 100);
        //        }
        //        public MyClass(int x, char y)
        //        {
        //            num = x;
        //            sym = y;
        //        }
        //        public void FieldConsole()
        //        {
        //            Console.WriteLine(Convert.ToString(num) + " " + Convert.ToString(sym));
        //            Console.ReadLine();
        //        }
        //    }
        //}

        //Lesson6 EX6
        //    static void Main(string[] args)
        //    {
        //        Six s1 = new Six();
        //        s1.GetField();
        //        s1.SetField(123456789);
        //        s1.GetField();
        //        Six s2 = new Six(40);
        //        s2.GetField();
        //        s2.SetField();
        //        s2.GetField();
        //    }
        //    class Six
        //    {
        //        private int sixNum;
        //        public Six()
        //        {
        //            sixNum = 0;
        //        }
        //        public Six(int n)
        //        {
        //            if (n <= 100)
        //                sixNum = n;
        //            else
        //                sixNum = 100;
        //        }
        //        public void SetField()
        //        {
        //            sixNum = 0;
        //        }
        //        public void SetField(int n)
        //        {
        //            if (n <= 100)
        //                sixNum = n;
        //            else
        //                sixNum = 100;
        //        }
        //        public void GetField()
        //        {
        //            Console.WriteLine(sixNum);
        //            Console.ReadLine();
        //        }
        //    }
        //}

        //Lesson6 EX7
        //        private int number;

        //        public Main(int s)
        //        {
        //            number = s;
        //        }

        //        public Main()
        //        {

        //        }

        //        public void Show(int a)
        //        {
        //            number = a;
        //        }

        //        public void Show()
        //        {
        //            number = 0;
        //        }

        //        public void Result()
        //        {
        //            if (number > 100)
        //            {
        //                number = 100;
        //                Console.WriteLine(number);
        //            }
        //            else
        //            {
        //                Console.WriteLine(number);
        //            }
        //        }
        //    }
        //    class Program
        //    {
        //        static void Main(string[] args)
        //        {
        //            Main obj = new Main();
        //            obj.Show(25);
        //            Console.Write("Метод вызывается аргументом и ему присваивается значение:");
        //            obj.Result();
        //            obj.Show();
        //            Console.Write("Метод вызывается без аргумента и ему присваивается значение:");
        //            obj.Result();
        //            obj.Show(250);
        //            Console.Write("Метод вызывается аргументом больше 100 и ему присвается значение:");
        //            obj.Result();
        //            Main B = new Main(260);
        //            Console.Write("Создается новый объект класса и ему присваивается значение:");
        //            B.Result();
        //            Console.ReadLine();
        //        }
        //    }
        //}


        //Lesson6 EX8
        //        private char symb;
        //        private string txt;
        //        public Main(char s)
        //        {
        //            symb = s;
        //        }

        //        public Main(string t)
        //        {
        //            txt = t;
        //        }

        //        public Main(char[] c)
        //        {
        //            if (c.Length == 1)
        //                symb = c[0];
        //            else
        //            {
        //                txt = "";
        //                for (int k = 0; k < c.Length; k++)
        //                {
        //                    txt += c[k];
        //                }
        //            }
        //        }

        //        public char ret_c()
        //        {
        //            return symb;
        //        }
        //        public string ret_txt()
        //        {
        //            return txt;
        //        }
        //    }

        //    class Program
        //    {
        //        static void Main()
        //        {
        //            char[] Mass1 = { 'a', 'b', 'c' };
        //            char[] Mass2 = { 'd' };
        //            Main A = new Main('A');
        //            Console.WriteLine("Конструктор вызывается одним символьным параметром: {0}", A.ret_c());
        //            Main B = new Main("Строка");
        //            Console.WriteLine("Конструктор вызывается одним строковым параметром: {0}", B.ret_txt());
        //            Main C = new Main(Mass1);
        //            Console.WriteLine("Конструктор вызывается массивом из более чем одного элемента: {0}", C.ret_txt());
        //            Main D = new Main(Mass2);
        //            Console.WriteLine("Конструктор вызывается одним массивом элемента: {0}", D.ret_c());
        //            Console.ReadLine();
        //        }
        //    }
        //}

        //Lesson6 EX9
        //        static void Main(string[] args)
        //        {
        //            for (int i = 0; i < 5; i++)
        //            {
        //                ExampleClasss.Method();
        //            }
        //            Console.ReadLine();
        //        }
        //    }
        //    class ExampleClasss
        //    {
        //        private static int field = 0;

        //        public static void Method()
        //        {
        //            Console.WriteLine(field);
        //            field += 1;
        //        }
        //    }
        //}

        //Lesson6 EX10
        //static public void Method1(out int mn, out int mx, out double avg,
        //   params int[] a)
        //{

        //    int sum = 0;
        //    mx = a[0];
        //    mn = a[0];
        //    for (int k = 0; k < a.Length; k++)
        //    {

        //            sum += a[k];
        //            if (a[k] > mx) mx = a[k];
        //            if (a[k] < mn) mn = a[k];
        //        }

        //        avg = (double)sum / a.Length;
        //    }
        //}

        //class Program
        //{
        //    static void Main()
        //    {

        //        int[] A = { 1, 3, 5, 7, 15, 8 };

        //        int Mn, Mx;
        //        double Avg;

        //        Main1.Method1(out Mn, out Mx, out Avg, A);
        //        Console.WriteLine("Минимальное значение: {0}", Mn);
        //        Console.WriteLine("Максимальное значение: {0}", Mx);
        //        Console.WriteLine("Среднее значение: {0}", Avg);

        //        Console.ReadLine();
        //    }
        //}


        //Lesson7 EX2
        //static string WhiteSpace(string a)
        //{
        //    var r = string.Empty;
        //    for (var i = 0; i < a.Length; i++)
        //    {
        //        r += a[i];
        //        if (i < a.Length - 1) r += " ";
        //    }
        //    return r;
        //}
        //static void Main()
        //{
        //    Console.WriteLine(WhiteSpace("sometimes i fell apset then i should wake up"));
        //    Console.ReadLine();
        //}

        //Lesson7 EX3
        //static void Reverse()
        //{
        //    string sres = " ";
        //    Regex reg = new Regex("(?<=^|[^a-zA-Za-ztA-Zt])[a-zA-Za-ztA-Zt]+(?=$|[^a-zA-Za-ztA-Zt])");
        //    string str = " ";
        //    Console.WriteLine("Введите строку:");
        //    str = Console.ReadLine();
        //    MatchCollection mc = reg.Matches(str);
        //    for (int i = 0; i < mc.Count; i++)
        //    {
        //        string rev = "";
        //        for (int j = mc[i].Length - 1; j >= 0; --j)
        //        {
        //            rev += mc[i].Value[j];
        //        }

        //        int ib = (i == 0 ? 0 : mc[i - 1].Index + mc[i - 1].Length);
        //        int ie = mc[i].Index;
        //        sres += str.Substring(ib, ie - ib) + rev;
        //    }
        //    Console.WriteLine(sres);
        //}
        //static void Main()
        //{
        //    Reverse();
        //    Console.ReadLine();
        //}

        //Lesson7 EX4
        //static bool txt(string s1, string s2)
        //{
        //    if (s1 == s2)
        //        return true;
        //    else
        //        return false;
        //}
        //static void Main()
        //{
        //    string s1, s2;
        //    Console.Write("Ведите первую строку: ");
        //    s1 = Console.ReadLine();
        //    Console.Write("Введите вторую строку:");
        //    s2 = Console.ReadLine();
        //    if (txt(s1, s2))
        //        Console.WriteLine("Строки одинаковы");
        //    else
        //        Console.WriteLine("Строки разные");
        //    Console.ReadLine();
        //}

        //Lesson7 EX5
        //static bool IsEqual(string str1, string str2) => str1.Distinct().OrderBy(x => x).SequenceEqual(str2.Distinct().OrderBy(x => x));

        //static void Main()
        //{
        //    string s1, s2;
        //    Console.Write("Ведите первую строку:");
        //    s1 = Console.ReadLine();
        //    Console.Write("Введите вторую строку:");
        //    s2 = Console.ReadLine();
        //    if (IsEqual(s1, s2))
        //        Console.WriteLine("Строки одинаковы:");
        //    else
        //        Console.WriteLine("Строки разные");
        //    Console.ReadLine();
        //}

        ////Lesson7 EX6
        //static void IsEqual(string str1, char str2)
        //{
        //    bool c = false;
        //    for (int i = 0; i < str1.Length; i++)
        //    {
        //        if (str1[i] == str2)
        //        {
        //            c = true;
        //            Console.WriteLine(i);
        //        }
        //    }
        //    if (!c)
        //        Console.WriteLine("-1");
        //}

        //static void Main()
        //{
        //    string s1;
        //    char s2;
        //    Console.Write("Введите строку 2:  ");
        //    s1 = Console.ReadLine();
        //    Console.WriteLine("Введите строку 2: ");
        //    s2 = Convert.ToChar(Console.ReadLine());
        //    IsEqual(s1, s2);
        //    Console.ReadLine();
        //}

        //Lesson7 EX7
        //static void IsEqual(string str1)
        //{
        //    char[] b = str1.ToCharArray();
        //    Array.Sort(b);
        //    Console.WriteLine(b);
        //}
        //static void Main()
        //{
        //    string s1;
        //    char s2;
        //    Console.Write("Введите строку 1: ");
        //    s1 = Console.ReadLine();
        //    IsEqual(s1);
        //    Console.ReadLine();
        //}

        //Lesson7 EX8
        //static void IsEqual(string str1, int index)
        //{
        //    string otv = "";
        //    for (int i = index; i < str1.Length; i++)
        //        otv += str1[i];
        //    Console.WriteLine(otv);
        //}

        //static void Main()
        //{
        //    string s1;
        //    int c;
        //    Console.WriteLine("Введите первую строку:");
        //    s1 = Console.ReadLine();
        //    Console.Write("Введите подстроку индекса:");
        //    c = Int32.Parse(Console.ReadLine());
        //    IsEqual(s1, c);
        //    Console.ReadLine();
        //}

        //Lesson7 EX9
        //    private int[] mas;
        //    public MyClass()
        //    {
        //        Random rnd = new Random();
        //        int size = 1 + rnd.Next(20);
        //        mas = new int[size];
        //        for (int k = 0; k < mas.Length; k++)
        //        {
        //            mas[k] = -50 + rnd.Next(101);
        //        }
        //    }
        //    public override String ToString()
        //    {
        //        String txt = "";
        //        int sum = 0;
        //        for (int k = 0; k < mas.Length; k++)
        //        {
        //            sum += mas[k];
        //            txt += (mas[k] + " ");
        //        }
        //        txt = txt + "\nколичество элементов: " + mas.Length;
        //        txt = txt + "\nсредняя сумма: " + ((double)sum / mas.Length);
        //        return txt;
        //    }
        //}
        //class Programm
        //{
        //    static void Main()
        //    {
        //        MyClass A = new MyClass();
        //        Console.WriteLine("Объект А: {0}", A);
        //        MyClass B = new MyClass();
        //        Console.WriteLine("\nОбъект B: {0}", B);
        //        Console.ReadLine();
        //    }

        //Lesson7 EX10
        //static void ch(string str, string str2)
        //{
        //    char[] charr = str2.ToCharArray();
        //    string[] starr = str.Split(charr);

        //    for (int i = 0; i < starr.Length; i++)
        //        Console.WriteLine(starr[i].Trim());

        //}

        //static void Main()
        //{
        //    string str = @"";
        //    Console.WriteLine("Введите строку:");
        //    str += Console.ReadLine();
        //    Console.WriteLine("Введите без пробела");
        //    string str2 = Console.ReadLine();
        //    ch(str, str2);
        //    Console.ReadLine();
        //}

        //Lesson7 EX11
        //    private int[] mas;

        //    public MyClass()
        //    {
        //        Random rnd = new Random();
        //        int size = 1 + rnd.Next(20);
        //        mas = new int[size];
        //        for (int k = 0; k < mas.Length; k++)
        //        {
        //            mas[k] = -50 + rnd.Next(101);
        //        }
        //    }

        //    public override String ToString()
        //    {
        //        String txt = "";
        //        int sum = 0;
        //        for (int k = 0; k < mas.Length; k++)
        //        {
        //            sum += mas[k];
        //            txt += (mas[k] + " ");
        //        }
        //        txt = txt + "\nЗначение элемента: " + mas.Length;
        //        txt = txt + "\nСреднее значение элемента: " + ((double)sum / mas.Length);
        //        return txt;
        //    }
        //}

        //class Program
        //{
        //    static void Main()
        //    {
        //        MyClass A = new MyClass();
        //        Console.WriteLine("Объект А: {0}", A);
        //        Console.ReadLine();
        //    }

        //Lesson8 EX2
        //    private char _symb;
        //    public char Symb { get => _symb; set => _symb = value; }
        //    public static Program operator ++(Program over1)
        //    {
        //        over1.Symb = Convert.ToChar(Convert.ToInt32(over1.Symb) + 1);
        //        return over1;
        //    }
        //    public static Program operator --(Program over1)
        //    {
        //        over1.Symb = Convert.ToChar(Convert.ToInt32(over1.Symb) - 1);
        //        return over1;
        //    }
        //    public static Program operator +(Program over1, int a)
        //    {
        //        over1.Symb = Convert.ToChar(Convert.ToInt32(over1.Symb) + a);
        //        return over1;
        //    }
        //    public static Program operator +(int a, Program over1)
        //    {
        //        over1.Symb = Convert.ToChar(Convert.ToInt32(over1.Symb) + a);
        //        return over1;
        //    }
        //    public static int operator -(Program over1, Program over2)
        //    {
        //        int choto = over1.Symb - over2.Symb;
        //        return choto;
        //    }

        //    static void Main()
        //    {
        //        Program over = new Program();
        //        over.Symb = 'a';

        //        over++;
        //        Console.WriteLine(over.Symb);

        //        over--;
        //        Console.WriteLine(over.Symb);

        //        over = over + 4;
        //        Console.WriteLine(over.Symb);

        //        over = 3 + over;
        //        Console.WriteLine(over.Symb);

        //        Program over1 = new Program();
        //        over.Symb = 'n';
        //        Console.WriteLine(over1 - over);
        //        Console.ReadLine();
        //    }
        //}

        //Lesson8 EX3
        //    private int[] ar;

        //    public Programm(int size)
        //    {
        //        ar = new int[size];
        //        for (int i = 0; i < ar.Length; i++)
        //        {
        //            ar[i] = 0;
        //        }
        //    }

        //    public override string ToString()
        //    {
        //        string txt = "Множество:";
        //        foreach (int i in ar)
        //        {
        //            txt += $"{i} ";
        //        }
        //        return txt;
        //    }

        //    public static string operator ~(Programm p)
        //    {
        //        return p.ToString();
        //    }

        //    public static Programm operator ++(Programm p)
        //    {
        //        int[] result = new int[p.ar.Length + 1];
        //        for (int i = 0; i < result.Length; i++)
        //        {
        //            result[i] = 0;
        //        }

        //        p.ar = result;

        //        return p;
        //    }

        //    public static Programm operator --(Programm p)
        //    {
        //        Programm program = new Programm(p.ar.Length - 1);
        //        for (int i = 0; i < program.ar.Length; i++)
        //        {
        //            program.ar[i] = p.ar[i];
        //        }
        //        return program;
        //    }

        //    public static Programm operator +(Programm p, Programm p2)
        //    {
        //        Programm program = new Programm(p.ar.Length + p2.ar.Length);
        //        int idx = 0;
        //        for (int i = 0; i < p.ar.Length; i++, idx++)
        //        {
        //            program.ar[idx] = p.ar[i];
        //        }

        //        for (int i = 0; i < p2.ar.Length; i++, idx++)
        //        {
        //            program.ar[idx] = p2.ar[i];
        //        }
        //        return program;
        //    }

        //    public static Programm operator +(Programm p, int n)
        //    {
        //        Programm program = new Programm(p.ar.Length + 1);
        //        int i;
        //        for (i = 0; i < p.ar.Length; i++)
        //        {
        //            program.ar[i] = p.ar[i];
        //        }

        //        program.ar[i] = n;
        //        return program;
        //    }

        //    public static Programm operator +(int n, Programm p)
        //    {
        //        Programm program = new Programm(p.ar.Length + 1) { ar = { [0] = n } };
        //        for (int i = 0; i < p.ar.Length; i++)
        //        {
        //            program.ar[i + 1] = p.ar[i];
        //        }
        //        return program;
        //    }

        //    private static void Main()
        //    {
        //        var p1 = new Programm(4);
        //        var p2 = new Programm(3);
        //        Console.WriteLine(~p1);
        //        Console.WriteLine(++p1);
        //        Console.WriteLine(--p1);
        //        Console.WriteLine(p1 += p2);
        //        Console.WriteLine(p1 += 4);
        //        p1 += 6;
        //        Console.ReadLine();
        //    }
        //}

        //Lesson8 EX4
        //    private static void Main()
        //    {
        //        var t = new Test(10, 2);
        //        var t2 = new Test(20, 6);
        //        Console.WriteLine(t > t2);
        //        Console.WriteLine(t < t2);
        //        Console.ReadLine();
        //    }
        //}

        //class Test
        //{
        //    public int x { get; set; }
        //    public int y { get; set; }

        //    public Test(int x, int y)
        //    {
        //        this.x = x;
        //        this.y = y;
        //    }

        //    public static bool operator >(Test t1, Test t2)
        //    {
        //        return Math.Pow(t1.x, 2) + Math.Pow(t1.y, 2) > Math.Pow(t2.x, 2) + Math.Pow(t2.y, 2);
        //    }

        //    public static bool operator <(Test t1, Test t2)
        //    {
        //        return !(t1 > t2);
        //    }
        //}


        //Lesson8 EX5
        //    private static void Main()
        //    {
        //        var t = new Test(100, "A");
        //        var t2 = new Test(100, "D");
        //        var t3 = new Test(300, "H");
        //        Console.WriteLine(t < t2);
        //        Console.WriteLine(t > t2);
        //        Console.WriteLine(t > t3);
        //        Console.WriteLine(t != t3);
        //        Console.ReadLine();
        //    }
        //}

        //class Test
        //{
        //    public int code;
        //    public string txt;

        //    public Test(int code, string txt)
        //    {
        //        this.code = code;
        //        this.txt = txt;
        //    }

        //    public static bool operator >(Test t, Test t2)
        //    {
        //        return t.txt.Length > t2.txt.Length;
        //    }

        //    public static bool operator <(Test t, Test t2)
        //    {
        //        return !(t > t2);
        //    }
        //    public static bool operator >=(Test t, Test t2)
        //    {
        //        return t.code >= t2.code;
        //    }

        //    public static bool operator <=(Test t, Test t2)
        //    {
        //        return t.code <= t2.code;
        //    }

        //    public static bool operator ==(Test t, Test t2)
        //    {
        //        return t.Equals(t2);
        //    }

        //    public static bool operator !=(Test t, Test t2)
        //    {
        //        return !(t == t2);
        //    }

        //    public override bool Equals(object obj)
        //    {
        //        var t = (Test)obj;
        //        return code == t.code && txt == t.txt;
        //    }

        //    public override int GetHashCode()
        //    {
        //        return code ^ txt[0];
        //    }
        //}


        //Lesson8 EX6
        //    internal class Program
        //    {
        //        public static void Main()
        //        {
        //            char[] ar = { 'a', 'd', 'h', 'q' };
        //            Console.WriteLine("Введите символ");
        //            var test = new Test(Console.Read());
        //            Console.WriteLine(test);
        //            Console.ReadKey();
        //            for (var i = 0; i < ar.Length; i++)
        //            {
        //                test.s = ar[i];
        //                if (test) Console.Write($"{ar[i]} ({(int)ar[i]}), ");
        //            }
        //        }
        //    }

        //    internal class Test
        //    {
        //        public int code;
        //        public char s;

        //        public Test(int code, char s)
        //        {
        //            this.code = code;
        //            this.s = s;
        //        }

        //        public Test(char s)
        //        {
        //            this.s = s;
        //            code = s;
        //        }

        //        public Test(int code)
        //        {
        //            this.code = code;
        //            s = (char)code;
        //        }

        //        public static bool operator false(Test t)
        //        {
        //            return t.code - t.s <= 10 || t.code - t.s >= -10;
        //        }

        //        public static bool operator true(Test t)
        //        {
        //            return Math.Abs(t.code - t.s) <= 10;
        //        }

        //        public override string ToString()
        //        {
        //            return $"{s} + ({code})";
        //        }
        //    }
        //}



        //Lesson8 EX7
        public int code;
        public Programm(int n)
        {
            code = n;
        }

        public static bool operator true(Programm obj)
        {
            switch (obj.code)
            {
                case 2:
                case 3:
                case 5:
                case 7:
                    return true;
                default:
                    return false;
            }
        }

        public static bool operator false(Programm obj)
        {

            if (obj) return obj.code < 1 || obj.code > 10;
            else return true;
        }

        public static Programm operator &(Programm a, Programm b)
        {
            if (a) return b; else return a;
        }

        public static Programm operator |(Programm a, Programm b)
        {
            if (a) return a; else return b;
        }
    }

    class Program
    {
        static void Main()
        {
            Programm A = new Programm(2);
            Programm D = new Programm(6);
            Programm H = new Programm(5);
            Programm N = new Programm(12);
            Console.WriteLine("Выражение A&&:D {0}", (A && D).code);
            Console.WriteLine("Выражение D&&A: {0}", (D && A).code);
            Console.WriteLine("Выражение A&&H: {0}", (A && H).code);
            Console.WriteLine("Выражение H&&A: {0}", (H && A).code);
            Console.WriteLine("Выражение A&&N: {0}", (A && N).code);
            Console.WriteLine("Выражение N&&A: {0}", (N && A).code);
            Console.WriteLine("Выражение A||D: {0}", (A || D).code);
            Console.WriteLine("Выражение D||A: {0}", (D || A).code);
            Console.WriteLine("Выражение A||H: {0}", (A || H).code);
            Console.WriteLine("Выражение H||A: {0}", (H || A).code);
            Console.WriteLine("Выражение А||N: {0}", (A || N).code);
            Console.WriteLine("Выражение N||A: {0}", (N || A).code);
            Console.ReadLine();
        }
    }
}















