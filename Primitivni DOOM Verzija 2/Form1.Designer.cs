namespace Primitivni_Doom___Treci_put_pravim_novi_projekat____
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.spawner1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HistoryButton = new System.Windows.Forms.Button();
            this.despawner1 = new System.Windows.Forms.Timer(this.components);
            this.PauseButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.ZavrsiButton = new System.Windows.Forms.Button();
            this.ResumeButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.DobarLik2 = new System.Windows.Forms.PictureBox();
            this.DobarLik3 = new System.Windows.Forms.PictureBox();
            this.spawner3 = new System.Windows.Forms.Timer(this.components);
            this.DobarLik1 = new System.Windows.Forms.PictureBox();
            this.spawner2 = new System.Windows.Forms.Timer(this.components);
            this.despawner3 = new System.Windows.Forms.Timer(this.components);
            this.timer7 = new System.Windows.Forms.Timer(this.components);
            this.LoshiLik3 = new System.Windows.Forms.PictureBox();
            this.LoshiLik2 = new System.Windows.Forms.PictureBox();
            this.LoshiLik1 = new System.Windows.Forms.PictureBox();
            this.despawner2 = new System.Windows.Forms.Timer(this.components);
            this.LoshiLik5 = new System.Windows.Forms.PictureBox();
            this.LoshiLik4 = new System.Windows.Forms.PictureBox();
            this.mlgPozadina420 = new System.Windows.Forms.PictureBox();
            this.timer8 = new System.Windows.Forms.Timer(this.components);
            this.BeskonacnoButton = new System.Windows.Forms.Button();
            this.MetciButton = new System.Windows.Forms.Button();
            this.MinutiButton = new System.Windows.Forms.Button();
            this.NazadButton = new System.Windows.Forms.Button();
            this.VremeLabel = new System.Windows.Forms.Label();
            this.timer9 = new System.Windows.Forms.Timer(this.components);
            this.SkoreLabel = new System.Windows.Forms.Label();
            this.TutorijalButton = new System.Windows.Forms.Button();
            this.StatusBar = new System.Windows.Forms.PictureBox();
            this.LoshiLabel = new System.Windows.Forms.Label();
            this.MetciLabel = new System.Windows.Forms.Label();
            this.DobriLabel = new System.Windows.Forms.Label();
            this.PojeniButton = new System.Windows.Forms.Button();
            this.PerfekcionizamButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DobarLik2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DobarLik3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DobarLik1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoshiLik3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoshiLik2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoshiLik1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoshiLik5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoshiLik4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mlgPozadina420)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBar)).BeginInit();
            this.SuspendLayout();
            // 
            // spawner1
            // 
            this.spawner1.Interval = 3000;
            this.spawner1.Tick += new System.EventHandler(this.SpawnerTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(362, 355);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.mlgPozadina420_Click);
            // 
            // HistoryButton
            // 
            this.HistoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryButton.Location = new System.Drawing.Point(378, 94);
            this.HistoryButton.Name = "HistoryButton";
            this.HistoryButton.Size = new System.Drawing.Size(120, 67);
            this.HistoryButton.TabIndex = 43;
            this.HistoryButton.Text = "VersiJon Histori ";
            this.HistoryButton.UseVisualStyleBackColor = true;
            this.HistoryButton.Click += new System.EventHandler(this.HistoryButton_Click);
            // 
            // despawner1
            // 
            this.despawner1.Interval = 2500;
            this.despawner1.Tick += new System.EventHandler(this.DespawnerTimer_Tick);
            // 
            // PauseButton
            // 
            this.PauseButton.Enabled = false;
            this.PauseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PauseButton.Location = new System.Drawing.Point(378, 21);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(120, 67);
            this.PauseButton.TabIndex = 42;
            this.PauseButton.Text = "PAUSE";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Visible = false;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(378, 21);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(120, 67);
            this.StartButton.TabIndex = 41;
            this.StartButton.Text = "START!";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ZavrsiButton
            // 
            this.ZavrsiButton.Enabled = false;
            this.ZavrsiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZavrsiButton.Location = new System.Drawing.Point(378, 94);
            this.ZavrsiButton.Name = "ZavrsiButton";
            this.ZavrsiButton.Size = new System.Drawing.Size(120, 67);
            this.ZavrsiButton.TabIndex = 39;
            this.ZavrsiButton.Text = "Zavrsi igru";
            this.ZavrsiButton.UseVisualStyleBackColor = true;
            this.ZavrsiButton.Visible = false;
            this.ZavrsiButton.Click += new System.EventHandler(this.ZavrsiButton_Click);
            // 
            // ResumeButton
            // 
            this.ResumeButton.Enabled = false;
            this.ResumeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResumeButton.Location = new System.Drawing.Point(378, 21);
            this.ResumeButton.Name = "ResumeButton";
            this.ResumeButton.Size = new System.Drawing.Size(120, 67);
            this.ResumeButton.TabIndex = 40;
            this.ResumeButton.Text = "RESUME";
            this.ResumeButton.UseVisualStyleBackColor = true;
            this.ResumeButton.Visible = false;
            this.ResumeButton.Click += new System.EventHandler(this.ResumeButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(362, 355);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(171, 177);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.mlgPozadina420_Click);
            // 
            // DobarLik2
            // 
            this.DobarLik2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DobarLik2.Image = ((System.Drawing.Image)(resources.GetObject("DobarLik2.Image")));
            this.DobarLik2.Location = new System.Drawing.Point(455, 235);
            this.DobarLik2.Name = "DobarLik2";
            this.DobarLik2.Size = new System.Drawing.Size(43, 61);
            this.DobarLik2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DobarLik2.TabIndex = 36;
            this.DobarLik2.TabStop = false;
            this.DobarLik2.Click += new System.EventHandler(this.DobarLik2_Click);
            // 
            // DobarLik3
            // 
            this.DobarLik3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DobarLik3.Image = ((System.Drawing.Image)(resources.GetObject("DobarLik3.Image")));
            this.DobarLik3.Location = new System.Drawing.Point(596, 229);
            this.DobarLik3.Name = "DobarLik3";
            this.DobarLik3.Size = new System.Drawing.Size(92, 121);
            this.DobarLik3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DobarLik3.TabIndex = 35;
            this.DobarLik3.TabStop = false;
            this.DobarLik3.Click += new System.EventHandler(this.DobarLik3_Click);
            // 
            // spawner3
            // 
            this.spawner3.Interval = 2500;
            this.spawner3.Tick += new System.EventHandler(this.SpawnerTimer_Tick);
            // 
            // DobarLik1
            // 
            this.DobarLik1.BackColor = System.Drawing.Color.Black;
            this.DobarLik1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DobarLik1.Image = ((System.Drawing.Image)(resources.GetObject("DobarLik1.Image")));
            this.DobarLik1.InitialImage = null;
            this.DobarLik1.Location = new System.Drawing.Point(12, 253);
            this.DobarLik1.Name = "DobarLik1";
            this.DobarLik1.Size = new System.Drawing.Size(85, 119);
            this.DobarLik1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DobarLik1.TabIndex = 34;
            this.DobarLik1.TabStop = false;
            this.DobarLik1.Click += new System.EventHandler(this.DobarLik1_Click);
            // 
            // spawner2
            // 
            this.spawner2.Interval = 2000;
            this.spawner2.Tick += new System.EventHandler(this.SpawnerTimer_Tick);
            // 
            // despawner3
            // 
            this.despawner3.Interval = 3500;
            this.despawner3.Tick += new System.EventHandler(this.DespawnerTimer_Tick);
            // 
            // timer7
            // 
            this.timer7.Tick += new System.EventHandler(this.timer7_Tick);
            // 
            // LoshiLik3
            // 
            this.LoshiLik3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoshiLik3.Image = ((System.Drawing.Image)(resources.GetObject("LoshiLik3.Image")));
            this.LoshiLik3.Location = new System.Drawing.Point(120, 167);
            this.LoshiLik3.Name = "LoshiLik3";
            this.LoshiLik3.Size = new System.Drawing.Size(160, 173);
            this.LoshiLik3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoshiLik3.TabIndex = 31;
            this.LoshiLik3.TabStop = false;
            this.LoshiLik3.Click += new System.EventHandler(this.LoshiLik3_Click);
            // 
            // LoshiLik2
            // 
            this.LoshiLik2.Image = ((System.Drawing.Image)(resources.GetObject("LoshiLik2.Image")));
            this.LoshiLik2.Location = new System.Drawing.Point(716, 41);
            this.LoshiLik2.Name = "LoshiLik2";
            this.LoshiLik2.Size = new System.Drawing.Size(106, 129);
            this.LoshiLik2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoshiLik2.TabIndex = 33;
            this.LoshiLik2.TabStop = false;
            this.LoshiLik2.Click += new System.EventHandler(this.LoshiLik2_Click);
            // 
            // LoshiLik1
            // 
            this.LoshiLik1.Image = ((System.Drawing.Image)(resources.GetObject("LoshiLik1.Image")));
            this.LoshiLik1.Location = new System.Drawing.Point(24, 21);
            this.LoshiLik1.Name = "LoshiLik1";
            this.LoshiLik1.Size = new System.Drawing.Size(105, 121);
            this.LoshiLik1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoshiLik1.TabIndex = 32;
            this.LoshiLik1.TabStop = false;
            this.LoshiLik1.Click += new System.EventHandler(this.LoshiLik1_Click);
            // 
            // despawner2
            // 
            this.despawner2.Interval = 2300;
            this.despawner2.Tick += new System.EventHandler(this.DespawnerTimer_Tick);
            // 
            // LoshiLik5
            // 
            this.LoshiLik5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoshiLik5.Image = ((System.Drawing.Image)(resources.GetObject("LoshiLik5.Image")));
            this.LoshiLik5.Location = new System.Drawing.Point(716, 253);
            this.LoshiLik5.Name = "LoshiLik5";
            this.LoshiLik5.Size = new System.Drawing.Size(92, 140);
            this.LoshiLik5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoshiLik5.TabIndex = 30;
            this.LoshiLik5.TabStop = false;
            this.LoshiLik5.Click += new System.EventHandler(this.LoshiLik5_Click);
            // 
            // LoshiLik4
            // 
            this.LoshiLik4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoshiLik4.Image = ((System.Drawing.Image)(resources.GetObject("LoshiLik4.Image")));
            this.LoshiLik4.Location = new System.Drawing.Point(362, 229);
            this.LoshiLik4.Name = "LoshiLik4";
            this.LoshiLik4.Size = new System.Drawing.Size(71, 94);
            this.LoshiLik4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoshiLik4.TabIndex = 29;
            this.LoshiLik4.TabStop = false;
            this.LoshiLik4.Click += new System.EventHandler(this.LoshiLik4_Click);
            // 
            // mlgPozadina420
            // 
            this.mlgPozadina420.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mlgPozadina420.BackgroundImage")));
            this.mlgPozadina420.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mlgPozadina420.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mlgPozadina420.Location = new System.Drawing.Point(-2, 0);
            this.mlgPozadina420.Name = "mlgPozadina420";
            this.mlgPozadina420.Size = new System.Drawing.Size(860, 532);
            this.mlgPozadina420.TabIndex = 28;
            this.mlgPozadina420.TabStop = false;
            this.mlgPozadina420.Click += new System.EventHandler(this.mlgPozadina420_Click);
            // 
            // timer8
            // 
            this.timer8.Enabled = true;
            this.timer8.Interval = 1;
            this.timer8.Tick += new System.EventHandler(this.timer8_Tick);
            // 
            // BeskonacnoButton
            // 
            this.BeskonacnoButton.Enabled = false;
            this.BeskonacnoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeskonacnoButton.Location = new System.Drawing.Point(378, 94);
            this.BeskonacnoButton.Name = "BeskonacnoButton";
            this.BeskonacnoButton.Size = new System.Drawing.Size(120, 67);
            this.BeskonacnoButton.TabIndex = 43;
            this.BeskonacnoButton.Text = "Beskonacno";
            this.BeskonacnoButton.UseVisualStyleBackColor = true;
            this.BeskonacnoButton.Visible = false;
            this.BeskonacnoButton.Click += new System.EventHandler(this.BeskonacnoButton_Click);
            // 
            // MetciButton
            // 
            this.MetciButton.Enabled = false;
            this.MetciButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetciButton.Location = new System.Drawing.Point(252, 94);
            this.MetciButton.Name = "MetciButton";
            this.MetciButton.Size = new System.Drawing.Size(120, 67);
            this.MetciButton.TabIndex = 43;
            this.MetciButton.Text = "100 Metaka ";
            this.MetciButton.UseVisualStyleBackColor = true;
            this.MetciButton.Visible = false;
            this.MetciButton.Click += new System.EventHandler(this.MetciButton_Click);
            // 
            // MinutiButton
            // 
            this.MinutiButton.Enabled = false;
            this.MinutiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinutiButton.Location = new System.Drawing.Point(252, 167);
            this.MinutiButton.Name = "MinutiButton";
            this.MinutiButton.Size = new System.Drawing.Size(120, 67);
            this.MinutiButton.TabIndex = 43;
            this.MinutiButton.Text = "10 Minuta";
            this.MinutiButton.UseVisualStyleBackColor = true;
            this.MinutiButton.Visible = false;
            this.MinutiButton.Click += new System.EventHandler(this.MinutiButton_Click);
            // 
            // NazadButton
            // 
            this.NazadButton.Enabled = false;
            this.NazadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NazadButton.Location = new System.Drawing.Point(378, 21);
            this.NazadButton.Name = "NazadButton";
            this.NazadButton.Size = new System.Drawing.Size(120, 67);
            this.NazadButton.TabIndex = 42;
            this.NazadButton.Text = "NAZAD";
            this.NazadButton.UseVisualStyleBackColor = true;
            this.NazadButton.Visible = false;
            this.NazadButton.Click += new System.EventHandler(this.NazadButton_Click);
            // 
            // VremeLabel
            // 
            this.VremeLabel.AutoSize = true;
            this.VremeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VremeLabel.Location = new System.Drawing.Point(31, 567);
            this.VremeLabel.Name = "VremeLabel";
            this.VremeLabel.Size = new System.Drawing.Size(98, 37);
            this.VremeLabel.TabIndex = 45;
            this.VremeLabel.Text = "00:00";
            this.VremeLabel.Click += new System.EventHandler(this.mlgPozadina420_Click);
            // 
            // timer9
            // 
            this.timer9.Interval = 1000;
            this.timer9.Tick += new System.EventHandler(this.timer9_Tick);
            // 
            // SkoreLabel
            // 
            this.SkoreLabel.AutoSize = true;
            this.SkoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkoreLabel.Location = new System.Drawing.Point(773, 568);
            this.SkoreLabel.Name = "SkoreLabel";
            this.SkoreLabel.Size = new System.Drawing.Size(35, 37);
            this.SkoreLabel.TabIndex = 45;
            this.SkoreLabel.Text = "0";
            this.SkoreLabel.Click += new System.EventHandler(this.mlgPozadina420_Click);
            // 
            // TutorijalButton
            // 
            this.TutorijalButton.Enabled = false;
            this.TutorijalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TutorijalButton.Location = new System.Drawing.Point(378, 167);
            this.TutorijalButton.Name = "TutorijalButton";
            this.TutorijalButton.Size = new System.Drawing.Size(120, 67);
            this.TutorijalButton.TabIndex = 42;
            this.TutorijalButton.Text = "TutoriJal";
            this.TutorijalButton.UseVisualStyleBackColor = true;
            this.TutorijalButton.Visible = false;
            this.TutorijalButton.Click += new System.EventHandler(this.TutorijalButton_Click);
            // 
            // StatusBar
            // 
            this.StatusBar.Image = ((System.Drawing.Image)(resources.GetObject("StatusBar.Image")));
            this.StatusBar.Location = new System.Drawing.Point(-2, 529);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(860, 132);
            this.StatusBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StatusBar.TabIndex = 46;
            this.StatusBar.TabStop = false;
            this.StatusBar.Click += new System.EventHandler(this.mlgPozadina420_Click);
            // 
            // LoshiLabel
            // 
            this.LoshiLabel.AutoSize = true;
            this.LoshiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoshiLabel.Location = new System.Drawing.Point(245, 567);
            this.LoshiLabel.Name = "LoshiLabel";
            this.LoshiLabel.Size = new System.Drawing.Size(35, 37);
            this.LoshiLabel.TabIndex = 45;
            this.LoshiLabel.Text = "0";
            this.LoshiLabel.Click += new System.EventHandler(this.mlgPozadina420_Click);
            // 
            // MetciLabel
            // 
            this.MetciLabel.AutoSize = true;
            this.MetciLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetciLabel.Location = new System.Drawing.Point(427, 568);
            this.MetciLabel.Name = "MetciLabel";
            this.MetciLabel.Size = new System.Drawing.Size(35, 37);
            this.MetciLabel.TabIndex = 45;
            this.MetciLabel.Text = "0";
            this.MetciLabel.Click += new System.EventHandler(this.mlgPozadina420_Click);
            // 
            // DobriLabel
            // 
            this.DobriLabel.AutoSize = true;
            this.DobriLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DobriLabel.Location = new System.Drawing.Point(589, 568);
            this.DobriLabel.Name = "DobriLabel";
            this.DobriLabel.Size = new System.Drawing.Size(35, 37);
            this.DobriLabel.TabIndex = 45;
            this.DobriLabel.Text = "0";
            this.DobriLabel.Click += new System.EventHandler(this.mlgPozadina420_Click);
            // 
            // PojeniButton
            // 
            this.PojeniButton.Enabled = false;
            this.PojeniButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PojeniButton.Location = new System.Drawing.Point(504, 94);
            this.PojeniButton.Name = "PojeniButton";
            this.PojeniButton.Size = new System.Drawing.Size(120, 67);
            this.PojeniButton.TabIndex = 47;
            this.PojeniButton.Text = "-5 PoJena";
            this.PojeniButton.UseVisualStyleBackColor = true;
            this.PojeniButton.Visible = false;
            this.PojeniButton.Click += new System.EventHandler(this.PojeniButton_Click);
            // 
            // PerfekcionizamButton
            // 
            this.PerfekcionizamButton.Enabled = false;
            this.PerfekcionizamButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PerfekcionizamButton.Location = new System.Drawing.Point(504, 167);
            this.PerfekcionizamButton.Name = "PerfekcionizamButton";
            this.PerfekcionizamButton.Size = new System.Drawing.Size(120, 67);
            this.PerfekcionizamButton.TabIndex = 48;
            this.PerfekcionizamButton.Text = "Perfekcionizam";
            this.PerfekcionizamButton.UseVisualStyleBackColor = true;
            this.PerfekcionizamButton.Visible = false;
            this.PerfekcionizamButton.Click += new System.EventHandler(this.PerfekcionizamButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 650);
            this.Controls.Add(this.PerfekcionizamButton);
            this.Controls.Add(this.PojeniButton);
            this.Controls.Add(this.VremeLabel);
            this.Controls.Add(this.DobriLabel);
            this.Controls.Add(this.MetciLabel);
            this.Controls.Add(this.LoshiLabel);
            this.Controls.Add(this.SkoreLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MinutiButton);
            this.Controls.Add(this.MetciButton);
            this.Controls.Add(this.BeskonacnoButton);
            this.Controls.Add(this.HistoryButton);
            this.Controls.Add(this.TutorijalButton);
            this.Controls.Add(this.NazadButton);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ZavrsiButton);
            this.Controls.Add(this.ResumeButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.DobarLik2);
            this.Controls.Add(this.DobarLik3);
            this.Controls.Add(this.DobarLik1);
            this.Controls.Add(this.LoshiLik3);
            this.Controls.Add(this.LoshiLik2);
            this.Controls.Add(this.LoshiLik1);
            this.Controls.Add(this.LoshiLik5);
            this.Controls.Add(this.LoshiLik4);
            this.Controls.Add(this.mlgPozadina420);
            this.Controls.Add(this.StatusBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(999, 999);
            this.MinimumSize = new System.Drawing.Size(20, 570);
            this.Name = "Form1";
            this.Text = "Primitivni DOOM";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DobarLik2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DobarLik3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DobarLik1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoshiLik3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoshiLik2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoshiLik1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoshiLik5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoshiLik4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mlgPozadina420)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer spawner1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button HistoryButton;
        private System.Windows.Forms.Timer despawner1;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button ZavrsiButton;
        private System.Windows.Forms.Button ResumeButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox DobarLik2;
        private System.Windows.Forms.PictureBox DobarLik3;
        private System.Windows.Forms.Timer spawner3;
        private System.Windows.Forms.PictureBox DobarLik1;
        private System.Windows.Forms.Timer spawner2;
        private System.Windows.Forms.Timer despawner3;
        private System.Windows.Forms.Timer timer7;
        private System.Windows.Forms.PictureBox LoshiLik3;
        private System.Windows.Forms.PictureBox LoshiLik2;
        private System.Windows.Forms.PictureBox LoshiLik1;
        private System.Windows.Forms.Timer despawner2;
        private System.Windows.Forms.PictureBox LoshiLik5;
        private System.Windows.Forms.PictureBox LoshiLik4;
        private System.Windows.Forms.PictureBox mlgPozadina420;
        private System.Windows.Forms.Timer timer8;
        private System.Windows.Forms.Button BeskonacnoButton;
        private System.Windows.Forms.Button MetciButton;
        private System.Windows.Forms.Button MinutiButton;
        private System.Windows.Forms.Button NazadButton;
        private System.Windows.Forms.Label VremeLabel;
        private System.Windows.Forms.Timer timer9;
        private System.Windows.Forms.Label SkoreLabel;
        private System.Windows.Forms.Button TutorijalButton;
        private System.Windows.Forms.PictureBox StatusBar;
        private System.Windows.Forms.Label LoshiLabel;
        private System.Windows.Forms.Label MetciLabel;
        private System.Windows.Forms.Label DobriLabel;
        private System.Windows.Forms.Button PojeniButton;
        private System.Windows.Forms.Button PerfekcionizamButton;
    }
}

