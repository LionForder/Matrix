using System;

namespace Program
{
    public class Application
    {
        public static void Main(string[] args)
        {
            /*Arr arr1 = new Arr(2, 5);

            arr1.Fill();
            arr1.Show();
            arr1.SumOf(1);
            arr1.SumOf(2);
            arr1.SumOf(3);
            Console.WriteLine(arr1.Zero);

            arr1.Diagonal = 5;
            arr1.Show();

            arr1[0, 0] = 1;
            arr1[0, 1] = 2;
            arr1[0, 2] = 3;
            arr1++;
            arr1.Show();

            Arr arr2 = new Arr(2, 2);
            arr2.Fill();

            Arr arr3 = arr1 + arr2;
            arr3.Show();
            */

            int[,] mas = { { 1, 2 }, { 2, 3 } };
            Arr masIsArr = mas;
            masIsArr.Show();
            Console.WriteLine($"{masIsArr.Diagonal = 12}");
            masIsArr.Show();

            int[,] massive = (int[,])masIsArr;
            foreach (var i in massive)
                Console.Write($"{i} ");

             if (masIsArr)
                 Console.WriteLine("square");
             else Console.WriteLine("Not square");
        }
    }
}