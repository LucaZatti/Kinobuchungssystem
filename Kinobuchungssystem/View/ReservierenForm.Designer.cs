namespace Kinobuchungssystem.View
{
    partial class ReservierenForm
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
            this.txt_Vorstellung = new System.Windows.Forms.Label();
            this.tb_Vorstellung = new System.Windows.Forms.TextBox();
            this.tb_AnzahlPlaetze = new System.Windows.Forms.TextBox();
            this.txt_AnzahlPlaetze = new System.Windows.Forms.Label();
            this.btn_Suchen = new System.Windows.Forms.Button();
            this.cb_FreiePlaetze = new System.Windows.Forms.ComboBox();
            this.txt_FreiePlaetze = new System.Windows.Forms.Label();
            this.txt_Vorname = new System.Windows.Forms.Label();
            this.txt_Nachname = new System.Windows.Forms.Label();
            this.txt_Telefonnummer = new System.Windows.Forms.Label();
            this.tb_Vorname = new System.Windows.Forms.TextBox();
            this.tb_Nachname = new System.Windows.Forms.TextBox();
            this.tb_Telefonnummer = new System.Windows.Forms.TextBox();
            this.btn_zurück = new System.Windows.Forms.Button();
            this.btn_Reservieren = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Vorstellung
            // 
            this.txt_Vorstellung.AutoSize = true;
            this.txt_Vorstellung.Location = new System.Drawing.Point(13, 13);
            this.txt_Vorstellung.Name = "txt_Vorstellung";
            this.txt_Vorstellung.Size = new System.Drawing.Size(83, 17);
            this.txt_Vorstellung.TabIndex = 0;
            this.txt_Vorstellung.Text = "Vorstellung:";
            // 
            // tb_Vorstellung
            // 
            this.tb_Vorstellung.Location = new System.Drawing.Point(117, 10);
            this.tb_Vorstellung.Name = "tb_Vorstellung";
            this.tb_Vorstellung.Size = new System.Drawing.Size(100, 22);
            this.tb_Vorstellung.TabIndex = 1;
            // 
            // tb_AnzahlPlaetze
            // 
            this.tb_AnzahlPlaetze.Location = new System.Drawing.Point(117, 40);
            this.tb_AnzahlPlaetze.Name = "tb_AnzahlPlaetze";
            this.tb_AnzahlPlaetze.Size = new System.Drawing.Size(100, 22);
            this.tb_AnzahlPlaetze.TabIndex = 2;
            this.tb_AnzahlPlaetze.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_AnzahlPlaetze_KeyPress);
            // 
            // txt_AnzahlPlaetze
            // 
            this.txt_AnzahlPlaetze.AutoSize = true;
            this.txt_AnzahlPlaetze.Location = new System.Drawing.Point(13, 43);
            this.txt_AnzahlPlaetze.Name = "txt_AnzahlPlaetze";
            this.txt_AnzahlPlaetze.Size = new System.Drawing.Size(98, 17);
            this.txt_AnzahlPlaetze.TabIndex = 3;
            this.txt_AnzahlPlaetze.Text = "Anzahl Plätze:";
            // 
            // btn_Suchen
            // 
            this.btn_Suchen.Location = new System.Drawing.Point(249, 39);
            this.btn_Suchen.Name = "btn_Suchen";
            this.btn_Suchen.Size = new System.Drawing.Size(75, 23);
            this.btn_Suchen.TabIndex = 4;
            this.btn_Suchen.Text = "Suchen";
            this.btn_Suchen.UseVisualStyleBackColor = true;
            this.btn_Suchen.Click += new System.EventHandler(this.btn_Suchen_Click);
            // 
            // cb_FreiePlaetze
            // 
            this.cb_FreiePlaetze.FormattingEnabled = true;
            this.cb_FreiePlaetze.Location = new System.Drawing.Point(117, 82);
            this.cb_FreiePlaetze.Name = "cb_FreiePlaetze";
            this.cb_FreiePlaetze.Size = new System.Drawing.Size(121, 24);
            this.cb_FreiePlaetze.TabIndex = 5;
            // 
            // txt_FreiePlaetze
            // 
            this.txt_FreiePlaetze.AutoSize = true;
            this.txt_FreiePlaetze.Location = new System.Drawing.Point(12, 85);
            this.txt_FreiePlaetze.Name = "txt_FreiePlaetze";
            this.txt_FreiePlaetze.Size = new System.Drawing.Size(87, 17);
            this.txt_FreiePlaetze.TabIndex = 6;
            this.txt_FreiePlaetze.Text = "Freie Plätze:";
            // 
            // txt_Vorname
            // 
            this.txt_Vorname.AutoSize = true;
            this.txt_Vorname.Location = new System.Drawing.Point(360, 16);
            this.txt_Vorname.Name = "txt_Vorname";
            this.txt_Vorname.Size = new System.Drawing.Size(69, 17);
            this.txt_Vorname.TabIndex = 7;
            this.txt_Vorname.Text = "Vorname:";
            // 
            // txt_Nachname
            // 
            this.txt_Nachname.AutoSize = true;
            this.txt_Nachname.Location = new System.Drawing.Point(360, 46);
            this.txt_Nachname.Name = "txt_Nachname";
            this.txt_Nachname.Size = new System.Drawing.Size(80, 17);
            this.txt_Nachname.TabIndex = 8;
            this.txt_Nachname.Text = "Nachname:";
            // 
            // txt_Telefonnummer
            // 
            this.txt_Telefonnummer.AutoSize = true;
            this.txt_Telefonnummer.Location = new System.Drawing.Point(360, 74);
            this.txt_Telefonnummer.Name = "txt_Telefonnummer";
            this.txt_Telefonnummer.Size = new System.Drawing.Size(111, 17);
            this.txt_Telefonnummer.TabIndex = 9;
            this.txt_Telefonnummer.Text = "Telefonnummer:";
            // 
            // tb_Vorname
            // 
            this.tb_Vorname.Location = new System.Drawing.Point(480, 13);
            this.tb_Vorname.Name = "tb_Vorname";
            this.tb_Vorname.Size = new System.Drawing.Size(100, 22);
            this.tb_Vorname.TabIndex = 10;
            // 
            // tb_Nachname
            // 
            this.tb_Nachname.Location = new System.Drawing.Point(480, 43);
            this.tb_Nachname.Name = "tb_Nachname";
            this.tb_Nachname.Size = new System.Drawing.Size(100, 22);
            this.tb_Nachname.TabIndex = 11;
            // 
            // tb_Telefonnummer
            // 
            this.tb_Telefonnummer.Location = new System.Drawing.Point(480, 71);
            this.tb_Telefonnummer.Name = "tb_Telefonnummer";
            this.tb_Telefonnummer.Size = new System.Drawing.Size(100, 22);
            this.tb_Telefonnummer.TabIndex = 12;
            this.tb_Telefonnummer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Telefonnummer_KeyPress);
            // 
            // btn_zurück
            // 
            this.btn_zurück.Location = new System.Drawing.Point(379, 116);
            this.btn_zurück.Name = "btn_zurück";
            this.btn_zurück.Size = new System.Drawing.Size(75, 23);
            this.btn_zurück.TabIndex = 13;
            this.btn_zurück.Text = "Zurück";
            this.btn_zurück.UseVisualStyleBackColor = true;
            // 
            // btn_Reservieren
            // 
            this.btn_Reservieren.Location = new System.Drawing.Point(480, 116);
            this.btn_Reservieren.Name = "btn_Reservieren";
            this.btn_Reservieren.Size = new System.Drawing.Size(98, 23);
            this.btn_Reservieren.TabIndex = 14;
            this.btn_Reservieren.Text = "Reservieren";
            this.btn_Reservieren.UseVisualStyleBackColor = true;
            this.btn_Reservieren.Click += new System.EventHandler(this.btn_Reservieren_Click);
            // 
            // ReservierenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 151);
            this.Controls.Add(this.btn_Reservieren);
            this.Controls.Add(this.btn_zurück);
            this.Controls.Add(this.tb_Telefonnummer);
            this.Controls.Add(this.tb_Nachname);
            this.Controls.Add(this.tb_Vorname);
            this.Controls.Add(this.txt_Telefonnummer);
            this.Controls.Add(this.txt_Nachname);
            this.Controls.Add(this.txt_Vorname);
            this.Controls.Add(this.txt_FreiePlaetze);
            this.Controls.Add(this.cb_FreiePlaetze);
            this.Controls.Add(this.btn_Suchen);
            this.Controls.Add(this.txt_AnzahlPlaetze);
            this.Controls.Add(this.tb_AnzahlPlaetze);
            this.Controls.Add(this.tb_Vorstellung);
            this.Controls.Add(this.txt_Vorstellung);
            this.Name = "ReservierenForm";
            this.Text = "Kinoverwaltungssystem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_Vorstellung;
        private System.Windows.Forms.TextBox tb_Vorstellung;
        private System.Windows.Forms.TextBox tb_AnzahlPlaetze;
        private System.Windows.Forms.Label txt_AnzahlPlaetze;
        private System.Windows.Forms.Button btn_Suchen;
        private System.Windows.Forms.ComboBox cb_FreiePlaetze;
        private System.Windows.Forms.Label txt_FreiePlaetze;
        private System.Windows.Forms.Label txt_Vorname;
        private System.Windows.Forms.Label txt_Nachname;
        private System.Windows.Forms.Label txt_Telefonnummer;
        private System.Windows.Forms.TextBox tb_Vorname;
        private System.Windows.Forms.TextBox tb_Nachname;
        private System.Windows.Forms.TextBox tb_Telefonnummer;
        private System.Windows.Forms.Button btn_zurück;
        private System.Windows.Forms.Button btn_Reservieren;
    }
}