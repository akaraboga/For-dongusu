using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_orneklerı
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*
               for(int i=1; i<=10; i++)
               {
                   Console.WriteLine(i+" :Kendime inanıyorum yazılım işi bende \n\n");
               }

            */



            /*
                for(int i=1; i<=20;i++) 
                {
                Console.WriteLine($"1 ile 20 arasındaki sayilar {i} \n\n");
                }

            */

            /*



            for(int i = 0; i <= 20; i += 2) //Birden 20 arasındaki çift sayiları i=0 dan başlatıp 20 ye kadar i+=2 ile 2 şer 2 şer artırıyoruz
            {
                Console.WriteLine(i);
            }

            */




            /*

            int toplam = 0; //ilk once döngünün içinde topladıgımız degerleri tutacak olan değişkeni tanımlıyoruz

            for(int i=50;i<=150;i++)
            {
  // = in solundaki toplam degeri başlangıcta 0 , daha sonra başlangıc değeri 50 olan i  ile toplam değerini toplayıp "toplam" degerine atıyoruz  bu sayede i bir arttığında toplam değeri daha onceki tuttuğu degerin ustune yeni değeri topluyor
  // 
                toplam = toplam+i; 
                 
            }
            Console.WriteLine("50 ile 150 arasındaki sayilarin toplami :"+toplam);
                
            */


            

            int teksayi = 0; //tek ve çift sayiları tutacak olan değerleri alıyoruz
            int çiftsayi=0;

            for(int i = 1; i <= 120; i++)
            {
                if(i % 2 ==0) // Eğer i içindeki sayilarin 2 ile bölümünden 0 kalıyorsa çiftsayi değişkenine atayıp topluyoruz 
                {
                    çiftsayi=çiftsayi+i;
                }
                else
                {
                    teksayi=teksayi+i; //Eğer 2 ile bolumunden 1 kalıyorsa teksayi değişkenine atayıp topluyoruz
                }

            }

            Console.WriteLine("1 ile 120 arasındaki tek sayiların toplamı : "+teksayi);
            Console.WriteLine("1 ile 120 arasındaki çift sayiların toplamı :"+çiftsayi);

            Console.ReadLine();
        }
    }
}
