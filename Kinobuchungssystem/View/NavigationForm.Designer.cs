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
            this.label1 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 68);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hier können Sie wählen, ob Sie etwas Verwalten wollen \r\noder einen Platz reservie" +
    "ren wollen.\r\nBetätigen Sie den richtigen Knopf und Sie werden \r\nweitergeleitet. " +
    "";
            // 
            // NavigationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 134);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secondView_btn_verwalten);
            this.Controls.Add(this.secondView_btn_reservieren);
            this.Name = "NavigationForm";
            this.Text = "Kinoverwaltungssystem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button secondView_btn_reservieren;
        private System.Windows.Forms.Button secondView_btn_verwalten;
        private System.Windows.Forms.Label label1;
    }
}