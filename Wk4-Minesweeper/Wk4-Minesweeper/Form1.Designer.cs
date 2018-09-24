namespace Wk4_Minesweeper
{
    partial class Form1
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
            this.SelectLevelGroupBox = new System.Windows.Forms.GroupBox();
            this.PlayButton = new System.Windows.Forms.Button();
            this.DifficultButton = new System.Windows.Forms.RadioButton();
            this.ModerateButton = new System.Windows.Forms.RadioButton();
            this.EasyButton = new System.Windows.Forms.RadioButton();
            this.SelectLevelGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectLevelGroupBox
            // 
            this.SelectLevelGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.SelectLevelGroupBox.Controls.Add(this.PlayButton);
            this.SelectLevelGroupBox.Controls.Add(this.DifficultButton);
            this.SelectLevelGroupBox.Controls.Add(this.ModerateButton);
            this.SelectLevelGroupBox.Controls.Add(this.EasyButton);
            this.SelectLevelGroupBox.Location = new System.Drawing.Point(550, 50);
            this.SelectLevelGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SelectLevelGroupBox.Name = "SelectLevelGroupBox";
            this.SelectLevelGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SelectLevelGroupBox.Size = new System.Drawing.Size(255, 245);
            this.SelectLevelGroupBox.TabIndex = 0;
            this.SelectLevelGroupBox.TabStop = false;
            this.SelectLevelGroupBox.Text = "Select Level";
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PlayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayButton.Location = new System.Drawing.Point(122, 195);
            this.PlayButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(112, 35);
            this.PlayButton.TabIndex = 3;
            this.PlayButton.Text = "Play Game";
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // DifficultButton
            // 
            this.DifficultButton.AutoSize = true;
            this.DifficultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DifficultButton.Location = new System.Drawing.Point(18, 138);
            this.DifficultButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DifficultButton.Name = "DifficultButton";
            this.DifficultButton.Size = new System.Drawing.Size(89, 24);
            this.DifficultButton.TabIndex = 2;
            this.DifficultButton.TabStop = true;
            this.DifficultButton.Text = "Difficult";
            this.DifficultButton.UseVisualStyleBackColor = true;
            // 
            // ModerateButton
            // 
            this.ModerateButton.AutoSize = true;
            this.ModerateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModerateButton.Location = new System.Drawing.Point(18, 92);
            this.ModerateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ModerateButton.Name = "ModerateButton";
            this.ModerateButton.Size = new System.Drawing.Size(103, 24);
            this.ModerateButton.TabIndex = 1;
            this.ModerateButton.TabStop = true;
            this.ModerateButton.Text = "Moderate";
            this.ModerateButton.UseVisualStyleBackColor = true;
            // 
            // EasyButton
            // 
            this.EasyButton.AutoSize = true;
            this.EasyButton.BackColor = System.Drawing.SystemColors.Control;
            this.EasyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EasyButton.Location = new System.Drawing.Point(18, 46);
            this.EasyButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EasyButton.Name = "EasyButton";
            this.EasyButton.Size = new System.Drawing.Size(66, 24);
            this.EasyButton.TabIndex = 0;
            this.EasyButton.TabStop = true;
            this.EasyButton.Text = "Easy";
            this.EasyButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.SelectLevelGroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SelectLevelGroupBox.ResumeLayout(false);
            this.SelectLevelGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SelectLevelGroupBox;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.RadioButton DifficultButton;
        private System.Windows.Forms.RadioButton ModerateButton;
        private System.Windows.Forms.RadioButton EasyButton;
    }
}

