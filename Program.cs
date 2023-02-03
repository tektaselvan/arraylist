using System;
using System.Collections;
using System.Collections.Generic;

namespace arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collections namespace
            ArrayList liste = new ArrayList();
            liste.Add("Elvan");
            liste.Add(2);
            liste.Add('A');
            liste.Add(true);

            //verilere ulaşma
            Console.WriteLine(liste[1]);

            foreach (var item in liste)
                Console.WriteLine(item);

            //AddRange
            Console.WriteLine("***** Add Range *****");
            // string[] renkler = { "Mavi", "Yeşil", "Kırmızı", "Siyah" };
            List<int> sayilar = new List<int>() { 1, 8, 9, 65, 52, 3, 7 };
            // liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach (var item in liste)
                Console.WriteLine(item);

            //Sort
            Console.WriteLine("***** Sort *****");
            liste.Sort();

            foreach (var item in liste)
                Console.WriteLine(item);


            //Binary Search
            Console.WriteLine("***** Binary Search *****");
            liste.BinarySearch(9);

            //Reverse
            Console.WriteLine("***** Reverse *****");
            liste.Reverse();


            foreach (var item in liste)
                Console.WriteLine(item);

            //Clear
            Console.WriteLine("***** Clear *****");
            liste.Clear();


            foreach (var item in liste)
                Console.WriteLine(item);
        }
    }
}
