using System;
namespace Algoritma_sorulari
{
    class birincisoru
    {
        static void Main(string []args)
        {

            int sayi;
            Console.WriteLine("Lütfen bir pozitif tam sayı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            int[] sayilar = new int[sayi];
            Console.WriteLine(sayi+ " adet pozitif tam sayı giriniz.");
            for (int i = 0; i < sayi; i++)
            {
                Console.Write("Sayılar dizisinin "+ (i+1) + ". indexini giriniz:");
                
            }

            Console.WriteLine("Dizinizdeki çift sayılar: ");
            foreach (int item in sayilar)
            {
                if (item%2==0)
                Console.WriteLine(item+",");
            }

            ikincisoru.Second();
        }
    }
}