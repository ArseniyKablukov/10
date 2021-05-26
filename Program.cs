using System;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n\nВыберите номер задания (1-2)");
                int g = Convert.ToInt32(Console.ReadLine());

                switch (g)
                {
                    case 1:
                        Console.WriteLine("Введите римские цифры {I-1\tV-5\tX-10\tL-50\tC-100\tD-500\tM-1000}");
                        int sum = 0;
                        int pred = 999999;
                        int a = 0;
                        char c = ' ';

                        while (true)
                        {
                            c = Console.ReadKey().KeyChar;


                            if (c.Equals('M'))
                            {
                                a = 1000;
                            }
                            if (c.Equals('D'))
                            {
                                a = 500;
                            }
                            if (c.Equals('C'))
                            {
                                a = 100;
                            }
                            if (c.Equals('L'))
                            {
                                a = 50;
                            }
                            if (c.Equals('X'))
                            {
                                a = 10;
                            }
                            if (c.Equals('V'))
                            {
                                a = 5;
                            }
                            if (c.Equals('I'))
                            {
                                a = 1;
                            }


                            if (pred >= a)
                            {
                                sum += a;
                            }
                            else
                            {
                                sum = a - pred;
                            }
                            pred = a;
                            Console.WriteLine("\n" + sum);
                        }
                        break;


                    case 2:
                        Console.WriteLine("Часть 2");
                        Console.WriteLine("\t\t\t\tМассив\n");
                        int[,] m = new int[10, 10];
                        Random random = new Random();
                        for (int i = 0; i < m.GetLength(0); i++)
                        {
                            for (int j = 0; j < m.GetLength(1); j++)
                            {
                                m[i, j] = random.Next(-50, 50);
                                Console.Write(m[i, j] + "\t");
                            }
                            Console.WriteLine("\n\n");
                        }


                        int r = 1000;
                        int icop = 0;
                        int jcop = 0;
                        int[,] m2 = new int[10, 10];
                        for (int ii = 0; ii < m2.GetLength(0); ii++)
                        {
                            for (int jj = 0; jj < m2.GetLength(1); jj++)
                            {
                                for (int i = 0; i < m.GetLength(0); i++)
                                {
                                    for (int j = 0; j < m.GetLength(1); j++)
                                    {
                                        if (r > m[j, i])
                                        {
                                            r = m[j, i];
                                            icop = i;
                                            jcop = j;
                                        }
                                    }
                                    if (jj < 10)
                                    {
                                        m2[jj, ii] = m[jcop, icop];
                                        m[jcop, icop] = 10000;
                                        r = 1000;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                    jj++;
                                }
                            }
                        }


                        Console.WriteLine("\n\n\t\t\tОтсортированный массив\n");
                        for (int i = 0; i < m2.GetLength(0); i++)
                        {
                            for (int j = 0; j < m2.GetLength(1); j++)
                            {
                                Console.Write(m2[j, i] + "\t");
                            }
                            Console.WriteLine("\n\n");
                        }
                        break;
                }
            }
        }
    }
}
