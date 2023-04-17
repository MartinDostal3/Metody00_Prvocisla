using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace String01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool JePrvocislo00(int n)   //Z definice
        {
            //Spočteme všechny dělitele čísla a pokud má přesně dva dělitele, jedná se o prvočíslo
            int pocetDelitelu = 0;
            for (int delitel = 1; delitel <= n; delitel++)
            {
                if (n % delitel == 0) pocetDelitelu++;
            }
            return pocetDelitelu == 2;
            
        }

        private bool JePrvocislo01(int n)
        {
            //1. optimalizace
            //Zredukujeme počet zkoušených dělitelů
            //Budeme zkoušet dělitele od 2 do poloviny n, pokud nenajdeme dělitele jedná se o prvočíslo
            //Zdůvodnění:
            //Žádné číslo nemá většího VLASTNÍHO dělitele než je jeho polovina

            
            bool prvocislo = true;
            if (n == 1) prvocislo = false;
            for (int delitel = 2; delitel <= n / 2; ++delitel)
            {
                if (n % delitel == 0) prvocislo = false;
            }

            return prvocislo;
            
        }

        private bool JePrvocislo02(int n)
        {
            //2. optimalizace
            //Ještě více zredukujeme počet dělitelů
            //Budeme zkoušet dělitele od 2 do odmocniny z n, pokud nenajdeme dělitele jedná se o prvočíslo
            //Zdůvodnění:
            //Pokud má číslo n VLASTNÍHO dělitele většího než je jeho odmocnina, pak k němu existuje i dělitel menší než odmocnina tak,
            //že součin těchto dvou dělitelů je číslo n.
            //Ve speciálních případech, kdy číslo n je druhá mocnina nějakého přirozeného čísla je odmocnina největší vlastní dělitel. 


            bool prvocislo = true;
           
            if (n == 1) prvocislo = false;
            for (int delitel = 2; delitel <= Math.Sqrt(n); ++delitel)
            {
                if (n % delitel == 0) prvocislo = false;
            }
            return prvocislo;
        }
        private bool JePrvocislo03(int n)
        {
            //3. optimalizace
            //Použijeme logickou proměnnou pro zkrácení běhu programu
            //Pokud zjistíme, že číslo n není prvočíslo (najdeme dělitele)
            //cyklus skončí
            //Tento  algoritmus se nezkrátí pokud n je prvočíslo

            bool prvocislo = true;
            if (n == 1) prvocislo = false;
            int delitel = 2;
            while (delitel <= Math.Sqrt(n) && prvocislo)
            {
                if (n % delitel == 0) prvocislo = false;
                ++delitel;
            }
            return prvocislo;
        }
        private bool JePrvocislo04(int n)
        {
            //4. optimalizace
            //Zkoušíme jen lichhé dělitele - sudá čísla nejsou prvočísla s výjimkou č. 2
            //Dvojku a sudá čísla ošetříme zvlášť

            bool prvocislo = true;

            if (n == 1 ) prvocislo = false;
            if (n % 2 == 0 && n != 2) prvocislo = false;
           
            for (int delitel = 3; delitel <= Math.Sqrt(n) && prvocislo; delitel += 2)
            {
                if (n % delitel == 0) prvocislo = false;
            }
            return prvocislo;
        }

            private void button1_Click(object sender, EventArgs e)
        {
            //DEFINICE: 
            //Prvočíslo je přirozené číslo >1 dělitelné pouze 1 a sebou sama a není dělitelné žádným dalším přirozeným číslem
            //Nejmenší prvočíslo je 2 a je to jediné sudé prvočíslo
            //JePrvocislo00
            int cislo = int.Parse(textBox1.Text);



        }

        private void button2_Click(object sender, EventArgs e)
        {
            ////JePrvocislo01
            int cislo = int.Parse(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //JePrvocislo02
            int cislo = int.Parse(textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //JePrvocislo03
            int cislo = int.Parse(textBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //JePrvocislo04
            int cislo = int.Parse(textBox1.Text);
            
        }
    }
}
