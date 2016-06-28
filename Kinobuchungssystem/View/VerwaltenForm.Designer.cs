﻿namespace Kinobuchungssystem
{
    partial class VerwaltenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerwaltenForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Benutzer = new System.Windows.Forms.TabPage();
            this.txt_telefonnummer = new System.Windows.Forms.Label();
            this.txt_nachnameBenutzer = new System.Windows.Forms.Label();
            this.txt_vornameBenutzer = new System.Windows.Forms.Label();
            this.tb_telefonnummerBenutzer = new System.Windows.Forms.TextBox();
            this.tb_nachname = new System.Windows.Forms.TextBox();
            this.tb_vorname = new System.Windows.Forms.TextBox();
            this.btn_saveBenutzer = new System.Windows.Forms.Button();
            this.lb_benutzer = new System.Windows.Forms.ListBox();
            this.tb_suchenBenutzer = new System.Windows.Forms.TextBox();
            this.btn_suchenBenutzer = new System.Windows.Forms.Button();
            this.Vorstellung = new System.Windows.Forms.TabPage();
            this.btn_vorstellungSave = new System.Windows.Forms.Button();
            this.tb_vorstellungZeit = new System.Windows.Forms.TextBox();
            this.tb_vorstellungDatum = new System.Windows.Forms.TextBox();
            this.tb_vorstellungFilm = new System.Windows.Forms.TextBox();
            this.tb_vorstellungKinosaal = new System.Windows.Forms.TextBox();
            this.tb_vorstellungsnummer = new System.Windows.Forms.TextBox();
            this.txt_vorstellungZeit = new System.Windows.Forms.Label();
            this.txt_vorstellungDatum = new System.Windows.Forms.Label();
            this.txt_vorstellungFilm = new System.Windows.Forms.Label();
            this.txt_vorstellungKinosaal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_vorstellungsNummer = new System.Windows.Forms.Label();
            this.lb_vorstellung = new System.Windows.Forms.ListBox();
            this.tb_vorstellungSuchen = new System.Windows.Forms.TextBox();
            this.btn_vorstellungSuchen = new System.Windows.Forms.Button();
            this.Film = new System.Windows.Forms.TabPage();
            this.btn_filmSave = new System.Windows.Forms.Button();
            this.tb_filmBeschreibung = new System.Windows.Forms.TextBox();
            this.tb_filmGenre = new System.Windows.Forms.TextBox();
            this.tb_filmProduzent = new System.Windows.Forms.TextBox();
            this.tb_filmAltersfreigabe = new System.Windows.Forms.TextBox();
            this.tb_filmDauer = new System.Windows.Forms.TextBox();
            this.tb_filmName = new System.Windows.Forms.TextBox();
            this.txt_filmBeschreibung = new System.Windows.Forms.Label();
            this.txt_filmGenre = new System.Windows.Forms.Label();
            this.txt_filmProduzent = new System.Windows.Forms.Label();
            this.txt_filmAltersfreigabe = new System.Windows.Forms.Label();
            this.txt_filmDauer = new System.Windows.Forms.Label();
            this.txt_filmName = new System.Windows.Forms.Label();
            this.lb_film = new System.Windows.Forms.ListBox();
            this.tb_filmSuchen = new System.Windows.Forms.TextBox();
            this.btn_filmSuchen = new System.Windows.Forms.Button();
            this.btn_zurueck = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Benutzer.SuspendLayout();
            this.Vorstellung.SuspendLayout();
            this.Film.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Benutzer);
            this.tabControl1.Controls.Add(this.Vorstellung);
            this.tabControl1.Controls.Add(this.Film);
            this.tabControl1.Location = new System.Drawing.Point(12, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(608, 305);
            this.tabControl1.TabIndex = 1;
            // 
            // Benutzer
            // 
            this.Benutzer.Controls.Add(this.txt_telefonnummer);
            this.Benutzer.Controls.Add(this.txt_nachnameBenutzer);
            this.Benutzer.Controls.Add(this.txt_vornameBenutzer);
            this.Benutzer.Controls.Add(this.tb_telefonnummerBenutzer);
            this.Benutzer.Controls.Add(this.tb_nachname);
            this.Benutzer.Controls.Add(this.tb_vorname);
            this.Benutzer.Controls.Add(this.btn_saveBenutzer);
            this.Benutzer.Controls.Add(this.lb_benutzer);
            this.Benutzer.Controls.Add(this.tb_suchenBenutzer);
            this.Benutzer.Controls.Add(this.btn_suchenBenutzer);
            this.Benutzer.Location = new System.Drawing.Point(4, 25);
            this.Benutzer.Name = "Benutzer";
            this.Benutzer.Padding = new System.Windows.Forms.Padding(3);
            this.Benutzer.Size = new System.Drawing.Size(600, 276);
            this.Benutzer.TabIndex = 0;
            this.Benutzer.Text = "Benutzer";
            this.Benutzer.UseVisualStyleBackColor = true;
            // 
            // txt_telefonnummer
            // 
            this.txt_telefonnummer.AutoSize = true;
            this.txt_telefonnummer.Location = new System.Drawing.Point(335, 75);
            this.txt_telefonnummer.Name = "txt_telefonnummer";
            this.txt_telefonnummer.Size = new System.Drawing.Size(111, 17);
            this.txt_telefonnummer.TabIndex = 9;
            this.txt_telefonnummer.Text = "Telefonnummer:";
            // 
            // txt_nachnameBenutzer
            // 
            this.txt_nachnameBenutzer.AutoSize = true;
            this.txt_nachnameBenutzer.Location = new System.Drawing.Point(335, 47);
            this.txt_nachnameBenutzer.Name = "txt_nachnameBenutzer";
            this.txt_nachnameBenutzer.Size = new System.Drawing.Size(80, 17);
            this.txt_nachnameBenutzer.TabIndex = 8;
            this.txt_nachnameBenutzer.Text = "Nachname:";
            // 
            // txt_vornameBenutzer
            // 
            this.txt_vornameBenutzer.AutoSize = true;
            this.txt_vornameBenutzer.Location = new System.Drawing.Point(335, 19);
            this.txt_vornameBenutzer.Name = "txt_vornameBenutzer";
            this.txt_vornameBenutzer.Size = new System.Drawing.Size(69, 17);
            this.txt_vornameBenutzer.TabIndex = 7;
            this.txt_vornameBenutzer.Text = "Vorname:";
            // 
            // tb_telefonnummerBenutzer
            // 
            this.tb_telefonnummerBenutzer.Location = new System.Drawing.Point(488, 72);
            this.tb_telefonnummerBenutzer.Name = "tb_telefonnummerBenutzer";
            this.tb_telefonnummerBenutzer.Size = new System.Drawing.Size(100, 22);
            this.tb_telefonnummerBenutzer.TabIndex = 6;
            this.tb_telefonnummerBenutzer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_telefonnummer_KeyPress);
            // 
            // tb_nachname
            // 
            this.tb_nachname.Location = new System.Drawing.Point(488, 44);
            this.tb_nachname.Name = "tb_nachname";
            this.tb_nachname.Size = new System.Drawing.Size(100, 22);
            this.tb_nachname.TabIndex = 5;
            // 
            // tb_vorname
            // 
            this.tb_vorname.Location = new System.Drawing.Point(488, 16);
            this.tb_vorname.Name = "tb_vorname";
            this.tb_vorname.Size = new System.Drawing.Size(100, 22);
            this.tb_vorname.TabIndex = 4;
            // 
            // btn_saveBenutzer
            // 
            this.btn_saveBenutzer.Location = new System.Drawing.Point(513, 247);
            this.btn_saveBenutzer.Name = "btn_saveBenutzer";
            this.btn_saveBenutzer.Size = new System.Drawing.Size(75, 23);
            this.btn_saveBenutzer.TabIndex = 3;
            this.btn_saveBenutzer.Text = "Save";
            this.btn_saveBenutzer.UseVisualStyleBackColor = true;
            this.btn_saveBenutzer.Click += new System.EventHandler(this.btn_saveBenutzer_Click);
            // 
            // lb_benutzer
            // 
            this.lb_benutzer.FormattingEnabled = true;
            this.lb_benutzer.ItemHeight = 16;
            this.lb_benutzer.Location = new System.Drawing.Point(15, 67);
            this.lb_benutzer.Name = "lb_benutzer";
            this.lb_benutzer.Size = new System.Drawing.Size(217, 100);
            this.lb_benutzer.TabIndex = 2;
            // 
            // tb_suchenBenutzer
            // 
            this.tb_suchenBenutzer.Location = new System.Drawing.Point(15, 16);
            this.tb_suchenBenutzer.Name = "tb_suchenBenutzer";
            this.tb_suchenBenutzer.Size = new System.Drawing.Size(100, 22);
            this.tb_suchenBenutzer.TabIndex = 1;
            this.tb_suchenBenutzer.TextChanged += new System.EventHandler(this.tb_suchenBenutzer_TextChanged);
            // 
            // btn_suchenBenutzer
            // 
            this.btn_suchenBenutzer.Location = new System.Drawing.Point(158, 16);
            this.btn_suchenBenutzer.Name = "btn_suchenBenutzer";
            this.btn_suchenBenutzer.Size = new System.Drawing.Size(74, 22);
            this.btn_suchenBenutzer.TabIndex = 0;
            this.btn_suchenBenutzer.Text = "Suchen";
            this.btn_suchenBenutzer.UseVisualStyleBackColor = true;
            this.btn_suchenBenutzer.Click += new System.EventHandler(this.btn_suchenBenutzer_Click);
            // 
            // Vorstellung
            // 
            this.Vorstellung.Controls.Add(this.btn_vorstellungSave);
            this.Vorstellung.Controls.Add(this.tb_vorstellungZeit);
            this.Vorstellung.Controls.Add(this.tb_vorstellungDatum);
            this.Vorstellung.Controls.Add(this.tb_vorstellungFilm);
            this.Vorstellung.Controls.Add(this.tb_vorstellungKinosaal);
            this.Vorstellung.Controls.Add(this.tb_vorstellungsnummer);
            this.Vorstellung.Controls.Add(this.txt_vorstellungZeit);
            this.Vorstellung.Controls.Add(this.txt_vorstellungDatum);
            this.Vorstellung.Controls.Add(this.txt_vorstellungFilm);
            this.Vorstellung.Controls.Add(this.txt_vorstellungKinosaal);
            this.Vorstellung.Controls.Add(this.label1);
            this.Vorstellung.Controls.Add(this.txt_vorstellungsNummer);
            this.Vorstellung.Controls.Add(this.lb_vorstellung);
            this.Vorstellung.Controls.Add(this.tb_vorstellungSuchen);
            this.Vorstellung.Controls.Add(this.btn_vorstellungSuchen);
            this.Vorstellung.Location = new System.Drawing.Point(4, 25);
            this.Vorstellung.Name = "Vorstellung";
            this.Vorstellung.Padding = new System.Windows.Forms.Padding(3);
            this.Vorstellung.Size = new System.Drawing.Size(600, 276);
            this.Vorstellung.TabIndex = 1;
            this.Vorstellung.Text = "Vorstellung";
            this.Vorstellung.UseVisualStyleBackColor = true;
            // 
            // btn_vorstellungSave
            // 
            this.btn_vorstellungSave.Location = new System.Drawing.Point(513, 247);
            this.btn_vorstellungSave.Name = "btn_vorstellungSave";
            this.btn_vorstellungSave.Size = new System.Drawing.Size(75, 23);
            this.btn_vorstellungSave.TabIndex = 3;
            this.btn_vorstellungSave.Text = "Save";
            this.btn_vorstellungSave.UseVisualStyleBackColor = true;
            this.btn_vorstellungSave.Click += new System.EventHandler(this.btn_saveVorstellung_Click);
            // 
            // tb_vorstellungZeit
            // 
            this.tb_vorstellungZeit.Location = new System.Drawing.Point(488, 126);
            this.tb_vorstellungZeit.Name = "tb_vorstellungZeit";
            this.tb_vorstellungZeit.Size = new System.Drawing.Size(100, 22);
            this.tb_vorstellungZeit.TabIndex = 19;
            // 
            // tb_vorstellungDatum
            // 
            this.tb_vorstellungDatum.Location = new System.Drawing.Point(488, 98);
            this.tb_vorstellungDatum.Name = "tb_vorstellungDatum";
            this.tb_vorstellungDatum.Size = new System.Drawing.Size(100, 22);
            this.tb_vorstellungDatum.TabIndex = 18;
            // 
            // tb_vorstellungFilm
            // 
            this.tb_vorstellungFilm.Location = new System.Drawing.Point(488, 70);
            this.tb_vorstellungFilm.Name = "tb_vorstellungFilm";
            this.tb_vorstellungFilm.Size = new System.Drawing.Size(100, 22);
            this.tb_vorstellungFilm.TabIndex = 17;
            // 
            // tb_vorstellungKinosaal
            // 
            this.tb_vorstellungKinosaal.Location = new System.Drawing.Point(488, 42);
            this.tb_vorstellungKinosaal.Name = "tb_vorstellungKinosaal";
            this.tb_vorstellungKinosaal.Size = new System.Drawing.Size(100, 22);
            this.tb_vorstellungKinosaal.TabIndex = 16;
            this.tb_vorstellungKinosaal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_kinosaalVorstellung_KeyPress);
            // 
            // tb_vorstellungsnummer
            // 
            this.tb_vorstellungsnummer.Location = new System.Drawing.Point(488, 14);
            this.tb_vorstellungsnummer.Name = "tb_vorstellungsnummer";
            this.tb_vorstellungsnummer.Size = new System.Drawing.Size(100, 22);
            this.tb_vorstellungsnummer.TabIndex = 15;
            this.tb_vorstellungsnummer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_vorstellungsnummer_KeyPress);
            // 
            // txt_vorstellungZeit
            // 
            this.txt_vorstellungZeit.AutoSize = true;
            this.txt_vorstellungZeit.Location = new System.Drawing.Point(341, 129);
            this.txt_vorstellungZeit.Name = "txt_vorstellungZeit";
            this.txt_vorstellungZeit.Size = new System.Drawing.Size(36, 17);
            this.txt_vorstellungZeit.TabIndex = 14;
            this.txt_vorstellungZeit.Text = "Zeit:";
            // 
            // txt_vorstellungDatum
            // 
            this.txt_vorstellungDatum.AutoSize = true;
            this.txt_vorstellungDatum.Location = new System.Drawing.Point(341, 101);
            this.txt_vorstellungDatum.Name = "txt_vorstellungDatum";
            this.txt_vorstellungDatum.Size = new System.Drawing.Size(53, 17);
            this.txt_vorstellungDatum.TabIndex = 13;
            this.txt_vorstellungDatum.Text = "Datum:";
            // 
            // txt_vorstellungFilm
            // 
            this.txt_vorstellungFilm.AutoSize = true;
            this.txt_vorstellungFilm.Location = new System.Drawing.Point(341, 73);
            this.txt_vorstellungFilm.Name = "txt_vorstellungFilm";
            this.txt_vorstellungFilm.Size = new System.Drawing.Size(37, 17);
            this.txt_vorstellungFilm.TabIndex = 12;
            this.txt_vorstellungFilm.Text = "Film:";
            // 
            // txt_vorstellungKinosaal
            // 
            this.txt_vorstellungKinosaal.AutoSize = true;
            this.txt_vorstellungKinosaal.Location = new System.Drawing.Point(341, 45);
            this.txt_vorstellungKinosaal.Name = "txt_vorstellungKinosaal";
            this.txt_vorstellungKinosaal.Size = new System.Drawing.Size(66, 17);
            this.txt_vorstellungKinosaal.TabIndex = 11;
            this.txt_vorstellungKinosaal.Text = "Kinosaal:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 10;
            // 
            // txt_vorstellungsNummer
            // 
            this.txt_vorstellungsNummer.AutoSize = true;
            this.txt_vorstellungsNummer.Location = new System.Drawing.Point(341, 17);
            this.txt_vorstellungsNummer.Name = "txt_vorstellungsNummer";
            this.txt_vorstellungsNummer.Size = new System.Drawing.Size(141, 17);
            this.txt_vorstellungsNummer.TabIndex = 9;
            this.txt_vorstellungsNummer.Text = "Vorstellungsnummer:";
            // 
            // lb_vorstellung
            // 
            this.lb_vorstellung.FormattingEnabled = true;
            this.lb_vorstellung.ItemHeight = 16;
            this.lb_vorstellung.Location = new System.Drawing.Point(21, 68);
            this.lb_vorstellung.Name = "lb_vorstellung";
            this.lb_vorstellung.Size = new System.Drawing.Size(217, 100);
            this.lb_vorstellung.TabIndex = 8;
            // 
            // tb_vorstellungSuchen
            // 
            this.tb_vorstellungSuchen.Location = new System.Drawing.Point(21, 17);
            this.tb_vorstellungSuchen.Name = "tb_vorstellungSuchen";
            this.tb_vorstellungSuchen.Size = new System.Drawing.Size(100, 22);
            this.tb_vorstellungSuchen.TabIndex = 7;
            this.tb_vorstellungSuchen.TextChanged += new System.EventHandler(this.tb_suchenVorstellung_TextChanged);
            // 
            // btn_vorstellungSuchen
            // 
            this.btn_vorstellungSuchen.Location = new System.Drawing.Point(164, 17);
            this.btn_vorstellungSuchen.Name = "btn_vorstellungSuchen";
            this.btn_vorstellungSuchen.Size = new System.Drawing.Size(74, 22);
            this.btn_vorstellungSuchen.TabIndex = 6;
            this.btn_vorstellungSuchen.Text = "Suchen";
            this.btn_vorstellungSuchen.UseVisualStyleBackColor = true;
            this.btn_vorstellungSuchen.Click += new System.EventHandler(this.btn_suchenVorstellung_Click);
            // 
            // Film
            // 
            this.Film.Controls.Add(this.btn_filmSave);
            this.Film.Controls.Add(this.tb_filmBeschreibung);
            this.Film.Controls.Add(this.tb_filmGenre);
            this.Film.Controls.Add(this.tb_filmProduzent);
            this.Film.Controls.Add(this.tb_filmAltersfreigabe);
            this.Film.Controls.Add(this.tb_filmDauer);
            this.Film.Controls.Add(this.tb_filmName);
            this.Film.Controls.Add(this.txt_filmBeschreibung);
            this.Film.Controls.Add(this.txt_filmGenre);
            this.Film.Controls.Add(this.txt_filmProduzent);
            this.Film.Controls.Add(this.txt_filmAltersfreigabe);
            this.Film.Controls.Add(this.txt_filmDauer);
            this.Film.Controls.Add(this.txt_filmName);
            this.Film.Controls.Add(this.lb_film);
            this.Film.Controls.Add(this.tb_filmSuchen);
            this.Film.Controls.Add(this.btn_filmSuchen);
            this.Film.Location = new System.Drawing.Point(4, 25);
            this.Film.Name = "Film";
            this.Film.Padding = new System.Windows.Forms.Padding(3);
            this.Film.Size = new System.Drawing.Size(600, 276);
            this.Film.TabIndex = 2;
            this.Film.Text = "Film";
            this.Film.UseVisualStyleBackColor = true;
            // 
            // btn_filmSave
            // 
            this.btn_filmSave.Location = new System.Drawing.Point(513, 247);
            this.btn_filmSave.Name = "btn_filmSave";
            this.btn_filmSave.Size = new System.Drawing.Size(75, 23);
            this.btn_filmSave.TabIndex = 3;
            this.btn_filmSave.Text = "Save";
            this.btn_filmSave.UseVisualStyleBackColor = true;
            this.btn_filmSave.Click += new System.EventHandler(this.btn_saveFilm_Click);
            // 
            // tb_filmBeschreibung
            // 
            this.tb_filmBeschreibung.Location = new System.Drawing.Point(430, 154);
            this.tb_filmBeschreibung.Multiline = true;
            this.tb_filmBeschreibung.Name = "tb_filmBeschreibung";
            this.tb_filmBeschreibung.Size = new System.Drawing.Size(158, 73);
            this.tb_filmBeschreibung.TabIndex = 17;
            // 
            // tb_filmGenre
            // 
            this.tb_filmGenre.Location = new System.Drawing.Point(430, 125);
            this.tb_filmGenre.Name = "tb_filmGenre";
            this.tb_filmGenre.Size = new System.Drawing.Size(158, 22);
            this.tb_filmGenre.TabIndex = 16;
            // 
            // tb_filmProduzent
            // 
            this.tb_filmProduzent.Location = new System.Drawing.Point(430, 97);
            this.tb_filmProduzent.Name = "tb_filmProduzent";
            this.tb_filmProduzent.Size = new System.Drawing.Size(158, 22);
            this.tb_filmProduzent.TabIndex = 15;
            // 
            // tb_filmAltersfreigabe
            // 
            this.tb_filmAltersfreigabe.Location = new System.Drawing.Point(430, 69);
            this.tb_filmAltersfreigabe.Name = "tb_filmAltersfreigabe";
            this.tb_filmAltersfreigabe.Size = new System.Drawing.Size(158, 22);
            this.tb_filmAltersfreigabe.TabIndex = 14;
            // 
            // tb_filmDauer
            // 
            this.tb_filmDauer.Location = new System.Drawing.Point(430, 41);
            this.tb_filmDauer.Name = "tb_filmDauer";
            this.tb_filmDauer.Size = new System.Drawing.Size(158, 22);
            this.tb_filmDauer.TabIndex = 13;
            // 
            // tb_filmName
            // 
            this.tb_filmName.Location = new System.Drawing.Point(430, 10);
            this.tb_filmName.Name = "tb_filmName";
            this.tb_filmName.Size = new System.Drawing.Size(158, 22);
            this.tb_filmName.TabIndex = 12;
            // 
            // txt_filmBeschreibung
            // 
            this.txt_filmBeschreibung.AutoSize = true;
            this.txt_filmBeschreibung.Location = new System.Drawing.Point(305, 157);
            this.txt_filmBeschreibung.Name = "txt_filmBeschreibung";
            this.txt_filmBeschreibung.Size = new System.Drawing.Size(99, 17);
            this.txt_filmBeschreibung.TabIndex = 11;
            this.txt_filmBeschreibung.Text = "Beschreibung:";
            // 
            // txt_filmGenre
            // 
            this.txt_filmGenre.AutoSize = true;
            this.txt_filmGenre.Location = new System.Drawing.Point(305, 128);
            this.txt_filmGenre.Name = "txt_filmGenre";
            this.txt_filmGenre.Size = new System.Drawing.Size(52, 17);
            this.txt_filmGenre.TabIndex = 10;
            this.txt_filmGenre.Text = "Genre:";
            // 
            // txt_filmProduzent
            // 
            this.txt_filmProduzent.AutoSize = true;
            this.txt_filmProduzent.Location = new System.Drawing.Point(305, 100);
            this.txt_filmProduzent.Name = "txt_filmProduzent";
            this.txt_filmProduzent.Size = new System.Drawing.Size(77, 17);
            this.txt_filmProduzent.TabIndex = 9;
            this.txt_filmProduzent.Text = "Produzent:";
            // 
            // txt_filmAltersfreigabe
            // 
            this.txt_filmAltersfreigabe.AutoSize = true;
            this.txt_filmAltersfreigabe.Location = new System.Drawing.Point(305, 72);
            this.txt_filmAltersfreigabe.Name = "txt_filmAltersfreigabe";
            this.txt_filmAltersfreigabe.Size = new System.Drawing.Size(100, 17);
            this.txt_filmAltersfreigabe.TabIndex = 8;
            this.txt_filmAltersfreigabe.Text = "Altersfreigabe:";
            // 
            // txt_filmDauer
            // 
            this.txt_filmDauer.AutoSize = true;
            this.txt_filmDauer.Location = new System.Drawing.Point(305, 44);
            this.txt_filmDauer.Name = "txt_filmDauer";
            this.txt_filmDauer.Size = new System.Drawing.Size(51, 17);
            this.txt_filmDauer.TabIndex = 7;
            this.txt_filmDauer.Text = "Dauer:";
            // 
            // txt_filmName
            // 
            this.txt_filmName.AutoSize = true;
            this.txt_filmName.Location = new System.Drawing.Point(305, 13);
            this.txt_filmName.Name = "txt_filmName";
            this.txt_filmName.Size = new System.Drawing.Size(49, 17);
            this.txt_filmName.TabIndex = 6;
            this.txt_filmName.Text = "Name:";
            // 
            // lb_film
            // 
            this.lb_film.FormattingEnabled = true;
            this.lb_film.ItemHeight = 16;
            this.lb_film.Location = new System.Drawing.Point(16, 64);
            this.lb_film.Name = "lb_film";
            this.lb_film.Size = new System.Drawing.Size(217, 100);
            this.lb_film.TabIndex = 5;
            // 
            // tb_filmSuchen
            // 
            this.tb_filmSuchen.Location = new System.Drawing.Point(16, 13);
            this.tb_filmSuchen.Name = "tb_filmSuchen";
            this.tb_filmSuchen.Size = new System.Drawing.Size(100, 22);
            this.tb_filmSuchen.TabIndex = 4;
            this.tb_filmSuchen.TextChanged += new System.EventHandler(this.tb_suchenFilm_TextChanged);
            // 
            // btn_filmSuchen
            // 
            this.btn_filmSuchen.Location = new System.Drawing.Point(159, 13);
            this.btn_filmSuchen.Name = "btn_filmSuchen";
            this.btn_filmSuchen.Size = new System.Drawing.Size(74, 22);
            this.btn_filmSuchen.TabIndex = 3;
            this.btn_filmSuchen.Text = "Suchen";
            this.btn_filmSuchen.UseVisualStyleBackColor = true;
            this.btn_filmSuchen.Click += new System.EventHandler(this.btn_suchenFilm_Click);
            // 
            // btn_zurueck
            // 
            this.btn_zurueck.Location = new System.Drawing.Point(529, 314);
            this.btn_zurueck.Name = "btn_zurueck";
            this.btn_zurueck.Size = new System.Drawing.Size(75, 23);
            this.btn_zurueck.TabIndex = 2;
            this.btn_zurueck.Text = "Zurück";
            this.btn_zurueck.UseVisualStyleBackColor = true;
            this.btn_zurueck.Click += new System.EventHandler(this.btn_zurueck_Click);
            // 
            // VerwaltenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 345);
            this.Controls.Add(this.btn_zurueck);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VerwaltenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kinoverwaltungssystem";
            this.tabControl1.ResumeLayout(false);
            this.Benutzer.ResumeLayout(false);
            this.Benutzer.PerformLayout();
            this.Vorstellung.ResumeLayout(false);
            this.Vorstellung.PerformLayout();
            this.Film.ResumeLayout(false);
            this.Film.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Film;
        private System.Windows.Forms.TabPage Vorstellung;
        private System.Windows.Forms.TabPage Benutzer;
        private System.Windows.Forms.TextBox tb_suchenBenutzer;
        private System.Windows.Forms.Button btn_suchenBenutzer;
        private System.Windows.Forms.Button btn_saveBenutzer;
        private System.Windows.Forms.ListBox lb_benutzer;
        private System.Windows.Forms.Label txt_telefonnummer;
        private System.Windows.Forms.Label txt_nachnameBenutzer;
        private System.Windows.Forms.Label txt_vornameBenutzer;
        private System.Windows.Forms.TextBox tb_telefonnummerBenutzer;
        private System.Windows.Forms.TextBox tb_nachname;
        private System.Windows.Forms.TextBox tb_vorname;
        private System.Windows.Forms.Button btn_zurueck;
        private System.Windows.Forms.ListBox lb_film;
        private System.Windows.Forms.TextBox tb_filmSuchen;
        private System.Windows.Forms.Button btn_filmSuchen;
        private System.Windows.Forms.Button btn_filmSave;
        private System.Windows.Forms.TextBox tb_filmBeschreibung;
        private System.Windows.Forms.TextBox tb_filmGenre;
        private System.Windows.Forms.TextBox tb_filmProduzent;
        private System.Windows.Forms.TextBox tb_filmAltersfreigabe;
        private System.Windows.Forms.TextBox tb_filmDauer;
        private System.Windows.Forms.TextBox tb_filmName;
        private System.Windows.Forms.Label txt_filmBeschreibung;
        private System.Windows.Forms.Label txt_filmGenre;
        private System.Windows.Forms.Label txt_filmProduzent;
        private System.Windows.Forms.Label txt_filmAltersfreigabe;
        private System.Windows.Forms.Label txt_filmDauer;
        private System.Windows.Forms.Label txt_filmName;
        private System.Windows.Forms.Button btn_vorstellungSave;
        private System.Windows.Forms.TextBox tb_vorstellungZeit;
        private System.Windows.Forms.TextBox tb_vorstellungDatum;
        private System.Windows.Forms.TextBox tb_vorstellungFilm;
        private System.Windows.Forms.TextBox tb_vorstellungKinosaal;
        private System.Windows.Forms.TextBox tb_vorstellungsnummer;
        private System.Windows.Forms.Label txt_vorstellungZeit;
        private System.Windows.Forms.Label txt_vorstellungDatum;
        private System.Windows.Forms.Label txt_vorstellungFilm;
        private System.Windows.Forms.Label txt_vorstellungKinosaal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt_vorstellungsNummer;
        private System.Windows.Forms.ListBox lb_vorstellung;
        private System.Windows.Forms.TextBox tb_vorstellungSuchen;
        private System.Windows.Forms.Button btn_vorstellungSuchen;
    }
}