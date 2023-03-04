namespace Kassa_Systeem
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
            this.button_Betalen = new System.Windows.Forms.Button();
            this.Number_1 = new System.Windows.Forms.Button();
            this.Number_2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Betalen
            // 
            this.button_Betalen.Location = new System.Drawing.Point(623, 391);
            this.button_Betalen.Name = "button_Betalen";
            this.button_Betalen.Size = new System.Drawing.Size(126, 30);
            this.button_Betalen.TabIndex = 0;
            this.button_Betalen.Text = "Betalen";
            this.button_Betalen.UseVisualStyleBackColor = true;
            this.button_Betalen.Click += new System.EventHandler(this.button1_Click);
            // 
            // Number_1
            // 
            this.Number_1.Location = new System.Drawing.Point(283, 261);
            this.Number_1.Name = "Number_1";
            this.Number_1.Size = new System.Drawing.Size(49, 49);
            this.Number_1.TabIndex = 1;
            this.Number_1.Text = "1";
            this.Number_1.UseVisualStyleBackColor = true;
            // 
            // Number_2
            // 
            this.Number_2.Location = new System.Drawing.Point(338, 261);
            this.Number_2.Name = "Number_2";
            this.Number_2.Size = new System.Drawing.Size(50, 49);
            this.Number_2.TabIndex = 2;
            this.Number_2.Text = "2";
            this.Number_2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Number_2);
            this.Controls.Add(this.Number_1);
            this.Controls.Add(this.button_Betalen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button_Betalen;
        private Button Number_1;
        private Button Number_2;
    }
}