using System;

namespace LocalFunctions
{
    class Program
    {
        /// <summary>
        /// On this lesson we demostrate ho to use function inside methods c sharp
        /// this can be done with lambda expression or with c sharp functions
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            FunctionLambdaTest();
            FuntionCsharpTest();

            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// function using lambda
        /// </summary>
        public static void FunctionLambdaTest()
        {
            //<input 1, input 2, result> functionName = (parameters name)=> operation
            Func<int, int, int> add = (x, y) => x + y;
         
            Console.WriteLine("\n Resultado de la suma mediante funcion lambda");
            Console.WriteLine("\n resultado {0}", add(89, 41).ToString());
            Console.ReadKey();
        }

        /// <summary>
        /// Funtion using c sharp
        /// </summary>
        public static void FuntionCsharpTest()
        {
            //Method type and name(parameter and type) => operations
            int add(int x, int y) => x + y;

            Console.WriteLine("\n Resultado de la suma mediante funcion csharp");
            Console.WriteLine("\n resultado {0}", add(89, 41).ToString());
            Console.ReadKey();
        }
    }
}
