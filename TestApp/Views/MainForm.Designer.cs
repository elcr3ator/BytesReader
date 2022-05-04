namespace TestApp.Views
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.FilePath = new System.Windows.Forms.TextBox();
            this.FileLabel = new System.Windows.Forms.Label();
            this.FileInfoSize = new System.Windows.Forms.Label();
            this.FileSize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.width = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.File1 = new System.Windows.Forms.TextBox();
            this.File2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.byteAmount = new System.Windows.Forms.TextBox();
            this.Ok = new System.Windows.Forms.Button();
            this.bitmap = new System.Windows.Forms.PictureBox();
            this.WriteFileBin = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.WriteFileDec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bitmap)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FilePath
            // 
            this.FilePath.Location = new System.Drawing.Point(138, 82);
            this.FilePath.Name = "FilePath";
            this.FilePath.ReadOnly = true;
            this.FilePath.Size = new System.Drawing.Size(163, 20);
            this.FilePath.TabIndex = 0;
            this.FilePath.Click += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FileLabel
            // 
            this.FileLabel.AutoSize = true;
            this.FileLabel.Location = new System.Drawing.Point(52, 82);
            this.FileLabel.Name = "FileLabel";
            this.FileLabel.Size = new System.Drawing.Size(36, 13);
            this.FileLabel.TabIndex = 2;
            this.FileLabel.Text = "Файл";
            // 
            // FileInfoSize
            // 
            this.FileInfoSize.AutoSize = true;
            this.FileInfoSize.Location = new System.Drawing.Point(405, 81);
            this.FileInfoSize.Name = "FileInfoSize";
            this.FileInfoSize.Size = new System.Drawing.Size(42, 13);
            this.FileInfoSize.TabIndex = 3;
            this.FileInfoSize.Text = "Розмір";
            // 
            // FileSize
            // 
            this.FileSize.AutoSize = true;
            this.FileSize.Location = new System.Drawing.Point(477, 82);
            this.FileSize.Name = "FileSize";
            this.FileSize.Size = new System.Drawing.Size(0, 13);
            this.FileSize.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Область візуалізації";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Висота";
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(105, 173);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(59, 20);
            this.height.TabIndex = 7;
            this.height.TextChanged += new System.EventHandler(this.height_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Широта";
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(231, 173);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(58, 20);
            this.width.TabIndex = 9;
            this.width.TextChanged += new System.EventHandler(this.width_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Файл1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(429, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Файл2:";
            // 
            // File1
            // 
            this.File1.Location = new System.Drawing.Point(480, 140);
            this.File1.Name = "File1";
            this.File1.Size = new System.Drawing.Size(49, 20);
            this.File1.TabIndex = 12;
            // 
            // File2
            // 
            this.File2.Location = new System.Drawing.Point(480, 176);
            this.File2.Name = "File2";
            this.File2.Size = new System.Drawing.Size(49, 20);
            this.File2.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(660, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Байт:";
            // 
            // byteAmount
            // 
            this.byteAmount.Location = new System.Drawing.Point(663, 165);
            this.byteAmount.Name = "byteAmount";
            this.byteAmount.ReadOnly = true;
            this.byteAmount.Size = new System.Drawing.Size(72, 20);
            this.byteAmount.TabIndex = 15;
            // 
            // Ok
            // 
            this.Ok.Enabled = false;
            this.Ok.Location = new System.Drawing.Point(589, 415);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(118, 23);
            this.Ok.TabIndex = 16;
            this.Ok.Text = "Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.button1_Click);
            // 
            // bitmap
            // 
            this.bitmap.Location = new System.Drawing.Point(57, 218);
            this.bitmap.Margin = new System.Windows.Forms.Padding(2);
            this.bitmap.MaximumSize = new System.Drawing.Size(520, 10000);
            this.bitmap.Name = "bitmap";
            this.bitmap.Size = new System.Drawing.Size(100, 100);
            this.bitmap.TabIndex = 17;
            this.bitmap.TabStop = false;
            // 
            // WriteFileBin
            // 
            this.WriteFileBin.Location = new System.Drawing.Point(560, 138);
            this.WriteFileBin.Margin = new System.Windows.Forms.Padding(2);
            this.WriteFileBin.Name = "WriteFileBin";
            this.WriteFileBin.Size = new System.Drawing.Size(79, 19);
            this.WriteFileBin.TabIndex = 18;
            this.WriteFileBin.Text = "Save Binary";
            this.WriteFileBin.UseVisualStyleBackColor = true;
            this.WriteFileBin.Click += new System.EventHandler(this.WriteFile_Click);
            // 
            // WriteFileDec
            // 
            this.WriteFileDec.Location = new System.Drawing.Point(560, 176);
            this.WriteFileDec.Margin = new System.Windows.Forms.Padding(2);
            this.WriteFileDec.Name = "WriteFileDec";
            this.WriteFileDec.Size = new System.Drawing.Size(79, 19);
            this.WriteFileDec.TabIndex = 19;
            this.WriteFileDec.Text = "Save Decimal";
            this.WriteFileDec.UseVisualStyleBackColor = true;
            this.WriteFileDec.Click += new System.EventHandler(this.WriteFileDec_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WriteFileDec);
            this.Controls.Add(this.WriteFileBin);
            this.Controls.Add(this.bitmap);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.byteAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.File2);
            this.Controls.Add(this.File1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.width);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.height);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FileSize);
            this.Controls.Add(this.FileInfoSize);
            this.Controls.Add(this.FileLabel);
            this.Controls.Add(this.FilePath);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bitmap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox FilePath;
        private System.Windows.Forms.Label FileLabel;
        private System.Windows.Forms.Label FileInfoSize;
        private System.Windows.Forms.Label FileSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox width;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox File1;
        private System.Windows.Forms.TextBox File2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox byteAmount;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.PictureBox bitmap;
        private System.Windows.Forms.Button WriteFileBin;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button WriteFileDec;
    }
}

