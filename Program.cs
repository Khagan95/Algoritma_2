using System;

namespace KarakterCikarmaUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("String ifade ve index (örn: Algoritma,3): ");
            string input = Console.ReadLine();

            string[] parts = input.Split(',');
            if (parts.Length == 2)
            {
                string ifade = parts[0].Trim();
                int index = Convert.ToInt32(parts[1].Trim());

                KarakterCikarici karakterCikarici = new KarakterCikarici();
                string sonuc = karakterCikarici.KarakterCikar(ifade, index);

                Console.WriteLine("Sonuç: " + sonuc);
            }
            else
            {
                Console.WriteLine("Geçersiz giriş formatı!");
            }
        }
    }

    class KarakterCikarici
    {
        public string KarakterCikar(string ifade, int index)
        {
            if (index >= 0 && index < ifade.Length)
            {
                return ifade.Remove(index, 1);
            }
            else
            {
                return "Geçersiz index!";
            }
        }
    }
}
