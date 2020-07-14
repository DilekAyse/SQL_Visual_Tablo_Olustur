namespace tablo_olustur
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
            this.TABLO_OLUSTUR = new System.Windows.Forms.Button();
            this.DATABASE_ADRES = new System.Windows.Forms.TextBox();
            this.MAKINE_ISMI = new System.Windows.Forms.TextBox();
            this.MAKINA_1 = new System.Windows.Forms.TextBox();
            this.recete_bilgisi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.veri_ekle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.veri_sil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TABLO_OLUSTUR
            // 
            this.TABLO_OLUSTUR.Location = new System.Drawing.Point(613, 12);
            this.TABLO_OLUSTUR.Name = "TABLO_OLUSTUR";
            this.TABLO_OLUSTUR.Size = new System.Drawing.Size(112, 23);
            this.TABLO_OLUSTUR.TabIndex = 0;
            this.TABLO_OLUSTUR.Text = "TABLO_OLUSTUR";
            this.TABLO_OLUSTUR.UseVisualStyleBackColor = true;
            this.TABLO_OLUSTUR.Click += new System.EventHandler(this.button1_Click);
            // 
            // DATABASE_ADRES
            // 
            this.DATABASE_ADRES.Location = new System.Drawing.Point(22, 12);
            this.DATABASE_ADRES.Name = "DATABASE_ADRES";
            this.DATABASE_ADRES.Size = new System.Drawing.Size(583, 20);
            this.DATABASE_ADRES.TabIndex = 1;
            this.DATABASE_ADRES.Text = "DILEKGUN\\SQLEXPRESS;Integrated Security=True";
            this.DATABASE_ADRES.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MAKINE_ISMI
            // 
            this.MAKINE_ISMI.Location = new System.Drawing.Point(22, 38);
            this.MAKINE_ISMI.Name = "MAKINE_ISMI";
            this.MAKINE_ISMI.Size = new System.Drawing.Size(583, 20);
            this.MAKINE_ISMI.TabIndex = 2;
            this.MAKINE_ISMI.Text = "Z_FORD_EF_";
            // 
            // MAKINA_1
            // 
            this.MAKINA_1.Location = new System.Drawing.Point(22, 73);
            this.MAKINA_1.Name = "MAKINA_1";
            this.MAKINA_1.Size = new System.Drawing.Size(252, 20);
            this.MAKINA_1.TabIndex = 3;
            this.MAKINA_1.Text = "MAKINA_1_KISA_YUZDE_YUZ";
            // 
            // recete_bilgisi
            // 
            this.recete_bilgisi.Location = new System.Drawing.Point(120, 123);
            this.recete_bilgisi.Name = "recete_bilgisi";
            this.recete_bilgisi.Size = new System.Drawing.Size(100, 20);
            this.recete_bilgisi.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Reçete Bilgisi:";
            // 
            // veri_ekle
            // 
            this.veri_ekle.Location = new System.Drawing.Point(15, 203);
            this.veri_ekle.Name = "veri_ekle";
            this.veri_ekle.Size = new System.Drawing.Size(100, 23);
            this.veri_ekle.TabIndex = 12;
            this.veri_ekle.Text = "Veri Ekle";
            this.veri_ekle.UseVisualStyleBackColor = true;
            this.veri_ekle.Click += new System.EventHandler(this.veri_ekle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Swıtch Acı Alt:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 166);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 14;
            // 
            // veri_sil
            // 
            this.veri_sil.Location = new System.Drawing.Point(120, 203);
            this.veri_sil.Name = "veri_sil";
            this.veri_sil.Size = new System.Drawing.Size(97, 23);
            this.veri_sil.TabIndex = 15;
            this.veri_sil.Text = "Veri Sil";
            this.veri_sil.UseVisualStyleBackColor = true;
            this.veri_sil.Click += new System.EventHandler(this.veri_sil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 328);
            this.Controls.Add(this.veri_sil);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.veri_ekle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.recete_bilgisi);
            this.Controls.Add(this.MAKINA_1);
            this.Controls.Add(this.MAKINE_ISMI);
            this.Controls.Add(this.DATABASE_ADRES);
            this.Controls.Add(this.TABLO_OLUSTUR);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TABLO_OLUSTUR;
        private System.Windows.Forms.TextBox DATABASE_ADRES;
        private System.Windows.Forms.TextBox MAKINE_ISMI;
        private System.Windows.Forms.TextBox MAKINA_1;
        private System.Windows.Forms.TextBox recete_bilgisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button veri_ekle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button veri_sil;
    }
}

