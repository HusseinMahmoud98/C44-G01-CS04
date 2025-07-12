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
            int a = 1, b = 2;

            Console.WriteLine("Before Swapping");
            Console.WriteLine($"a = {a}, b = {b}");  //a = 1, b = 2

            SwapByValue(a, b);
            Console.WriteLine("Afer Swapping by vlaue"); //a = 1, b = 2
            Console.WriteLine($"a = {a}, b = {b}");

            SwapByRef(ref a, ref b);
            Console.WriteLine("Afer Swapping by vlaue"); //a = 2, b = 1
            Console.WriteLine($"a = {a}, b = {b}");

            #endregion
        }
    }
}
