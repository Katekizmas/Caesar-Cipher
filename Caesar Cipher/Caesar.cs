using System;

namespace Caesar_Cipher
{
    public class Caesar
    {
        static void Main(string[] args)
        {
            int poslinkis = 13; // Per kiek raidžių yra paslinkta raidė
            Console.WriteLine("Caesar Cipher");
            Console.Write("Įveskite šifruojamą tekstą: ");
            string tekstas = Console.ReadLine();
            if (tekstas.Length > 0)
            {
                poslinkis = poslinkis % 26; // jeigu skaicius didelis tai paimama liekana visada bus tarp 1-26
                string uzsifruotas = Sifravimas(tekstas, poslinkis, false);
                Console.WriteLine("Užšifruotas tekstas: {0}", uzsifruotas);

                Console.WriteLine("Atšifruotas tekstas: {0}", Sifravimas(uzsifruotas, poslinkis, true));
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Neįvestas tekstas!");
            }

        }

        public static string Sifravimas(string tekstas, int poslinkis, bool atsifruoti)
        {
            if (atsifruoti)
                poslinkis = 26 - poslinkis;

            string rezultatas = "";

            for (int i = 0; i < tekstas.Length; i++)
            {
                if (char.IsLetter(tekstas[i]))
                {
                    char vietaAtmintyje = char.IsUpper(tekstas[i]) ? 'A' : 'a'; // Gauname nuo kurios vietos prasideda raide
                                                                                //65    97
                    rezultatas += (char)(((tekstas[i] + poslinkis) - vietaAtmintyje) % 26 + vietaAtmintyje);
                }
                else
                    rezultatas += tekstas[i];
            }

            return rezultatas;
        }
    }
}
