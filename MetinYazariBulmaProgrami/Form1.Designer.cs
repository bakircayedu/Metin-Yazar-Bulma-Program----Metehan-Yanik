namespace MetinYazariBulmaProgrami
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metinYukleBtn = new System.Windows.Forms.Button();
            this.stackOkuBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MetinTxtBox = new System.Windows.Forms.TextBox();
            this.filePathText = new System.Windows.Forms.Label();
            this.CumleInfoTxt = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lwKelimeInfo = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.agacaAktarBtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.hashTableBtn = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tumKelimelerTxt = new System.Windows.Forms.TextBox();
            this.tumKelimeleriGoruntuleBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // metinYukleBtn
            // 
            this.metinYukleBtn.Location = new System.Drawing.Point(19, 39);
            this.metinYukleBtn.Name = "metinYukleBtn";
            this.metinYukleBtn.Size = new System.Drawing.Size(119, 25);
            this.metinYukleBtn.TabIndex = 0;
            this.metinYukleBtn.Text = "Metin Yükle";
            this.metinYukleBtn.UseVisualStyleBackColor = true;
            this.metinYukleBtn.Click += new System.EventHandler(this.metinYukleBtn_Click);
            // 
            // stackOkuBtn
            // 
            this.stackOkuBtn.Location = new System.Drawing.Point(19, 66);
            this.stackOkuBtn.Name = "stackOkuBtn";
            this.stackOkuBtn.Size = new System.Drawing.Size(119, 27);
            this.stackOkuBtn.TabIndex = 1;
            this.stackOkuBtn.Text = "Stack\'e Oku";
            this.stackOkuBtn.UseVisualStyleBackColor = true;
            this.stackOkuBtn.Click += new System.EventHandler(this.stackOkuBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MetinTxtBox);
            this.groupBox1.Controls.Add(this.filePathText);
            this.groupBox1.Controls.Add(this.metinYukleBtn);
            this.groupBox1.Location = new System.Drawing.Point(23, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 278);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Metin Dosyası Yükleyiniz";
            // 
            // MetinTxtBox
            // 
            this.MetinTxtBox.Location = new System.Drawing.Point(19, 86);
            this.MetinTxtBox.Multiline = true;
            this.MetinTxtBox.Name = "MetinTxtBox";
            this.MetinTxtBox.ReadOnly = true;
            this.MetinTxtBox.Size = new System.Drawing.Size(407, 164);
            this.MetinTxtBox.TabIndex = 2;
            // 
            // filePathText
            // 
            this.filePathText.AutoSize = true;
            this.filePathText.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.filePathText.Location = new System.Drawing.Point(192, 44);
            this.filePathText.Name = "filePathText";
            this.filePathText.Size = new System.Drawing.Size(65, 15);
            this.filePathText.TabIndex = 1;
            this.filePathText.Text = "Dosya Yolu\r\n";
            // 
            // CumleInfoTxt
            // 
            this.CumleInfoTxt.AutoSize = true;
            this.CumleInfoTxt.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CumleInfoTxt.Location = new System.Drawing.Point(158, 74);
            this.CumleInfoTxt.Name = "CumleInfoTxt";
            this.CumleInfoTxt.Size = new System.Drawing.Size(84, 15);
            this.CumleInfoTxt.TabIndex = 3;
            this.CumleInfoTxt.Text = "Cümle Bilgileri";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lwKelimeInfo);
            this.groupBox2.Controls.Add(this.CumleInfoTxt);
            this.groupBox2.Controls.Add(this.stackOkuBtn);
            this.groupBox2.Location = new System.Drawing.Point(23, 325);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 282);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stack Oku";
            // 
            // lwKelimeInfo
            // 
            this.lwKelimeInfo.Location = new System.Drawing.Point(19, 158);
            this.lwKelimeInfo.Name = "lwKelimeInfo";
            this.lwKelimeInfo.Size = new System.Drawing.Size(460, 104);
            this.lwKelimeInfo.TabIndex = 5;
            this.lwKelimeInfo.UseCompatibleStateImageBehavior = false;
            this.lwKelimeInfo.View = System.Windows.Forms.View.List;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.agacaAktarBtn);
            this.groupBox3.Location = new System.Drawing.Point(562, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 96);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ağaç";
            // 
            // agacaAktarBtn
            // 
            this.agacaAktarBtn.Location = new System.Drawing.Point(35, 39);
            this.agacaAktarBtn.Name = "agacaAktarBtn";
            this.agacaAktarBtn.Size = new System.Drawing.Size(139, 25);
            this.agacaAktarBtn.TabIndex = 0;
            this.agacaAktarBtn.Text = "Ağaça Aktar";
            this.agacaAktarBtn.UseVisualStyleBackColor = true;
            this.agacaAktarBtn.Click += new System.EventHandler(this.agacaAktarBtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.hashTableBtn);
            this.groupBox4.Location = new System.Drawing.Point(562, 162);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(240, 112);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hash Table";
            // 
            // hashTableBtn
            // 
            this.hashTableBtn.Location = new System.Drawing.Point(19, 54);
            this.hashTableBtn.Name = "hashTableBtn";
            this.hashTableBtn.Size = new System.Drawing.Size(193, 25);
            this.hashTableBtn.TabIndex = 0;
            this.hashTableBtn.Text = "Hash Tablosu Oluştur";
            this.hashTableBtn.UseVisualStyleBackColor = true;
            this.hashTableBtn.Click += new System.EventHandler(this.hashTableBtn_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tumKelimelerTxt);
            this.groupBox5.Controls.Add(this.tumKelimeleriGoruntuleBtn);
            this.groupBox5.Location = new System.Drawing.Point(562, 340);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(474, 284);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Kelime Görüntüleme Ekranı";
            // 
            // tumKelimelerTxt
            // 
            this.tumKelimelerTxt.Location = new System.Drawing.Point(34, 102);
            this.tumKelimelerTxt.Multiline = true;
            this.tumKelimelerTxt.Name = "tumKelimelerTxt";
            this.tumKelimelerTxt.ReadOnly = true;
            this.tumKelimelerTxt.Size = new System.Drawing.Size(423, 165);
            this.tumKelimelerTxt.TabIndex = 1;
            // 
            // tumKelimeleriGoruntuleBtn
            // 
            this.tumKelimeleriGoruntuleBtn.Location = new System.Drawing.Point(35, 51);
            this.tumKelimeleriGoruntuleBtn.Name = "tumKelimeleriGoruntuleBtn";
            this.tumKelimeleriGoruntuleBtn.Size = new System.Drawing.Size(153, 23);
            this.tumKelimeleriGoruntuleBtn.TabIndex = 0;
            this.tumKelimeleriGoruntuleBtn.Text = "Kelimeleri Görüntüle";
            this.tumKelimeleriGoruntuleBtn.UseVisualStyleBackColor = true;
            this.tumKelimeleriGoruntuleBtn.Click += new System.EventHandler(this.tumKelimeleriGoruntuleBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 636);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Metin Yazarı Bulma Programı -- Metehan Yanık -- 200601078";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button metinYukleBtn;
        private Button stackOkuBtn;
        private GroupBox groupBox1;
        private Label filePathText;
        private TextBox MetinTxtBox;
        private Label CumleInfoTxt;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button agacaAktarBtn;
        private ListView lwKelimeInfo;
        private GroupBox groupBox4;
        private Button hashTableBtn;
        private GroupBox groupBox5;
        private TextBox tumKelimelerTxt;
        private Button tumKelimeleriGoruntuleBtn;
    }
}