namespace UP0401Ex4
{
    partial class Form1
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
            this.Colors = new System.Windows.Forms.ComboBox();
            this.Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TEXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Colors
            // 
            this.Colors.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Colors.FormattingEnabled = true;
            this.Colors.Items.AddRange(new object[] {
            "Pink",
            "Maroon",
            "Black",
            "Gray",
            "Green"});
            this.Colors.Location = new System.Drawing.Point(12, 47);
            this.Colors.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Colors.Name = "Colors";
            this.Colors.Size = new System.Drawing.Size(182, 27);
            this.Colors.TabIndex = 0;
            this.Colors.SelectedIndexChanged += new System.EventHandler(this.Colors_SelectedIndexChanged);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Save.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Save.Location = new System.Drawing.Point(426, 175);
            this.Save.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(118, 50);
            this.Save.TabIndex = 1;
            this.Save.Text = "Save changes";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose color:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TEXT
            // 
            this.TEXT.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TEXT.Location = new System.Drawing.Point(242, 47);
            this.TEXT.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TEXT.Name = "TEXT";
            this.TEXT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TEXT.Size = new System.Drawing.Size(180, 27);
            this.TEXT.TabIndex = 3;
            this.TEXT.TextChanged += new System.EventHandler(this.TEXT_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(248, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Input text:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 237);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TEXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Colors);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Changes saver";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Colors;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TEXT;
        private System.Windows.Forms.Label label2;
    }
}

