using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMethod2
{
    class Program
    {
        static void Main(string[] args)
        {
            int hasil;

            //membuat objek class kalkulator
            Kalkulator kalkulator = new Kalkulator();

            hasil = kalkulator.Penjumlah(10, 2);
            CetakHasil("Hasil penjumlah: " + hasil);

            hasil = kalkulator.Penjumlah(10, 2, 3);
            CetakHasil("Hasil penjumlah overload: " + hasil);

            hasil = kalkulator.Pengurangan(7, 2);
            CetakHasil("Hasil pengurangan: " + hasil);

            hasil = Kalkulator.Perkalian(5, 2);
            CetakHasil("Hasil perkalian: " + hasil);

            Console.ReadKey();
        }

        static void CetakHasil(string hasil)
        {
            Console.WriteLine(hasil);
        }

        static int Penjumlah(int a, int b)
        {
            return a + b;
        }
    }
}
