using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje2_dikdörtgen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kisakenar, uzunkenar, alan, cevre;  //degisken tanimlama yapildi
            Console.Write("kisa kenari giriniz: ");  //istenilen ilk degeri ekrana yazdirdim
            kisakenar = Convert.ToInt32(Console.ReadLine()); //kullanicinin girmis oldugu degeri algilattim
            Console.Write("uzun kenari giriniz: "); //istenilen ikinci degeri ekrana yazdirdim
            uzunkenar = Convert.ToInt32(Console.ReadLine()); // kullanicinin girmis olduğu ikinci degeri algilattim
            alan = kisakenar * uzunkenar; //dikdörtgenin alan hesaplamasını girdim
            cevre = (kisakenar + uzunkenar) * 2; //dikdörtgenin cevre hesaplamasini girdim
            Console.WriteLine("dikdörtgenin alanı: " + alan); //hesaplanan alan degerini ekrana yazdirdim
            Console.WriteLine("dikdörtgenin cevresi: " + cevre); //hesaplanan cevre degerini ekrana yazdirdim
            Console.Read(); //siyah ekranın enter yapana kadar ekranda durmsanı sagladim

        }
    }
}
