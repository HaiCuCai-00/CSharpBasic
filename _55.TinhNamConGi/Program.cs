using System;

namespace _55.TinhNamConGi
{
    class Program
    {
        static void Main(string[] args)
        {
            Test1();
        }

        private static void Test1()
        {
            int n;
            int Nam = 2021;
            n = Nam;
            int i = n;
            while (i >= 12)
            {
                i = i - 12;
                //Console.WriteLine($"n = {i}");
            }
            /*
              * 0 : Thân
                1 : Dậu
                2 : Tuất
                3 : Hợi
                4 : Tí
                5 : Sửu
                6 : Dần
                7 : Mão ( Mẹo )
                8 : Thìn
                9 : Tỵ
                10 : Ngọ
                11: Mùi
             */
            if (i == 0) Console.WriteLine($"Nam {n} la Than");
            if (i == 1) Console.WriteLine($"Nam {n} la Dau");
            if (i == 2) Console.WriteLine($"Nam {n} la Tuat");
            if (i == 3) Console.WriteLine($"Nam {n} la Hoi");
            if (i == 4) Console.WriteLine($"Nam {n} la Ti");
            if (i == 5) Console.WriteLine($"Nam {n} la Suu");
            if (i == 6) Console.WriteLine($"Nam {n} la Dan");
            if (i == 7) Console.WriteLine($"Nam {n} la Meo");
            if (i == 8) Console.WriteLine($"Nam {n} la Thin");
            if (i == 9) Console.WriteLine($"Nam {n} la Ty");
            if (i == 10) Console.WriteLine($"Nam {n} la Ngo");
            if (i == 11) Console.WriteLine($"Nam {n} la Mui");
            // Console.WriteLine($"n = {n}");
        }
    }
}
