namespace WindowsFormsApp2
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.derece = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hizmett = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.oneris = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Memnuniyet derecenizi girin (1 ile 5 Arasında 1 Çok kötü - 5 Çok iyi) :";
            // 
            // derece
            // 
            this.derece.Location = new System.Drawing.Point(346, 15);
            this.derece.Name = "derece";
            this.derece.Size = new System.Drawing.Size(100, 20);
            this.derece.TabIndex = 1;
            this.derece.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.derece_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hangi hizmetlerimizi yetersiz yada eksik buluyorsunuz ? :";
            // 
            // hizmett
            // 
            this.hizmett.Location = new System.Drawing.Point(346, 55);
            this.hizmett.Multiline = true;
            this.hizmett.Name = "hizmett";
            this.hizmett.Size = new System.Drawing.Size(204, 102);
            this.hizmett.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Öneri yada şikayetleriniz :";
            // 
            // oneris
            // 
            this.oneris.Location = new System.Drawing.Point(346, 177);
            this.oneris.Multiline = true;
            this.oneris.Name = "oneris";
            this.oneris.Size = new System.Drawing.Size(204, 102);
            this.oneris.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(461, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Gönder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(346, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 31);
            this.button2.TabIndex = 7;
            this.button2.Text = "Geri Dön";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 340);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.oneris);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hizmett);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.derece);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Yemeksepeti Anket";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox derece;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hizmett;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox oneris;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}