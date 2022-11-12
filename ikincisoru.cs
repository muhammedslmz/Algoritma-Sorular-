using System;
namespace Algoritma_sorulari
{
class ikincisoru 
{
     public static void Second()
    {
        int[] dizi=new int[2];
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("İki pozitif tam sayıdan "+(i+1)+". sini giriniz.");
             dizi[i]=Convert.ToInt32(Console.ReadLine());
        }
        
        Console.WriteLine("Lütfen "+dizi[0]+" adet pozitif sayı giriniz");
        int[] dizi2= new int[dizi[0]];
        for (int i = 0; i < dizi[0]; i++)
        {
            Console.WriteLine((i+1)+". sayı:");
            dizi2[i]=Convert.ToInt32(Console.ReadLine());
        }

        foreach (var item in dizi2)
        {
            if(item % dizi[1] == 0)
            Console.WriteLine(item);

            
        }
        ucuncusoru.Third();
    }
}
}