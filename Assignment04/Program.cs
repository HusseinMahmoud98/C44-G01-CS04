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
            int a = 3, b = 7;
            SumSub(a, b, out int sum, out int sub);

            Console.WriteLine($"Sum = {sum}, Sub = {sub}"); //Sum = 10, Sub = -4
            #endregion
        }
    }
}
