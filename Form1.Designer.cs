namespace WinFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.file1 = new System.Windows.Forms.Label();
            this.file2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateBlue;
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 450);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сгенерировать массив";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SlateBlue;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(609, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 450);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отредактировать массив";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // file1
            // 
            this.file1.AutoSize = true;
            this.file1.BackColor = System.Drawing.Color.AliceBlue;
            this.file1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.file1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.file1.ForeColor = System.Drawing.Color.Indigo;
            this.file1.Location = new System.Drawing.Point(275, 90);
            this.file1.MaximumSize = new System.Drawing.Size(250, 30);
            this.file1.MinimumSize = new System.Drawing.Size(250, 30);
            this.file1.Name = "file1";
            this.file1.Size = new System.Drawing.Size(250, 30);
            this.file1.TabIndex = 2;
            this.file1.Text = "Изначальный вид массива";
            this.file1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // file2
            // 
            this.file2.AutoSize = true;
            this.file2.BackColor = System.Drawing.Color.AliceBlue;
            this.file2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.file2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.file2.ForeColor = System.Drawing.Color.Indigo;
            this.file2.Location = new System.Drawing.Point(275, 296);
            this.file2.MaximumSize = new System.Drawing.Size(250, 30);
            this.file2.MinimumSize = new System.Drawing.Size(250, 30);
            this.file2.Name = "file2";
            this.file2.Size = new System.Drawing.Size(250, 30);
            this.file2.TabIndex = 3;
            this.file2.Text = "Отредактированный массив";
            this.file2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "array";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "array";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.file2);
            this.Controls.Add(this.file1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Лабораторная работа №4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Label file1;
        private Label file2;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}