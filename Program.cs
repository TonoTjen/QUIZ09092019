using System;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bangun Ruang");
            Console.WriteLine("----------------------------------------");
            BRuang obj = new BRuang();
            Console.WriteLine("1.) Menghitung Volume Balok");
            int p, l, t1;
            Console.Write("    Panjang : ");
            p = Convert.ToInt32(Console.ReadLine());
            Console.Write("    Lebar : ");
            l = Convert.ToInt32(Console.ReadLine());
            Console.Write("    Tinggi : ");
            t1 = Convert.ToInt32(Console.ReadLine());
            obj.volume_balok(p, l, t1);

            Console.WriteLine("----------------------------------------");

            Console.WriteLine("2.) Menghitung Volume Kubus");
            int s1;
            Console.Write("    Sisi : ");
            s1 = Convert.ToInt32(Console.ReadLine());
            obj.volume_kubus(s1);

            Console.WriteLine("========================================");
            Console.WriteLine("Bangun Datar");
            Console.WriteLine("----------------------------------------");

            BDatar objct = new BDatar();
            Console.WriteLine("1.) Menghitung Luas Persegi");
            int s;
            Console.Write("    Sisi : ");
            s = Convert.ToInt32(Console.ReadLine());
            objct.luas_persegi(s);

            Console.WriteLine("----------------------------------------");

            Console.WriteLine("2.) Menghitung Luas Segitiga");
            int t,a;
            Console.Write("    Tinggi : ");
            t = Convert.ToInt32(Console.ReadLine());
            Console.Write("    Alas : ");
            a = Convert.ToInt32(Console.ReadLine());
            objct.luas_segitiga(t, a);

            Console.WriteLine("----------------------------------------");
            
            Console.WriteLine("3.) Menghitung Luas Lingkaran");
            int r;
            Console.Write("    Jari-Jari : ");
            r = Convert.ToInt32(Console.ReadLine());
            objct.luas_lingkaran(r);
        }
    }
}
