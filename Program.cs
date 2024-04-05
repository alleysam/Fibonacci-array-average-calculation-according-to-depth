using System;


namespace fibonacci {
    internal class Program
    {
        static void Main(string[] args)
        
        {
            FibonacciManager fibonacciManager = new FibonacciManager();

            Console.WriteLine("Dizi Derinliğini Girin : ");
            string input = Console.ReadLine();
            int depth =  Convert.ToInt32(input);

            List<int> FibArr = new List<int>{0,1};
            Console.WriteLine($"{depth} derinliğindeki fibonacci dizisinin ortalaması = {fibonacciManager.fiboArrAdd(FibArr,depth)}");
        }
    }
}
