namespace SalesAnalysis
{
    partial class SalesAnalysisForm
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
            this.DisplayButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.AverageLabel = new System.Windows.Forms.Label();
            this.HighestLabel = new System.Windows.Forms.Label();
            this.LowestLabel = new System.Windows.Forms.Label();
            this.TotalNameLabel = new System.Windows.Forms.Label();
            this.AverageNameLabel = new System.Windows.Forms.Label();
            this.HighestNameLabel = new System.Windows.Forms.Label();
            this.LowestNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DisplayButton
            // 
            this.DisplayButton.Location = new System.Drawing.Point(72, 286);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(170, 41);
            this.DisplayButton.TabIndex = 0;
            this.DisplayButton.Text = "Display Values";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(411, 286);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(170, 41);
            this.CalculateButton.TabIndex = 1;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(411, 339);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(170, 41);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.ItemHeight = 20;
            this.ValuesListBox.Location = new System.Drawing.Point(72, 12);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(170, 244);
            this.ValuesListBox.TabIndex = 3;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(72, 339);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(170, 41);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // TotalLabel
            // 
            this.TotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalLabel.Location = new System.Drawing.Point(411, 12);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(170, 28);
            this.TotalLabel.TabIndex = 5;
            this.TotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AverageLabel
            // 
            this.AverageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AverageLabel.Location = new System.Drawing.Point(411, 89);
            this.AverageLabel.Name = "AverageLabel";
            this.AverageLabel.Size = new System.Drawing.Size(170, 28);
            this.AverageLabel.TabIndex = 6;
            this.AverageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HighestLabel
            // 
            this.HighestLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HighestLabel.Location = new System.Drawing.Point(411, 156);
            this.HighestLabel.Name = "HighestLabel";
            this.HighestLabel.Size = new System.Drawing.Size(170, 28);
            this.HighestLabel.TabIndex = 7;
            this.HighestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LowestLabel
            // 
            this.LowestLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LowestLabel.Location = new System.Drawing.Point(411, 228);
            this.LowestLabel.Name = "LowestLabel";
            this.LowestLabel.Size = new System.Drawing.Size(170, 28);
            this.LowestLabel.TabIndex = 8;
            this.LowestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TotalNameLabel
            // 
            this.TotalNameLabel.AutoSize = true;
            this.TotalNameLabel.Location = new System.Drawing.Point(288, 12);
            this.TotalNameLabel.Name = "TotalNameLabel";
            this.TotalNameLabel.Size = new System.Drawing.Size(85, 20);
            this.TotalNameLabel.TabIndex = 9;
            this.TotalNameLabel.Text = "Sum Total:";
            // 
            // AverageNameLabel
            // 
            this.AverageNameLabel.AutoSize = true;
            this.AverageNameLabel.Location = new System.Drawing.Point(288, 89);
            this.AverageNameLabel.Name = "AverageNameLabel";
            this.AverageNameLabel.Size = new System.Drawing.Size(72, 20);
            this.AverageNameLabel.TabIndex = 10;
            this.AverageNameLabel.Text = "Average:";
            // 
            // HighestNameLabel
            // 
            this.HighestNameLabel.AutoSize = true;
            this.HighestNameLabel.Location = new System.Drawing.Point(288, 156);
            this.HighestNameLabel.Name = "HighestNameLabel";
            this.HighestNameLabel.Size = new System.Drawing.Size(68, 20);
            this.HighestNameLabel.TabIndex = 11;
            this.HighestNameLabel.Text = "Highest:";
            // 
            // LowestNameLabel
            // 
            this.LowestNameLabel.AutoSize = true;
            this.LowestNameLabel.Location = new System.Drawing.Point(288, 228);
            this.LowestNameLabel.Name = "LowestNameLabel";
            this.LowestNameLabel.Size = new System.Drawing.Size(64, 20);
            this.LowestNameLabel.TabIndex = 12;
            this.LowestNameLabel.Text = "Lowest:";
            // 
            // SalesAnalysisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 436);
            this.Controls.Add(this.LowestNameLabel);
            this.Controls.Add(this.HighestNameLabel);
            this.Controls.Add(this.AverageNameLabel);
            this.Controls.Add(this.TotalNameLabel);
            this.Controls.Add(this.LowestLabel);
            this.Controls.Add(this.HighestLabel);
            this.Controls.Add(this.AverageLabel);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ValuesListBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.DisplayButton);
            this.Name = "SalesAnalysisForm";
            this.Text = "Sales Analysis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label AverageLabel;
        private System.Windows.Forms.Label HighestLabel;
        private System.Windows.Forms.Label LowestLabel;
        private System.Windows.Forms.Label TotalNameLabel;
        private System.Windows.Forms.Label AverageNameLabel;
        private System.Windows.Forms.Label HighestNameLabel;
        private System.Windows.Forms.Label LowestNameLabel;
    }
}

