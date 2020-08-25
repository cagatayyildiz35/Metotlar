using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            //Dışarıdan 2 tane int değişken alan ve bu değikenleri toplayıp geriye döndüren metot
            //int Topla(int x, int y)
            //{
            //    int sonuc = x + y;

            //    return sonuc;
            //}

            //Dışarıdan bir string değişken alan ilk harfini büyülten ve sonucu döndüren metot
            string Ilkharf(string kelime)
            {
                string sonuc = kelime.ToLower();
                //ıvır zıvır

                return sonuc;
            }

           
            //Dışarıdan bir string dizi alan ve bu bool döndüren metot
            bool Zart(string[] isimdizi)
            {

                return true;
            }


            int[] sayilar = { 3, -1, 22, 4 };

            int metin = TeksayiHesapla(sayilar);


            //Dışarıdan aldığı int dizisine göre kaç adet sayının tek sayı olduğunu döndüren?
            int TeksayiHesapla(int[] sayidizi)
            {
                int sayac = 0;

                for (int i = 0; i < sayidizi.Length; i++)
                {

                    if(sayidizi[i] % 2 != 0)
                    {
                        sayac++;
                    }
                }

                return sayac;
            }




            //Dışarıdan 2 metin alan ve bu metinleri birleştirip metin dönen metot
            string MetinBirles(string kelime1, string kelime2)
            {
                string sonuc = kelime1 + kelime2;

                return sonuc;
            }


            //Console.WriteLine("Lütfen kısa kenarı giriniz");
            //double x = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Lüfen uzun kenarı giriniz");
            //double y = Convert.ToDouble(Console.ReadLine());

            //double z = DikdortgenCevre(x, y);

            ////Dikdörtgenin çevresini hesaplayan metot
            //double DikdortgenCevre(double kisa, double uzun)
            //{
            //    double sonuc = 2 * (kisa + uzun);

            //    return sonuc;
            //}

            //Verilen bir metinde ‘w’ ve ‘q’ harfleri var mı ? (string alıp boolean dönecek)

            //KarakterKontrol("çawaqay");

            //bool KarakterKontrol(string kelime)
            //{
            //    bool varMi = false;

            //    for (int i = 0; i < kelime.Length; i++)
            //    {
            //        if (kelime[i] == 'w' && kelime[i] == 'q')
            //        {
            //            varMi = true;
            //        }
            //    }

            //    return varMi;
              
            //}

            //kdv hesaplayan metot
            double KDVHesapla(double fiyat)
            {
                double sonuc = fiyat * 1.18;

                return sonuc;
            }


            //Gelen metnin solundaki yıldızları kaldır *
            //string y = YildizDuzenle("*****çağaty***asd**asd");
            //string YildizDuzenle(string ad)
            //{
            //    int yildizsayac = 0;
            //    bool sayacdurum = true;
            //    for (int i = 0; i < ad.Length; i++)
            //    {
            //        if(ad[i] != '*' && sayacdurum)
            //        {
            //            yildizsayac = i;
            //            sayacdurum = false;

            //            //break;
            //        }
            //    }

            //  //return  ad.Remove(yildizsayac);
            //   return ad.Substring(yildizsayac);
            //}


            //2. yol

            //string YildizDuzenle(string ad)
            //{
            //    int yildizsayac = 0;
            //    for (int i = 0; i < ad.Length; i++)
            //    {
            //        if (i == 0)
            //        {
            //            if (ad[0] == '*')
            //            {
            //                bool yildizdurum = true;
            //                for (int j = 0; j < ad.Length; j++)
            //                {
            //                    if (ad[j] == '*' && yildizdurum)
            //                    {
            //                        yildizsayac++;
            //                    }
            //                    else
            //                    {
            //                        yildizdurum = false;
            //                    }
            //                }
            //            }
            //        }
            //    }

            //    ad.Remove(yildizsayac);
            //    ad.Substring(yildizsayac);
            //}





        }



    }
}
