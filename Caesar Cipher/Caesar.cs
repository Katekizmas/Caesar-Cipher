using System;

namespace Caesar_Cipher
{
    class Caesar
    {
        static void Main(string[] args)
        {
            int poslinkis = 4; // Per kiek raidžių yra paslinkta raidė
            Console.WriteLine("Caesar Cipher");
            Console.Write("Įveskite šifruojamą tekstą: ");
            string tekstas = Console.ReadLine();
            if (tekstas.Length > 0)
            {
                string uzsifruotas = Uzsifruoti(tekstas, poslinkis);
                Console.WriteLine("Užšifruotas tekstas: {0}", uzsifruotas);

                Console.WriteLine("Atšifruotas tekstas: {0}", Atsifruoti(uzsifruotas, poslinkis));
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Neįvestas tekstas!");
            }

        }

        public static string Uzsifruoti(string tekstas, int poslinkis)
        {
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

        public static string Atsifruoti(string tekstas, int poslinkis)
        {
            string rezultatas = "";

            for (int i = 0; i < tekstas.Length; i++)
            {
                if (char.IsLetter(tekstas[i]))
                {
                    char vietaAtmintyje = char.IsUpper(tekstas[i]) ? 'A' : 'a'; // Gauname nuo kurios vietos prasideda raide
                                                                                //65    97
                    rezultatas += (char)(((tekstas[i] - poslinkis) - vietaAtmintyje) % 26 + vietaAtmintyje);
                }
                else
                    rezultatas += tekstas[i];
            }

            return rezultatas;
        }
    }
}
