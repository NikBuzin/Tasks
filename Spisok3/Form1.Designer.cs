namespace Spisok3
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
            this.OuText = new System.Windows.Forms.TextBox();
            this.Find = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddProfButton = new System.Windows.Forms.Button();
            this.ProfTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OuText
            // 
            this.OuText.Location = new System.Drawing.Point(12, 38);
            this.OuText.Multiline = true;
            this.OuText.Name = "OuText";
            this.OuText.Size = new System.Drawing.Size(251, 163);
            this.OuText.TabIndex = 4;
            this.OuText.TextChanged += new System.EventHandler(this.OuText_TextChanged);
            // 
            // Find
            // 
            this.Find.Location = new System.Drawing.Point(145, 233);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(117, 23);
            this.Find.TabIndex = 5;
            this.Find.Text = "Вывести";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(12, 9);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(127, 23);
            this.LoadButton.TabIndex = 6;
            this.LoadButton.Text = "Загрузить людей";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 207);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 20);
            this.textBox1.TabIndex = 8;
            // 
            // AddProfButton
            // 
            this.AddProfButton.Location = new System.Drawing.Point(12, 233);
            this.AddProfButton.Name = "AddProfButton";
            this.AddProfButton.Size = new System.Drawing.Size(127, 23);
            this.AddProfButton.TabIndex = 9;
            this.AddProfButton.Text = "Добавить профессию";
            this.AddProfButton.UseVisualStyleBackColor = true;
            this.AddProfButton.Click += new System.EventHandler(this.AddProfButton_Click);
            // 
            // ProfTB
            // 
            this.ProfTB.Location = new System.Drawing.Point(270, 38);
            this.ProfTB.Multiline = true;
            this.ProfTB.Name = "ProfTB";
            this.ProfTB.Size = new System.Drawing.Size(100, 217);
            this.ProfTB.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 267);
            this.Controls.Add(this.ProfTB);
            this.Controls.Add(this.AddProfButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.OuText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox OuText;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AddProfButton;
        private System.Windows.Forms.TextBox ProfTB;
    }
}

