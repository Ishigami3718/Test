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

        static int[,] ChooseStudent1Block(int[,] arr)
        {
            string choose = Console.ReadLine();
            switch (choose)
            {
                case "1":Student1.Block1(arr);break;
                    case "2": Student1.Block2(arr); break;
                    case "3": Student1.Block3(arr); break;
            }
            return arr;
        }

        static int[,] ChooseStudent2Block(int[,] arr)
        {
            string choose = Console.ReadLine();
            switch (choose)
            {
                case "1": Student2.Block1(arr); break;
                case "2": Student2.Block2(arr); break;
                case "3": Student2.Block3(arr); break;
            }
            return arr;
        }

        static int[,] ChooseStudent3Block(int[,] arr)
        {
            string choose = Console.ReadLine();
            switch (choose)
            {
                case "1": Student3.Block1(arr); break;
                case "2": Student3.Block2(arr); break;
                case "3": Student3.Block3(arr); break;
            }
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
                    default: arr = new int[1, 1];break;
                }
                string chooseStudent = "1";
                while (chooseStudent != "0")
                {
                    chooseStudent = Console.ReadLine();
                    Console.WriteLine("Input student to do");
                    switch (choose)
                    {
                        case "1": ChooseStudent1Block(arr) ; break;
                        case "2": ChooseStudent2Block(arr); break;
                        case "3": ChooseStudent3Block(arr); break;
                    }

                }
            }
        }
    }
}