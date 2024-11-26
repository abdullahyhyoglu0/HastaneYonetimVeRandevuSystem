namespace HastaneYönetimVeRandevuSystem
{
    partial class frmdoktordetay
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labeltc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelad = new System.Windows.Forms.Label();
            this.labelsoyad = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rchşikayet = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnbilgidüzenle = new System.Windows.Forms.Button();
            this.btnduyurular = new System.Windows.Forms.Button();
            this.btnçıkış = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelsoyad);
            this.groupBox1.Controls.Add(this.labelad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labeltc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 196);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Bilgi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC NO:";
            // 
            // labeltc
            // 
            this.labeltc.AutoSize = true;
            this.labeltc.Location = new System.Drawing.Point(142, 66);
            this.labeltc.Name = "labeltc";
            this.labeltc.Size = new System.Drawing.Size(133, 25);
            this.labeltc.TabIndex = 1;
            this.labeltc.Text = "00000000000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ad Soyad:";
            // 
            // labelad
            // 
            this.labelad.AutoSize = true;
            this.labelad.Location = new System.Drawing.Point(157, 125);
            this.labelad.Name = "labelad";
            this.labelad.Size = new System.Drawing.Size(45, 25);
            this.labelad.TabIndex = 3;
            this.labelad.Text = "Null";
            // 
            // labelsoyad
            // 
            this.labelsoyad.AutoSize = true;
            this.labelsoyad.Location = new System.Drawing.Point(230, 125);
            this.labelsoyad.Name = "labelsoyad";
            this.labelsoyad.Size = new System.Drawing.Size(45, 25);
            this.labelsoyad.TabIndex = 4;
            this.labelsoyad.Text = "Null";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rchşikayet);
            this.groupBox2.Location = new System.Drawing.Point(12, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 218);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Detay";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(432, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(756, 573);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(750, 544);
            this.dataGridView1.TabIndex = 0;
            // 
            // rchşikayet
            // 
            this.rchşikayet.Location = new System.Drawing.Point(6, 57);
            this.rchşikayet.Name = "rchşikayet";
            this.rchşikayet.Size = new System.Drawing.Size(380, 141);
            this.rchşikayet.TabIndex = 0;
            this.rchşikayet.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnçıkış);
            this.groupBox4.Controls.Add(this.btnduyurular);
            this.groupBox4.Controls.Add(this.btnbilgidüzenle);
            this.groupBox4.Location = new System.Drawing.Point(13, 438);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(416, 147);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // btnbilgidüzenle
            // 
            this.btnbilgidüzenle.Location = new System.Drawing.Point(212, 29);
            this.btnbilgidüzenle.Name = "btnbilgidüzenle";
            this.btnbilgidüzenle.Size = new System.Drawing.Size(191, 44);
            this.btnbilgidüzenle.TabIndex = 0;
            this.btnbilgidüzenle.Text = "Bilgi Düzenle";
            this.btnbilgidüzenle.UseVisualStyleBackColor = true;
            // 
            // btnduyurular
            // 
            this.btnduyurular.Location = new System.Drawing.Point(6, 29);
            this.btnduyurular.Name = "btnduyurular";
            this.btnduyurular.Size = new System.Drawing.Size(195, 44);
            this.btnduyurular.TabIndex = 1;
            this.btnduyurular.Text = "Duyurular\r\n";
            this.btnduyurular.UseVisualStyleBackColor = true;
            // 
            // btnçıkış
            // 
            this.btnçıkış.Location = new System.Drawing.Point(21, 86);
            this.btnçıkış.Name = "btnçıkış";
            this.btnçıkış.Size = new System.Drawing.Size(382, 44);
            this.btnçıkış.TabIndex = 2;
            this.btnçıkış.Text = "Çıkış";
            this.btnçıkış.UseVisualStyleBackColor = true;
            // 
            // frmdoktordetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1200, 593);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmdoktordetay";
            this.Text = "frmdoktordetay";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labeltc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelsoyad;
        private System.Windows.Forms.Label labelad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox rchşikayet;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnçıkış;
        private System.Windows.Forms.Button btnduyurular;
        private System.Windows.Forms.Button btnbilgidüzenle;
    }
}