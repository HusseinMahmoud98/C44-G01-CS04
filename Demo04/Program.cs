namespace Demo04
{
    internal class Program
    {
        //1. Class member methods [Static methods]
        //2. Object member method [Non-static methods]
        public static void PrintShape(string pattern = "-_-", int count = 3)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write($"{pattern} ");
            }

        }


        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }



        public static int SumArray(ref int[] arr)
        {
            int sum = 0;

            if (arr is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
            }

            return sum;
        }


        public static int SumArray02(int[] arr)
        {
            int sum = 0;

            arr = new int[] { 10, 20, 30, 40, 50 };

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }

        public static int SumArray03(ref int[] arr)
        {
            int sum = 0;

            arr = new int[] { 10, 20, 30, 40, 50 };

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }

        public static int SumArray04(params int[] arr)
        {
            int sum = 0;
            if (arr is not null)
                for (int i = 0; i < arr.Length; i++)
                    sum += arr[i];

            return sum;
        }

        public static int[] SumSub(int num1, int num2)
        {
            return [num1 + num2, num1 - num2];
        }

        public static DataToReturn SumSub02(int num1, int num2)
        {
            return new DataToReturn() { Sum = num1 + num2, Sub = num1 - num2 };
        }


        public static object SumSub03(int num1, int num2)
        {
            int Sum = num1 + num2;
            int Sub = num1 - num2;
            return new { Sum, Sub };
        }

        public static void SumSub04(int num1, int num2, out int sum, out int sub)
        {
            sum = num1 + num2;
            sub = num1 - num2;
        }

        public static void Concat<T>(params ReadOnlySpan<T> items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine($"{items[i]}");
            }
        }

        static void Main(string[] args)
        {
            #region 1D Array
            //int[] numbers1 = new int[3];

            ////initialize 0, 1, 2
            //for (int i = 0; i < numbers1.Length; i++)
            //{
            //    numbers1[i] = i;
            //}

            //int[] numbers2 = new int[3] { 4, 5, 6};  //initialize 4, 5, 6
            //int[] numbers3 = new int[] { 7, 8, 9 };  //initialize 7, 8, 9
            //int[] numbers4 = new int[3];  //initialize 0, 0, 0



            //Console.WriteLine($"Size of numbers1[] = {numbers1.Length}");  //Size of numbers1[] = 3
            //Console.WriteLine($"Rank of numbers1[] = {numbers1.Rank}");  //Rank of numbers1[] = 1
            #endregion

            #region 2D Array
            //int[,] marks1 = new int[2, 3];
            //marks1[0, 0] = 100;
            //marks1[0, 1] = 95;
            //marks1[0, 2] = 90;
            //marks1[1, 0] = 80;
            //marks1[1, 1] = 75;
            //marks1[1, 2] = 88;

            //int[,] marks2 = new int[2, 3] { { 100, 90, 60 }, { 55, 40, 99 } };

            //for (int i = 0; i < marks1.Length; i++)
            //{
            //    Console.WriteLine($"Subject number{i/marks1.Rank+1} = {marks1[i%marks1.Rank, i/marks1.Rank]}");
            //}
            #endregion

            #region Judged Array
            //int[][] jadgedArray = new int[2][];

            //jadgedArray[0] = new int[2];
            //jadgedArray[1] = new int[3] { 1, 2, 3};


            
            #endregion

            #region Function Prototybe
            //PrintShape(":)", 10); //Passing by rder
            //Console.WriteLine();

            //PrintShape(count: 5, pattern: ":("); //Passing by name
            //Console.WriteLine();

            //PrintShape(); //Use default values
            #endregion

            #region Function Parameters
            ////Value Type vs Ref tybe
            //int a=1, b=2;
            //Console.WriteLine("Before Swapping");
            //Console.WriteLine($"a = {a}, b = {b}");
            //Swap(ref a, ref b);
            //Console.WriteLine("Afer Swapping");
            //Console.WriteLine($"a = {a}, b = {b}");


            #endregion

            #region Function Parameters Ref Type Ex01
            //int[] numbers = { 1, 2, 3, 4, 5};
            ////int[] numbers = null;
            //Console.WriteLine($"Sum of array = {SumArray(ref numbers)}");
            #endregion


            #region Function Parameters Ref Type Ex02
            //int[] numbers = { 1, 2, 3, 4, 5 };
            ////Console.WriteLine($"Sum = {SumArray02(numbers)}");
            //Console.WriteLine($"Sum = {SumArray03(ref numbers)}");
            //Console.WriteLine(numbers[0]);
            #endregion

            #region Function Parameters out
            //int num1 = 2, num2 = 5;
            //SumSub04(num1 , num2, out int SumResult, out int SubResult);

            //Console.WriteLine($"{num1} + {num2} = {SumResult}");
            //Console.WriteLine($"{num1} - {num2} = {SubResult}");
            #endregion

            #region Funtion Parameters [Params] Ex01
            //Console.WriteLine($"Sum = {SumArray04(1, 2, 3, 4, 5)}");
            #endregion

            #region Funtion Parameters [Params] Ex02
            //Concat<object>("Hello Hussein", "Welcome back", "Your number is", 12345, "Date is ", DateTime.Now);
            #endregion

            #region Funtion Parameters [Params] Ex03
            //int number = 12345;
            //string name = "Hussein";
            //string message = string.Format("Hello {0}!\nYour Age is {1}, Your number is {2}", name, 27, number);
            //Console.WriteLine( message);
            #endregion



        }

    }
}


