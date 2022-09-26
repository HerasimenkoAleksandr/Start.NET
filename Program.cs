using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;



namespace Start.NET
{
    
    class Program
    {
        struct Task1
        {
            private int value;
            public void Solution()
            {
                Console.WriteLine("Задание 1");
                Console.WriteLine("Введите число в диапазоне от 1 до 100: ");
                value = Int32.Parse(Console.ReadLine());
                if (value > 100 || value < 0)
                {
                    Console.WriteLine("Резултат согласно условия задачи -> ОШИБКА");
                    return;
                }
                if (value % 3 == 0 && value % 5 == 0)
                {
                    Console.WriteLine("Резултат согласно условия задачи -> Fizz Buzz");
                }
                else
                {
                    if (value % 3 == 0)
                        Console.WriteLine("Резултат согласно условия задачи -> Fizz ");
                    else
                    {
                        if (value % 5 == 0)
                            Console.WriteLine("Резултат согласно условия задачи -> Buzz");
                        else
                            Console.WriteLine("Резултат согласно условия задачи -> " + value);
                    }
                }

            }

        }
        struct Task2
        {
            private double value;
            private double percent;
            public void Solution()
            {
                Console.WriteLine("\nЗадание 2");
                Console.WriteLine("Введите любое число: ");
                value = Double.Parse(Console.ReadLine());
                Console.WriteLine("Введите процент который нкобходимо посчитать от числа " + value);
                percent = Int32.Parse(Console.ReadLine());
                double result = ((value / 100) * percent);
                Console.WriteLine("Резултат: " + percent + " процентов от " + value + " равняется " + result);

            }

        }
        struct Task3
        {
            private int value;

            public void Solution()
            {
                string a = null;
                //string a = new string();
                Console.WriteLine("\nЗадание 3");
                Console.WriteLine("Вам нужно ввести 4 цифры!");
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine("Введите " + (i + 1) + "-ю цифру:");
                    // a =  Console.ReadLine();
                    a += Console.ReadLine();

                    //Console.WriteLine("Число " + a);

                }
                value = Int32.Parse(a);
                Console.WriteLine("Сформированое число: " + a);
            }
        }
        struct Task4
        {
            private int value;

            public void Solution()
            {
                string a = null;
                string b = null;
                int a1;
                int a2;
                //string a = new string();
                Console.WriteLine("\nЗадание 4");
                Console.WriteLine("Вам нужно ввести шестизначное число!");
                a = Console.ReadLine();
                if (a.Length != 6)
                {
                    Console.WriteLine("Резултат согласно условия задачи -> ОШИБКА");
                    return;
                }
                Console.WriteLine("Теперь введите номера разрядов для обмена цифр");
                Console.WriteLine("введите первый номер: ");
                a1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("введите второй номер номер: ");
                a2 = Int32.Parse(Console.ReadLine());
                for (int i = 0; i < 6; i++)
                {
                    if (a1 - 1 == i)
                        b += a[a2 - 1];
                    else
                    {
                        if (a2 - 1 == i)
                            b += a[a1 - 1];
                        else
                            b += a[i];
                    }

                }
                value = Int32.Parse(b);
                Console.WriteLine("Число " + a + " превратилось в чило " + b);


            }
        }
        struct Task5
        {
            private DateTime date;

            public void Solution()
            {
                string b;
                string a;
                Console.WriteLine("\nЗадание 5");
                Console.WriteLine("Введите любую дату года в формате 01.01.2022 !");
                a = Console.ReadLine();
                date = DateTime.Parse(a);



                if (date.Month > 2 && date.Month < 6)
                    b = "Spring";
                {
                    if (date.Month > 6 && date.Month < 9)
                        b = "Summer";
                    else
                    {
                        if (date.Month > 9 && date.Month < 12)
                            b = "Autumn";
                        else
                            b = "Winter";
                    }
                }
                Console.WriteLine("Результат задания: " + b + " " + date.DayOfWeek);

            }
        }
        struct Task6
        {
            private int value;

            public void Solution()
            {
                int b;
                string a;
                Console.WriteLine("\nЗадание 6");
                Console.WriteLine("Введите показатель температуры: ");
                a = Console.ReadLine();
                value = Int32.Parse(a);
                Console.WriteLine("Теперь уточните в каких единицах измерения Вы указали температуру ");
                Console.WriteLine("Фарингейт: введите -1- ");
                Console.WriteLine("Цельсий: введите -2- ");
                b = Int32.Parse(Console.ReadLine());
                switch (b)
                {
                    case (1):
                        {
                            Console.WriteLine("Результат:  ");
                            Console.WriteLine("-температура в Фаренгейтах " + value);
                            Console.WriteLine("-температура в Цельсиях " + ((value - 32) / 1.8));
                            System.Threading.Thread.Sleep(2000);

                            break;
                        }
                    case (2):
                        {
                            Console.WriteLine("Результат:  ");
                            Console.WriteLine("-температура в Цельсиях " + value);
                            Console.WriteLine("-температура в Фаренгейтах " + (value * 9 / 5 + 32));
                            System.Threading.Thread.Sleep(2000);
                            break;
                        }
                    default:
                        break;
                }



            }
        }
        struct Task7
        {

            private int value1;
            private int value2;

            public void Solution()
            {
                int b;
                string a;
                Console.WriteLine("\nЗадание 7");
                Console.WriteLine("Вам необходимо ввести 2 числа! ");
                Console.WriteLine("-введите первое число: ");
                value1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("-введите второе число: ");
                value2 = Int32.Parse(Console.ReadLine());

                if (value2 < value1)
                {
                    int temp;
                    temp = value1;
                    value1 = value2;
                    value2 = temp;
                }
                Console.WriteLine("Все четные числа в диапазоне от " + value1 + " до " + value2 + ":");
                for (int i = value1; i <= value2; i++)
                {
                    if (i % 2 == 0)
                        Console.WriteLine(i + " ");

                }




            }
        }
        static void Main(string[] args)
        {
            Task1 K = new Task1();
            K.Solution();
            Task2 B = new Task2();
            B.Solution();
            Task3 C = new Task3();
            C.Solution();
            Task4 Q = new Task4();
            Q.Solution();
            Task5 E = new Task5();
            E.Solution();
            Task6 T = new Task6();
            T.Solution();
            Console.WriteLine("\nЗадание 6 можете проверить еще раз!");
            T.Solution();
            Task7 R = new Task7();
            R.Solution();
        }
    }

}
