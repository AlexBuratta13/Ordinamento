using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace ConsoleBubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensione = { 1, 20, 50, 100, 500, 1000 };
            using (StreamWriter sw = new StreamWriter("Stat.csv", false, Encoding.UTF8))
            {
                sw.Write("Algoritmo ; Dimensione ; Tipo");
                foreach (int dim in dimensione)
                {
                    int[] numeri = new int[dim];
                    Random r = new Random();
                    for (int i = 0; i < dim; i++)
                    {
                        numeri[i] = r.Next();
                    }
                    Stopwatch s = new Stopwatch();
                    s.Start();
                    LibraryBubbleSort.bubblesort1.Sort(numeri);
                    s.Stop();
                    long elapsed = s.ElapsedMilliseconds;
                    sw.WriteLine($"Bubblesort;{dim};{elapsed}");
                }
                sw.Flush();
                Console.ReadLine();
            }
        }
    }
}
