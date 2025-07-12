namespace Assignment04
{
    internal class Program
    {
        public static void SwapByValue(int num1, int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }

        public static void SwapByRef(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }

        public static void SwapByValueRefType(int[] number)
        {
            int temp = number[0];
            number[0] = number[1];
            number[1] = temp;
        }

        public static void SwapByRefRefType(ref int[] number)
        {
            int temp = number[0];
            number[0] = number[1];
            number[1] = temp;
        }

        public static void SumSub(int num1, int num2, out int sum, out int sub)
        {
            sum = num1 + num2;
            sub = num1 - num2;
        }

        public static int SumOfIndividualDigits(int number)
        {
            int Sum = 0;

            while (number != 0)
            {
                Sum += number % 10;
                number /= 10;
            }


            return Sum;
        }


        public static bool isPrime(uint number)
        {

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return number > 2 ? true : false;
        }

        public static void MinMaxArray(ref int[] Numbers, ref int Max, ref int Min)
        {
            Max = Numbers[0];
            Min = Numbers[0];

            for (int i = 1; i < Numbers.Length; i++)
            {
                if (Numbers[i] > Max)
                {
                    Max = Numbers[i];
                }

                if (Numbers[i] < Min)
                {
                    Min = Numbers[i];
                }
            }
        }

        public static uint GetFactorial(uint number)
        {
            if (number == 0 || number == 1)
            {
                return 1;
            }

            else
            {
                return GetFactorial(number - 1) * number;
            }
        }

        public static string ChangeChar(string str01, int Position, char newChar)
        {
            char[] strToArrayOfChar = str01.ToCharArray();  //convert the array into an array of char


            strToArrayOfChar[Position] = newChar; //Update the required character

            return new string(strToArrayOfChar); //return the new string object
        }

        public static int GetSumOfArray(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        static void Main(string[] args)
        {
            #region Q01
            //1 - Explain the difference between passing(Value type parameters) by value and by reference then write a suitable c# example. 
            /* Passing by value:
             * Create stack frame and with new variables of initial values givin in function call
             * Once the function is terminated, the the parameter variables are removed from stack frame
             * Passing by ref:
             * Create stack frame but with the same variables adressess parameters
             * Once the function is terminated, the the parameter variables are not removed from stack frame
             */
            //int a = 1, b = 2;

            //Console.WriteLine("Before Swapping");
            //Console.WriteLine($"a = {a}, b = {b}");  //a = 1, b = 2

            //SwapByValue(a, b);
            //Console.WriteLine("Afer Swapping by vlaue"); //a = 1, b = 2
            //Console.WriteLine($"a = {a}, b = {b}");

            //SwapByRef(ref a, ref b);
            //Console.WriteLine("Afer Swapping by vlaue"); //a = 2, b = 1
            //Console.WriteLine($"a = {a}, b = {b}");
            #endregion

            #region Q02
            //2- Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.

            //int[] arr = { 10, 20 };

            //Console.WriteLine("Before Swapping");
            //Console.WriteLine($"arr[0] = {arr[0]}, arr[1] = {arr[1]}");  //arr[0] = 10, arr[1] = 20

            //SwapByValueRefType(arr);
            //Console.WriteLine("Afer Swapping by vlaue");
            //Console.WriteLine($"arr[0] = {arr[0]}, arr[1] = {arr[1]}"); //arr[0] = 20, arr[1] = 10

            //SwapByRefRefType(ref arr);
            //Console.WriteLine("Afer Swapping by Ref");
            //Console.WriteLine($"arr[0] = {arr[0]}, arr[1] = {arr[1]}"); //arr[0] = 10, arr[1] = 20

            #endregion

            #region Q03
            /* 3- Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers */
            //int a = 3, b = 7;
            //SumSub(a, b, out int sum, out int sub);

            //Console.WriteLine($"Sum = {sum}, Sub = {sub}"); //Sum = 10, Sub = -4
            #endregion

            #region Q04
            //4 - Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            //    Output should be like
            //    Enter a number: 25
            //    The sum of the digits of the number 25 is: 7
            //int num;
            //bool isNum;

            //do
            //{
            //    Console.Write("Enter a number: ");
            //    isNum = int.TryParse(Console.ReadLine(), out num);
            //}
            //while (!isNum);

            //Console.WriteLine($"Sum of individual digits of {num} is {SumOfIndividualDigits(num)}"); //Sum of individual digits of 45 is 9

            #endregion

            #region Q05
            //5- Create a function named "IsPrime", which receives an integer number
            //   and retuns true if it is prime, or false if it is not:
            //uint number;
            //bool isNum;

            //do
            //{
            //    Console.Write("Enter a number: ");
            //    isNum = uint.TryParse(Console.ReadLine(), out number);
            //}
            //while (!isNum);

            //if (isPrime(number))
            //{
            //    Console.WriteLine($"{number} is prime");
            //}

            //else
            //{
            //    Console.WriteLine($"{number} is not prime");
            //}

            #endregion

            #region Q06
            // 6 - Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            //int[] arr = { 3, 2, 6, 11, -3, 9 };
            //int Min = 0, Max = 0;
            //MinMaxArray(ref arr, ref Max, ref Min);

            //Console.WriteLine($"Max = {Max}, Min = {Min}"); //Max = 11, Min = -3

            #endregion

            #region Q07
            ////7- Create function to calculate the factorial of the number specified as parameter
            //uint number;
            //bool isNum;

            //do
            //{
            //    Console.Write("Enter a positive number: ");
            //    isNum = uint.TryParse(Console.ReadLine(), out number);
            //}
            //while (!isNum);

            //Console.WriteLine($"Factorial of {number} is {GetFactorial(number)}");
            #endregion

            #region Q08
            //8 - Create a function named "ChangeChar" to modify a letter in a certain position(0 based) of a string, replacing it with a different letter
            //string str = "Hussein Mahmoud";

            //str = ChangeChar(str, 7, '_');

            //Console.WriteLine(str);  //Hussein_Mahmoud

            #endregion

            #region Q09
            //9- . Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table
            //     of size n* n.
            //Console.Write("Enter the rank of the matrix: ");

            //int rank = int.Parse(Console.ReadLine());

            //for (int i = 0; i < rank; i++)
            //{
            //    for (int j = 0; j < rank; j++)
            //    {
            //        if (i == j)
            //        {
            //            Console.Write("1\t");
            //        }

            //        else
            //        {
            //            Console.Write("0\t");
            //        }
            //    }

            //    Console.Write("\n");  //create new line for the new row
            //}

            #endregion

            #region Q10
            // 10- Write a program in C# Sharp to find the sum of all elements of the array.
            //int[] arr = { 1, 2, 3, 4, 5, 7, -2, 50, 0 };
            //Console.WriteLine($"Sum of array is {GetSumOfArray(arr)}");  //Sum of array is 70
            #endregion

            #region Q11
            // 11-  Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //Console.WriteLine("Enter the size of the arrays N");

            //int N = int.Parse(Console.ReadLine());



            //int[] arr1 = new int[N], arr2 = new int[N];

            //Console.WriteLine("Enter the first array");

            //for (int i = 0; i < N; i++)
            //{
            //    arr1[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Enter the second array");

            //for (int i = 0; i < N; i++)
            //{
            //    arr2[i] = int.Parse(Console.ReadLine());
            //}

            ////Merge the two arrays
            //int[] mergedArr = new int[2 * N];

            //for (int i = 0; i < N; i++)
            //{
            //    mergedArr[i] = arr1[i];
            //    mergedArr[i + N] = arr2[i];
            //}

            ////Sort the merged array
            //for (int i = 0; i < mergedArr.Length - 1; i++)
            //{
            //    for (int j = 0; j < N * 2 - i - 1; j++)
            //    {
            //        if (mergedArr[j] > mergedArr[j + 1])
            //        {
            //            int temp = mergedArr[j];
            //            mergedArr[j] = mergedArr[j + 1];
            //            mergedArr[j + 1] = temp;
            //        }
            //    }
            //}


            //Console.WriteLine("============================================");
            //Console.WriteLine("The sorted array :");
            //for (int i = 0; i < mergedArr.Length; i++)
            //{
            //    Console.Write(mergedArr[i]+" ");
            //}

            #endregion

            #region Q12
            /* 12- Write a program in C# Sharp to find maximum and minimum element in an array*/
            //int[] arr = { 1, 2, 0, 8, 7 };

            //int max = arr[0], min = arr[0];

            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //    }

            //    if (arr[i] < min)
            //    {
            //        min = arr[i];
            //    }
            //}

            //Console.WriteLine($"Max = {max}, Min = {min}");  //Max = 8, Min = 0
            #endregion

            #region Q13
            //13- Write a program in C# Sharp to find the second largest element in an array.
            int[] arr = { 1, 2, 0, 8, 7 };

            //Sort the array in descending order
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        //swap
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine($"Second largest element in the array is {arr[1]}");  //7

            #endregion

            #region Q14
            /* 14- Consider an Array of Integer values with size N, having values as write a program to find the longest distance between Two equal cells.
             * In this example. The distance is measured by the number Of cells- for example, the distance between the first and the
             * fourth cell is 2 (cell 2 and cell 3).
             * In the example above, the longest distance is between the first 7 and the 10th 7, with a distance of 8 cells, i.e. the number of cells between the 1st 
             * And the 10th 7s. 
             * Note:
             * Array values will be taken from the user If you have input like 1111111 then the distance is the number of Cells between the first and the last cell. 
             */
            int N, longest_distance = 0, distance = 0;
            Console.Write("Enter the number of cells: ");
            N = int.Parse(Console.ReadLine());

            int[] Cells = new int[N];


            Console.WriteLine("Enter cells' values");
            for (int i = 0; i < N; i++)
            {
                Cells[i] = int.Parse(Console.ReadLine());
            }

            //get the largest distance
            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (Cells[i] == Cells[j])
                    {
                        distance = j - i - 1;

                        if (distance > longest_distance)
                        {
                            longest_distance = distance;
                        }
                    }
                }
            }

            Console.WriteLine($"longest distance = {longest_distance}");
            #endregion


        }
    }
}
