using System;
using System.Collections;

namespace Collection
{
    class Program
    {
        private const int V = 3;

        static void Main(string[] args)
        {
            //  Soru1();
            Soru2();
            //   Soru3();
        }
        #region Soru_1
        static void Soru1()
        {
            /*
           Soru 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)
              Negatif ve numeric olmayan girişleri engelleyin.
              Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
              Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
             */


            ArrayList prime = new ArrayList();
            ArrayList notPrime = new ArrayList();

            for (int i = 0;i <20; i++)
            { Console.WriteLine("Bir sayı giriniz : ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if(sayi > 0)
                {
                    Console.WriteLine((i+1) + ". Sayıyı giriniz :");
                    int sayac = 0;
                    for (int j = 2; j<sayi; j++)
                    {
                        if (sayi % j ==0)
                        {
                            sayac++;

                        }
                    }
                    if (sayac==0)
                    {
                        prime.Add(sayi);
                    }
                    else
                    {
                        notPrime.Add(sayi);
                   }
                }
                else
                {
                    Console.WriteLine(" Negatif ve numeric olmayan değer girilemez !!");
                    i--;
                }
           }
            prime.Sort();
            prime.Reverse();
            Console.WriteLine("-----------------------Asal sayılar ----------------------");
            sirala(prime);
            ortlama(prime);

            notPrime.Sort();
            notPrime.Reverse();
            Console.WriteLine("-----------------------Asal  olmayan sayılar ----------------------");
            sirala(notPrime);
            ortlama(notPrime);
        
            void ortlama(ArrayList list)
            {
                int toplam = 0;
                double ortalama = 0;
                foreach (int item in list)
                {
                    toplam += item;

                }
                ortalama = toplam / list.Count;
                Console.WriteLine("Ortalama : " + ortalama.ToString());

            }

            void sirala(ArrayList list)
            {
                foreach (int item in list)
                {
                    Console.WriteLine(item.ToString());

                }
            }

        }
        #endregion
        #region Soru_2
        static void Soru2()
        {/*Soru 2 :
          * Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, 
          * her iki grubun kendi içerisinde ortalamalarını * alan ve
          * bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız.
          * (Array sınıfını kullanarak yazınız.) 
          */
            ArrayList sayilar = new ArrayList();
            int[] EB = new int[3];
            int[] EK = new int[3];
            int sayi = 0;
            for (int i =0; i<20; i++ )
            {
                Console.WriteLine((i+1).ToString()+". Sayıyı gir : ");
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi>=0)
                {
                    sayilar.Add(sayi);
                }
                else
                {
                    Console.WriteLine("Negatif ve numeric olmayan girişler yapılamaz ...");
                    i--;
                }          
            }

            sayiAl(sayilar);
            sayilar.Sort();
            sayilar.Reverse();
            Console.WriteLine("En büyük 3 sayi ortalaması : " + ortlama(EB).ToString());
            sayilar.Sort();
            Console.WriteLine("En küçük 3 sayi ortalaması : " + ortlama(EK).ToString());
            Console.WriteLine("İkisinin toplamı: " + (ortlama(EB) + ortlama(EK)).ToString());


            double ortlama(int[] say  )
            {
                double ortlama = 0;
                int toplam = 0;
                foreach (int item in sayilar)
                {
                    toplam += item;
                }
                ortlama = toplam / sayilar.Count;
                return ortlama;
            }

            void sayiAl(ArrayList sayilar)
            {
                
                int sayac = 0;
                foreach (int item in sayilar)
                {
                    if (sayac>=0 && sayac<3 ) {
                        EK[sayac] = item;
                        sayac++;
                    }
                    else
                    {
                        break;
                    }
                }
                int say = 0;
            
                foreach (int item in sayilar)
                {
                    if (say >= 0 && say < 3)
                    {
                        EB[say] = item;
                        say++;
                    }
                }


            }



   
        }
         #endregion
             #region Soru_3
        static void Soru3()
        {
            /*
             Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve
            dizinin elemanlarını sıralayan programı yazınız.
             */


            char[] sesliHarf = { 'I', 'ı', 'İ', 'i', 'E', 'e', 'A', 'a', 'Ö', 'ö', 'U', 'u', 'O', 'o' };
            try
            {
                Console.Write("Bir cümle gir : ");
                string metin = Console.ReadLine();

                char[] metinAyir = metin.ToCharArray();
                char[] liste = new char[metin.Length];
                int say = 0;

                for (int i = 0; i < metinAyir.Length; i++)
                {
                    for (int j = 0; j < sesliHarf.Length; j++)
                    {
                        if (metinAyir[i] == sesliHarf[j])
                        {
                            liste[say] = metinAyir[i];
                            say++;
                        }
                    }
                }
                Console.WriteLine("Metindeki sesli harfler");
                foreach (var item in liste)
                {
                    Console.Write(" "+item.ToString());
                }

            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }


        }
        
        
       #endregion
    }


    }

