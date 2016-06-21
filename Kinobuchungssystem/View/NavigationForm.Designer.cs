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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NavigationForm));
            this.NavigationForm_btn_reservieren = new System.Windows.Forms.Button();
            this.NavigationForm_btn_verwalten = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NavigationForm_btn_reservieren
            // 
            this.NavigationForm_btn_reservieren.Location = new System.Drawing.Point(273, 90);
            this.NavigationForm_btn_reservieren.Name = "NavigationForm_btn_reservieren";
            this.NavigationForm_btn_reservieren.Size = new System.Drawing.Size(97, 32);
            this.NavigationForm_btn_reservieren.TabIndex = 0;
            this.NavigationForm_btn_reservieren.Text = "Reservieren";
            this.NavigationForm_btn_reservieren.UseVisualStyleBackColor = true;
            this.NavigationForm_btn_reservieren.Click += new System.EventHandler(this.NavigationForm_btn_reservieren_Click);
            // 
            // NavigationForm_btn_verwalten
            // 
            this.NavigationForm_btn_verwalten.Location = new System.Drawing.Point(145, 89);
            this.NavigationForm_btn_verwalten.Name = "NavigationForm_btn_verwalten";
            this.NavigationForm_btn_verwalten.Size = new System.Drawing.Size(110, 33);
            this.NavigationForm_btn_verwalten.TabIndex = 1;
            this.NavigationForm_btn_verwalten.Text = "Verwalten";
            this.NavigationForm_btn_verwalten.UseVisualStyleBackColor = true;
            this.NavigationForm_btn_verwalten.Click += new System.EventHandler(this.NavigationForm_btn_verwalten_Click);
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
            this.Controls.Add(this.NavigationForm_btn_verwalten);
            this.Controls.Add(this.NavigationForm_btn_reservieren);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NavigationForm";
            this.Text = "Kinoverwaltungssystem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NavigationForm_btn_reservieren;
        private System.Windows.Forms.Button NavigationForm_btn_verwalten;
        private System.Windows.Forms.Label label1;
    }
}