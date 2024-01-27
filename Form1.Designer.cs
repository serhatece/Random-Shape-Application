
namespace Random_Shape_Application
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCevap1 = new System.Windows.Forms.Button();
            this.btnCevap2 = new System.Windows.Forms.Button();
            this.btnCevap3 = new System.Windows.Forms.Button();
            this.btnCevap4 = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblDogru = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(56, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCevap1
            // 
            this.btnCevap1.Location = new System.Drawing.Point(56, 224);
            this.btnCevap1.Name = "btnCevap1";
            this.btnCevap1.Size = new System.Drawing.Size(103, 41);
            this.btnCevap1.TabIndex = 1;
            this.btnCevap1.Text = "button1";
            this.btnCevap1.UseVisualStyleBackColor = true;
            this.btnCevap1.Click += new System.EventHandler(this.btnCevap1_Click);
            // 
            // btnCevap2
            // 
            this.btnCevap2.Location = new System.Drawing.Point(182, 224);
            this.btnCevap2.Name = "btnCevap2";
            this.btnCevap2.Size = new System.Drawing.Size(103, 41);
            this.btnCevap2.TabIndex = 2;
            this.btnCevap2.Text = "button2";
            this.btnCevap2.UseVisualStyleBackColor = true;
            this.btnCevap2.Click += new System.EventHandler(this.btnCevap2_Click);
            // 
            // btnCevap3
            // 
            this.btnCevap3.Location = new System.Drawing.Point(56, 281);
            this.btnCevap3.Name = "btnCevap3";
            this.btnCevap3.Size = new System.Drawing.Size(103, 42);
            this.btnCevap3.TabIndex = 3;
            this.btnCevap3.Text = "button3";
            this.btnCevap3.UseVisualStyleBackColor = true;
            this.btnCevap3.Click += new System.EventHandler(this.btnCevap3_Click);
            // 
            // btnCevap4
            // 
            this.btnCevap4.Location = new System.Drawing.Point(182, 281);
            this.btnCevap4.Name = "btnCevap4";
            this.btnCevap4.Size = new System.Drawing.Size(103, 42);
            this.btnCevap4.TabIndex = 4;
            this.btnCevap4.Text = "button4";
            this.btnCevap4.UseVisualStyleBackColor = true;
            this.btnCevap4.Click += new System.EventHandler(this.btnCevap4_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(344, 30);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(103, 32);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblDogru
            // 
            this.lblDogru.AutoSize = true;
            this.lblDogru.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDogru.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblDogru.Location = new System.Drawing.Point(486, 92);
            this.lblDogru.Name = "lblDogru";
            this.lblDogru.Size = new System.Drawing.Size(65, 28);
            this.lblDogru.TabIndex = 6;
            this.lblDogru.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(344, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Puan : ";
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPuan.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblPuan.Location = new System.Drawing.Point(422, 154);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(25, 30);
            this.lblPuan.TabIndex = 8;
            this.lblPuan.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(344, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Doğru Cevap :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(613, 451);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDogru);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnCevap4);
            this.Controls.Add(this.btnCevap3);
            this.Controls.Add(this.btnCevap2);
            this.Controls.Add(this.btnCevap1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCevap1;
        private System.Windows.Forms.Button btnCevap2;
        private System.Windows.Forms.Button btnCevap3;
        private System.Windows.Forms.Button btnCevap4;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblDogru;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Label label1;
    }
}

