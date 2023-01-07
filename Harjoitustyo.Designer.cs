namespace Harjoitustyö
{
    partial class Harjoitustyo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Harjoitustyo));
            this.label6 = new System.Windows.Forms.Label();
            this.tbEtunimet = new System.Windows.Forms.TextBox();
            this.tbKutsumanimi = new System.Windows.Forms.TextBox();
            this.tbHetu = new System.Windows.Forms.TextBox();
            this.tbKatuosoite = new System.Windows.Forms.TextBox();
            this.tbPostinumero = new System.Windows.Forms.TextBox();
            this.tbToimipaikka = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSukunimi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbYksikko = new System.Windows.Forms.TextBox();
            this.dtpPaattymispaiva = new System.Windows.Forms.DateTimePicker();
            this.dtpAlkamispaiva = new System.Windows.Forms.DateTimePicker();
            this.StatusLisaaTyontekija = new System.Windows.Forms.StatusStrip();
            this.tslTeksti = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnTyhjenna = new System.Windows.Forms.Button();
            this.btnTallenna = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tbNimike = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rbMaaraaikainen = new System.Windows.Forms.RadioButton();
            this.rbToistaiseksi = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbcLisaaTyontekija = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.statusTyontekijat = new System.Windows.Forms.StatusStrip();
            this.tslTallennettu = new System.Windows.Forms.ToolStripStatusLabel();
            this.label14 = new System.Windows.Forms.Label();
            this.btnPoista = new System.Windows.Forms.Button();
            this.btnMuokkaa = new System.Windows.Forms.Button();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.dgvTyontekijat = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tsStatusTyontekijat = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tmrAjastin = new System.Windows.Forms.Timer(this.components);
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.StatusLisaaTyontekija.SuspendLayout();
            this.tbcLisaaTyontekija.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.statusTyontekijat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTyontekijat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Postinumero ja toimipaikka";
            // 
            // tbEtunimet
            // 
            this.tbEtunimet.Location = new System.Drawing.Point(212, 23);
            this.tbEtunimet.Name = "tbEtunimet";
            this.tbEtunimet.Size = new System.Drawing.Size(313, 22);
            this.tbEtunimet.TabIndex = 6;
            this.tbEtunimet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEtunimet_KeyPress);
            this.tbEtunimet.Leave += new System.EventHandler(this.TbLeave);
            this.tbEtunimet.Validating += new System.ComponentModel.CancelEventHandler(this.tbEtunimet_Validating);
            this.tbEtunimet.Validated += new System.EventHandler(this.tbEtunimet_Validated);
            // 
            // tbKutsumanimi
            // 
            this.tbKutsumanimi.Location = new System.Drawing.Point(212, 99);
            this.tbKutsumanimi.Name = "tbKutsumanimi";
            this.tbKutsumanimi.Size = new System.Drawing.Size(313, 22);
            this.tbKutsumanimi.TabIndex = 8;
            this.tbKutsumanimi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEtunimet_KeyPress);
            this.tbKutsumanimi.Leave += new System.EventHandler(this.TbLeave);
            this.tbKutsumanimi.Validating += new System.ComponentModel.CancelEventHandler(this.tbEtunimet_Validating);
            this.tbKutsumanimi.Validated += new System.EventHandler(this.tbEtunimet_Validated);
            // 
            // tbHetu
            // 
            this.tbHetu.Location = new System.Drawing.Point(212, 135);
            this.tbHetu.Name = "tbHetu";
            this.tbHetu.Size = new System.Drawing.Size(313, 22);
            this.tbHetu.TabIndex = 9;
            this.tbHetu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHetu_KeyPress_1);
            this.tbHetu.Validating += new System.ComponentModel.CancelEventHandler(this.tbHetu_Validating);
            this.tbHetu.Validated += new System.EventHandler(this.tbHetu_Validated);
            // 
            // tbKatuosoite
            // 
            this.tbKatuosoite.Location = new System.Drawing.Point(212, 171);
            this.tbKatuosoite.Name = "tbKatuosoite";
            this.tbKatuosoite.Size = new System.Drawing.Size(313, 22);
            this.tbKatuosoite.TabIndex = 10;
            this.tbKatuosoite.Leave += new System.EventHandler(this.TbLeave);
            this.tbKatuosoite.Validating += new System.ComponentModel.CancelEventHandler(this.tbEtunimet_Validating);
            this.tbKatuosoite.Validated += new System.EventHandler(this.tbEtunimet_Validated);
            // 
            // tbPostinumero
            // 
            this.tbPostinumero.Location = new System.Drawing.Point(212, 205);
            this.tbPostinumero.Name = "tbPostinumero";
            this.tbPostinumero.Size = new System.Drawing.Size(124, 22);
            this.tbPostinumero.TabIndex = 11;
            this.tbPostinumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPostinumero_KeyPress_1);
            this.tbPostinumero.Validating += new System.ComponentModel.CancelEventHandler(this.TbPostinumero_Validating);
            this.tbPostinumero.Validated += new System.EventHandler(this.TbPostinumero_Validated);
            // 
            // tbToimipaikka
            // 
            this.tbToimipaikka.Location = new System.Drawing.Point(358, 205);
            this.tbToimipaikka.Name = "tbToimipaikka";
            this.tbToimipaikka.Size = new System.Drawing.Size(167, 22);
            this.tbToimipaikka.TabIndex = 12;
            this.tbToimipaikka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEtunimet_KeyPress);
            this.tbToimipaikka.Leave += new System.EventHandler(this.TbLeave);
            this.tbToimipaikka.Validating += new System.ComponentModel.CancelEventHandler(this.tbEtunimet_Validating);
            this.tbToimipaikka.Validated += new System.EventHandler(this.tbEtunimet_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Katuosoite";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Henkilötunnus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kutsumanimi";
            // 
            // tbSukunimi
            // 
            this.tbSukunimi.Location = new System.Drawing.Point(212, 62);
            this.tbSukunimi.Name = "tbSukunimi";
            this.tbSukunimi.Size = new System.Drawing.Size(313, 22);
            this.tbSukunimi.TabIndex = 7;
            this.tbSukunimi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEtunimet_KeyPress);
            this.tbSukunimi.Leave += new System.EventHandler(this.TbLeave);
            this.tbSukunimi.Validating += new System.ComponentModel.CancelEventHandler(this.tbEtunimet_Validating);
            this.tbSukunimi.Validated += new System.EventHandler(this.tbEtunimet_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sukunimi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Etunimet";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.tbYksikko);
            this.tabPage1.Controls.Add(this.dtpPaattymispaiva);
            this.tabPage1.Controls.Add(this.dtpAlkamispaiva);
            this.tabPage1.Controls.Add(this.StatusLisaaTyontekija);
            this.tabPage1.Controls.Add(this.btnTyhjenna);
            this.tabPage1.Controls.Add(this.btnTallenna);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.tbNimike);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.rbMaaraaikainen);
            this.tabPage1.Controls.Add(this.rbToistaiseksi);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.tbHetu);
            this.tabPage1.Controls.Add(this.tbToimipaikka);
            this.tabPage1.Controls.Add(this.tbKutsumanimi);
            this.tabPage1.Controls.Add(this.tbPostinumero);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbKatuosoite);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tbSukunimi);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.tbEtunimet);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(929, 639);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lisää työntekijä";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(567, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 301);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // tbYksikko
            // 
            this.tbYksikko.Location = new System.Drawing.Point(212, 522);
            this.tbYksikko.Name = "tbYksikko";
            this.tbYksikko.Size = new System.Drawing.Size(204, 22);
            this.tbYksikko.TabIndex = 18;
            this.tbYksikko.Leave += new System.EventHandler(this.TbLeave);
            this.tbYksikko.Validating += new System.ComponentModel.CancelEventHandler(this.tbEtunimet_Validating);
            this.tbYksikko.Validated += new System.EventHandler(this.tbEtunimet_Validated);
            // 
            // dtpPaattymispaiva
            // 
            this.dtpPaattymispaiva.Checked = false;
            this.dtpPaattymispaiva.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPaattymispaiva.Location = new System.Drawing.Point(212, 437);
            this.dtpPaattymispaiva.Name = "dtpPaattymispaiva";
            this.dtpPaattymispaiva.Size = new System.Drawing.Size(204, 22);
            this.dtpPaattymispaiva.TabIndex = 16;
            // 
            // dtpAlkamispaiva
            // 
            this.dtpAlkamispaiva.Checked = false;
            this.dtpAlkamispaiva.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAlkamispaiva.Location = new System.Drawing.Point(212, 393);
            this.dtpAlkamispaiva.Name = "dtpAlkamispaiva";
            this.dtpAlkamispaiva.Size = new System.Drawing.Size(204, 22);
            this.dtpAlkamispaiva.TabIndex = 15;
            // 
            // StatusLisaaTyontekija
            // 
            this.StatusLisaaTyontekija.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusLisaaTyontekija.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslTeksti});
            this.StatusLisaaTyontekija.Location = new System.Drawing.Point(3, 610);
            this.StatusLisaaTyontekija.Name = "StatusLisaaTyontekija";
            this.StatusLisaaTyontekija.Size = new System.Drawing.Size(923, 26);
            this.StatusLisaaTyontekija.TabIndex = 33;
            this.StatusLisaaTyontekija.Text = "statusStrip1";
            // 
            // tslTeksti
            // 
            this.tslTeksti.Name = "tslTeksti";
            this.tslTeksti.Size = new System.Drawing.Size(163, 20);
            this.tslTeksti.Text = "Lisää työntekijän tiedot";
            // 
            // btnTyhjenna
            // 
            this.btnTyhjenna.Location = new System.Drawing.Point(567, 508);
            this.btnTyhjenna.Name = "btnTyhjenna";
            this.btnTyhjenna.Size = new System.Drawing.Size(142, 36);
            this.btnTyhjenna.TabIndex = 20;
            this.btnTyhjenna.Text = "Tyhjennä lomake";
            this.btnTyhjenna.UseVisualStyleBackColor = true;
            this.btnTyhjenna.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnTyhjenna_MouseClick);
            // 
            // btnTallenna
            // 
            this.btnTallenna.Enabled = false;
            this.btnTallenna.Location = new System.Drawing.Point(727, 508);
            this.btnTallenna.Name = "btnTallenna";
            this.btnTallenna.Size = new System.Drawing.Size(142, 36);
            this.btnTallenna.TabIndex = 19;
            this.btnTallenna.Text = "Tallenna";
            this.btnTallenna.UseVisualStyleBackColor = false;
            this.btnTallenna.Click += new System.EventHandler(this.btnTallenna_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 527);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 17);
            this.label13.TabIndex = 27;
            this.label13.Text = "Yksikkö";
            // 
            // tbNimike
            // 
            this.tbNimike.Location = new System.Drawing.Point(212, 488);
            this.tbNimike.Name = "tbNimike";
            this.tbNimike.Size = new System.Drawing.Size(204, 22);
            this.tbNimike.TabIndex = 17;
            this.tbNimike.Leave += new System.EventHandler(this.TbLeave);
            this.tbNimike.Validating += new System.ComponentModel.CancelEventHandler(this.tbEtunimet_Validating);
            this.tbNimike.Validated += new System.EventHandler(this.tbEtunimet_Validated);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 488);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 17);
            this.label12.TabIndex = 23;
            this.label12.Text = "Nimike";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 442);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Päättymispäivä";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 321);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Työsuhteen muoto";
            // 
            // rbMaaraaikainen
            // 
            this.rbMaaraaikainen.AutoSize = true;
            this.rbMaaraaikainen.Checked = true;
            this.rbMaaraaikainen.Location = new System.Drawing.Point(212, 317);
            this.rbMaaraaikainen.Name = "rbMaaraaikainen";
            this.rbMaaraaikainen.Size = new System.Drawing.Size(122, 21);
            this.rbMaaraaikainen.TabIndex = 13;
            this.rbMaaraaikainen.TabStop = true;
            this.rbMaaraaikainen.Text = "Määräaikainen";
            this.rbMaaraaikainen.UseVisualStyleBackColor = true;
            this.rbMaaraaikainen.CheckedChanged += new System.EventHandler(this.rbMaaraaikainen_CheckedChanged);
            // 
            // rbToistaiseksi
            // 
            this.rbToistaiseksi.AutoSize = true;
            this.rbToistaiseksi.Location = new System.Drawing.Point(212, 344);
            this.rbToistaiseksi.Name = "rbToistaiseksi";
            this.rbToistaiseksi.Size = new System.Drawing.Size(204, 21);
            this.rbToistaiseksi.TabIndex = 14;
            this.rbToistaiseksi.Text = "Toistaiseksi voimassa oleva";
            this.rbToistaiseksi.UseVisualStyleBackColor = true;
            this.rbToistaiseksi.CheckedChanged += new System.EventHandler(this.rbToistaiseksi_CheckedChanged_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 398);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Aloituspäivä";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Toimisuhteen tiedot";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Henkilön tiedot";
            // 
            // tbcLisaaTyontekija
            // 
            this.tbcLisaaTyontekija.Controls.Add(this.tabPage1);
            this.tbcLisaaTyontekija.Controls.Add(this.tabPage2);
            this.tbcLisaaTyontekija.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcLisaaTyontekija.Location = new System.Drawing.Point(0, 0);
            this.tbcLisaaTyontekija.Name = "tbcLisaaTyontekija";
            this.tbcLisaaTyontekija.SelectedIndex = 0;
            this.tbcLisaaTyontekija.Size = new System.Drawing.Size(937, 668);
            this.tbcLisaaTyontekija.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Controls.Add(this.statusTyontekijat);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.btnPoista);
            this.tabPage2.Controls.Add(this.btnMuokkaa);
            this.tabPage2.Controls.Add(this.btnLisaa);
            this.tabPage2.Controls.Add(this.dgvTyontekijat);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(929, 639);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Työntekijät";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(9, 496);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(325, 96);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "Tässä näkymässä voit järjestää työntekijät nousevaan tai laskevaan aakkosjärjesty" +
    "kseen haluamasi tavan mukaan. Klikkaa esimerkiksi \"Etunimet\" kohtaa ja sen jälke" +
    "en klikkaa pientä nuolta sen vieressä.";
            // 
            // statusTyontekijat
            // 
            this.statusTyontekijat.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusTyontekijat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslTallennettu});
            this.statusTyontekijat.Location = new System.Drawing.Point(3, 610);
            this.statusTyontekijat.Name = "statusTyontekijat";
            this.statusTyontekijat.Size = new System.Drawing.Size(923, 26);
            this.statusTyontekijat.TabIndex = 7;
            this.statusTyontekijat.Text = "statusStrip2";
            // 
            // tslTallennettu
            // 
            this.tslTallennettu.Name = "tslTallennettu";
            this.tslTallennettu.Size = new System.Drawing.Size(45, 20);
            this.tslTallennettu.Text = "         ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 532);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 17);
            this.label14.TabIndex = 4;
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(601, 520);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(148, 40);
            this.btnPoista.TabIndex = 3;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // btnMuokkaa
            // 
            this.btnMuokkaa.Location = new System.Drawing.Point(765, 520);
            this.btnMuokkaa.Name = "btnMuokkaa";
            this.btnMuokkaa.Size = new System.Drawing.Size(148, 40);
            this.btnMuokkaa.TabIndex = 2;
            this.btnMuokkaa.Text = "Muokkaa";
            this.btnMuokkaa.UseVisualStyleBackColor = true;
            this.btnMuokkaa.Click += new System.EventHandler(this.btnMuokkaa_Click_1);
            // 
            // btnLisaa
            // 
            this.btnLisaa.Location = new System.Drawing.Point(391, 520);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(188, 40);
            this.btnLisaa.TabIndex = 1;
            this.btnLisaa.Text = "Lisää uusi työntekijä";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // dgvTyontekijat
            // 
            this.dgvTyontekijat.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvTyontekijat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTyontekijat.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvTyontekijat.Location = new System.Drawing.Point(3, 3);
            this.dgvTyontekijat.Name = "dgvTyontekijat";
            this.dgvTyontekijat.RowHeadersWidth = 51;
            this.dgvTyontekijat.RowTemplate.Height = 24;
            this.dgvTyontekijat.Size = new System.Drawing.Size(923, 486);
            this.dgvTyontekijat.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(375, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 22);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tsStatusTyontekijat
            // 
            this.tsStatusTyontekijat.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.tsStatusTyontekijat.Name = "tsStatusTyontekijat";
            this.tsStatusTyontekijat.Size = new System.Drawing.Size(129, 20);
            this.tsStatusTyontekijat.Text = "                              ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tmrAjastin
            // 
            this.tmrAjastin.Interval = 1000;
            this.tmrAjastin.Tick += new System.EventHandler(this.tmrAjastin_Tick);
            // 
            // Harjoitustyo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 668);
            this.Controls.Add(this.tbcLisaaTyontekija);
            this.Name = "Harjoitustyo";
            this.Text = "Harjoitustyö";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Harjoitustyo_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Harjoitustyo_FormClosed);
            this.Load += new System.EventHandler(this.Harjoitustyo_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.StatusLisaaTyontekija.ResumeLayout(false);
            this.StatusLisaaTyontekija.PerformLayout();
            this.tbcLisaaTyontekija.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.statusTyontekijat.ResumeLayout(false);
            this.statusTyontekijat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTyontekijat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbEtunimet;
        private System.Windows.Forms.TextBox tbKutsumanimi;
        private System.Windows.Forms.TextBox tbHetu;
        private System.Windows.Forms.TextBox tbKatuosoite;
        private System.Windows.Forms.TextBox tbPostinumero;
        private System.Windows.Forms.TextBox tbToimipaikka;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSukunimi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tbcLisaaTyontekija;
        private System.Windows.Forms.RadioButton rbMaaraaikainen;
        private System.Windows.Forms.RadioButton rbToistaiseksi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNimike;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnTallenna;
        private System.Windows.Forms.Button btnTyhjenna;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.Button btnMuokkaa;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.DataGridView dgvTyontekijat;
        private System.Windows.Forms.ToolStripStatusLabel tsStatusTyontekijat;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.StatusStrip StatusLisaaTyontekija;
        private System.Windows.Forms.ToolStripStatusLabel tslTeksti;
        private System.Windows.Forms.Timer tmrAjastin;
        private System.Windows.Forms.StatusStrip statusTyontekijat;
        private System.Windows.Forms.ToolStripStatusLabel tslTallennettu;
        private System.Windows.Forms.TextBox tbYksikko;
        private System.Windows.Forms.DateTimePicker dtpPaattymispaiva;
        private System.Windows.Forms.DateTimePicker dtpAlkamispaiva;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

