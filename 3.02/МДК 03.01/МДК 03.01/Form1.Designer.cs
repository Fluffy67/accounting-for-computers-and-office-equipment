namespace МДК_03._01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Serg = new System.Windows.Forms.Button();
            this.Vlad = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Serg
            // 
            this.Serg.BackColor = System.Drawing.Color.DarkSalmon;
            this.Serg.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Serg.Location = new System.Drawing.Point(12, 12);
            this.Serg.Name = "Serg";
            this.Serg.Size = new System.Drawing.Size(161, 81);
            this.Serg.TabIndex = 0;
            this.Serg.Text = "Сергей маленький ";
            this.Serg.UseVisualStyleBackColor = false;
            // 
            // Vlad
            // 
            this.Vlad.BackColor = System.Drawing.Color.DarkSalmon;
            this.Vlad.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Vlad.Location = new System.Drawing.Point(193, 12);
            this.Vlad.Name = "Vlad";
            this.Vlad.Size = new System.Drawing.Size(154, 81);
            this.Vlad.TabIndex = 1;
            this.Vlad.Text = " Влад маленький ";
            this.Vlad.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(353, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Vlad);
            this.Controls.Add(this.Serg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Serg;
        private Button Vlad;
        private Button button1;
    }
}