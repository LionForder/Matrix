using System;

namespace Program
{
    public class Arr
    {
        public Arr(int n, int m)
        {
            IntArray = new int[n, m];
            this.n = n;
            this.m = m;
        }
        int[,] IntArray;
        int n;
        int m; // matrix parameters is n*m (override operator true/false)

        // properties
        public int Zero
        {
            get
            {
                int zero = 0;
                foreach (int i in IntArray)
                    if (i == 0)
                        zero++;
                return zero;
            }
        }

        public int Diagonal
        {
            set
            {
                // if(m == n) square matrix
                for (int i = 0; i < (n > m ? m : n); i++)
                    IntArray[i, i] = value;
            }
        }

        // indexator
        public int this[int first, int second]
        {
            get { return IntArray[first, second]; }
            set { IntArray[first, second] = value; }
        }

        //Override
        public static Arr operator ++(Arr mas)
        {
            for (int i = 0; i < mas.n; i++)
                for (int j = 0; j < mas.m; j++)
                    mas.IntArray[i, j]++;
            return mas;
        }

        public static Arr operator --(Arr mas)
        {
            for (int i = 0; i < mas.n; i++)
                for (int j = 0; j < mas.m; j++)
                    mas.IntArray[i, j]--;
            return mas;
        }

        public static bool operator true(Arr mas)
        {
            return mas.n == mas.m;
        }

        public static bool operator false(Arr mas)
        {
            return mas.n == mas.m;
        }

        public static Arr operator +(Arr arr1, Arr arr2)
        {
            Arr arr3 = new Arr(arr1.n, arr1.m);
            if (arr1.n == arr2.n && arr1.m == arr2.m)
                for (int i = 0; i < arr1.n; i++)
                    for (int j = 0; j < arr2.m; j++)
                        arr3[i, j] = arr1[i, j] + arr2[i, j];
            return arr3;
        }




        // preobr
        public static explicit operator int[,](Arr arr)
        {
            return arr.IntArray;
        }

        public static implicit operator Arr(int[,] mas)
        {
            int row = mas.GetLength(0);
            int column = mas.GetLength(1);
            Arr arr = new Arr(row, column) { IntArray = mas };
            return arr;
        }



        public void Fill()
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Вводите элементы из {i + 1} строки");
                for (int j = 0; j < m; j++)
                    IntArray[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void Show()
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"[{IntArray[i, 0]}");
                for (int j = 1; j < m; j++)
                    Console.Write($", {IntArray[i, j]}");
                Console.WriteLine("]");
            }
        }

        public void SumOf(int column)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
                sum += IntArray[i, column - 1];
            Console.WriteLine($"Сумма {column} столбца = {sum}");
        }
    }
}
