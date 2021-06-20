namespace WindowsFormsApp2
{
    partial class Form5
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.skytoneri = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hizmetii = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.derecesi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(346, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 31);
            this.button2.TabIndex = 15;
            this.button2.Text = "Geri Dön";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(461, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 32);
            this.button1.TabIndex = 14;
            this.button1.Text = "Gönder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // skytoneri
            // 
            this.skytoneri.Location = new System.Drawing.Point(346, 168);
            this.skytoneri.Multiline = true;
            this.skytoneri.Name = "skytoneri";
            this.skytoneri.Size = new System.Drawing.Size(204, 102);
            this.skytoneri.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Öneri yada şikayetleriniz :";
            // 
            // hizmetii
            // 
            this.hizmetii.Location = new System.Drawing.Point(346, 46);
            this.hizmetii.Multiline = true;
            this.hizmetii.Name = "hizmetii";
            this.hizmetii.Size = new System.Drawing.Size(204, 102);
            this.hizmetii.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Hangi hizmetlerimizi yetersiz yada eksik buluyorsunuz ? :";
            // 
            // derecesi
            // 
            this.derecesi.Location = new System.Drawing.Point(346, 6);
            this.derecesi.Name = "derecesi";
            this.derecesi.Size = new System.Drawing.Size(100, 20);
            this.derecesi.TabIndex = 9;
            this.derecesi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.derecesi_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Memnuniyet derecenizi girin (1 ile 5 Arasında 1 Çok kötü - 5 Çok iyi) :";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 324);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.skytoneri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hizmetii);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.derecesi);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Defacto Anket";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox skytoneri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hizmetii;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox derecesi;
        private System.Windows.Forms.Label label1;
    }
}