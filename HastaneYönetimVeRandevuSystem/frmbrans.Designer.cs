namespace HastaneYönetimVeRandevuSystem
{
    partial class frmbrans
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnsil = new System.Windows.Forms.Button();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(437, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(527, 304);
            this.dataGridView1.TabIndex = 27;
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.Crimson;
            this.btnsil.Location = new System.Drawing.Point(252, 193);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(118, 39);
            this.btnsil.TabIndex = 26;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            // 
            // btngüncelle
            // 
            this.btngüncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btngüncelle.Location = new System.Drawing.Point(185, 263);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(121, 46);
            this.btngüncelle.TabIndex = 25;
            this.btngüncelle.Text = "Güncelle";
            this.btngüncelle.UseVisualStyleBackColor = false;
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.DarkCyan;
            this.btnekle.Location = new System.Drawing.Point(121, 193);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(116, 39);
            this.btnekle.TabIndex = 24;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = false;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(164, 66);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(160, 30);
            this.txtid.TabIndex = 22;
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(164, 131);
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(160, 30);
            this.msktc.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Branş İd:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "TC:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmbrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(971, 338);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmbrans";
            this.Text = "frmbrans";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}