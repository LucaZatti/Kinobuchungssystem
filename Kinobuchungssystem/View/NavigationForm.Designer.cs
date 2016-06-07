namespace Kinobuchungssystem
{
    partial class NavigationForm
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
            this.secondView_btn_reservieren = new System.Windows.Forms.Button();
            this.secondView_btn_verwalten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // secondView_btn_reservieren
            // 
            this.secondView_btn_reservieren.Location = new System.Drawing.Point(273, 90);
            this.secondView_btn_reservieren.Name = "secondView_btn_reservieren";
            this.secondView_btn_reservieren.Size = new System.Drawing.Size(97, 32);
            this.secondView_btn_reservieren.TabIndex = 0;
            this.secondView_btn_reservieren.Text = "Reservieren";
            this.secondView_btn_reservieren.UseVisualStyleBackColor = true;
            this.secondView_btn_reservieren.Click += new System.EventHandler(this.secondView_btn_reservieren_Click);
            // 
            // secondView_btn_verwalten
            // 
            this.secondView_btn_verwalten.Location = new System.Drawing.Point(157, 90);
            this.secondView_btn_verwalten.Name = "secondView_btn_verwalten";
            this.secondView_btn_verwalten.Size = new System.Drawing.Size(110, 33);
            this.secondView_btn_verwalten.TabIndex = 1;
            this.secondView_btn_verwalten.Text = "Verwalten";
            this.secondView_btn_verwalten.UseVisualStyleBackColor = true;
            this.secondView_btn_verwalten.Click += new System.EventHandler(this.secondView_btn_verwalten_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 134);
            this.Controls.Add(this.secondView_btn_verwalten);
            this.Controls.Add(this.secondView_btn_reservieren);
            this.Name = "Form2";
            this.Text = "Kinoverwaltungssystem";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button secondView_btn_reservieren;
        private System.Windows.Forms.Button secondView_btn_verwalten;
    }
}