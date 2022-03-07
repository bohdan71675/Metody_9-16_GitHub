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
    }
}
