﻿namespace Pract
{
    internal class Program
    {
        static void Main(string[] args)
        {
           uint N = 0, k = 0, applesPerPupil;

            CheckInput("Количество школьников N = ", ref N);
            CheckInput("Число яблок в корзине k = ", ref k);

            applesPerPupil = k / N;
            
            Console.WriteLine($"Каждому школьнику достанется по {applesPerPupil} яблок, " +
                $"в корзине останется {k - applesPerPupil * N} яблок");
        }

static void CheckInput(string message, ref uint var)
        {
            while (true)
            {
                Console.Write(message);
                if (!uint.TryParse(Console.ReadLine(), out var))
                {
                    Console.WriteLine("Ошибка ввода, попробуйте снова\n");
                    continue;
                }
                break;
            }
        }
    }
}
