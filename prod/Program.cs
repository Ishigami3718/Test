using prod;
using System;
namespace Lab
{
    class Program
    {
        static int[,] CreateArray()
        {
            ///code
            int[,] arr = new int[1, 1];
            return arr;
        }
        static void Main(string[] args)
        {
            string choose = "1";
            int[,] arr;
            while (choose != "0")
            {
                choose = Console.ReadLine();
                Console.WriteLine("Input create array style");
                switch (choose)
                {
                    case "1":arr = CreateArray(); break;
                    case "2": arr = CreateArray(); break;
                    case "3": arr = CreateArray(); break;
                }
                string chooseSrudent = "1";
                while (chooseSrudent != "0")
                {
                    choose = Console.ReadLine();
                    Console.WriteLine("Input block to do");
                    switch (choose)
                    {
                        case "1": arr = Student1.Block1(); break;
                        case "2": arr = CreateArray(); break;
                        case "3": arr = CreateArray(); break;
                    }

                }
            }
        }
    }
}