namespace Kinobuchungssystem
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.firstView_btn_Next = new System.Windows.Forms.Button();
            this.firstView_txt_Einleitung = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstView_btn_Next
            // 
            this.firstView_btn_Next.Location = new System.Drawing.Point(385, 119);
            this.firstView_btn_Next.Name = "firstView_btn_Next";
            this.firstView_btn_Next.Size = new System.Drawing.Size(75, 23);
            this.firstView_btn_Next.TabIndex = 0;
            this.firstView_btn_Next.Text = "Next";
            this.firstView_btn_Next.UseVisualStyleBackColor = true;
            this.firstView_btn_Next.Click += new System.EventHandler(this.firstView_btn_Next_Click);
            // 
            // firstView_txt_Einleitung
            // 
            this.firstView_txt_Einleitung.AutoSize = true;
            this.firstView_txt_Einleitung.Location = new System.Drawing.Point(13, 13);
            this.firstView_txt_Einleitung.Name = "firstView_txt_Einleitung";
            this.firstView_txt_Einleitung.Size = new System.Drawing.Size(460, 85);
            this.firstView_txt_Einleitung.TabIndex = 1;
            this.firstView_txt_Einleitung.Text = resources.GetString("firstView_txt_Einleitung.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 147);
            this.Controls.Add(this.firstView_txt_Einleitung);
            this.Controls.Add(this.firstView_btn_Next);
            this.Name = "Form1";
            this.Text = "Kinoverwaltungssystem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button firstView_btn_Next;
        private System.Windows.Forms.Label firstView_txt_Einleitung;
    }
}

