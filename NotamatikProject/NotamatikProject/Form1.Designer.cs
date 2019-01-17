namespace NotamatikProject
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
            this.btnGamOlustur = new System.Windows.Forms.Button();
            this.listNota = new System.Windows.Forms.ListBox();
            this.cmbGamTip = new System.Windows.Forms.ComboBox();
            this.boxOzelGam = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGamNotaAraliklari = new System.Windows.Forms.TextBox();
            this.btnOzelGamOlustur = new System.Windows.Forms.Button();
            this.boxCiktiGam = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAritmetikCaldir = new System.Windows.Forms.Button();
            this.txtCaldirmaSirasi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOlcuSirasi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.boxOzelGam.SuspendLayout();
            this.boxCiktiGam.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGamOlustur
            // 
            this.btnGamOlustur.Location = new System.Drawing.Point(431, 35);
            this.btnGamOlustur.Name = "btnGamOlustur";
            this.btnGamOlustur.Size = new System.Drawing.Size(164, 75);
            this.btnGamOlustur.TabIndex = 0;
            this.btnGamOlustur.Text = "button1";
            this.btnGamOlustur.UseVisualStyleBackColor = true;
            this.btnGamOlustur.Click += new System.EventHandler(this.button1_Click);
            // 
            // listNota
            // 
            this.listNota.FormattingEnabled = true;
            this.listNota.Location = new System.Drawing.Point(12, 35);
            this.listNota.Name = "listNota";
            this.listNota.Size = new System.Drawing.Size(132, 212);
            this.listNota.TabIndex = 1;
            // 
            // cmbGamTip
            // 
            this.cmbGamTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGamTip.FormattingEnabled = true;
            this.cmbGamTip.Location = new System.Drawing.Point(174, 35);
            this.cmbGamTip.Name = "cmbGamTip";
            this.cmbGamTip.Size = new System.Drawing.Size(121, 21);
            this.cmbGamTip.TabIndex = 2;
            this.cmbGamTip.SelectedIndexChanged += new System.EventHandler(this.cmbGamTip_SelectedIndexChanged);
            // 
            // boxOzelGam
            // 
            this.boxOzelGam.Controls.Add(this.label1);
            this.boxOzelGam.Controls.Add(this.txtGamNotaAraliklari);
            this.boxOzelGam.Controls.Add(this.btnOzelGamOlustur);
            this.boxOzelGam.Location = new System.Drawing.Point(290, 139);
            this.boxOzelGam.Name = "boxOzelGam";
            this.boxOzelGam.Size = new System.Drawing.Size(405, 131);
            this.boxOzelGam.TabIndex = 3;
            this.boxOzelGam.TabStop = false;
            this.boxOzelGam.Text = "Özel Gam";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Örnek : majör  ->  2, 2, 1, 2, 2, 2  -> 2 tam 1 yarım 3 tam 1 yarım (sonuncu yazm" +
    "a)";
            // 
            // txtGamNotaAraliklari
            // 
            this.txtGamNotaAraliklari.Location = new System.Drawing.Point(26, 49);
            this.txtGamNotaAraliklari.Name = "txtGamNotaAraliklari";
            this.txtGamNotaAraliklari.Size = new System.Drawing.Size(100, 20);
            this.txtGamNotaAraliklari.TabIndex = 5;
            // 
            // btnOzelGamOlustur
            // 
            this.btnOzelGamOlustur.Location = new System.Drawing.Point(221, 33);
            this.btnOzelGamOlustur.Name = "btnOzelGamOlustur";
            this.btnOzelGamOlustur.Size = new System.Drawing.Size(116, 50);
            this.btnOzelGamOlustur.TabIndex = 4;
            this.btnOzelGamOlustur.Text = "Oluştur";
            this.btnOzelGamOlustur.UseVisualStyleBackColor = true;
            this.btnOzelGamOlustur.Click += new System.EventHandler(this.btnOzelGamOlustur_Click);
            // 
            // boxCiktiGam
            // 
            this.boxCiktiGam.Controls.Add(this.groupBox1);
            this.boxCiktiGam.Controls.Add(this.flowLayoutPanel1);
            this.boxCiktiGam.Location = new System.Drawing.Point(12, 276);
            this.boxCiktiGam.Name = "boxCiktiGam";
            this.boxCiktiGam.Size = new System.Drawing.Size(776, 609);
            this.boxCiktiGam.TabIndex = 4;
            this.boxCiktiGam.TabStop = false;
            this.boxCiktiGam.Text = "Çalışma Alanı";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtOlcuSirasi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAritmetikCaldir);
            this.groupBox1.Controls.Add(this.txtCaldirmaSirasi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 151);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gam Çaldırma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Örnek : sırayla çaldırma => 011111";
            // 
            // btnAritmetikCaldir
            // 
            this.btnAritmetikCaldir.Enabled = false;
            this.btnAritmetikCaldir.Location = new System.Drawing.Point(483, 27);
            this.btnAritmetikCaldir.Name = "btnAritmetikCaldir";
            this.btnAritmetikCaldir.Size = new System.Drawing.Size(100, 23);
            this.btnAritmetikCaldir.TabIndex = 2;
            this.btnAritmetikCaldir.Text = "Aritmetik Çaldır";
            this.btnAritmetikCaldir.UseVisualStyleBackColor = true;
            this.btnAritmetikCaldir.Click += new System.EventHandler(this.btnAritmetikCaldir_Click);
            // 
            // txtCaldirmaSirasi
            // 
            this.txtCaldirmaSirasi.Location = new System.Drawing.Point(134, 42);
            this.txtCaldirmaSirasi.Name = "txtCaldirmaSirasi";
            this.txtCaldirmaSirasi.Size = new System.Drawing.Size(307, 20);
            this.txtCaldirmaSirasi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Çaldırma Sırası Gir :";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(764, 63);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Notaların Ölçüsünü Gir :";
            // 
            // txtOlcuSirasi
            // 
            this.txtOlcuSirasi.Location = new System.Drawing.Point(134, 76);
            this.txtOlcuSirasi.Name = "txtOlcuSirasi";
            this.txtOlcuSirasi.Size = new System.Drawing.Size(307, 20);
            this.txtOlcuSirasi.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Örnek : ölçü sirasi 1248";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 897);
            this.Controls.Add(this.boxCiktiGam);
            this.Controls.Add(this.boxOzelGam);
            this.Controls.Add(this.cmbGamTip);
            this.Controls.Add(this.listNota);
            this.Controls.Add(this.btnGamOlustur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.boxOzelGam.ResumeLayout(false);
            this.boxOzelGam.PerformLayout();
            this.boxCiktiGam.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGamOlustur;
        private System.Windows.Forms.ListBox listNota;
        private System.Windows.Forms.ComboBox cmbGamTip;
        private System.Windows.Forms.GroupBox boxOzelGam;
        private System.Windows.Forms.Button btnOzelGamOlustur;
        private System.Windows.Forms.GroupBox boxCiktiGam;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox txtGamNotaAraliklari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAritmetikCaldir;
        private System.Windows.Forms.TextBox txtCaldirmaSirasi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOlcuSirasi;
        private System.Windows.Forms.Label label4;
    }
}

