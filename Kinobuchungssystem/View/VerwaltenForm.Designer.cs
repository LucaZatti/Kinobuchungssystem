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
            this.txt_nachname = new System.Windows.Forms.Label();
            this.txt_vorname = new System.Windows.Forms.Label();
            this.tb_telefonnummer = new System.Windows.Forms.TextBox();
            this.tb_nachname = new System.Windows.Forms.TextBox();
            this.tb_vorname = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.lb_benutzer = new System.Windows.Forms.ListBox();
            this.tb_suchenBenutzer = new System.Windows.Forms.TextBox();
            this.btn_suchenBenutzer = new System.Windows.Forms.Button();
            this.Vorstellung = new System.Windows.Forms.TabPage();
            this.Film = new System.Windows.Forms.TabPage();
            this.btn_zurueck = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Benutzer.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(596, 211);
            this.tabControl1.TabIndex = 1;
            // 
            // Benutzer
            // 
            this.Benutzer.Controls.Add(this.txt_telefonnummer);
            this.Benutzer.Controls.Add(this.txt_nachname);
            this.Benutzer.Controls.Add(this.txt_vorname);
            this.Benutzer.Controls.Add(this.tb_telefonnummer);
            this.Benutzer.Controls.Add(this.tb_nachname);
            this.Benutzer.Controls.Add(this.tb_vorname);
            this.Benutzer.Controls.Add(this.btn_save);
            this.Benutzer.Controls.Add(this.lb_benutzer);
            this.Benutzer.Controls.Add(this.tb_suchenBenutzer);
            this.Benutzer.Controls.Add(this.btn_suchenBenutzer);
            this.Benutzer.Location = new System.Drawing.Point(4, 25);
            this.Benutzer.Name = "Benutzer";
            this.Benutzer.Padding = new System.Windows.Forms.Padding(3);
            this.Benutzer.Size = new System.Drawing.Size(588, 182);
            this.Benutzer.TabIndex = 0;
            this.Benutzer.Text = "Benutzer";
            this.Benutzer.UseVisualStyleBackColor = true;
            // 
            // txt_telefonnummer
            // 
            this.txt_telefonnummer.AutoSize = true;
            this.txt_telefonnummer.Location = new System.Drawing.Point(335, 97);
            this.txt_telefonnummer.Name = "txt_telefonnummer";
            this.txt_telefonnummer.Size = new System.Drawing.Size(111, 17);
            this.txt_telefonnummer.TabIndex = 9;
            this.txt_telefonnummer.Text = "Telefonnummer:";
            // 
            // txt_nachname
            // 
            this.txt_nachname.AutoSize = true;
            this.txt_nachname.Location = new System.Drawing.Point(335, 57);
            this.txt_nachname.Name = "txt_nachname";
            this.txt_nachname.Size = new System.Drawing.Size(80, 17);
            this.txt_nachname.TabIndex = 8;
            this.txt_nachname.Text = "Nachname:";
            // 
            // txt_vorname
            // 
            this.txt_vorname.AutoSize = true;
            this.txt_vorname.Location = new System.Drawing.Point(335, 19);
            this.txt_vorname.Name = "txt_vorname";
            this.txt_vorname.Size = new System.Drawing.Size(69, 17);
            this.txt_vorname.TabIndex = 7;
            this.txt_vorname.Text = "Vorname:";
            // 
            // tb_telefonnummer
            // 
            this.tb_telefonnummer.Location = new System.Drawing.Point(452, 94);
            this.tb_telefonnummer.Name = "tb_telefonnummer";
            this.tb_telefonnummer.Size = new System.Drawing.Size(100, 22);
            this.tb_telefonnummer.TabIndex = 6;
            this.tb_telefonnummer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_telefonnummer_KeyPress);
            // 
            // tb_nachname
            // 
            this.tb_nachname.Location = new System.Drawing.Point(452, 54);
            this.tb_nachname.Name = "tb_nachname";
            this.tb_nachname.Size = new System.Drawing.Size(100, 22);
            this.tb_nachname.TabIndex = 5;
            // 
            // tb_vorname
            // 
            this.tb_vorname.Location = new System.Drawing.Point(452, 16);
            this.tb_vorname.Name = "tb_vorname";
            this.tb_vorname.Size = new System.Drawing.Size(100, 22);
            this.tb_vorname.TabIndex = 4;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(477, 142);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
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
            this.Vorstellung.Location = new System.Drawing.Point(4, 25);
            this.Vorstellung.Name = "Vorstellung";
            this.Vorstellung.Padding = new System.Windows.Forms.Padding(3);
            this.Vorstellung.Size = new System.Drawing.Size(588, 182);
            this.Vorstellung.TabIndex = 1;
            this.Vorstellung.Text = "Vorstellung";
            this.Vorstellung.UseVisualStyleBackColor = true;
            // 
            // Film
            // 
            this.Film.Location = new System.Drawing.Point(4, 25);
            this.Film.Name = "Film";
            this.Film.Padding = new System.Windows.Forms.Padding(3);
            this.Film.Size = new System.Drawing.Size(588, 182);
            this.Film.TabIndex = 2;
            this.Film.Text = "Film";
            this.Film.UseVisualStyleBackColor = true;
            // 
            // btn_zurueck
            // 
            this.btn_zurueck.Location = new System.Drawing.Point(528, 221);
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
            this.ClientSize = new System.Drawing.Size(632, 255);
            this.Controls.Add(this.btn_zurueck);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VerwaltenForm";
            this.Text = "Kinoverwaltungssystem";
            this.tabControl1.ResumeLayout(false);
            this.Benutzer.ResumeLayout(false);
            this.Benutzer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Film;
        private System.Windows.Forms.TabPage Vorstellung;
        private System.Windows.Forms.TabPage Benutzer;
        private System.Windows.Forms.TextBox tb_suchenBenutzer;
        private System.Windows.Forms.Button btn_suchenBenutzer;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ListBox lb_benutzer;
        private System.Windows.Forms.Label txt_telefonnummer;
        private System.Windows.Forms.Label txt_nachname;
        private System.Windows.Forms.Label txt_vorname;
        private System.Windows.Forms.TextBox tb_telefonnummer;
        private System.Windows.Forms.TextBox tb_nachname;
        private System.Windows.Forms.TextBox tb_vorname;
        private System.Windows.Forms.Button btn_zurueck;
    }
}