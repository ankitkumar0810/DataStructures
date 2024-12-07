
namespace Recursion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Method1();
            //Method2();
            //Method3();
            //Method4();
            //TailRecursionDemo();
            //HeadRecursionDemo();
            //LinearRecursionDemo();
            //TreeRecursionDemo();
            //IndirectRecursionDemo();
            //NestedRecursionDemo();
            //SumDemo();
            //FactorialDemo();
            //PowerDemo();
            //TowerOfHanoiDemo();
            //FibonacciDemo();
            //MemoDemo();
            PascalTriangleDemo();
        }

        private static void Method1()
        {
            Example1 ex = new Example1();
            ex.fun1(3);

            // Output : 3 2 1
        }
        private static void Method2()
        {
            Example2 ex = new Example2();
            ex.fun2(3);

            // Output : 1 2 3
        }
        private static void Method3()
        {
            Example3 ex = new Example3();
            Console.WriteLine(ex.fun(5));

            // Output : 15
        }
        private static void Method4()
        {
            Example4 ex = new Example4();
            Console.WriteLine(ex.fun(5));

            // Output : 25
        }
        private static void TailRecursionDemo()
        {
            TailRecursion ex = new TailRecursion();
            ex.fun(3);

            // recursive method is called at returning phase
        }
        private static void HeadRecursionDemo()
        {
            HeadRecursion ex = new HeadRecursion();
            ex.fun(3);

            // recursive method is called at calling phase
        }
        private static void LinearRecursionDemo()
        {
            LinearRecursion ex = new LinearRecursion();
            ex.fun(3);

            // single recursive call is made
        }
        private static void TreeRecursionDemo()
        {
            TreeRecursion ex = new TreeRecursion();
            ex.fun(3);

            // Output : 3 2 1 1 2 1 1
            // multiple recursive call is made
        }
        private static void IndirectRecursionDemo()
        {
            IndirectRecursion ex = new IndirectRecursion();
            ex.funA(20);

            // Output : 20 19 8 4 3 1
            // funcA calls funcB and funcB calls funcA
        }
        private static void NestedRecursionDemo()
        {
            NestedRecursion ex = new NestedRecursion();
            Console.WriteLine(ex.fun(95));

            // Output : 91
            // recursive call within another receursive call
        }
        private static void SumDemo()
        {
            Sum sum = new Sum();
            Console.WriteLine(sum.sum(5));
        }
        private static void FactorialDemo()
        {
            Factorial fact = new Factorial();
            Console.WriteLine(fact.Fact(5));
        }
        private static void PowerDemo()
        {
            Power power = new Power();
            Console.WriteLine(power.Exponent(2, 30));
        }
        private static void TowerOfHanoiDemo()
        {
            TowerOfHanoi toh = new TowerOfHanoi();
            toh.TOH(3, 'A', 'B','C');
        }
        private static void FibonacciDemo()
        {
            Fibonacci fib = new Fibonacci();
            Console.WriteLine(fib.fib(6));
        }
        private static void MemoDemo()
        {
            FibMemo fib = new FibMemo();
            Console.WriteLine(fib.Memo(6));
        }
        private static void PascalTriangleDemo()
        {
            PascalTriangle pt = new PascalTriangle();
            pt.PrintPascalTriangle(5);
        }
    }
}
