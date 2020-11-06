using System;

namespace Unit1_2
{
    
    class Program
    {
        //Bubble sorting algorithm method

        static void Bubble(int[] arr)
        {
            int x = arr.Length;

            //two for loops to essentially have two seperate cells selected in the array
            for (int i = 0; i < x - 1; i++)
                for (int y = 0; y < x - i - 1; y++)
                    if (arr[y] > arr[y + 1])
                    {
                        // swap temp and arr[i] 
                        int temp = arr[y];
                        arr[y] = arr[y + 1];
                        arr[y + 1] = temp;
                    }
        }


        //Partition algorithm method
        static int Part(int[] arr, int low, int high)
        {
            int pivot = arr[high];

            int i = (low - 1);
            for (int x = low; x < high; x++)
            {
                if (arr[x] < pivot)
                {
                    i++;

                    int temp = arr[i];
                    arr[i] = arr[x];
                    arr[x] = temp;
                }

            }

            int temper = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temper;

            return i + 1;

        }

        //Quick sort algorithm method
        static void Quick(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int Partin = Part(arr, low, high);
                Quick(arr, low, Partin - 1);
                Quick(arr, Partin + 1, high);
            }
        }

        //Print Array
        static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if (i < arr.Length - 1)
                {
                    Console.Write(", ");
                }
            }
        }

        static void Main(string[] args)
        {
            //Array created and values stored in array
            int[] mainarr = {100, 45, 33, 55, 356, 11, 1000, 999, 987};

            int x = mainarr.Length;

            //pass array into bubble sort and calculate time
            //initialize stopwatch for timing methods
            var watch = System.Diagnostics.Stopwatch.StartNew();
            Bubble(mainarr);
            Console.WriteLine("Bubble Sort: ");
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Print(mainarr);
            Console.WriteLine("\n" + "Bubble Sort Time: " + elapsedMs);

            //pass array into merge sort and calculate time
            
            watch.Start();
            Quick(mainarr, 0, x - 1);
            Console.WriteLine("\nQuick Sort: ");
            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;
            Print(mainarr);
            Console.WriteLine("\n" + "Quick Sort Time: " + elapsedMs);

        }
    }
}
