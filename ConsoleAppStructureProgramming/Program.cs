using System;

namespace ConsoleAppStructureProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Hay nhap thang dang so: ");
            int m = Convert.ToInt32(Console.ReadLine()); //"10" vs 10
            PrintMonth(m);
            Console.Write($"Tong cac phan tu tu 1 den n la: {Sum(100)}");
            */

            /*
               - Khai báo mảng một chiều n số nguyên
               - Thêm mới một phần tử x vào mảng
               - In ra tất cả các phần tử từ mảng ra ngoài
               - Xóa một phần tử
               - Update một phần tử tại vị trí p nào đó.
             
             */

            //Cú pháp 1:
            int[] arrNumbers = new int[5];
            //Cú pháp 2:
            int[] arrayNum = { 1, 3, 5, 7, 9, 10 };
            //Cú pháp 3:
            int[] arrayData = new int[5] { 1, 2, 3, 4, 5 };
            PrintArray(arrayData);

            AddArray(ref arrayData, 20);
            PrintArray(arrayData);
            Console.WriteLine("===============================");
            arrayData = RemoveArray(arrayData, 2);
            PrintArray(arrayData);
            UpdateArray(ref arrayData, 4, 100);
            Console.WriteLine("===============================");
            PrintArray(arrayData);
        }

        /*
         Nhập vào từ bàn phím số nguyên month in [1,12]. Và in màn hình tên tháng.
         Ví dụ: month = 1 ==> "Tháng 1"
         */
        static void PrintMonth(int month)
        {
            if (month <= 0 && month > 12)
                Console.WriteLine("Thang khong hop le");

            if(month == 1)
            {
                Console.WriteLine("Thang 1");
            }else if( month == 2)
            {
                Console.WriteLine("Thang 2");
            }
            else
            {
                Console.WriteLine("Thang khong hop le");
            }
 
        }
        static void PrintMonthCase(int m)
        {
            switch (m)
            {
                case 1:
                    Console.WriteLine("Thang 1");
                    break;
                case 2:
                    Console.WriteLine("Thang 2");
                    break;
                case 3:
                    Console.WriteLine("Thang 3");
                    break;
                default:
                    Console.WriteLine("Invalid month");
                    break;
            }
        }
        /*
         Viết chương trình tính tổng dãy số: s = 1+2+3+..+n
         */
        /*
        static int Sum(int n)
        {
            int total = 0, i = 0;
            
            while (i <= n)
            {
                total += i;
                i++;  
            }
            for(i = 1; i <= n; i++)
                total += i;
            

            return total;
        }
        */
        //thay vòng lặp bằng đệ quy
        static int Sum(int n)
        {
            if (n == 0 || n == 1)
                return n; //base
            return n + Sum(n - 1); //dk đệ quy
        }
        //In ra
        static void PrintArray(int[] data)
        {
            int d = 0;
            //cú pháp 1:
            /*
            for (int i = 0; i < data.Length; i++)
                Console.WriteLine($"Phan tu thu {i+1} là: {data[i]}");
            */
            //cú pháp 2
            foreach(int v in data)
            {
                Console.WriteLine($"Phan tu là: {v}");
            }
               
        }
        
        //Them moi phan tu x vao mang 
        static void AddArray(ref int[] data, int x)
        {
            //1. Do mang data bị full, tạo 1 mảng mới có dung lượng > lớn hơn data 1 đơn vị
            int[] temp = new int[data.Length + 1];
            //2. copy số lượng phần tử từ mảng data sang temp
            Array.Copy(data, 0, temp,0, data.Length);
            //2. add phần tử x vào mảng mới đó (vào vị trí cuối)
            temp[temp.Length-1] = x;
            //3. Thay đổi mảng data
            data = temp;
        }
        //Remove 1 phan tu tai vi tri p nao do
        /// <summary>
        /// This function remove a element in the array...
        /// </summary>
        /// <param name="data"></param>
        /// <param name="p"></param>
        /// <returns>Xóa một phần tử ở vị trí p cho trước</returns>
        static int[] RemoveArray(int[] data, int p)
        {
            int[] temp = new int[data.Length - 1];
            if (p < 0 || p >= data.Length)
                return data;
            //"xô" từ vị trị p + 1 --> p
            for(int i = p; i<data.Length-1; i++)
            {
                data[i] = data[i + 1];
            }
            //copy tu mang data với length - 1 --> temp
            Array.Copy(data, 0, temp, 0, data.Length - 1);
            // return temp
            return temp;
        }
        static void UpdateArray(ref int[] data,int p, int x)
        {
            if(!(p < 0 || p >= data.Length))
            {
                data[p] = x;
            }
        }
    }
}
