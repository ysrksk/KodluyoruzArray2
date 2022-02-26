using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayiDizisi = {23,12,4,86,72,3,11,17};

            System.Console.WriteLine("****sırasız dizi****");

            foreach (var item in sayiDizisi)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine("****Sıralı Dizi ****");
            Array.Sort(sayiDizisi);

            foreach (var item in sayiDizisi)
            {
                System.Console.WriteLine(item);
            }

            //clear
            System.Console.WriteLine("Array Clear");

            // sayiDzisi elamanlarını kullarak 2. index ten itibaren 2 tane elemanı 0 yapar
            Array.Clear(sayiDizisi,2,2);

            foreach (var item in sayiDizisi)
            {
                System.Console.WriteLine(item);
            }

            //reverse
            System.Console.WriteLine("Array Reverse");
            Array.Reverse(sayiDizisi);

            foreach (var item in sayiDizisi)
            {
                System.Console.WriteLine(item);
            }

            //indexof
            System.Console.WriteLine("index of");
            System.Console.WriteLine(Array.IndexOf(sayiDizisi,23));

            // Array Resize
            System.Console.WriteLine("Array Resize");
            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8] = 99;

              foreach (var item in sayiDizisi)
            {
                System.Console.WriteLine(item);
            }

        }
    }
}
