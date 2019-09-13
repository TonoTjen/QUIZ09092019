using System;

namespace Quiz
{
    class BRuang
    {
        public void volume_balok(int panjang, int lebar, int tinggi)
        {
            Console.WriteLine("    Volume Balok adalah "+panjang*lebar*tinggi);
        }
        public void volume_kubus(int sisi)
        {
            Console.WriteLine("    Volume Kubus adalah "+sisi*sisi*sisi);
        }
    }
}