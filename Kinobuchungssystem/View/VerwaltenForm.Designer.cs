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
            this.btn_saveVorstellung = new System.Windows.Forms.Button();
            this.tb_zeitVorstellung = new System.Windows.Forms.TextBox();
            this.tb_datumVorstellung = new System.Windows.Forms.TextBox();
            this.tb_filmVorstellung = new System.Windows.Forms.TextBox();
            this.tb_kinosaalVorstellung = new System.Windows.Forms.TextBox();
            this.tb_vorstellungsnummer = new System.Windows.Forms.TextBox();
            this.txt_zeitVorstellung = new System.Windows.Forms.Label();
            this.txt_datumVorstellung = new System.Windows.Forms.Label();
            this.txt_filmVorstellung = new System.Windows.Forms.Label();
            this.txt_kinosaal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_vorstellungsnummer = new System.Windows.Forms.Label();
            this.lb_vorstellung = new System.Windows.Forms.ListBox();
            this.tb_suchenVorstellung = new System.Windows.Forms.TextBox();
            this.btn_suchenVorstellung = new System.Windows.Forms.Button();
            this.Film = new System.Windows.Forms.TabPage();
            this.btn_saveFilm = new System.Windows.Forms.Button();
            this.tb_beschreibungFilm = new System.Windows.Forms.TextBox();
            this.tb_genreFilm = new System.Windows.Forms.TextBox();
            this.tb_produzentFilm = new System.Windows.Forms.TextBox();
            this.tb_altersfreigabeFilm = new System.Windows.Forms.TextBox();
            this.tb_dauerFilm = new System.Windows.Forms.TextBox();
            this.tb_nameFilm = new System.Windows.Forms.TextBox();
            this.txt_beschreibungFilm = new System.Windows.Forms.Label();
            this.txt_genreFilm = new System.Windows.Forms.Label();
            this.txt_produzentFilm = new System.Windows.Forms.Label();
            this.txt_altersfreigabeFilm = new System.Windows.Forms.Label();
            this.txt_dauerFilm = new System.Windows.Forms.Label();
            this.txt_nameFilm = new System.Windows.Forms.Label();
            this.lb_film = new System.Windows.Forms.ListBox();
            this.tb_suchenFilm = new System.Windows.Forms.TextBox();
            this.btn_suchenFilm = new System.Windows.Forms.Button();
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
            this.Vorstellung.Controls.Add(this.btn_saveVorstellung);
            this.Vorstellung.Controls.Add(this.tb_zeitVorstellung);
            this.Vorstellung.Controls.Add(this.tb_datumVorstellung);
            this.Vorstellung.Controls.Add(this.tb_filmVorstellung);
            this.Vorstellung.Controls.Add(this.tb_kinosaalVorstellung);
            this.Vorstellung.Controls.Add(this.tb_vorstellungsnummer);
            this.Vorstellung.Controls.Add(this.txt_zeitVorstellung);
            this.Vorstellung.Controls.Add(this.txt_datumVorstellung);
            this.Vorstellung.Controls.Add(this.txt_filmVorstellung);
            this.Vorstellung.Controls.Add(this.txt_kinosaal);
            this.Vorstellung.Controls.Add(this.label1);
            this.Vorstellung.Controls.Add(this.txt_vorstellungsnummer);
            this.Vorstellung.Controls.Add(this.lb_vorstellung);
            this.Vorstellung.Controls.Add(this.tb_suchenVorstellung);
            this.Vorstellung.Controls.Add(this.btn_suchenVorstellung);
            this.Vorstellung.Location = new System.Drawing.Point(4, 25);
            this.Vorstellung.Name = "Vorstellung";
            this.Vorstellung.Padding = new System.Windows.Forms.Padding(3);
            this.Vorstellung.Size = new System.Drawing.Size(600, 276);
            this.Vorstellung.TabIndex = 1;
            this.Vorstellung.Text = "Vorstellung";
            this.Vorstellung.UseVisualStyleBackColor = true;
            // 
            // btn_saveVorstellung
            // 
            this.btn_saveVorstellung.Location = new System.Drawing.Point(513, 247);
            this.btn_saveVorstellung.Name = "btn_saveVorstellung";
            this.btn_saveVorstellung.Size = new System.Drawing.Size(75, 23);
            this.btn_saveVorstellung.TabIndex = 3;
            this.btn_saveVorstellung.Text = "Save";
            this.btn_saveVorstellung.UseVisualStyleBackColor = true;
            this.btn_saveVorstellung.Click += new System.EventHandler(this.btn_saveVorstellung_Click);
            // 
            // tb_zeitVorstellung
            // 
            this.tb_zeitVorstellung.Location = new System.Drawing.Point(488, 126);
            this.tb_zeitVorstellung.Name = "tb_zeitVorstellung";
            this.tb_zeitVorstellung.Size = new System.Drawing.Size(100, 22);
            this.tb_zeitVorstellung.TabIndex = 19;
            // 
            // tb_datumVorstellung
            // 
            this.tb_datumVorstellung.Location = new System.Drawing.Point(488, 98);
            this.tb_datumVorstellung.Name = "tb_datumVorstellung";
            this.tb_datumVorstellung.Size = new System.Drawing.Size(100, 22);
            this.tb_datumVorstellung.TabIndex = 18;
            // 
            // tb_filmVorstellung
            // 
            this.tb_filmVorstellung.Location = new System.Drawing.Point(488, 70);
            this.tb_filmVorstellung.Name = "tb_filmVorstellung";
            this.tb_filmVorstellung.Size = new System.Drawing.Size(100, 22);
            this.tb_filmVorstellung.TabIndex = 17;
            // 
            // tb_kinosaalVorstellung
            // 
            this.tb_kinosaalVorstellung.Location = new System.Drawing.Point(488, 42);
            this.tb_kinosaalVorstellung.Name = "tb_kinosaalVorstellung";
            this.tb_kinosaalVorstellung.Size = new System.Drawing.Size(100, 22);
            this.tb_kinosaalVorstellung.TabIndex = 16;
            this.tb_kinosaalVorstellung.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_kinosaalVorstellung_KeyPress);
            // 
            // tb_vorstellungsnummer
            // 
            this.tb_vorstellungsnummer.Location = new System.Drawing.Point(488, 14);
            this.tb_vorstellungsnummer.Name = "tb_vorstellungsnummer";
            this.tb_vorstellungsnummer.Size = new System.Drawing.Size(100, 22);
            this.tb_vorstellungsnummer.TabIndex = 15;
            this.tb_vorstellungsnummer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_vorstellungsnummer_KeyPress);
            // 
            // txt_zeitVorstellung
            // 
            this.txt_zeitVorstellung.AutoSize = true;
            this.txt_zeitVorstellung.Location = new System.Drawing.Point(341, 129);
            this.txt_zeitVorstellung.Name = "txt_zeitVorstellung";
            this.txt_zeitVorstellung.Size = new System.Drawing.Size(36, 17);
            this.txt_zeitVorstellung.TabIndex = 14;
            this.txt_zeitVorstellung.Text = "Zeit:";
            // 
            // txt_datumVorstellung
            // 
            this.txt_datumVorstellung.AutoSize = true;
            this.txt_datumVorstellung.Location = new System.Drawing.Point(341, 101);
            this.txt_datumVorstellung.Name = "txt_datumVorstellung";
            this.txt_datumVorstellung.Size = new System.Drawing.Size(53, 17);
            this.txt_datumVorstellung.TabIndex = 13;
            this.txt_datumVorstellung.Text = "Datum:";
            // 
            // txt_filmVorstellung
            // 
            this.txt_filmVorstellung.AutoSize = true;
            this.txt_filmVorstellung.Location = new System.Drawing.Point(341, 73);
            this.txt_filmVorstellung.Name = "txt_filmVorstellung";
            this.txt_filmVorstellung.Size = new System.Drawing.Size(37, 17);
            this.txt_filmVorstellung.TabIndex = 12;
            this.txt_filmVorstellung.Text = "Film:";
            // 
            // txt_kinosaal
            // 
            this.txt_kinosaal.AutoSize = true;
            this.txt_kinosaal.Location = new System.Drawing.Point(341, 45);
            this.txt_kinosaal.Name = "txt_kinosaal";
            this.txt_kinosaal.Size = new System.Drawing.Size(66, 17);
            this.txt_kinosaal.TabIndex = 11;
            this.txt_kinosaal.Text = "Kinosaal:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 10;
            // 
            // txt_vorstellungsnummer
            // 
            this.txt_vorstellungsnummer.AutoSize = true;
            this.txt_vorstellungsnummer.Location = new System.Drawing.Point(341, 17);
            this.txt_vorstellungsnummer.Name = "txt_vorstellungsnummer";
            this.txt_vorstellungsnummer.Size = new System.Drawing.Size(141, 17);
            this.txt_vorstellungsnummer.TabIndex = 9;
            this.txt_vorstellungsnummer.Text = "Vorstellungsnummer:";
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
            // tb_suchenVorstellung
            // 
            this.tb_suchenVorstellung.Location = new System.Drawing.Point(21, 17);
            this.tb_suchenVorstellung.Name = "tb_suchenVorstellung";
            this.tb_suchenVorstellung.Size = new System.Drawing.Size(100, 22);
            this.tb_suchenVorstellung.TabIndex = 7;
            this.tb_suchenVorstellung.TextChanged += new System.EventHandler(this.tb_suchenVorstellung_TextChanged);
            // 
            // btn_suchenVorstellung
            // 
            this.btn_suchenVorstellung.Location = new System.Drawing.Point(164, 17);
            this.btn_suchenVorstellung.Name = "btn_suchenVorstellung";
            this.btn_suchenVorstellung.Size = new System.Drawing.Size(74, 22);
            this.btn_suchenVorstellung.TabIndex = 6;
            this.btn_suchenVorstellung.Text = "Suchen";
            this.btn_suchenVorstellung.UseVisualStyleBackColor = true;
            this.btn_suchenVorstellung.Click += new System.EventHandler(this.btn_suchenVorstellung_Click);
            // 
            // Film
            // 
            this.Film.Controls.Add(this.btn_saveFilm);
            this.Film.Controls.Add(this.tb_beschreibungFilm);
            this.Film.Controls.Add(this.tb_genreFilm);
            this.Film.Controls.Add(this.tb_produzentFilm);
            this.Film.Controls.Add(this.tb_altersfreigabeFilm);
            this.Film.Controls.Add(this.tb_dauerFilm);
            this.Film.Controls.Add(this.tb_nameFilm);
            this.Film.Controls.Add(this.txt_beschreibungFilm);
            this.Film.Controls.Add(this.txt_genreFilm);
            this.Film.Controls.Add(this.txt_produzentFilm);
            this.Film.Controls.Add(this.txt_altersfreigabeFilm);
            this.Film.Controls.Add(this.txt_dauerFilm);
            this.Film.Controls.Add(this.txt_nameFilm);
            this.Film.Controls.Add(this.lb_film);
            this.Film.Controls.Add(this.tb_suchenFilm);
            this.Film.Controls.Add(this.btn_suchenFilm);
            this.Film.Location = new System.Drawing.Point(4, 25);
            this.Film.Name = "Film";
            this.Film.Padding = new System.Windows.Forms.Padding(3);
            this.Film.Size = new System.Drawing.Size(600, 276);
            this.Film.TabIndex = 2;
            this.Film.Text = "Film";
            this.Film.UseVisualStyleBackColor = true;
            // 
            // btn_saveFilm
            // 
            this.btn_saveFilm.Location = new System.Drawing.Point(513, 247);
            this.btn_saveFilm.Name = "btn_saveFilm";
            this.btn_saveFilm.Size = new System.Drawing.Size(75, 23);
            this.btn_saveFilm.TabIndex = 3;
            this.btn_saveFilm.Text = "Save";
            this.btn_saveFilm.UseVisualStyleBackColor = true;
            // 
            // tb_beschreibungFilm
            // 
            this.tb_beschreibungFilm.Location = new System.Drawing.Point(430, 154);
            this.tb_beschreibungFilm.Multiline = true;
            this.tb_beschreibungFilm.Name = "tb_beschreibungFilm";
            this.tb_beschreibungFilm.Size = new System.Drawing.Size(158, 73);
            this.tb_beschreibungFilm.TabIndex = 17;
            // 
            // tb_genreFilm
            // 
            this.tb_genreFilm.Location = new System.Drawing.Point(430, 125);
            this.tb_genreFilm.Name = "tb_genreFilm";
            this.tb_genreFilm.Size = new System.Drawing.Size(158, 22);
            this.tb_genreFilm.TabIndex = 16;
            // 
            // tb_produzentFilm
            // 
            this.tb_produzentFilm.Location = new System.Drawing.Point(430, 97);
            this.tb_produzentFilm.Name = "tb_produzentFilm";
            this.tb_produzentFilm.Size = new System.Drawing.Size(158, 22);
            this.tb_produzentFilm.TabIndex = 15;
            // 
            // tb_altersfreigabeFilm
            // 
            this.tb_altersfreigabeFilm.Location = new System.Drawing.Point(430, 69);
            this.tb_altersfreigabeFilm.Name = "tb_altersfreigabeFilm";
            this.tb_altersfreigabeFilm.Size = new System.Drawing.Size(158, 22);
            this.tb_altersfreigabeFilm.TabIndex = 14;
            // 
            // tb_dauerFilm
            // 
            this.tb_dauerFilm.Location = new System.Drawing.Point(430, 41);
            this.tb_dauerFilm.Name = "tb_dauerFilm";
            this.tb_dauerFilm.Size = new System.Drawing.Size(158, 22);
            this.tb_dauerFilm.TabIndex = 13;
            // 
            // tb_nameFilm
            // 
            this.tb_nameFilm.Location = new System.Drawing.Point(430, 10);
            this.tb_nameFilm.Name = "tb_nameFilm";
            this.tb_nameFilm.Size = new System.Drawing.Size(158, 22);
            this.tb_nameFilm.TabIndex = 12;
            // 
            // txt_beschreibungFilm
            // 
            this.txt_beschreibungFilm.AutoSize = true;
            this.txt_beschreibungFilm.Location = new System.Drawing.Point(305, 157);
            this.txt_beschreibungFilm.Name = "txt_beschreibungFilm";
            this.txt_beschreibungFilm.Size = new System.Drawing.Size(99, 17);
            this.txt_beschreibungFilm.TabIndex = 11;
            this.txt_beschreibungFilm.Text = "Beschreibung:";
            // 
            // txt_genreFilm
            // 
            this.txt_genreFilm.AutoSize = true;
            this.txt_genreFilm.Location = new System.Drawing.Point(305, 128);
            this.txt_genreFilm.Name = "txt_genreFilm";
            this.txt_genreFilm.Size = new System.Drawing.Size(52, 17);
            this.txt_genreFilm.TabIndex = 10;
            this.txt_genreFilm.Text = "Genre:";
            // 
            // txt_produzentFilm
            // 
            this.txt_produzentFilm.AutoSize = true;
            this.txt_produzentFilm.Location = new System.Drawing.Point(305, 100);
            this.txt_produzentFilm.Name = "txt_produzentFilm";
            this.txt_produzentFilm.Size = new System.Drawing.Size(77, 17);
            this.txt_produzentFilm.TabIndex = 9;
            this.txt_produzentFilm.Text = "Produzent:";
            // 
            // txt_altersfreigabeFilm
            // 
            this.txt_altersfreigabeFilm.AutoSize = true;
            this.txt_altersfreigabeFilm.Location = new System.Drawing.Point(305, 72);
            this.txt_altersfreigabeFilm.Name = "txt_altersfreigabeFilm";
            this.txt_altersfreigabeFilm.Size = new System.Drawing.Size(100, 17);
            this.txt_altersfreigabeFilm.TabIndex = 8;
            this.txt_altersfreigabeFilm.Text = "Altersfreigabe:";
            // 
            // txt_dauerFilm
            // 
            this.txt_dauerFilm.AutoSize = true;
            this.txt_dauerFilm.Location = new System.Drawing.Point(305, 44);
            this.txt_dauerFilm.Name = "txt_dauerFilm";
            this.txt_dauerFilm.Size = new System.Drawing.Size(51, 17);
            this.txt_dauerFilm.TabIndex = 7;
            this.txt_dauerFilm.Text = "Dauer:";
            // 
            // txt_nameFilm
            // 
            this.txt_nameFilm.AutoSize = true;
            this.txt_nameFilm.Location = new System.Drawing.Point(305, 13);
            this.txt_nameFilm.Name = "txt_nameFilm";
            this.txt_nameFilm.Size = new System.Drawing.Size(49, 17);
            this.txt_nameFilm.TabIndex = 6;
            this.txt_nameFilm.Text = "Name:";
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
            // tb_suchenFilm
            // 
            this.tb_suchenFilm.Location = new System.Drawing.Point(16, 13);
            this.tb_suchenFilm.Name = "tb_suchenFilm";
            this.tb_suchenFilm.Size = new System.Drawing.Size(100, 22);
            this.tb_suchenFilm.TabIndex = 4;
            this.tb_suchenFilm.TextChanged += new System.EventHandler(this.tb_suchenFilm_TextChanged);
            // 
            // btn_suchenFilm
            // 
            this.btn_suchenFilm.Location = new System.Drawing.Point(159, 13);
            this.btn_suchenFilm.Name = "btn_suchenFilm";
            this.btn_suchenFilm.Size = new System.Drawing.Size(74, 22);
            this.btn_suchenFilm.TabIndex = 3;
            this.btn_suchenFilm.Text = "Suchen";
            this.btn_suchenFilm.UseVisualStyleBackColor = true;
            this.btn_suchenFilm.Click += new System.EventHandler(this.btn_suchenFilm_Click);
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
        private System.Windows.Forms.TextBox tb_suchenFilm;
        private System.Windows.Forms.Button btn_suchenFilm;
        private System.Windows.Forms.Button btn_saveFilm;
        private System.Windows.Forms.TextBox tb_beschreibungFilm;
        private System.Windows.Forms.TextBox tb_genreFilm;
        private System.Windows.Forms.TextBox tb_produzentFilm;
        private System.Windows.Forms.TextBox tb_altersfreigabeFilm;
        private System.Windows.Forms.TextBox tb_dauerFilm;
        private System.Windows.Forms.TextBox tb_nameFilm;
        private System.Windows.Forms.Label txt_beschreibungFilm;
        private System.Windows.Forms.Label txt_genreFilm;
        private System.Windows.Forms.Label txt_produzentFilm;
        private System.Windows.Forms.Label txt_altersfreigabeFilm;
        private System.Windows.Forms.Label txt_dauerFilm;
        private System.Windows.Forms.Label txt_nameFilm;
        private System.Windows.Forms.Button btn_saveVorstellung;
        private System.Windows.Forms.TextBox tb_zeitVorstellung;
        private System.Windows.Forms.TextBox tb_datumVorstellung;
        private System.Windows.Forms.TextBox tb_filmVorstellung;
        private System.Windows.Forms.TextBox tb_kinosaalVorstellung;
        private System.Windows.Forms.TextBox tb_vorstellungsnummer;
        private System.Windows.Forms.Label txt_zeitVorstellung;
        private System.Windows.Forms.Label txt_datumVorstellung;
        private System.Windows.Forms.Label txt_filmVorstellung;
        private System.Windows.Forms.Label txt_kinosaal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt_vorstellungsnummer;
        private System.Windows.Forms.ListBox lb_vorstellung;
        private System.Windows.Forms.TextBox tb_suchenVorstellung;
        private System.Windows.Forms.Button btn_suchenVorstellung;
    }
}