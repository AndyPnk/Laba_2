using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k; 

            Console.WriteLine("Введите количество вращений массива.");
            k = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите данные в массив.");

            string arrayS;
            arrayS = Console.ReadLine();
            string[] array1 = arrayS.Split(" ");  

            int[] array = new int[arrayS.Length]; 
            n = array1.Length; 
            for (int i = 0; i < array1.Length; i++) 
                array[i] = Convert.ToInt32(array1[i]); 

            int[] sumArray = new int[n]; 


            for (int j = 0; j < k; j++) 
            {
                int t = array[n - 1]; 
                for (int i = n - 1; i > 0; i--) { array[i] = array[i - 1]; } 
                array[0] = t; 
                for (int p = 0; p < n; p++) { sumArray[p] += array[p]; } 


            }
            Console.WriteLine("Результат");
            for (int i = 0; i < n; i++) { Console.Write(sumArray[i] + " "); }
        }
    }
}
