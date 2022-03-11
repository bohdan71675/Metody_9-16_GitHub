using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody_9_16_GitHub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = "Ahoj5 jak0 se mas34";
            int cifSoucet;
            int cifSoucetLich;
            int cifSoucetSud;
            if (Obsahuje.obsahujeCislici(s, out cifSoucet, out cifSoucetLich, out cifSoucetSud))
            {
                MessageBox.Show("Obsahuje číslici\nCif Sou. je: " + cifSoucet + "\nCif. Sou. Lich. je: " + cifSoucetLich + "\nCif. Sou. Sud.: " + cifSoucetSud);
            }
            else MessageBox.Show("Neobsahuje číslo");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = "Ahoj5 jak0 se mas34";
            string novyretezec = "";
            MessageBox.Show("Pocet slov je: " + Obsahuje.PocetSlov(s, out novyretezec) + " Veta bez cislic: " + novyretezec);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string s = "Ahoj jak se mas";
            string nejkratsi = "";
            string nejdelsi = "";
            if (Obsahuje.ObsahujeSlovo(s, out nejkratsi, out nejdelsi))
            {
                MessageBox.Show("Obsahuje alespon jedno slovo\nNejkratsi je: " + nejkratsi + "\nNejdelsi je: " + nejdelsi);
            }
            else MessageBox.Show("Zadne slovo");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string s = "Ahoj 6jak se 6mas";
            int malych = 0;
            int velkych = 0;
            int jinych = 0;
            if (Obsahuje.JeAlfanum(s, out malych, out velkych, out jinych))
            {
                MessageBox.Show("Ano, je alfanumericke \nMalych pismen je: " + malych + "\nVelkych pismen je : " + velkych);
            }
            else MessageBox.Show("Ne neni alfanumericke \nMalych pismen je: " + malych + "\nVelkych pismen je : " + velkych + "\nJinych je: " + jinych);
        }
    }
}
