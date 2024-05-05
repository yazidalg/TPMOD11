using LibararyMod10;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] persamaan = { -1, -3, -10 };
            double[] akar = Aljabar.PersamaanAkarKuadrat(persamaan);
            double[] hasil = { 2, -3 };
            double[] hasilKuadrat = Aljabar.HasilKuadrat(hasil);

            Console.WriteLine("Akar Persamaan Kuadrat : ");
            foreach (var akarValue in akar)
            {
                Console.WriteLine(akarValue);
            }

            Console.WriteLine("Hasil : ");
            foreach (var value in hasilKuadrat)
            {
                Console.WriteLine(value);
            }
        }
    }
}
