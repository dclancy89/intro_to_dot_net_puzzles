using System;

namespace Puzzles
{
    class Program
    {
        public static void randomArray()
        {
            Random rand = new Random();
            int[] arr = new int[10];
            arr[0] = rand.Next(5,25);
            int min = arr[0];
            int max = arr[0];
            int sum = arr[0];
            for(int i = 1; i < arr.Length; i++)
            {
                arr[i] = rand.Next(5,25);
                if(arr[i] > max)
                {
                    max = arr[i];
                }
                if(arr[i] < min)
                {
                    min = arr[i];
                }
                sum += arr[i];
            }

            Console.WriteLine("Min: {0}", min);
            Console.WriteLine("Max: {0}", max);
            Console.WriteLine("Sum: {0}", sum);

        }

        public static string TossCoin()
        {
            Random rand = new Random();
            Console.WriteLine("Tossing a coin!");
            int toss_int = rand.Next(2);
            string toss;
            if(toss_int == 0)
            {
                toss = "Heads";
            }
            else {
                toss = "Tails";
            }

            Console.WriteLine(toss);
            return toss;
        }

        public static double TossMultipleCoins(int num)
        {
            double heads = 0;
            for(int i = 1; i <= num; i++)
            {
                string toss = TossCoin();
                if(toss == "Heads")
                {
                    heads++;
                }
            }

            return heads /num;
        }

        public static string[] Names(string[] arr)
        {
            int counter = 0;
           foreach(string x in arr)
           {
               if (x.Length > 5)
               {
                   counter++;
               }
           }

           string[] newArr = new string[counter];
           counter = 0;
           foreach(string x in arr)
           {
               if (x.Length > 5)
               {
                   newArr[counter] = x;
                   counter++;
               }
           }

           return newArr;

        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            randomArray();
            Console.WriteLine();
            TossCoin();
            Console.WriteLine();
            Console.WriteLine(TossMultipleCoins(10));
            Console.WriteLine();
            string[] names = {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            foreach(string name in Names(names))
            {
                Console.WriteLine(name);
            }
            
        }
    }
}
