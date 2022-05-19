namespace SinavSistemi
{
    partial class frmOgrenci
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
            this.testButton = new System.Windows.Forms.Button();
            this.statButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testButton
            // 
            this.testButton.BackColor = System.Drawing.Color.DarkOrange;
            this.testButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.testButton.Location = new System.Drawing.Point(129, 130);
            this.testButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(133, 74);
            this.testButton.TabIndex = 0;
            this.testButton.Text = "Teste Başla";
            this.testButton.UseVisualStyleBackColor = false;
            this.testButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // statButton
            // 
            this.statButton.BackColor = System.Drawing.Color.DarkOrange;
            this.statButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.statButton.Location = new System.Drawing.Point(129, 233);
            this.statButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.statButton.Name = "statButton";
            this.statButton.Size = new System.Drawing.Size(133, 74);
            this.statButton.TabIndex = 1;
            this.statButton.Text = "İstatistikler";
            this.statButton.UseVisualStyleBackColor = false;
            this.statButton.Click += new System.EventHandler(this.statButton_Click);
            // 
            // frmOgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(376, 434);
            this.Controls.Add(this.statButton);
            this.Controls.Add(this.testButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(394, 481);
            this.MinimumSize = new System.Drawing.Size(394, 481);
            this.Name = "frmOgrenci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Paneli";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Button statButton;
    }
}