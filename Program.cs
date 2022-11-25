using System;
using System.Collections;

namespace arraylist
{
    class program
    {
        static void Main(string[] args)
        {
            //System.Collections namespace

            ArrayList liste = new ArrayList();
            //liste.Add("Ayşe");
            //liste.Add(2);
            //liste.Add(true);
            //liste.Add('A');

            //İçerisinde Verilere Erişim
            //Console.WriteLine(liste[1]);

            //foreach (var item in liste)
            //Console.WriteLine(item);


            //AddRange
            Console.WriteLine("***** Add Range******");
            //string[] renkler ={ "kırmızı","Sarı","Yeşil"};
            List<int> sayılar = new List<int>() { 1, 8, 3, 7, 9, 92, 5 };
            //liste.AddRange(renkler);
            liste.AddRange(sayılar);

            foreach (var item in liste)
                Console.WriteLine(item);

            //Sort (Küçükten Büyüğe Sıralama)
            Console.WriteLine("***** Sort******");
            liste.Sort();

            foreach (var item in liste)
                Console.WriteLine(item);

            // Binary Search
            Console.WriteLine("***** Binary Search******");
            Console.WriteLine(liste.BinarySearch(9));

            //Reverse (Büyükten Küçüğe Sıralama)
            Console.WriteLine("***** Reverse ******");
            liste.Reverse();

            foreach (var item in liste)
                Console.WriteLine(item);

            //Clear(Liste Temizleme)
            liste.Clear();

            foreach (var item in liste)
                Console.WriteLine(item);




        }
    }
}