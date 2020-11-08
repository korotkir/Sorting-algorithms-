using System;
using System.Diagnostics;
namespace sort
{
    public class Sortirovka
    {
        static void Main(string[] args)
        {
  
  Console.WriteLine("Выберите метод:");
  Console.WriteLine("1. Метод Пузырьков (упорядоченные)");
  Console.WriteLine("2. Метод Пузырьков (обратный)");
  Console.WriteLine("3. Метод Пузырьков (вырожденные)");
  Console.WriteLine("4. Метод Пузырьков (случайные)");
  Console.WriteLine("5. Метод Шелла (упорядоченные)");
  Console.WriteLine("6. Метод Шелла (обратные)");
  Console.WriteLine("7. Метод Шелла (вырожденные)");
  Console.WriteLine("8. Метод Шелла (случайные)");

            int e = Convert.ToInt32(Console.ReadLine());

if (e == 1) // 1. Метод Пузырьков (упорядоченные)
{           Stopwatch st = new Stopwatch(); // Обозначаем таймер
            st.Start(); // начало таймера
            int[] array = new int[1000]; // В квадратных скобках указываем количество элементов в массиве
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = rand.Next(1000);  
             // Метод пузырька
            for (int i = 0; i < array.Length; i++)
                for (int j = i + 1; j < array.Length; j++)
                    if (array[i] >  array[j]) // Знак ">" - упорядоченные, < - обратный порядок
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                    st.Stop();
                  // Вывод на экран по методу Пузырьков:
            Console.WriteLine("После сортировки методом Пузырьков (упорядоченные):");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("Время выполнения: {0}", st.Elapsed.TotalSeconds);
            Console.ReadLine();
                }
if (e == 2) // 2. Метод Пузырьков (обратный)
{           Stopwatch st = new Stopwatch(); // Обозначаем таймер
            st.Start(); // начало таймера
            int[] array = new int[1000]; // В квадратных скобках указываем количество элементов в массиве
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = rand.Next(1000);  
             // Метод пузырька
            for (int i = 0; i < array.Length; i++)
                for (int j = i + 1; j < array.Length; j++)
                    if (array[i] <  array[j]) // Знак ">" - упорядоченные, < - обратный порядок
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                    st.Stop();
                  // Вывод на экран по методу Пузырьков:
            Console.WriteLine("После сортировки методом Пузырьков (обратные):");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("Время выполнения: {0}", st.Elapsed.TotalSeconds);
            Console.ReadLine();}
if (e == 3) // 3. Метод Пузырьков (вырожденные)
{           Stopwatch st = new Stopwatch(); // Обозначаем таймер
            st.Start(); // начало таймера
            // Вырожденные
            int[] array = new int[1000]; // В квадратных скобках указываем количество элементов в массиве
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            array[i] = rand.Next(1, 13);
            // Метод пузырька
            for (int i = 0; i < array.Length; i++)
                for (int j = i + 1; j < array.Length; j++)
                    if (array[i] >  array[j]) // Знак ">" - упорядоченные, < - обратный порядок
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                    st.Stop();
                  // Вывод на экран по методу Пузырьков:
            Console.WriteLine("После сортировки методом Пузырьков (вырожденные):");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("Время выполнения: {0}", st.Elapsed.TotalSeconds);
            Console.ReadLine();}
if (e == 4)  // 4. Метод Пузырьков (случайные)
{           Stopwatch st = new Stopwatch(); // Обозначаем таймер
            st.Start(); // начало таймера
             // Рандомные
            int[] array = new int[1000]; // В квадратных скобках указываем количество элементов в массиве
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            array[i] = rand.Next();
            // Метод пузырька
            for (int i = 0; i < array.Length; i++)
                for (int j = i + 1; j < array.Length; j++)
                    if (array[i] >  array[j]) // Знак ">" - упорядоченные, < - обратный порядок
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                    st.Stop();
                  // Вывод на экран по методу Пузырьков:
            Console.WriteLine("После сортировки методом Пузырьков (случайные):");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("Время выполнения: {0}", st.Elapsed.TotalSeconds);
            Console.ReadLine();}
if (e == 5) // 5. Метод Шелла (упорядоченные)
{           //Метод Шелла
	        Stopwatch st = new Stopwatch(); // Обозначаем таймер
            st.Start(); // начало таймера
            for (var t = a; a = b; b = t;)
             
             static int[] ShellSort(int[] array)
             {
             //расстояние между элементами, которые сравниваются
             var d = array.Length / 2;
             while (d >= 1)
             {
             for (var i = d; i < array.Length; i++)
             {
             var j = i;
             while ((j >= d) && (array[j - d] > array[j]))
             {
             Swap(ref array[j], ref array[j - d]);
             j = j - d;
             }
             }
             d = d / 2;
             }
             return array;
             }

            // Упорядоченные
            int[] array = new int[1000]; // В квадратных скобках указываем количество элементов в массиве
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = rand.Next(1000); 
            // Вырожденные
            //int[] array = new int[1000]; // В квадратных скобках указываем количество элементов в массиве
            //Random rand = new Random();
            //for (int i = 0; i < array.Length; i++)
            //    array[i] = rand.Next(1, 13); 
            // Рандомные
            //int[] array = new int[1000]; // В квадратных скобках указываем количество элементов в массиве
            //Random rand = new Random();
            //for (int i = 0; i < array.Length; i++)
            //    array[i] = rand.Next(); 
            st.Stop();
            // Вывод на экран по методу Шелла:
             Console.WriteLine("После сортировки Шелла:");
             Console.WriteLine(string.Join(",", ShellSort(array)));
             Console.WriteLine("Время выполнения: {0}", st.Elapsed.TotalSeconds);
             Console.ReadLine();}
if (e == 6) // 6. Метод Шелла (обратные)
{Console.WriteLine();}
if (e == 7) // 7. Метод Шелла (вырожденные)
{Console.WriteLine();}
if (e == 8) // "8. Метод Шелла (случайные)
{Console.WriteLine();}

    
}
   }
       } 