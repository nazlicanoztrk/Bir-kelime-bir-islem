namespace birkelimebirislemn
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnharfgetir = new System.Windows.Forms.Button();
            this.btnharf5 = new System.Windows.Forms.Button();
            this.btnharf9 = new System.Windows.Forms.Button();
            this.btnharf4 = new System.Windows.Forms.Button();
            this.btnharf3 = new System.Windows.Forms.Button();
            this.btnharf2 = new System.Windows.Forms.Button();
            this.btnharf8 = new System.Windows.Forms.Button();
            this.btnharf7 = new System.Windows.Forms.Button();
            this.btnharf6 = new System.Windows.Forms.Button();
            this.btnharf1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnyenioyun = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnharfgetir);
            this.groupBox1.Controls.Add(this.btnharf5);
            this.groupBox1.Controls.Add(this.btnharf9);
            this.groupBox1.Controls.Add(this.btnharf4);
            this.groupBox1.Controls.Add(this.btnharf3);
            this.groupBox1.Controls.Add(this.btnharf2);
            this.groupBox1.Controls.Add(this.btnharf8);
            this.groupBox1.Controls.Add(this.btnharf7);
            this.groupBox1.Controls.Add(this.btnharf6);
            this.groupBox1.Controls.Add(this.btnharf1);
            this.groupBox1.Location = new System.Drawing.Point(1, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 271);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BİR KELİME";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btnharfgetir
            // 
            this.btnharfgetir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnharfgetir.Location = new System.Drawing.Point(287, 126);
            this.btnharfgetir.Name = "btnharfgetir";
            this.btnharfgetir.Size = new System.Drawing.Size(174, 71);
            this.btnharfgetir.TabIndex = 17;
            this.btnharfgetir.Text = "HARF GETİR";
            this.btnharfgetir.UseVisualStyleBackColor = true;
            this.btnharfgetir.Click += new System.EventHandler(this.btnharfgetir_Click);
            // 
            // btnharf5
            // 
            this.btnharf5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnharf5.Location = new System.Drawing.Point(336, 38);
            this.btnharf5.Name = "btnharf5";
            this.btnharf5.Size = new System.Drawing.Size(75, 71);
            this.btnharf5.TabIndex = 11;
            this.btnharf5.UseVisualStyleBackColor = true;
            this.btnharf5.Visible = false;
            // 
            // btnharf9
            // 
            this.btnharf9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnharf9.Location = new System.Drawing.Point(660, 38);
            this.btnharf9.Name = "btnharf9";
            this.btnharf9.Size = new System.Drawing.Size(75, 71);
            this.btnharf9.TabIndex = 8;
            this.btnharf9.UseVisualStyleBackColor = true;
            this.btnharf9.Visible = false;
            // 
            // btnharf4
            // 
            this.btnharf4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnharf4.Location = new System.Drawing.Point(255, 38);
            this.btnharf4.Name = "btnharf4";
            this.btnharf4.Size = new System.Drawing.Size(75, 71);
            this.btnharf4.TabIndex = 10;
            this.btnharf4.UseVisualStyleBackColor = true;
            this.btnharf4.Visible = false;
            // 
            // btnharf3
            // 
            this.btnharf3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnharf3.Location = new System.Drawing.Point(174, 38);
            this.btnharf3.Name = "btnharf3";
            this.btnharf3.Size = new System.Drawing.Size(75, 71);
            this.btnharf3.TabIndex = 9;
            this.btnharf3.UseVisualStyleBackColor = true;
            this.btnharf3.Visible = false;
            // 
            // btnharf2
            // 
            this.btnharf2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnharf2.Location = new System.Drawing.Point(93, 38);
            this.btnharf2.Name = "btnharf2";
            this.btnharf2.Size = new System.Drawing.Size(75, 71);
            this.btnharf2.TabIndex = 8;
            this.btnharf2.UseVisualStyleBackColor = true;
            this.btnharf2.Visible = false;
            // 
            // btnharf8
            // 
            this.btnharf8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnharf8.Location = new System.Drawing.Point(579, 38);
            this.btnharf8.Name = "btnharf8";
            this.btnharf8.Size = new System.Drawing.Size(75, 71);
            this.btnharf8.TabIndex = 7;
            this.btnharf8.UseVisualStyleBackColor = true;
            this.btnharf8.Visible = false;
            // 
            // btnharf7
            // 
            this.btnharf7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnharf7.Location = new System.Drawing.Point(498, 38);
            this.btnharf7.Name = "btnharf7";
            this.btnharf7.Size = new System.Drawing.Size(75, 71);
            this.btnharf7.TabIndex = 6;
            this.btnharf7.UseVisualStyleBackColor = true;
            this.btnharf7.Visible = false;
            // 
            // btnharf6
            // 
            this.btnharf6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnharf6.Location = new System.Drawing.Point(417, 38);
            this.btnharf6.Name = "btnharf6";
            this.btnharf6.Size = new System.Drawing.Size(75, 71);
            this.btnharf6.TabIndex = 5;
            this.btnharf6.UseVisualStyleBackColor = true;
            this.btnharf6.Visible = false;
            // 
            // btnharf1
            // 
            this.btnharf1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnharf1.Location = new System.Drawing.Point(12, 38);
            this.btnharf1.Name = "btnharf1";
            this.btnharf1.Size = new System.Drawing.Size(75, 71);
            this.btnharf1.TabIndex = 0;
            this.btnharf1.UseVisualStyleBackColor = true;
            this.btnharf1.Visible = false;
            // 
            // btnyenioyun
            // 
            this.btnyenioyun.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnyenioyun.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnyenioyun.Location = new System.Drawing.Point(217, 12);
            this.btnyenioyun.Name = "btnyenioyun";
            this.btnyenioyun.Size = new System.Drawing.Size(374, 37);
            this.btnyenioyun.TabIndex = 18;
            this.btnyenioyun.Text = "YENİ OYUN";
            this.btnyenioyun.UseVisualStyleBackColor = false;
            this.btnyenioyun.Click += new System.EventHandler(this.btnyenioyun_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(683, 212);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(104, 59);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 352);
            this.Controls.Add(this.btnyenioyun);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnharfgetir;
        private System.Windows.Forms.Button btnharf5;
        private System.Windows.Forms.Button btnharf9;
        private System.Windows.Forms.Button btnharf4;
        private System.Windows.Forms.Button btnharf3;
        private System.Windows.Forms.Button btnharf2;
        private System.Windows.Forms.Button btnharf8;
        private System.Windows.Forms.Button btnharf7;
        private System.Windows.Forms.Button btnharf6;
        private System.Windows.Forms.Button btnharf1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnyenioyun;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

