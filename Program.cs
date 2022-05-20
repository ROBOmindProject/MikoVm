using System;

namespace MikoVm
{
    class Program
    {
        static void Main(string[] args)
        {
            // パース処理
            string src = @"
a = 3 + 1;
print a;
";
            var tokens = Parser.Parse(src);

            foreach(var tk in tokens)
            {
                Console.WriteLine($"{tk}");
            }

            Console.WriteLine("(何かキーを押すと終了します)");
            Console.ReadLine();
        }
    }
}
