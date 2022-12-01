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
        Int32 sampletext, pojeni = 0, dobri, loshi, ukupni, mode, tut = 1, sekunde = 0, minuti = 0;
        Boolean ukljucenost = false;

        public Form1()
        {
            InitializeComponent();
            this.AllowTransparency = true;
            //
            //
            mlgPozadina420.Controls.Add(DobarLik1);
            DobarLik1.BackColor = Color.Transparent;
            //
            mlgPozadina420.Controls.Add(DobarLik2);
            DobarLik2.BackColor = Color.Transparent;
            //
            mlgPozadina420.Controls.Add(DobarLik3);
            DobarLik3.BackColor = Color.Transparent;
            //
            //
            mlgPozadina420.Controls.Add(LoshiLik1);
            LoshiLik1.BackColor = Color.Transparent;
            //
            mlgPozadina420.Controls.Add(LoshiLik2);
            LoshiLik2.BackColor = Color.Transparent;
            //
            mlgPozadina420.Controls.Add(LoshiLik3);
            LoshiLik3.BackColor = Color.Transparent;
            //
            mlgPozadina420.Controls.Add(LoshiLik4);
            LoshiLik4.BackColor = Color.Transparent;
            //
            mlgPozadina420.Controls.Add(LoshiLik5);
            LoshiLik5.BackColor = Color.Transparent;
            //
            //
            mlgPozadina420.Controls.Add(pictureBox1);
            pictureBox1.BackColor = Color.Transparent;
            //
            mlgPozadina420.Controls.Add(pictureBox2);
            pictureBox2.BackColor = Color.Transparent;
        }

        private void LoshiLik1_Click(object sender, EventArgs e)
        {
            pojeni = pojeni + 1;
            loshi = loshi + 1;
            ukupni = ukupni + 1;
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
            timer7.Enabled = true;
            LoshiLik1.Enabled = LoshiLik1.Visible = false;
        }

        private void LoshiLik2_Click(object sender, EventArgs e)
        {
            pojeni = pojeni + 1;
            loshi = loshi + 1;
            ukupni = ukupni + 1;
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
            timer7.Enabled = true;
            LoshiLik2.Enabled = LoshiLik2.Visible = false;
        }

        private void LoshiLik3_Click(object sender, EventArgs e)
        {
            pojeni = pojeni + 1;
            loshi = loshi + 1;
            ukupni = ukupni + 1;
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
            timer7.Enabled = true;
            LoshiLik3.Enabled = LoshiLik3.Visible = false;
        }

        private void LoshiLik4_Click(object sender, EventArgs e)
        {
            pojeni = pojeni + 1;
            loshi = loshi + 1;
            ukupni = ukupni + 1;
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
            timer7.Enabled = true;
            LoshiLik4.Enabled = LoshiLik4.Visible = false;
        }

        private void LoshiLik5_Click(object sender, EventArgs e)
        {
            pojeni = pojeni + 1;
            loshi = loshi + 1;
            ukupni = ukupni + 1;
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
            timer7.Enabled = true;
            LoshiLik5.Enabled = LoshiLik5.Visible = false;
        }

        private void DobarLik1_Click(object sender, EventArgs e)
        {
            pojeni = pojeni - 1;
            dobri = dobri + 1;
            ukupni = ukupni + 1;
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
            timer7.Enabled = true;
            DobarLik1.Enabled = DobarLik1.Visible = false;
        }

        private void DobarLik2_Click(object sender, EventArgs e)
        {
            pojeni = pojeni - 1;
            dobri = dobri + 1;
            ukupni = ukupni + 1;
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
            timer7.Enabled = true;
            DobarLik2.Enabled = DobarLik2.Visible = false;
        }

        private void DobarLik3_Click(object sender, EventArgs e)
        {
            pojeni = pojeni - 1;
            dobri = dobri + 1;
            ukupni = ukupni + 1;
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
            timer7.Enabled = true;
            DobarLik3.Enabled = DobarLik3.Visible = false;
        }

        private void mlgPozadina420_Click(object sender, EventArgs e)
        {
            ukupni = ukupni + 1;
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
            timer7.Enabled = true; 
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
            timer7.Enabled = true;
            BeskonacnoButton.Enabled = BeskonacnoButton.Visible = MetciButton.Enabled = MetciButton.Visible = TutorijalButton.Enabled = TutorijalButton.Visible = MinutiButton.Enabled = MinutiButton.Visible = NazadButton.Enabled = NazadButton.Visible = true;
            StartButton.Enabled = StartButton.Visible = HistoryButton.Enabled = HistoryButton.Visible = false;
        }

        private void NazadButton_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
            timer7.Enabled = true;
            BeskonacnoButton.Enabled = BeskonacnoButton.Visible = MetciButton.Enabled = MetciButton.Visible = TutorijalButton.Enabled = TutorijalButton.Visible = MinutiButton.Enabled = MinutiButton.Visible = NazadButton.Enabled = NazadButton.Visible = false;
            StartButton.Enabled = StartButton.Visible = HistoryButton.Enabled = HistoryButton.Visible = true;
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
            timer7.Enabled = true;
            ukljucenost = false;
            spawner1.Enabled = spawner2.Enabled = spawner3.Enabled = despawner1.Enabled = despawner2.Enabled = despawner3.Enabled = timer9.Enabled = false;
            PauseButton.Enabled = PauseButton.Visible = false;
            ResumeButton.Enabled = ResumeButton.Visible = ZavrsiButton.Enabled = ZavrsiButton.Visible = true;
            LoshiLik4.Enabled = LoshiLik5.Enabled = LoshiLik3.Enabled = LoshiLik2.Enabled = LoshiLik1.Enabled = DobarLik1.Enabled = DobarLik3.Enabled = DobarLik2.Enabled = false;
        }

        private void ResumeButton_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
            timer7.Enabled = true;
            ukljucenost = true;
            ResumeButton.Enabled = ResumeButton.Visible = ZavrsiButton.Enabled = ZavrsiButton.Visible = false;
            PauseButton.Enabled = PauseButton.Visible = true;
            spawner1.Enabled = spawner2.Enabled = spawner3.Enabled = despawner1.Enabled = despawner2.Enabled = despawner3.Enabled = timer8.Enabled = timer9.Enabled = true;
            LoshiLik1.Enabled = LoshiLik2.Enabled = LoshiLik3.Enabled = LoshiLik4.Enabled = LoshiLik5.Enabled = DobarLik1.Enabled = DobarLik2.Enabled = DobarLik3.Enabled = true;
        }

        private void ZavrsiButton_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
            timer7.Enabled = true;
            ukljucenost = false;
            LoshiLik4.Enabled = LoshiLik4.Visible = LoshiLik5.Enabled = LoshiLik5.Visible = LoshiLik3.Visible = LoshiLik3.Enabled = LoshiLik2.Visible = LoshiLik2.Enabled = LoshiLik1.Visible = LoshiLik1.Enabled = DobarLik1.Visible = DobarLik1.Enabled = DobarLik3.Visible = DobarLik3.Enabled = DobarLik2.Visible = DobarLik2.Enabled = true;
            StartButton.Enabled = StartButton.Visible = HistoryButton.Enabled = HistoryButton.Visible = true;
            ResumeButton.Visible = ResumeButton.Enabled = ZavrsiButton.Visible = ZavrsiButton.Enabled = false;
            spawner1.Enabled = spawner2.Enabled = spawner3.Enabled = despawner1.Enabled = despawner2.Enabled = despawner3.Enabled = timer9.Enabled = false;
            MessageBox.Show("G A M E  O V E R  B L Y A T");
        }

        private void HistoryButton_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
            timer7.Enabled = true;
            MessageBox.Show("VERZIJA 0:\n-Inicijalna BETA verzija\n-----------------\nVERZIJA 1:\n-Inicijalna dovrsena verzija\n-----------------\nVERZIJA 2:\n-Projekat je nov i zove se drugacije\n-VersiJon Histori dugme\n-Odvojeno brojanje ukupnog broja pogodaka, broja pogodaka dobrih i broja pogodaka loshih\n-Promenjene pozicije likova\n-Dodat TutoriJal\n-Novi ModeOvi\n-Posle kraja igre svi likovi postaju vidljivi\n-Dodati LabelOvi koji sve vreme pokazuju koliko dugo je igrac igrao i broj PoJena\n-U titleU pishe Primitivni DOOM\n-----------------\nREDUX VERZIJA:\n-Razne promene u kodu programa radi citljivosti\n-Uklonjen -5 PoJena mode\n-Uklonjeno dugme za pregled SkorEa\n-Dodat status bar kao zamena za SkorE dugme\n-Novi raspored dugmica\n-Projekat pravljen u Visual Studio Express 2010\n-Sve slike su sada uzete iz FreeDoom-a\n-KONACNO, dodata transparentnost :D\n-Novi raspored protivnika zbog nove pozadine.\n-Dodato ovo upozorenje za TutoriJal mod koji ima bag sa MessageBox-om koji se otvara gomilu puta umesto jedanput :P\n-Igrica ima pravu ikonicu\n-Game over poruka vise ne pokazuje zavrsni SkorE");
        }

        private void BeskonacnoButton_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
            timer7.Enabled = true;
            ukljucenost = true;
            mode = 4;
            timer9.Enabled = timer8.Enabled = true;
            BeskonacnoButton.Enabled = BeskonacnoButton.Visible = MetciButton.Enabled = MetciButton.Visible = TutorijalButton.Enabled = TutorijalButton.Visible = MinutiButton.Enabled = MinutiButton.Visible = NazadButton.Enabled = NazadButton.Visible = false;
            spawner1.Enabled = spawner2.Enabled = spawner3.Enabled = despawner1.Enabled = despawner2.Enabled = despawner3.Enabled = true;
            pojeni = dobri = loshi = ukupni = sekunde = minuti = 0;
            PauseButton.Enabled = PauseButton.Visible = true;
            LoshiLik4.Enabled = LoshiLik4.Visible = LoshiLik5.Enabled = LoshiLik5.Visible = LoshiLik3.Visible = LoshiLik3.Enabled = LoshiLik2.Visible = LoshiLik2.Enabled = LoshiLik1.Visible = LoshiLik1.Enabled = DobarLik1.Visible = DobarLik1.Enabled = DobarLik3.Visible = DobarLik3.Enabled = DobarLik2.Visible = DobarLik2.Enabled = false;
        }

        private void TutorijalButton_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
            timer7.Enabled = true;
            timer9.Enabled = true;
            ukljucenost = true;
            mode = tut = 1;
            StartButton.Enabled = StartButton.Visible = TutorijalButton.Enabled = TutorijalButton.Visible = HistoryButton.Enabled = HistoryButton.Visible = false;
            PauseButton.Enabled = PauseButton.Visible = true;
            pojeni = dobri = loshi = ukupni = 0;
            timer8.Enabled = true;
            DobarLik1.Enabled = DobarLik1.Visible = DobarLik3.Enabled = DobarLik3.Visible = DobarLik2.Enabled = DobarLik2.Visible = false;
            LoshiLik4.Enabled = LoshiLik4.Visible = LoshiLik5.Enabled = LoshiLik5.Visible = LoshiLik3.Enabled = LoshiLik3.Visible = LoshiLik2.Enabled = LoshiLik2.Visible = LoshiLik1.Enabled = LoshiLik1.Visible = true;
            MessageBox.Show("Ovo su loshi likovi. Kada upucate jednog od njih, vas skor se povecava za 1.");
        }

        private void MetciButton_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
            timer7.Enabled = true;
            ukljucenost = true;
            mode = 2;
            timer8.Enabled = timer9.Enabled = true;
            BeskonacnoButton.Enabled = BeskonacnoButton.Visible = MetciButton.Enabled = MetciButton.Visible = TutorijalButton.Enabled = TutorijalButton.Visible = MinutiButton.Enabled = MinutiButton.Visible = NazadButton.Enabled = NazadButton.Visible = false;
            spawner1.Enabled = spawner2.Enabled = spawner3.Enabled = despawner1.Enabled = despawner2.Enabled = despawner3.Enabled = true;
            pojeni = dobri = loshi = ukupni = sekunde = minuti = 0;
            PauseButton.Enabled = PauseButton.Visible = true;
            LoshiLik4.Enabled = LoshiLik4.Visible = LoshiLik5.Enabled = LoshiLik5.Visible = LoshiLik3.Visible = LoshiLik3.Enabled = LoshiLik2.Visible = LoshiLik2.Enabled = LoshiLik1.Visible = LoshiLik1.Enabled = DobarLik1.Visible = DobarLik1.Enabled = DobarLik3.Visible = DobarLik3.Enabled = DobarLik2.Visible = DobarLik2.Enabled = false;
        }

        private void MinutiButton_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
            timer7.Enabled = true;
            ukljucenost = true;
            mode = 3;
            timer8.Enabled = timer9.Enabled = true;
            BeskonacnoButton.Enabled = BeskonacnoButton.Visible = MetciButton.Enabled = MetciButton.Visible = TutorijalButton.Enabled = TutorijalButton.Visible = MinutiButton.Enabled = MinutiButton.Visible = NazadButton.Enabled = NazadButton.Visible = false;
            spawner1.Enabled = spawner2.Enabled = spawner3.Enabled = despawner1.Enabled = despawner2.Enabled = despawner3.Enabled = true;
            pojeni = dobri = loshi = ukupni = sekunde = minuti = 0;
            PauseButton.Enabled = PauseButton.Visible = true;
            LoshiLik4.Enabled = LoshiLik4.Visible = LoshiLik5.Enabled = LoshiLik5.Visible = LoshiLik3.Visible = LoshiLik3.Enabled = LoshiLik2.Visible = LoshiLik2.Enabled = LoshiLik1.Visible = LoshiLik1.Enabled = DobarLik1.Visible = DobarLik1.Enabled = DobarLik3.Visible = DobarLik3.Enabled = DobarLik2.Visible = DobarLik2.Enabled = false;
        }

        private void SpawnerTimer_Tick(object sender, EventArgs e)
        {
            sampletext = spawn.Next(1, 9);
            switch (sampletext)
            {
                case 1: LoshiLik4.Visible = LoshiLik4.Enabled = true; break;
                case 2: LoshiLik5.Visible = LoshiLik5.Enabled = true; break;
                case 3: LoshiLik3.Visible = LoshiLik3.Enabled = true; break;
                case 4: LoshiLik2.Visible = LoshiLik2.Enabled = true; break;
                case 5: LoshiLik1.Visible = LoshiLik1.Enabled = true; break;
                case 6: DobarLik1.Visible = DobarLik1.Enabled = true; break;
                case 7: DobarLik3.Visible = DobarLik3.Enabled = true; break;
                case 8: DobarLik2.Visible = DobarLik2.Enabled = true; break;
                case 9: break;
                default: break;
            }
        }

        private void DespawnerTimer_Tick(object sender, EventArgs e)
        {
            sampletext = spawn.Next(1, 9);
            switch (sampletext)
            {
                case 1: LoshiLik4.Visible = LoshiLik4.Enabled = false; break;
                case 2: LoshiLik5.Visible = LoshiLik5.Enabled = false; break;
                case 3: LoshiLik3.Visible = LoshiLik3.Enabled = false; break;
                case 4: LoshiLik2.Visible = LoshiLik2.Enabled = false; break;
                case 5: LoshiLik1.Visible = LoshiLik1.Enabled = false; break;
                case 6: DobarLik1.Visible = DobarLik1.Enabled = false; break;
                case 7: DobarLik3.Visible = DobarLik3.Enabled = false; break;
                case 8: DobarLik2.Visible = DobarLik2.Enabled = false; break;
                case 9: break;
                default: break;
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            timer7.Enabled = false;
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            // Mode = 1 => Tutorijal
            // Mode = 2 => 100 Metaka
            // Mode = 3 => 10 Minuta
            // Mode = 4 => Beskonacno
            if (ukljucenost == true)
            {
                SkoreLabel.Text = pojeni.ToString();
                MetciLabel.Text = ukupni.ToString();
                LoshiLabel.Text = loshi.ToString();
                DobriLabel.Text = dobri.ToString();
            }
            // TUTORIJAL MOD
            if (mode == 1)
            {
                if (loshi == 5)
                {
                    if (tut == 1)
                    {
                        MessageBox.Show("A ovo su dobri likovi. Kada upucate dobrog lika, vas skor se smanjuje za 1.");
                        DobarLik1.Visible = DobarLik1.Enabled = DobarLik3.Visible = DobarLik3.Enabled = DobarLik2.Visible = DobarLik2.Enabled = true;
                    }
                    tut = 2;
                }
                if (dobri == 3)
                {
                    if (tut == 2)
                    {
                        PauseButton.PerformClick();
                        ZavrsiButton.PerformClick();
                        MessageBox.Show("Igrica ima pet moda:\nTutoriJal mod ste upravo odigrali\nBeskonacni mod traje sve dok igrac ne zavrsi igru\n100 Metaka mod traje sve dog igrac ne potrosi 100 metaka.\n-5 PoJena mod traje sve dog igrac ne dodje do -5 PoJena.\n10 Minuta mod traje dok 10 minuta ne prodje\n...i to je to!");
                    }
                    tut = 3;
                }
            }

            // 100 METAKA MOD
            if (mode == 2)
            {
                if (ukupni == 100)
                {
                    PauseButton.PerformClick();
                    ZavrsiButton.PerformClick();
                }
            }

            // 10 MINUTA MOD

            if (mode == 3)
            {
                if (minuti == 10)
                {
                    PauseButton.PerformClick();
                    ZavrsiButton.PerformClick();
                }
            }

            // BESKONACNO MOD (NISTA XDD)
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
                VremeLabel.Text = minuti.ToString() + ":0" + sekunde.ToString();
            }
            else
            {
                VremeLabel.Text = minuti.ToString() + ":" + sekunde.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}