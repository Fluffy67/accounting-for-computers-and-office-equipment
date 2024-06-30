namespace Оргтехника
{
    partial class Beginning
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
            this.Exit = new System.Windows.Forms.Button();
            this.Tntrance = new System.Windows.Forms.Button();
            this.Regisatration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(346, 8);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(30, 26);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Tntrance
            // 
            this.Tntrance.BackColor = System.Drawing.Color.Transparent;
            this.Tntrance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Tntrance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tntrance.Location = new System.Drawing.Point(142, 92);
            this.Tntrance.Name = "Tntrance";
            this.Tntrance.Size = new System.Drawing.Size(111, 39);
            this.Tntrance.TabIndex = 5;
            this.Tntrance.Text = "Вход";
            this.Tntrance.UseVisualStyleBackColor = false;
            this.Tntrance.Click += new System.EventHandler(this.Tntrance_Click);
            // 
            // Regisatration
            // 
            this.Regisatration.BackColor = System.Drawing.Color.Transparent;
            this.Regisatration.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Regisatration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Regisatration.Location = new System.Drawing.Point(121, 138);
            this.Regisatration.Name = "Regisatration";
            this.Regisatration.Size = new System.Drawing.Size(151, 42);
            this.Regisatration.TabIndex = 6;
            this.Regisatration.Text = "Регистрация";
            this.Regisatration.UseVisualStyleBackColor = false;
            this.Regisatration.Click += new System.EventHandler(this.Regisatration_Click);
            // 
            // Beginning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Оргтехника.Properties.Resources.комп;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.Regisatration);
            this.Controls.Add(this.Tntrance);
            this.Controls.Add(this.Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Beginning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Tntrance;
        private System.Windows.Forms.Button Regisatration;
    }
}

