using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //comment on-single line
            /*comment tren 1 dong*/
            /*
               @Desc: Hàm này thực hiễn......
               @Author: Dongbh
               @Input:
               @Output:
             
             */
            //primitive/ prime
            byte age = 20;
            double salary = 1_500_000.25;
            string name = "Ma Van Meo";
            bool isManager = true;

            Console.WriteLine($"Ten la: {name}, tuoi: {age} va luong: {salary}");

            int add = Add(10, 11);
            Console.WriteLine($"Tong cua {10} và {11} là: {add}");
        }
        //Ham tinh tong hai so nguyen: signature
        //Overloading (nạp chồng)
        static int Add(int a, int b)
        {
            return a + b;
        }
        static double Add(double a, double b)
        {
            return a + b;
        }
        static int Add(int a, int b, int c) => Add(Add(a, b), c);
        static void Display(string message)
        {
            Console.WriteLine(message);
        }
    }
}
