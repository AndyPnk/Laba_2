﻿using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            string words1, words2; 
            Console.WriteLine("Введите первое предложение");
            words1 = Console.ReadLine();
            string[] s1 = words1.Split(' ');  

            Console.WriteLine("Введите первое предложение");
            words2 = Console.ReadLine();
            string[] s2 = words2.Split(' '); 

            int count = 0; 
            if (s1.Length <= s2.Length) 
            {
                for (int i = 0; i < s1.Length; i++)
                {
                    if (s1[i] == s2[i]) { count++; Console.Write(s1[i] + " "); } 
                }
            }
            else 
            {
                for (int i = s2.Length - 1; i >= 0; i--) 
                {
                    for (int j = s1.Length - 1; j >= (s1.Length - s2.Length); j--) 
                    {
                        if (s1[j] == s2[i]) { count++; Console.Write(s2[i] + " "); } 

                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Количество - {count}"); 
        }
    }
}
