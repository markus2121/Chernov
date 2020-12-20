﻿using System;
using System.IO;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[6];
            int res = 0;
            int M2 = 1001;
            int M3 = 1001;
            int M6 = 1001;
            int MIN = 1001;
            for (int i = 0; i < 6; i++)
            {
                a[i] = GetNumber("Введите элемент массива");
                Log("Введите элемент : " + a[i] + '\n'); //логи
                if (a[i] % 2 == 0 && a[i] % 3 != 0 && a[i] < M2)
                {
                    M2 = a[i];
                }
                if (a[i] % 3 == 0 && a[i] % 2 != 0 && a[i] < M3)
                {
                    M3 = a[i];
                }
                if (a[i] % 6 == 0 && a[i] < M6)
                {
                    if (M6 < MIN)
                    {
                        MIN = M6;
                    }
                    M6 = a[i];
                }
                if (a[i] < MIN)
                {
                    MIN = a[i];
                }
                if (M2 * M3 > M6 * MIN)
                {
                    res = M6 * MIN;
                }
                else
                {
                    res = M2 * M3;
                }
                if ((M6 >= 1001) && ((M2 >= 1001) || (M3 >= 1001)))
                {
                    res = 0;
                }
            }
            Log("Контрольное значение : " + res + '\n'); //логи
            Console.WriteLine("Вычисленное контрольное значение: " + res);
            if (res > 0)
            {
                Log("Контроль пройден"); //логи
                Console.WriteLine("Контроль пройден");
            }
            else
            {
                Log("Контроль не пройден"); //логи
                Console.WriteLine("Контроль не пройден");
            }
            static void Log(string message)
            {
                File.AppendAllText("C:\\44log.txt", message + Environment.NewLine); //путь к файлу для записи
            }
            static int GetNumber(string title) // обработка исключений
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine(title);
                        var textValue = Console.ReadLine();
                        if (!int.TryParse(textValue, out int result))
                        {
                            throw new Exception($"Не удалось конвертировать {textValue} в число");
                        }

                        return result;
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception.Message);
                    }

                }
            }
        }
    }
}
