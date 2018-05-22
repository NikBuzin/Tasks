namespace Sort2Keys
{
    partial class Sort2Keys
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
            this.components = new System.ComponentModel.Container();
            this.OutputTB1 = new System.Windows.Forms.TextBox();
            this.InBut = new System.Windows.Forms.Button();
            this.SortButName = new System.Windows.Forms.Button();
            this.OutputTB2 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // OutputTB1
            // 
            this.OutputTB1.Location = new System.Drawing.Point(0, 36);
            this.OutputTB1.Multiline = true;
            this.OutputTB1.Name = "OutputTB1";
            this.OutputTB1.Size = new System.Drawing.Size(141, 255);
            this.OutputTB1.TabIndex = 1;
            this.OutputTB1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // InBut
            // 
            this.InBut.Location = new System.Drawing.Point(0, 7);
            this.InBut.Name = "InBut";
            this.InBut.Size = new System.Drawing.Size(141, 23);
            this.InBut.TabIndex = 2;
            this.InBut.Text = "Добавить";
            this.InBut.UseVisualStyleBackColor = true;
            this.InBut.Click += new System.EventHandler(this.InBut_Click);
            // 
            // SortButName
            // 
            this.SortButName.Location = new System.Drawing.Point(147, 7);
            this.SortButName.Name = "SortButName";
            this.SortButName.Size = new System.Drawing.Size(141, 23);
            this.SortButName.TabIndex = 3;
            this.SortButName.Text = "Сортировать";
            this.SortButName.UseVisualStyleBackColor = true;
            this.SortButName.Click += new System.EventHandler(this.OutBut_Click);
            // 
            // OutputTB2
            // 
            this.OutputTB2.Location = new System.Drawing.Point(147, 36);
            this.OutputTB2.Multiline = true;
            this.OutputTB2.Name = "OutputTB2";
            this.OutputTB2.Size = new System.Drawing.Size(141, 255);
            this.OutputTB2.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Sort2Keys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 290);
            this.Controls.Add(this.OutputTB2);
            this.Controls.Add(this.SortButName);
            this.Controls.Add(this.InBut);
            this.Controls.Add(this.OutputTB1);
            this.Name = "Sort2Keys";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox OutputTB1;
        private System.Windows.Forms.Button InBut;
        private System.Windows.Forms.Button SortButName;
        private System.Windows.Forms.TextBox OutputTB2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

