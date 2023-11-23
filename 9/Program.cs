using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _9
{
    internal class Program
    {
        //Task 1.3
        public static void Output(List<int> ints)
        {
            foreach (var element in ints)
            {
                Write($"{element};\t");
            }
        }

        //Task 1.4
        public static int Count(List<int> ints)
        {
            return ints.Count();
        }

        //Task 1.5

        public static int Index(List<int> ints)
        {
            return ints.IndexOf(25);
        }

        //Task 1.6
        public static void Rem(List<int> ints)
        {
            foreach (var element in ints)
            {
                Write($"{element};\t");
            }
        }

        //Task 1.8
        public static bool Nal(List<int> ints)
        {
            return ints.Contains(25);
        }

        //Task 1.9
        public static void Insert(List<int> ints)
        {
            foreach (var element in ints)
            {
                Write($"{element};\t");
            }
        }

        //Task 1.10
        public static void Sort(List<int> ints)
        {
            foreach (var element in ints)
            {
                Write($"{element};\t");
            }
        }

        //Task 1.11
        public static void Sum(List<int> ints)
        {
            foreach (var element in ints)
            {
                Write($"{element};\t");
            }
        }

        //Task 2
        public static void Output_2(List<int> ints1)
        {
            foreach (var element in ints1)
            {
                Write($"{element};\t");
            }
            WriteLine();
        }
        public static void Compare(List<int> ints1)
        {
            for (int i = 0; i < ints1.Count; i++)
            {
                if (Math.Abs(ints1[i]) % 2 != 0)
                {
                    ints1.RemoveAt(i);
                    i--;
                }
            }
        }

        //Task 3
        public static void Output_3(List<int> price)
        {
            Write("Цены на товары: ");
            foreach (var element in price)
            {
                Write($"{element};\t");
            }
            WriteLine();
        }
        public static void CV(List<int> price,int n)
        { for (int i = 0; i < price.Count; i++)
            {
                if (n >= 0 && n < 20)
                {
                    price.Remove(n);
                    i--;
                }
                else
                {

                }
            }
        }
            //Task 4 
            public static void Output_4(List<int> li)
        {
            foreach (var element in li)
            {
                Write($"{element};\t");
            }
            WriteLine();
        }
        public static int Com(List<int> li)
        {
            int sum = 0;
            foreach (var elem in li)
            {
                if (elem % 5 == 0)
                {
                    sum += elem;
                }
            }
            return sum;
        }

        //Task 5
        public static void Output_5(List<int> ints3)
        {
            foreach (var element in ints3)
            {
                Write($"{element};\t");
            }
            WriteLine();
        }
        public static void Replac(List<int> ints3)
        {

            int count = ints3.Count;

            // Используем цикл for для перебора элементов списка
            for (int i = 0; i < count; i++)
            {
                
            }

        }
        static void Main(string[] args)
        {
            
                //Task 1.1

                List<int> ints = new List<int>(); //Создали пустой список

                //Task 1.2

                ints.Add(1);
                ints.Add(10);
                ints.Add(25);
                ints.Add(17);
                ints.Add(10);

                //Task 1.3

                Output(ints);

                //Task 1.4

                WriteLine($"\n\nКоличество элементов: {Count(ints)}");

                //Task 1.5

                WriteLine($"\n\nИндекс 25: {Index(ints)}");

                //Task 1.6

                ints.RemoveAt(1);
                WriteLine();
                Rem(ints);

                //Task 1.8

                WriteLine($"\n\nИндекс 25: {Nal(ints)}");

                //Task 1.9

                ints.Insert(0, 500);
                WriteLine();
                Insert(ints);

                //Task 1.10

                ints.Sort();
                WriteLine();
                Sort(ints);

                //Task 1.11

                ints[0] += 3;
                WriteLine();
                Sum(ints);

                //Task 1.12

                Sum(ints);


                //Task 2

                Random rand = new Random();
                List<int> ints1 = new List<int>();

                for (int i = 0; i < 10; i++)
                {
                    ints1.Add(rand.Next(-100, 100));
                }

            //task 3

            List<int> price = new List<int>() { 1, 2, 3, 4, 5, 6, 7,8,9,10,11,12,13,14,15,16,17,18,19,20};
            Write("\nВведите n от 1 до 20:");
            int n = Convert.ToInt32(ReadLine());

            //task 4

            List<int> li = new List<int>() {1,5,10,15,17,20};

                //task 5

                List<int> ints3 = new List<int>() { -1, 5, 7, -9, 67, 87 };




            //    WriteLine("\n\n");
            //    Write("Заполнили случайными значениями: ");
            //    Output_2(ints1);
            //    Compare(ints1);
            //    Write("Удалили нечетные значения: ");
            //    Output_2(ints1);
            
            //Output_4(li);
            //    Write($"Сумма числе кратных 5: {Com(li)}\n\n");
            //    Output_5(ints3);
            //    Replac(ints3);
                Output_3(price);
                CV(price, n);


            ReadKey();
                
        }
    }
}
