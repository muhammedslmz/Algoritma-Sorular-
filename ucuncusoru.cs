using System;
namespace Algoritma_sorulari
{
    class ucuncusoru
    {
        public static void Third()
        {
            Console.WriteLine("Lütfen pozitif bir değer giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            string[] dizi=new string[sayi];
            for (int i = 0; i < sayi; i++)
            {
                Console.WriteLine((i+1)+". kelimeyi giriniz: ");
                dizi[i]=Console.ReadLine();
            }
            for (int i = sayi; i > 0; i--)
                Console.WriteLine(dizi[i]);
            


            
        }
    }
}