using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Primitivni_Doom___Treci_put_pravim_novi_projekat____
{
    public partial class Form1 : Form
    {
        Random spawn = new Random();
        Int32 sampletext, pojeni = 0, dobri, loshi, tut = 1, ukupni, mode, sekunde = 0, minuti = 0;
        Boolean ukljucenost = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void teror5_Click(object sender, EventArgs e)
        {
            pojeni = pojeni + 1;
            loshi = loshi + 1;
            ukupni = ukupni + 1;
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            timer7.Enabled = true;
            teror5.Enabled = teror5.Visible = false;
        }

        private void teror4_Click(object sender, EventArgs e)
        {
            pojeni = pojeni + 1;
            loshi = loshi + 1;
            ukupni = ukupni + 1;
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            timer7.Enabled = true;
            teror4.Enabled = teror4.Visible = false;
        }

        private void teror3_Click(object sender, EventArgs e)
        {
            pojeni = pojeni + 1;
            loshi = loshi + 1;
            ukupni = ukupni + 1;
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            timer7.Enabled = true;
            teror3.Enabled = teror3.Visible = false;
        }

        private void dobar2_Click(object sender, EventArgs e)
        {
            pojeni = pojeni - 1;
            dobri = dobri + 1;
            ukupni = ukupni + 1;
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            timer7.Enabled = true;
            dobar2.Enabled = dobar2.Visible = false;
        }

        private void teror2_Click(object sender, EventArgs e)
        {
            pojeni = pojeni + 1;
            loshi = loshi + 1;
            ukupni = ukupni + 1;
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            timer7.Enabled = true;
            teror2.Enabled = teror2.Visible = false;
        }

        private void dobar3_Click(object sender, EventArgs e)
        {
            pojeni = pojeni - 1;
            dobri = dobri + 1;
            ukupni = ukupni + 1;
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            timer7.Enabled = true;
            dobar3.Enabled = dobar3.Visible = false;
        }

        private void teror1_Click(object sender, EventArgs e)
        {
            pojeni = pojeni + 1;
            loshi = loshi + 1;
            ukupni = ukupni + 1;
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            timer7.Enabled = true;
            teror1.Enabled = teror1.Visible = false;
        }

        private void dobar1_Click(object sender, EventArgs e)
        {
            pojeni = pojeni - 1;
            dobri = dobri + 1;
            ukupni = ukupni + 1;
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            timer7.Enabled = true;
            dobar1.Enabled = dobar1.Visible = false;
        }

        private void mlgPozadina420_Click(object sender, EventArgs e)
        {
            ukupni = ukupni + 1;
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
            timer7.Enabled = true; 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Version history dugme
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            timer7.Enabled = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            timer7.Enabled = true;
            MessageBox.Show("VERZIJA 0:\n-Inicijalna BETA verzija\n-----------------\nVERZIJA 1:\n-Inicijalna dovrsena verzija\n-----------------\nVERZIJA 2:\n-Projekat je nov i zove se drugacije\n-VersiJon Histori dugme\n-Odvojeno brojanje ukupnog broja pogodaka, broja pogodaka dobrih i broja pogodaka loshih\n-Promenjene pozicije likova\n-Dodat TutoriJal\n-Novi ModeOvi\n-Posle kraja igre svi likovi postaju vidljivi\n-Dodati LabelOvi koji sve vreme pokazuju koliko dugo je igrac igrao i broj PoJena\n-U titleU pishe Primitivni DOOM");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Resume dugme
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            timer7.Enabled = true;
            ukljucenost = true;
            button3.Enabled = button3.Visible = button4.Enabled = button4.Visible = button5.Enabled = button5.Visible = false;
            button2.Enabled = button2.Visible = true;
            timer1.Enabled = timer2.Enabled = timer3.Enabled = timer4.Enabled = timer5.Enabled = timer6.Enabled = timer8.Enabled = timer9.Enabled = true;
            teror1.Enabled = teror2.Enabled = teror3.Enabled = teror4.Enabled = teror5.Enabled = dobar1.Enabled = dobar2.Enabled = dobar3.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Dugme za pauzu
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            timer7.Enabled = true;
            ukljucenost = false;
            timer1.Enabled = timer2.Enabled = timer3.Enabled = timer4.Enabled = timer5.Enabled = timer6.Enabled = timer9.Enabled = false;
            button2.Enabled = button2.Visible = false;
            button3.Enabled = button3.Visible = button4.Enabled = button4.Visible = button5.Enabled = button5.Visible = true;
            teror1.Enabled = teror2.Enabled = teror3.Enabled = teror4.Enabled = teror5.Enabled = dobar1.Enabled = dobar2.Enabled = dobar3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Zavrsi igru dugme
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            timer7.Enabled = true;
            ukljucenost = false;
            teror1.Enabled = teror1.Visible = teror2.Enabled = teror2.Visible = teror3.Visible = teror3.Enabled = teror4.Visible = teror4.Enabled = teror5.Visible = teror5.Enabled = dobar1.Visible = dobar1.Enabled = dobar2.Visible = dobar2.Enabled = dobar3.Visible = dobar3.Enabled = true;
            button1.Enabled = button1.Visible = button6.Enabled = button6.Visible = button7.Enabled = button7.Visible = true;
            button3.Visible = button3.Enabled = button4.Visible = button4.Enabled = button5.Visible = button5.Enabled = false;
            timer1.Enabled = timer2.Enabled = timer3.Enabled = timer4.Enabled = timer5.Enabled = timer6.Enabled = timer9.Enabled = false;
            MessageBox.Show("Game over :( \nRezultat: " + pojeni.ToString() + "\nUkupan broj potrosenih metaka vam je: " + ukupni.ToString() + "\nBroj dobrih koje ste pogodili: " + dobri.ToString() + "\nBroj loshih koje ste pogodili: " + loshi.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Start dugme
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            timer7.Enabled = true;
            button8.Enabled = button8.Visible = button9.Enabled = button9.Visible = button10.Enabled = button10.Visible = button11.Enabled = button11.Visible = button12.Enabled = button12.Visible = true;
            button1.Enabled = button1.Visible = button7.Enabled = button7.Visible = button6.Enabled = button6.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Pogledaj PoJene
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            timer7.Enabled = true;
            MessageBox.Show("Vas trenutni broj poJena je: " + pojeni.ToString() + "\nUkupan broj potrosenih metaka vam je: " + ukupni.ToString() + "\nBroj dobrih koje ste pogodili: " + dobri.ToString() + "\nBroj loshih koje ste pogodili: " + loshi.ToString());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sampletext = spawn.Next(1, 9);
            switch (sampletext)
            {
                case 1: teror1.Visible = teror1.Enabled = true; break;
                case 2: teror2.Visible = teror2.Enabled = true; break;
                case 3: teror3.Visible = teror3.Enabled = true; break;
                case 4: teror4.Visible = teror4.Enabled = true; break;
                case 5: teror5.Visible = teror5.Enabled = true; break;
                case 6: dobar1.Visible = dobar1.Enabled = true; break;
                case 7: dobar2.Visible = dobar2.Enabled = true; break;
                case 8: dobar3.Visible = dobar3.Enabled = true; break;
                case 9: break;
                default: break;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            sampletext = spawn.Next(1, 9);
            switch (sampletext)
            {
                case 1: teror1.Visible = teror1.Enabled = true; break;
                case 2: teror2.Visible = teror2.Enabled = true; break;
                case 3: teror3.Visible = teror3.Enabled = true; break;
                case 4: teror4.Visible = teror4.Enabled = true; break;
                case 5: teror5.Visible = teror5.Enabled = true; break;
                case 6: dobar1.Visible = dobar1.Enabled = true; break;
                case 7: dobar2.Visible = dobar2.Enabled = true; break;
                case 8: dobar3.Visible = dobar3.Enabled = true; break;
                case 9: break;
                default: break;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            sampletext = spawn.Next(1, 9);
            switch (sampletext)
            {
                case 1: teror1.Visible = teror1.Enabled = true; break;
                case 2: teror2.Visible = teror2.Enabled = true; break;
                case 3: teror3.Visible = teror3.Enabled = true; break;
                case 4: teror4.Visible = teror4.Enabled = true; break;
                case 5: teror5.Visible = teror5.Enabled = true; break;
                case 6: dobar1.Visible = dobar1.Enabled = true; break;
                case 7: dobar2.Visible = dobar2.Enabled = true; break;
                case 8: dobar3.Visible = dobar3.Enabled = true; break;
                case 9: break;
                default: break;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            sampletext = spawn.Next(1, 9);
            switch (sampletext)
            {
                case 1: teror1.Visible = teror1.Enabled = false; break;
                case 2: teror2.Visible = teror2.Enabled = false; break;
                case 3: teror3.Visible = teror3.Enabled = false; break;
                case 4: teror4.Visible = teror4.Enabled = false; break;
                case 5: teror5.Visible = teror5.Enabled = false; break;
                case 6: dobar1.Visible = dobar1.Enabled = false; break;
                case 7: dobar2.Visible = dobar2.Enabled = false; break;
                case 8: dobar3.Visible = dobar3.Enabled = false; break;
                case 9: break;
                default: break;
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            sampletext = spawn.Next(1, 9);
            switch (sampletext)
            {
                case 1: teror1.Visible = teror1.Enabled = false; break;
                case 2: teror2.Visible = teror2.Enabled = false; break;
                case 3: teror3.Visible = teror3.Enabled = false; break;
                case 4: teror4.Visible = teror4.Enabled = false; break;
                case 5: teror5.Visible = teror5.Enabled = false; break;
                case 6: dobar1.Visible = dobar1.Enabled = false; break;
                case 7: dobar2.Visible = dobar2.Enabled = false; break;
                case 8: dobar3.Visible = dobar3.Enabled = false; break;
                case 9: break;
                default: break;
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            sampletext = spawn.Next(1, 9);
            switch (sampletext)
            {
                case 1: teror1.Visible = teror1.Enabled = false; break;
                case 2: teror2.Visible = teror2.Enabled = false; break;
                case 3: teror3.Visible = teror3.Enabled = false; break;
                case 4: teror4.Visible = teror4.Enabled = false; break;
                case 5: teror5.Visible = teror5.Enabled = false; break;
                case 6: dobar1.Visible = dobar1.Enabled = false; break;
                case 7: dobar2.Visible = dobar2.Enabled = false; break;
                case 8: dobar3.Visible = dobar3.Enabled = false; break;
                case 9: break;
                default: break;
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;
            timer7.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Tutorial dugme
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            timer7.Enabled = true;
            timer9.Enabled = true;
            ukljucenost = true;
            mode = tut = 1;
            timer10.Enabled = true;
            button1.Enabled = button1.Visible = button7.Enabled = button7.Visible = button6.Enabled = button6.Visible = false;
            button2.Enabled = button2.Visible = true;
            pojeni = dobri = loshi = ukupni = 0;
            timer8.Enabled = true;
            dobar1.Enabled = dobar1.Visible = dobar2.Enabled = dobar2.Visible = dobar3.Enabled = dobar3.Visible = false;
            teror1.Enabled = teror1.Visible = teror2.Enabled = teror2.Visible = teror3.Enabled = teror3.Visible = teror4.Enabled = teror4.Visible = teror5.Enabled = teror5.Visible = true;
            MessageBox.Show("Ovo su loshi likovi. Kada upucate jednog od njih, vas skor se povecava za 1.");
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            // Mode = 1 => Tutorijal
            // Mode = 2 => Beskonacno
            // Mode = 3 => 100 Metaka
            // Mode = 4 => Do -5 pojena
            // Mode = 5 => 10 Minuta
            if (ukljucenost == true)
            {
                label2.Text = "SkorE: " + pojeni.ToString();
            }
            // TUTORIJAL MOD

            if (mode == 1)
            {
                if (loshi == 5 && tut == 1)
                {
                    timer10.Enabled = true;
                    tut = 2;
                }
                if (dobri == 3 && tut == 2)
                {
                    timer11.Enabled = true;
                    tut = 3;
                }
            }

            // BESKONACNI MOD (nista xddddd)

            // 100 METAKA MOD
            if (mode == 3)
            {
                if (ukupni == 100)
                {
                    button2.PerformClick();
                    button4.PerformClick();
                }
            }

            // -5 POJENA MOD

            if (mode == 4)
            {
                if (pojeni == -5)
                {
                    button2.PerformClick();
                    button4.PerformClick();
                }
            }

            // 10 MINUTA MOD

            if (mode == 5)
            {
                if (minuti == 10)
                {
                    button2.PerformClick();
                    button4.PerformClick();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Beskonacni mode
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            timer7.Enabled = true;
            ukljucenost = true;
            mode = 1;
            timer9.Enabled = timer8.Enabled = true;
            button8.Enabled = button8.Visible = button9.Enabled = button9.Visible = button10.Enabled = button10.Visible = button11.Enabled = button11.Visible = button12.Enabled = button12.Visible = false;
            timer1.Enabled = timer2.Enabled = timer3.Enabled = timer4.Enabled = timer5.Enabled = timer6.Enabled = true;
            pojeni = dobri = loshi = ukupni = sekunde = minuti = 0;
            button2.Enabled = button2.Visible = true;
            teror1.Enabled = teror1.Visible = teror2.Enabled = teror2.Visible = teror3.Visible = teror3.Enabled = teror4.Visible = teror4.Enabled = teror5.Visible = teror5.Enabled = dobar1.Visible = dobar1.Enabled = dobar2.Visible = dobar2.Enabled = dobar3.Visible = dobar3.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // 100 Metaka mode
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            timer7.Enabled = true;
            ukljucenost = true;
            mode = 3;
            timer8.Enabled = timer9.Enabled = true;
            button8.Enabled = button8.Visible = button9.Enabled = button9.Visible = button10.Enabled = button10.Visible = button11.Enabled = button11.Visible = button12.Enabled = button12.Visible = false;
            timer1.Enabled = timer2.Enabled = timer3.Enabled = timer4.Enabled = timer5.Enabled = timer6.Enabled = true;
            pojeni = dobri = loshi = ukupni = sekunde = minuti = 0;
            button2.Enabled = button2.Visible = true;
            teror1.Enabled = teror1.Visible = teror2.Enabled = teror2.Visible = teror3.Visible = teror3.Enabled = teror4.Visible = teror4.Enabled = teror5.Visible = teror5.Enabled = dobar1.Visible = dobar1.Enabled = dobar2.Visible = dobar2.Enabled = dobar3.Visible = dobar3.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // -5 PoJena mod
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            timer7.Enabled = true;
            ukljucenost = true;
            mode = 4;
            timer8.Enabled = timer9.Enabled = true;
            button8.Enabled = button8.Visible = button9.Enabled = button9.Visible = button10.Enabled = button10.Visible = button11.Enabled = button11.Visible = button12.Enabled = button12.Visible = false;
            timer1.Enabled = timer2.Enabled = timer3.Enabled = timer4.Enabled = timer5.Enabled = timer6.Enabled = true;
            pojeni = dobri = loshi = ukupni = sekunde = minuti = 0;
            button2.Enabled = button2.Visible = true;
            teror1.Enabled = teror1.Visible = teror2.Enabled = teror2.Visible = teror3.Visible = teror3.Enabled = teror4.Visible = teror4.Enabled = teror5.Visible = teror5.Enabled = dobar1.Visible = dobar1.Enabled = dobar2.Visible = dobar2.Enabled = dobar3.Visible = dobar3.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // 10 Minuta mode
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            timer7.Enabled = true;
            ukljucenost = true;
            mode = 5;
            timer8.Enabled = timer9.Enabled = true;
            button8.Enabled = button8.Visible = button9.Enabled = button9.Visible = button10.Enabled = button10.Visible = button11.Enabled = button11.Visible = button12.Enabled = button12.Visible = false;
            timer1.Enabled = timer2.Enabled = timer3.Enabled = timer4.Enabled = timer5.Enabled = timer6.Enabled = true;
            pojeni = dobri = loshi = ukupni = sekunde = minuti = 0;
            button2.Enabled = button2.Visible = true;
            teror1.Enabled = teror1.Visible = teror2.Enabled = teror2.Visible = teror3.Visible = teror3.Enabled = teror4.Visible = teror4.Enabled = teror5.Visible = teror5.Enabled = dobar1.Visible = dobar1.Enabled = dobar2.Visible = dobar2.Enabled = dobar3.Visible = dobar3.Enabled = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // Back dugme (modeovi xdddd)
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            timer7.Enabled = true;
            button8.Enabled = button8.Visible = button9.Enabled = button9.Visible = button10.Enabled = button10.Visible = button11.Enabled = button11.Visible = button12.Enabled = button12.Visible = false;
            button1.Enabled = button1.Visible = button7.Enabled = button7.Visible = button6.Enabled = button6.Visible = true;
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            sekunde = sekunde + 1;
            if (sekunde == 60)
            {
                sekunde = 0;
                minuti = minuti + 1;
            }
            if (sekunde < 10)
            {
                label1.Text = "Vreme: " + minuti.ToString() + ":0" + sekunde.ToString();
            }
            else
            {
                label1.Text = "Vreme: " + minuti.ToString() + ":" + sekunde.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            //Tutorijal - prelazak iz dela o loshim u deo o dobrim
            MessageBox.Show("A ovo su dobri likovi. Kada upucate dobrog lika, vas skor se smanjuje za 1.");
            dobar1.Visible = dobar1.Enabled = dobar2.Visible = dobar2.Enabled = dobar3.Visible = dobar3.Enabled = true;
            timer10.Enabled = false;
        }

        private void timer11_Tick(object sender, EventArgs e)
        {
            //Tutorijal - kraj
            button2.PerformClick();
            button4.PerformClick();
            MessageBox.Show("Igrica ima pet moda:\nTutoriJal mod ste upravo odigrali\nBeskonacni mod traje sve dok igrac ne zavrsi igru\n100 Metaka mod traje sve dog igrac ne potrosi 100 metaka.\n-5 PoJena mod traje sve dog igrac ne dodje do -5 PoJena.\n10 Minuta mod traje dok 10 minuta ne prodje\n...i to je to!");
            timer11.Enabled = false;
        }
    }
}