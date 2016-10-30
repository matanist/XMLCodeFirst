namespace XMLODEV
{
    partial class Form1
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
            this.lstUrunler = new System.Windows.Forms.ListBox();
            this.btnVerileriGoster = new System.Windows.Forms.Button();
            this.btnVerileriYaz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstUrunler
            // 
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.ItemHeight = 18;
            this.lstUrunler.Location = new System.Drawing.Point(13, 58);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(539, 310);
            this.lstUrunler.TabIndex = 0;
            // 
            // btnVerileriGoster
            // 
            this.btnVerileriGoster.Location = new System.Drawing.Point(13, 12);
            this.btnVerileriGoster.Name = "btnVerileriGoster";
            this.btnVerileriGoster.Size = new System.Drawing.Size(167, 39);
            this.btnVerileriGoster.TabIndex = 1;
            this.btnVerileriGoster.Text = "Verileri Göster";
            this.btnVerileriGoster.UseVisualStyleBackColor = true;
            this.btnVerileriGoster.Click += new System.EventHandler(this.btnVerileriGoster_Click);
            // 
            // btnVerileriYaz
            // 
            this.btnVerileriYaz.Location = new System.Drawing.Point(365, 12);
            this.btnVerileriYaz.Name = "btnVerileriYaz";
            this.btnVerileriYaz.Size = new System.Drawing.Size(187, 39);
            this.btnVerileriYaz.TabIndex = 1;
            this.btnVerileriYaz.Text = "Verileri Veritabanına Aktar";
            this.btnVerileriYaz.UseVisualStyleBackColor = true;
            this.btnVerileriYaz.Click += new System.EventHandler(this.btnVerileriYaz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 415);
            this.Controls.Add(this.btnVerileriYaz);
            this.Controls.Add(this.btnVerileriGoster);
            this.Controls.Add(this.lstUrunler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstUrunler;
        private System.Windows.Forms.Button btnVerileriGoster;
        private System.Windows.Forms.Button btnVerileriYaz;
    }
}

