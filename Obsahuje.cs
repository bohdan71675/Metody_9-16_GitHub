using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody_9_16_GitHub
{
    class Obsahuje
    {
        public static bool obsahujeCislici(string retezec, out int cifSoucet, out int cifLich, out int cifSud)
        {
            int cifra;
            cifSoucet = 0;
            cifSud = 0;
            cifLich = 0;
            bool obsahuje = false;
            for (int i = 0; i < retezec.Length; ++i)
            {
                if (char.IsNumber(retezec[i]))
                {
                    obsahuje = true;
                    cifra = int.Parse(retezec[i].ToString());
                    cifSoucet += cifra;
                    if (cifra % 2 == 0) cifSud += cifra;
                    else cifLich += cifra;
                }
            }
            return obsahuje;
        }

        public static int PocetSlov(string s, out string novyretezec)
        {
            while (s.Contains("  "))
            {
                s = s.Replace("  ", " ");
            }
            s = s.Trim();
            novyretezec = s;
            int pocet = 0;
            char[] separator = { ' ' };
            string[] subs = s.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            pocet = subs.Length;

            int i = 0;
            while (i < s.Length)
            {
                if (Char.IsNumber(s[i]))
                {
                    s = s.Remove(i, 1);

                }
                else ++i;
            }
            novyretezec = s;
            return pocet;
        }

        public static bool ObsahujeSlovo(string s, out string nejkratsi, out string nejdelsi)
        {
            bool obsahuje1 = false;
            nejkratsi = "";
            nejdelsi = "";
            if (s.Length > 0 && s != "")
            {
                obsahuje1 = true;
                while (s.Contains("  "))
                {
                    s = s.Replace("  ", " ");
                }
                s = s.Trim();
                char[] separator = { ' ' };
                string[] subs = s.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                nejkratsi = subs[0];
                nejdelsi = subs[0];

                for (int i = 0; i < subs.Length; i++)
                {
                    string slovo = subs[i];
                    if (slovo.Length < nejkratsi.Length) nejkratsi = slovo;
                    if (slovo.Length > nejdelsi.Length) nejdelsi = slovo;
                }
            }
            return obsahuje1;
        }
    }
}
