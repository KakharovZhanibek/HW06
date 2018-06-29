using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int x;
                Console.WriteLine("Выберите задание");
                x = Int32.Parse(Console.ReadLine());
                if (x == 1)
                {
                    Console.Clear();
                    task1();
                    Console.ReadKey();
                    Console.Clear();
                }
                if (x == 2)
                {
                    Console.Clear();
                    task2();
                    Console.ReadKey();
                    Console.Clear();
                }
                if (x == 3)
                {
                    Console.Clear();
                    task3();
                    Console.ReadKey();
                    Console.Clear();
                }
                if (x == 4)
                {
                    Console.Clear();
                    task4();
                    Console.ReadKey();
                    Console.Clear();
                }
                if (x == 5)
                {
                    Console.Clear();
                    task5();
                    Console.ReadKey();
                    Console.Clear();
                }
                if (x == 6)
                {
                    Console.Clear();
                    task6();
                    Console.ReadKey();
                    Console.Clear();
                }
                if (x == 7)
                {
                    Console.Clear();
                    task7();
                    Console.ReadKey();
                    Console.Clear();
                }
                if (x == 8)
                {
                    Console.Clear();
                    task8();
                    Console.ReadKey();
                    Console.Clear();
                }
                if (x == 9)
                {
                    Console.Clear();
                    task9();
                    Console.ReadKey();
                    Console.Clear();
                }
                if (x == 10)
                {
                    Console.Clear();
                    task10();
                    Console.ReadKey();
                    Console.Clear();
                }
                if (x == 11)
                {
                    Console.Clear();
                    task11();
                    Console.ReadKey();
                    Console.Clear();
                }
                if (x == 12)
                {
                    Console.Clear();
                    task12();
                    Console.ReadKey();
                    Console.Clear();
                }
                if (x == 13)
                {
                    Console.Clear();
                    task15();
                    Console.ReadKey();
                    Console.Clear();
                }
                if (x == 14)
                {
                    Console.Clear();
                    task14();
                    Console.ReadKey();
                    Console.Clear();
                }
                if (x == 15)
                {
                    Console.Clear();
                    task15();
                    Console.ReadKey();
                    Console.Clear();
                }
                if (x == 16)
                {
                    Console.Clear();
                    task16();
                    Console.ReadKey();
                    Console.Clear();
                }
                if (x == 17)
                {
                    Console.Clear();
                    task17();
                    Console.ReadKey();
                    Console.Clear();
                }
                if (x == 18)
                {
                    Console.Clear();
                    task18();
                    Console.ReadKey();
                    Console.Clear();
                }
                if (x == 19)
                {
                    Console.Clear();
                    task19();
                    Console.ReadKey();
                    Console.Clear();
                }
                if (x == 21)
                {
                    Console.Clear();
                    task21();
                    Console.ReadKey();
                    Console.Clear();
                }
                if (x == 22)
                {
                    Console.Clear();
                    task22();
                    Console.ReadKey();
                    Console.Clear();
                }
                if (x == 23)
                {
                    Console.Clear();
                    task23();
                    Console.ReadKey();
                    Console.Clear();
                }
                if (x == 24)
                {
                    Console.Clear();
                    task24();
                    Console.ReadKey();
                    Console.Clear();
                }
                if (x == 25)
                {
                    Console.Clear();
                    task25();
                    Console.ReadKey();
                    Console.Clear();
                }
                if (x == 26)
                {
                    Console.Clear();
                    task26();
                    Console.ReadKey();
                    Console.Clear();
                }
                if (x == 27)
                {
                    Console.Clear();
                    task27();
                    Console.ReadKey();
                    Console.Clear();
                }
                if (x == 28)
                {
                    Console.Clear();
                    task28();
                    Console.ReadKey();
                    Console.Clear();
                }
                if (x == 29)
                {
                    Console.Clear();
                    task29();
                    Console.ReadKey();
                    Console.Clear();
                }
                if (x == 30)
                {
                    Console.Clear();
                    task30();
                    Console.ReadKey();
                    Console.Clear();
                }
                if (x == 31)
                {
                    Console.Clear();
                    task31();
                    Console.ReadKey();
                    Console.Clear();
                }
                if (x == 32)
                {
                    Console.Clear();
                    task32();
                    Console.ReadKey();
                    Console.Clear();
                }
                if (x == 33)
                {
                    Console.Clear();
                    task33();
                    Console.ReadKey();
                    Console.Clear();
                }
                if (x == 34)
                {
                    Console.Clear();
                    task34();
                    Console.ReadKey();
                    Console.Clear();
                }
                if (x == 37)
                {
                    Console.Clear();
                    task37();
                    Console.ReadKey();
                    Console.Clear();
                }
                if (x == 40)
                {
                    Console.Clear();
                    task40();
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
        static void task1()
        {

            /*1.Написать программу, которая считывает символы с клавиатуры, 
             * пока не будет введена точка. Программа должна сосчитать 
             * количество введенных пользователем пробелов. */
            string str = "";
            int i = 0;

            do
            {
                str += Console.ReadLine();//str = str + CR();
                i++;
            } while (!str.Contains('.'));

            int countspace = str.Count(w => w == ' ');

            int b = 0;
            for (int k = 0; k < str.Length; k++)
            {
                if (str[k] == ' ')
                {
                    b++;
                }
            }
            Console.WriteLine("Количество символов: " + i);
            Console.WriteLine("Количество пробелов: " + countspace);
            Console.WriteLine("Количество пробелов: " + b);
        }
        static void task2()
        {
            /*2.	Ввести с клавиатуры номер трамвайного билета (6-значное число) 
             * и проверить является ли данный билет счастливым (если на билете
             *  напечатано шестизначное число, и сумма первых трёх цифр равна 
             *  сумме последних трёх, то этот билет считается счастливым). */

            string ticket = Console.ReadLine();
            if (ticket.Length == 6)
            {
                //сумма первых трёх цифр
                int sum1 = ticket[0] + ticket[1] + ticket[2];
                // сумме последних трёх
                int sum2 = ticket[3] + ticket[4] + ticket[5];

                if (sum1 == sum2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Счастливый билет!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("БИлет не счастливый");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Длинна билета формата не соответствует формату!");
            }
        }
        static void task3()
        {
            /*Написать программу, которая считывает с клавиатуры и
             * конвертирует все символы нижнего регистра в 
             * символы верхнего регистра и наоборот*/
            string str;
            str = Console.ReadLine();
            str = str.ToUpper();
            Console.WriteLine(str);
            str = str.ToLower();
            Console.ReadKey();
            Console.WriteLine(str);
        }
        static void task4()
        {
            /*4.Даны целые положительные числа A и B (A < B). 
             * Вывести все целые числа от A до B включительно; 
             * каждое число должно выводиться на новой строке; 
             * при этом каждое число должно выводиться количество раз,
             *  равное его значению. Например: если А = 3, а В = 7, 
             *  то программа должна сформировать в консоли следующий вывод: */
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine("");
            }
        }
        static void task5()
        {
            /*5.Дано целое число N (> 0), найти число, 
             * полученное при прочтении числа N справа налево.
             *  Например, если было введено число 345, то программа
             *   должна вывести число 543.*/
            string a = Console.ReadLine();
            if (Int32.Parse(a) > 0)
            {
                for (int i = a.Length - 1; i >= 0; i--)
                {
                    Console.Write(a[i]);
                }
            }
        }
        static void task6()
        {
            /*6.	Составить программу вывода на экран в одну 
             * строку трех любых чисел с двумя пробелами между ними.*/
            string str;

            Random rnd = new Random();
            str = rnd.Next(1, 30) + "  " + rnd.Next(2, 20) + "  " + rnd.Next(3, 40);
            Console.WriteLine(str);
        }
        static void task7()
        {
            /*Вывести на экран числа 5, 10 и 21 одно под другим*/
            int a = 5, b = 10, c = 21;
            Console.WriteLine(a + "\n" + b + "\n" + c);
        }
        static void task8()
        {
            /*8.	Дано расстояние в сантиметрах. 
             * Найти число полных метров в нем.*/
            double a;
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine(a / 100 + " m");
        }
        static void task9()
        {
            /*С некоторого момента прошло 234 дня. 
            * Сколько полных недель прошло за этот период?*/
            Console.WriteLine("В 234 днях " + 234 / 7 + " недель.");
        }
        static void task10()
        {
            /*10.	Дано двузначное число. Найти:
                a.	число десятков в нем;
                b.	число единиц в нем;
                c.	сумму его цифр;
                d.	произведение его цифр*/
            int a;

            while (true)
            {
                Console.WriteLine("Введите двузначное число \n");
                a = Convert.ToInt32(Console.ReadLine());
                if (a > 9 && a < 99)
                {
                    int b = a / 10;
                    Console.WriteLine("Десятки: " + b);
                    Console.Write("Единицы: "); Console.WriteLine(a - a / 10 * 10);
                    Console.Write("Сумма цифр: "); Console.WriteLine(a / 10 + a - a / 10 * 10);
                    Console.Write("Произведение цифр: "); Console.WriteLine((a / 10) * (a - a / 10 * 10));
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели не двузначное число!");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
        static void task11()
        {
            /*11.	Вычислить значение логического выражения при 
             * следующих значениях логических величин А, В и С:
             *  А = Истина, В = Ложь, С = Ложь:
              
              *  a.	А или В; 
              *  b.	А и В; 
              *  c.	В или С.*/
            bool a, b, c;
            a = bool.Parse(Console.ReadLine());
            b = bool.Parse(Console.ReadLine());
            c = bool.Parse(Console.ReadLine());
            if (a || b)
            {
                Console.WriteLine("true");
            }
            if (b || c)
            {
                Console.WriteLine("false");
            }
        }
        static void task12()
        {
            /*Даны радиус круга и сторона квадрата.
             *У какой фигуры площадь больше?*/
            int r;
            int sqSide;
            Console.WriteLine("Введите радиус круга");
            r = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону квадрата");
            sqSide = Int32.Parse(Console.ReadLine());
            if (3.14 * Math.Pow(r, 2) > Math.Pow(sqSide, 2))
            {
                Console.WriteLine("Площадь круга больше");
            }
            else
            {
                Console.WriteLine("Площадь квадрата больше");
            }
        }
        static void task13()
        {
            /*Даны объемы и массы двух тел из разных материалов. 
             *Материал какого из тел имеет большую плотность?*/
            Console.WriteLine("Введите массу и объем первого материала");
            int a1, b1;
            a1 = Int32.Parse(Console.ReadLine());
            b1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите массу и объем первого материала");
            int a2, b2;
            a2 = Int32.Parse(Console.ReadLine());
            b2 = Int32.Parse(Console.ReadLine());
            if ((double)a1 / b1 > (double)a2 / b2)
            {
                Console.WriteLine("Первый материал имеет большую плотность");
            }
            else if ((double)a1 / b1 < (double)a2 / b2)
            {
                Console.WriteLine("Второй материал имеет большую плотность");
            }
        }
        static void task14()
        {
            /*Известны сопротивления двух несоединенных друг с другом
             *участков электрической цепи и напряжение на каждом из них. 
             *По какому участку протекает меньший ток?
             I=U/R*/
            Console.WriteLine("Введите напряжение и сопротивление первого участка");
            int U1, R1;
            U1 = Int32.Parse(Console.ReadLine());
            R1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите напряжение и сопротивление второго участка");
            int U2, R2;
            U2 = Int32.Parse(Console.ReadLine());
            R2 = Int32.Parse(Console.ReadLine());
            if ((double)U1 / R1 > (double)U2 / R2)
            {
                Console.WriteLine("Во втором участке меньший ток");
            }
            else if ((double)U1 / R1 < (double)U2 / R2)
            {
                Console.WriteLine("В первом участке меньший ток");
            }
        }
        static void task15()
        {
            /*15.	 Напечатать "столбиком": 
            a.	все целые числа от 20 до 35;
b.	квадраты всех целых чисел от 10 до b (значение b вводится с клавиатуры; b > 10);
c.	третьи степени всех целых чисел от a до 50 (значение a вводится с клавиатуры; a < 50);
d.	все целые числа от a до b (значения a и b вводятся с клавиатуры; b > a).
*/
            for (int i = 20; i <= 35; i++)
            {
                Console.WriteLine(i + "");
            }
            Console.WriteLine("------");
            int b;
            b = Int32.Parse(Console.ReadLine());
            for (int i = 10; i <= b; i++)
            {
                Console.WriteLine("{0}", Math.Pow(i, 2));
            }
            Console.WriteLine();
            Console.WriteLine("------");

            int a;
            a = Int32.Parse(Console.ReadLine());
            for (int i = a; i <= 50; i++)
            {
                Console.WriteLine("{0}", Math.Pow(i, 3));
            }
            Console.WriteLine();
        }
        static void task16()
        {
            /*Вычисления значения функции y = 7x^2-3x+6 при любом значении x;*/
            int x;
            x = Int32.Parse(Console.ReadLine());
            int y = 7 * x * x - 3 * x + 6;
            Console.WriteLine(y);
        }
        static void task17()
        {
            /*Вычисления значения функции x= 12a^2+7a-16 при любом значении а.*/
            int a;
            a = Int32.Parse(Console.ReadLine());
            int x = 12 * a * a + 7 * a - 16;
            Console.WriteLine(x);
        }
        static void task18()
        {
            /*Дана сторона квадрата. Найти его периметр*/
            int x;
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Периметр " + 4 * x);
        }
        static void task19()
        {
            /*Дан радиус окружности. Найти ее диаметр.*/
            int r;
            r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Диаметр " + 2 * r);
        }
        static void task21()
        {
            /*Вычисления значения функции z=x^3-2.5xy+1.78x^2-2.5y+1 при любых значениях х и y;*/
            Console.WriteLine("Введите x и y");
            int x, y;
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            double z = Math.Pow(x, 3) - 2.5 * x * y + Math.Pow(1.78, 2) - 2.5 * y + 1;
            Console.WriteLine(z);
        }
        static void task22()
        {
            /*Даны два целых числа. Найти: 
              a.их среднее арифметическое; 
              b.их среднее геометрическое.*/

            Console.WriteLine("Введите x и y");
            int x, y;
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Среднее арифметическое " + x + y / 2);
            Console.WriteLine("Среднее геометрическое " + Math.Sqrt(x * y));
        }
        static void task23()
        {
            /*Известны объем и масса тела. Определить плотность материала этого тела.*/
            Console.WriteLine("Введите массу и объем материала");
            int m, v;
            m = Int32.Parse(Console.ReadLine());
            v = Int32.Parse(Console.ReadLine());
            Console.WriteLine((double)m / v);
        }
        static void task24()
        {

            int a, b, c;
            a = Int32.Parse(Console.ReadLine());
            b = Int32.Parse(Console.ReadLine());
            c = Int32.Parse(Console.ReadLine());
            int temp = a;
            a = b;
            b = c;
            c = temp;

            Console.WriteLine(a + "\n" + b + "\n" + c);
            a = Int32.Parse(Console.ReadLine());
            b = Int32.Parse(Console.ReadLine());
            c = Int32.Parse(Console.ReadLine());
            int temp1 = c;
            c = b;
            b = a;
            a = temp1;
            Console.WriteLine(a + "\n" + b + "\n" + c);
        }
        static void task25()
        {
            /*10.	Дано двузначное число. Найти:
               a.	число десятков в нем;
               b.	число единиц в нем;
               c.	сумму его цифр;
               d.	произведение его цифр*/
            int a;

            while (true)
            {
                Console.WriteLine("Введите двузначное число \n");
                a = Convert.ToInt32(Console.ReadLine());
                if (a > 9 && a < 99)
                {
                    int b = a / 10;
                    Console.WriteLine("Десятки: " + b);
                    Console.Write("Единицы: "); Console.WriteLine(a - a / 10 * 10);
                    Console.Write("Сумма цифр: "); Console.WriteLine(a / 10 + a - a / 10 * 10);
                    Console.Write("Произведение цифр: "); Console.WriteLine((a / 10) * (a - a / 10 * 10));
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели не двузначное число!");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
        static void task26()
        {
            /* Дано четырехзначное число. Найти:
             a.сумму его цифр;
             b.произведение его цифр*/
            Console.WriteLine("Введите четырехзначное число");
            int x;
            while (true)
            {
                x = Int32.Parse(Console.ReadLine());
                if (x > 999 && x < 10000)
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Введите четырехзначное число");
                }
            }
            int[] arr = new int[4];
            arr[0] = x / 1000;
            arr[1] = (x % 1000) / 100;
            arr[2] = ((x % 1000) % 100) / 10;
            arr[3] = ((x % 1000) % 100) % 10;
            Console.Write("Сумма цифр: "); Console.WriteLine(arr[0] + arr[1] + arr[2] + arr[3]);
            Console.Write("Произведение цифр: "); Console.WriteLine(arr[0] * arr[1] * arr[2] * arr[3]);
        }
        static void task27()
        {
            /*27.	Вычислить значение логического выражения при
             *  следующих значениях логических величин X, Y и Z: X = Ложь, Y = Истина, Z = Ложь:
                   a.	X или Z;
                   b.	X и Y; 
                   c.	X и Z.*/

            bool X, Y, Z;
            X = bool.Parse(Console.ReadLine());
            Y = bool.Parse(Console.ReadLine());
            Z = bool.Parse(Console.ReadLine());
            if (X || Z)
            {
                Console.WriteLine("False");
            }
            if (X && Y)
            {
                Console.WriteLine("False");
            }
            if (X && Z)
            {
                Console.WriteLine("False");
            }
        }
        static void task28()
        {
            /*28.	Вычислить значение логического выражения при 
             * следующих значениях логических величин А, В и С: А = Истина, В = Ложь, С = Ложь: 
                a.	не А и В; 
                b.	А или не В; 
                c.	А и В или С.*/
            bool A, B, C;
            A = bool.Parse(Console.ReadLine());
            B = bool.Parse(Console.ReadLine());
            C = bool.Parse(Console.ReadLine());
            if (!A && B)
            {
                Console.WriteLine("True");
            }
            if (A || !B)
            {
                Console.WriteLine("True");
            }
            if (A && B || C)
            {
                Console.WriteLine("False");
            }
        }
        static void task29()
        {
            /*29.	Вычислить значение логического выражения при следующих значениях
             *  логических величин X, Y и Z: X = Ложь, Y = Истина, Z = Ложь: 
                a.	X и не (Z или Y) или не Z; 
                b.	не X или X и (Y или Z); 
                c.	 (X или Y и не Z) и Z.*/
            bool X, Y, Z;
            X = bool.Parse(Console.ReadLine());
            Y = bool.Parse(Console.ReadLine());
            Z = bool.Parse(Console.ReadLine());
            if (X && !(Z || Y) || !Z)
            {
                Console.WriteLine("True");
            }
            if (!X || X && (Y || Z))
            {
                Console.WriteLine("True");
            }
            if ((X || Y || !Z) && Z)
            {
                Console.WriteLine("False");
            }
        }
        static void task30()
        {
            /*30.	Даны два различных вещественных числа. Определить: 
                a.	какое из них больше; 
                b.	какое из них меньше*/
            double a, b;
            Console.WriteLine("Введите два значения");
            a = Double.Parse(Console.ReadLine());
            b = Double.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("Первое значение больше чем второе");
            }
            else if (a < b)
            {
                Console.WriteLine("Второе значение больше чем первое");
            }
            else
            {
                Console.WriteLine("Значения равны");
            }
        }
        static void task31()
        {
            /*31.	Известны два расстояния: одно в километрах,
             *  другое — в футах ( 1 фут 0,305 м ). 
             *  Какое из расстояний меньше?*/
            double a, b;
            a = Int32.Parse(Console.ReadLine());
            b = Int32.Parse(Console.ReadLine());
            b = (b * 0.305) / 1000;
            if (a > b)
            {
                Console.WriteLine("a > b");
            }
            else
            {
                Console.WriteLine("b > a");
            }
        }
        static void task32()
        {
            int a;
            int[] b = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("Введите число");
            a = Int32.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("Число четное");
            }
            else
            {
                Console.WriteLine("Число нечетное");
                char[] arr = Convert.ToString(a).ToCharArray();
                if (arr[arr.Length - 1] == '7')
                {
                    Console.WriteLine("Число заканчивается на 7");
                }

            }


        }
        static void task33()
        {
            Console.WriteLine("Введите двузначное число");
            string str;
            str = Console.ReadLine();
            char[] ch = str.ToCharArray();
            if((int)ch[0]>(int)ch[1])
            {
                Console.WriteLine("Первая цифра больше чем вторая");
            }
            else if((int)ch[0] < (int)ch[1])
            {
                Console.WriteLine("Вторая цифра больше чем первая");
            }
            else
            {
                Console.WriteLine("Первая цифра и вторая цифра равны");
            }
        }
        static void task34()
        {
            /*34.	. Составить программу, которая в зависимости 
             * от порядкового номера дня недели (1, 2, ..., 7) 
             * выводит на экран его название (понедельник, 
             * вторник, ..., воскресенье).*/

            int a;
            a = Int32.Parse(Console.ReadLine());
            DayOfWeek dow = (DayOfWeek)a;
            Console.WriteLine(dow);
            // var t = DateTime.Now.DayOfWeek
        }
        static void task37()
        {
            /*37.	Составить программу, которая в зависимости от 
             * порядкового номера месяца (1, 2, ..., 12) выводит на 
             * экран количество дней в этом месяце. Рассмотреть два случая: 
a.	год не является високосным (см. задачу 4.65); 
b.	год может быть високосным (информация об этом вводится с клавиатуры).
             */
            int a;
            a = Int32.Parse(Console.ReadLine());

            Console.WriteLine(DateTime.DaysInMonth(2018, a));
        }
        static void task40()
        {
            /*40.	 Напечатать "столбиком": 
            a.	все целые числа от 20 до 35;
b.	квадраты всех целых чисел от 10 до b (значение b вводится с клавиатуры; b > 10);
c.	третьи степени всех целых чисел от a до 50 (значение a вводится с клавиатуры; a < 50);
d.	все целые числа от a до b (значения a и b вводятся с клавиатуры; b > a).
*/
            for (int i = 20; i <= 35; i++)
            {
                Console.WriteLine(i + "");
            }
            Console.WriteLine("------");
            int b;
            b = Int32.Parse(Console.ReadLine());
            for (int i = 10; i <= b; i++)
            {
                Console.WriteLine("{0}", Math.Pow(i, 2));
            }
            Console.WriteLine();
            Console.WriteLine("------");

            int a;
            a = Int32.Parse(Console.ReadLine());
            for (int i = a; i <= 50; i++)
            {
                Console.WriteLine("{0}", Math.Pow(i, 3));
            }
            Console.WriteLine();
        }
    }
}
